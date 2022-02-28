using System;

namespace WorkingWithTimer.Classes
{
    public class ActionContainer
    {
        /// <summary>
        /// Action to perform
        /// </summary>
        public Action Action { get; set; } = () => { };
    }
}