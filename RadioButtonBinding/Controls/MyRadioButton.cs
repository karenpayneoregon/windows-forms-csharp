using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonBinding.Controls
{
    /// <summary>
    /// From https://stackoverflow.com/questions/38366222/circular-radiobutton-list-in-windows-forms
    /// </summary>
    public class MyRadioButton : RadioButton
    {
        public MyRadioButton()
        {
            Appearance = Appearance.Button;
            BackColor = Color.Transparent;
            TextAlign = ContentAlignment.MiddleCenter;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.RoyalBlue;
            FlatAppearance.BorderSize = 2;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            OnPaintBackground(e);
            
            using var path = new GraphicsPath();
            
            var c = e.Graphics.ClipBounds;
            var r = ClientRectangle;
            
            r.Inflate(-FlatAppearance.BorderSize, -FlatAppearance.BorderSize);
            path.AddEllipse(r);
            e.Graphics.SetClip(path);
            
            base.OnPaint(e);
            
            e.Graphics.SetClip(c);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            if (Checked)
            {
                using var p = new Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize);
                e.Graphics.DrawEllipse(p, r);
            }
        }
    }
}
