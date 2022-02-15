using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateDynamicControls.Classes.Controls;

namespace CreateDynamicControls.Classes
{
    public class CheckBoxOperations
    {
        public static List<CheckBox> List { get; set; }
        public static int Top { get; set; }
        public static int Left { get; set; }
        public static int Width { get; set; }
        public static int HeightPadding { get; set; }
        public static string BaseName { get; set; } = "CheckBox";
        public static EventHandler EventHandler { get; set; }
        public static Control ParentControl { get; set; }
        public static int Index = 1;

        /// <summary>
        /// Initialize global properties
        /// </summary>
        /// <param name="control">Control to place control</param>
        /// <param name="top">Top</param>
        /// <param name="baseHeightPadding">Padding between controls</param>
        /// <param name="left">Left position</param>
        /// <param name="eventHandler">Click event for button</param>
        public static void Initialize(Control control, int top, int baseHeightPadding, int left,  EventHandler eventHandler)
        {

            ParentControl = control;
            Top = top;
            HeightPadding = baseHeightPadding;
            Left = left;
            EventHandler = eventHandler;
            List = new List<CheckBox>();

        }

        public static void CreateButton(string text, bool binding)
        {

            var button = new CheckBox()
            {
                Name = $"{BaseName}{Index}",
                Text = text,
                Width = Width,
                Location = new Point(Left, Top),
                Parent = ParentControl,
                Visible = true, 
                Checked = binding
            };

            button.Click += EventHandler;
            List.Add(button);

            ParentControl.Controls.Add(button);
            Top += HeightPadding;
            Index += 1;

        }
    }
}
