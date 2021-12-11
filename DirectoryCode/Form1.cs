using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DirectoryCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DirectoryOperations.OnTraverseIncludeFolderEvent += DirectoryOperationsOnOnTraverseIncludeFolderEvent;
        }

        private void DirectoryOperationsOnOnTraverseIncludeFolderEvent(string sender)
        {
            Console.WriteLine(sender);
        }

        private string SourceFolder => @"c:\users";
        private string TargetFolder => @"c:\users\darren";

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (string.Equals(SourceFolder, TargetFolder, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(@"Pick another path");
                return;
            }
            Helpers.TraverseFolder += DirectoryExtensionsOnTraverse;
            Helpers.Traverse(TargetFolder);
            Helpers.TraverseFolder -= DirectoryExtensionsOnTraverse;
        }

        private void DirectoryExtensionsOnTraverse(string sender)
        {
            if (sender == SourceFolder)
            {
                MessageBox.Show(@"Pick another path");
                Helpers.Continue = false;

            }else if (sender == Helpers.DoneMessage && Helpers.Continue)
            {
                MessageBox.Show(@"Good to go");
            }
        }

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private async void TraverseButton_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            DirectoryInfo directoryInfo = 
                new DirectoryInfo(@"C:\OED\Dotnetland\VS2019\LearningVisualStudio\WindowsFormsSolution");

            try
            {
                await DirectoryOperations.RecursiveDelete(directoryInfo, _cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancelled");
            }
        }

        private void CancelTaskButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private List<string> folderList = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\en";
            string[] folders = Directory.GetDirectories(@"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Extensions\", "*", SearchOption.AllDirectories);
            var last = folders.Last();

            DirectoryHelper.TraverseFolder += DirectoryHelperOnTraverseFolder;
            DirectoryHelper.TraversePath(path);
            DirectoryHelper.TraverseFolder -= DirectoryHelperOnTraverseFolder;
            folderList.Clear();
        }

        private void DirectoryHelperOnTraverseFolder(string sender)
        {
            if (sender == DirectoryHelper.DoneMessage)
            {
                folderList.Reverse(0, folderList.Count);
                for (int index = 0; index < folderList.Count; index++)
                {
                    Console.WriteLine($"{index,-3}{folderList[index]}");
                }
            }
            else
            {
                folderList.Add(sender);
            }
            
        }
    }
}
