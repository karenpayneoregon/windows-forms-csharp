using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CreateDynamicControls.Classes
{
    public class ControlHelper
    {
        public static List<Button> ButtonsList { get; set; }
        public static int Top { get; set; }
        public static int Left { get; set; }
        public static int Width { get; set; }
        public static int HeightPadding { get; set; }
        public static string BaseName { get; set; } = "Button";
        public static Control ParentControl { get; set; }
        public static int Index = 0;
        public delegate void OnClick(object sender);
        public static event OnClick ButtonClick;

        public static void Initialize(Control pControl, int top, int heightPadding, int left, int width)
        {
            ParentControl = pControl;
            Top = top;
            HeightPadding = heightPadding;
            Left = left;
            Width = width;
            ButtonsList = new List<Button>();
        }

        public static void CreateButton()
        {

            var button = new Button()
            {
                Name = $"{BaseName}{Index +1}",
                Width = Width,
                Location = new Point(Left, Top),
                Parent = ParentControl,
                Visible = true,
                Tag = Index +1
            };

            button.Click += (sender, args) => ButtonClick?.Invoke(sender);
                
            ButtonsList.Add(button);

            ParentControl.Controls.Add(button);
            Top += HeightPadding;
            Index += 1;

        }

    }
}
