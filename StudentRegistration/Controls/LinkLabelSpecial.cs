using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration.Controls
{
    public class LinkLabelSpecial : LinkLabel
    {
        [Category("Data"), 
         Description("Identifier")]
        public int? Id { get; set; }
    }
}
