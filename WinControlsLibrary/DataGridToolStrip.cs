using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControlsLibrary.Properties;

namespace WinControlsLibrary
{
    public class DataGridToolStrip : BindingNavigator
    {
        public ToolStripButton PreviousButton { get; set; }
        public ToolStripButton NextButton { get; set; }
        public ToolStripButton EditButton { get; set; }
        
        public ToolStripSeparator Separator { get; set; }

        public override void AddStandardItems()
        {
            //base.AddStandardItems();
            
            PreviousButton = new ToolStripButton {Name = "PreviousButton", Image = Resources.ASX_Previous_blue_16x, Enabled = false};
            NextButton = new ToolStripButton {Name = "NextButton", Image = Resources.ASX_Next_blue_16x};
            Separator = new ToolStripSeparator();
            EditButton = new ToolStripButton {Name = "EditButton", Image = Resources.ASX_Edit_blue_16x};

            Items.AddRange(new ToolStripItem[] {PreviousButton, NextButton, Separator, EditButton });
            
        }
    }
}
