using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Operations
    {
        public static async Task AsyncMethod(IProgress<int> progress, CancellationToken ct)
        {

            for (int index = 100; index <= 120; index++)
            {
                //Simulate an async call that takes some time to complete
                await Task.Delay(200);

                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }

                if (progress != null)
                {
                    progress.Report(index);
                }

            }

        }
    }
}
