using System.Windows.Forms;

namespace PassingDataBetweenFormsSimple
{
    public partial class ConfirmForm : Form
    {
        public bool Confirmed => AgreeCheckBox.Checked;
        public ConfirmForm()
        {
            InitializeComponent();
        }
    }
}
