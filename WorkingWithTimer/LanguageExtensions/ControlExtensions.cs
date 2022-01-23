using System;
using System.ComponentModel;
using System.Diagnostics;

namespace WorkingWithTimer.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class Extensions
    {

        /// <summary>
        /// Determines if a control needs to be invoked to prevent a cross thread violation. 
        /// </summary>
        /// <typeparam name="T">Control</typeparam>
        /// <param name="control">Control</param>
        /// <param name="action">Predicate to run</param>
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