using System.Windows.Forms;

namespace DeconstructCodeSamples.Classes
{
    public class Dialogs
    {
        /// <summary>
        /// displays a message with option to assign button text
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">What to display</param>
        /// <param name="buttonText"></param>
        /// <remarks>Centers on owner</remarks>
        public static void Information(Control owner, string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new(buttonText);

            TaskDialogPage page = new()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Footnote = new TaskDialogFootnote() { Text = "Code sample by Karen Payne" },
                Icon = new TaskDialogIcon(Properties.Resources.blueInformation_32),
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };

            TaskDialog.ShowDialog(owner, page);

        }

        /// <summary>
        /// Displays <see cref="PersonEntity"/> properties
        /// </summary>
        /// <param name="owner">calling form or control</param>
        /// <param name="personEntity">Data to display</param>
        /// <param name="buttonText">optional button text</param>
        public static void Information(Control owner, PersonEntity personEntity, string buttonText = "Ok")
        {

            var (id, first, last) = personEntity;
            TaskDialogButton okayButton = new(buttonText);

            TaskDialogPage page = new()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = $"Id: {id} for {first} {last}",
                Footnote = new TaskDialogFootnote() { Text = "Code sample by Karen Payne" },
                Icon = new TaskDialogIcon(Properties.Resources.blueInformation_32),
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };

            TaskDialog.ShowDialog(owner, page);

        }
        /// <summary>
        /// Dialog to ask a question
        /// </summary>
        /// <param name="caption">text for dialog caption</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesText">text for yes button</param>
        /// <param name="noText">text for no button</param>
        /// <param name="defaultButton">specifies the default button for this dialog</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(string caption, string heading, string yesText, string noText, DialogResult defaultButton)
        {

            TaskDialogButton yesButton = new(yesText) { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new(noText) { Tag = DialogResult.No };

            TaskDialogButtonCollection buttons = new();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = caption,
                SizeToContent = true,
                Heading = heading,
                Footnote = new TaskDialogFootnote() { Text = "Code sample by Karen Payne" },
                Icon = TaskDialogIcon.Information,
                Buttons = buttons
            };


            TaskDialogButton result = TaskDialog.ShowDialog(page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }
    }
}