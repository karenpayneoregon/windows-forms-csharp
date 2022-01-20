using System;
using System.ComponentModel;

namespace Appsettings_sample.Classes
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Proactively prevent cross threading violations
        /// </summary>
        /// <typeparam name="T">Control type</typeparam>
        /// <param name="control">Control</param>
        /// <param name="action">Action to invoke on control</param>
        /// <example>
        /// <code title="Update ListBox from a secondary thread" >
        ///    private void DataOperationsOnAfterConnectMonitor(string message)
        ///    {
        ///        listBox1.InvokeIfRequired(lb => { lb.Items.Add(message); });
        ///    }
        /// </code>
        /// </example>        
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}