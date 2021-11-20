using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryMinuteSharp.Extensions
{
    public static class Extensions
    {
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
