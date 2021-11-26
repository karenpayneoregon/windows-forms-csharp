using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDynamicControls.Classes.Controls
{
    public class CustomButton : Button
    {
        [Category("Behavior"), Description("Constant identifier")]
        public string Information { get; set; }
    }

    public class CustomPanel : Panel
    {
        [Category("Behavior"), Description("Constant identifier")]
        public string Information { get; set; }
    }

    public class CustomLabel : Label
    {
        [Category("Behavior"), Description("Constant identifier")]
        public string Information { get; set; }
    }

}
