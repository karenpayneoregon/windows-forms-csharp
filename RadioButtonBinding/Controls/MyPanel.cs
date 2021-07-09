using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RadioButtonBinding.Controls
{
    /// <summary>
    /// From https://stackoverflow.com/questions/38366222/circular-radiobutton-list-in-windows-forms
    /// </summary>    
    public class MyPanel : Panel
    {
        public MyPanel()
        {
            this.Padding = new Padding(2);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            using var path = new GraphicsPath();
            
            var d = Padding.All;
            var r = Height - 2 * d;
            path.AddArc(d, d, r, r, 90, 180);
            path.AddArc(Width - r - d, d, r, r, -90, 180);
            path.CloseFigure();
            
            using var pen = new Pen(Color.Silver, d);
            
            e.Graphics.DrawPath(pen, path);
        }
    }
}