using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Appsettings_sample.Classes
{

    /// <summary>
    /// Represents a single asynchronous operation that is started on first demand.
    /// 
    /// In case of failure the error is not cached, and the operation is restarted (retried) later on demand.
    /// 
    /// </summary>
    public class AsyncLazy<TResult>
    {
        private Func<Task<TResult>> _factory;
        private Task<TResult> _task;

        public AsyncLazy(Func<Task<TResult>> factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public Task<TResult> Task
        {
            get
            {
                var currentTask = Volatile.Read(ref _task);

                if (currentTask == null)
                {
                    Task<TResult> newTask = null;
                    var newTaskTask = new Task<Task<TResult>>(async () =>
                    {
                        try
                        {
                            var result = await _factory().ConfigureAwait(false);
                            _factory = null; // No longer needed (let it get recycled)
                            return result;
                        }
                        catch
                        {
                            _ = Interlocked.CompareExchange(ref _task, null, newTask);
                            throw;
                        }
                    });

                    newTask = newTaskTask.Unwrap();
                    currentTask = Interlocked.CompareExchange(ref _task, newTask, null) ?? newTask;

                    if (currentTask == newTask)
                    {
                        newTaskTask.RunSynchronously(TaskScheduler.Default);
                    }
                }

                return currentTask.IsCompleted ? currentTask : RunContinuationsAsynchronously(currentTask);
            }
        }

        public TaskAwaiter<TResult> GetAwaiter() { return Task.GetAwaiter(); }

        private static Task<TResult> RunContinuationsAsynchronously(Task<TResult> task)
        {
            return task.ContinueWith(taskResult => taskResult, default,
                TaskContinuationOptions.RunContinuationsAsynchronously,
                TaskScheduler.Default).Unwrap();
        }
    }
}
