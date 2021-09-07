using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileHelpers;

namespace FileHelpersFrontEnd
{
    public partial class Form1 : Form
    {


        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private string _folderName = "C:\\OED\\Dotnetland\\VS2019\\csharp-tips";


        public Form1()
        {
            InitializeComponent();
            ResultsLabel.Text = "";
            Shown += OnShown;
            Operations.OnTraverseEvent += OperationsOnOnTraverseEvent;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            if (!Directory.Exists(_folderName))
            {
                RunButton.Enabled = false;
                MessageBox.Show("Folder does not exists");
            }
        }

        private void OperationsOnOnTraverseEvent(string status)
        {
            if (status.Contains("C:\\OED\\Dotnetland\\VS2019\\csharp-tips\\ClearControlsWindowsForms"))
            {
                listBox1.InvokeIfRequired(listbox =>
                {
                    listbox.Items.Add(status);
                    //listbox.Refresh();
                });
            }
            ResultsLabel.InvokeIfRequired(label =>
            {
                label.Text = status;
                label.Refresh();
            });

        }

        private async void RunButton_Click(object sender, EventArgs e)
        {

            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
                Operations.Cancelled = false;

                listBox1.Items.Clear();
            }

            var directoryInfo = new DirectoryInfo(_folderName);

            try
            {
                await Operations.RecursiveFolders(
                    directoryInfo,
                    new[] { "*.txt" },
                    _cancellationTokenSource.Token);

                if (Operations.Cancelled)
                {
                    MessageBox.Show(@"You cancelled the operation");
                }
                else
                {
                    MessageBox.Show(@"Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var folderName = "C:\\OED\\Dotnetland\\VS2019\\csharp-tips";
            //var operations = new FileSystemCrawlerSO();
            //operations.CollectFolders("C:\\OED\\Dotnetland\\VS2019\\csharp-tips");

            var numFolders = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            /*
             * Quick but can lead to non-responsiveness 
             */
            
            //foreach (var dir in Directory.EnumerateDirectories(@"C:\\OED\\Dotnetland\\VS2019\\csharp-tips", "*", SearchOption.AllDirectories))
            //{
            //    Debug.WriteLine($"{dir}");
            //    ++numFolders;
            //}

            
            /*
             * Responsive...tinker with this and we can go a long time which is not desirable.
             */
            await Task.Run(async () =>
            {

                foreach (var path in Directory.EnumerateDirectories(folderName, "*", SearchOption.AllDirectories))
                {

                    if (numFolders.TimeToDelay())
                    {
                        await Task.Delay(1);
                        Debug.WriteLine($"{path}");
                    }
                    
                    ++numFolders;
                }


            });

            watch.Stop();
            
            Debug.WriteLine($"Collected {numFolders:N0} folders in {watch.ElapsedMilliseconds} milliseconds.");
            Debug.WriteLine($"{TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds).TotalSeconds}");

        }
    }


    public static class Extensions
    {
        public static bool TimeToDelay(this int sender) => sender % 100 == 0;
    }
    public class FileSystemCrawlerSO
    {
        public int NumFolders { get; set; }
        private readonly ConcurrentQueue<DirectoryInfo> folderQueue = new ConcurrentQueue<DirectoryInfo>();
        private readonly ConcurrentBag<Task> tasks = new ConcurrentBag<Task>();

        public void CollectFolders(string path)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            tasks.Add(Task.Run(() => CrawlFolder(directoryInfo)));

            Task taskToWaitFor;
            while (tasks.TryTake(out taskToWaitFor))
                taskToWaitFor.Wait();
        }


        private void CrawlFolder(DirectoryInfo dir)
        {
            try
            {
                Debug.WriteLine(dir);
                DirectoryInfo[] directoryInfos = dir.GetDirectories();
                foreach (DirectoryInfo childInfo in directoryInfos)
                {
                    // here may be dragons using enumeration variable as closure!!
                    DirectoryInfo di = childInfo;
                    tasks.Add(Task.Run(() => CrawlFolder(di)));
                }
                // Do something with the current folder
                // e.g. Console.WriteLine($"{dir.FullName}");
                NumFolders++;
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine($"{ex.GetType()} {ex.Message}\n{ex.StackTrace}");
                    ex = ex.InnerException;
                }
            }
        }
    }
}
