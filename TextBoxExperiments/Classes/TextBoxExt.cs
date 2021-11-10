using System.Windows.Forms;
using TextBoxExperiments.Extensions;

namespace TextBoxExperiments.Classes
{
    public class TextBoxExt : TextBox
    {
        public new void AppendText(string text)
        {
            if (Text.Length == MaxLength)
            {
                return;
            }
            else if (Text.Length + text.Length > MaxLength)
            {
                base.AppendText(text[..(MaxLength - Text.Length)]);
            }
            else
            {
                base.AppendText(text);
            }
        }

        public override string Text
        {
            get => base.Text;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > MaxLength)
                {
                    base.Text = value[..MaxLength];
                }
                else
                {
                    base.Text = value;
                }
            }
        }

        public void ClearTopLines(int count)
        {
            if (count <= 0)
            {
                return;
            }
            else if (!Multiline)
            {
                Clear();
                return;
            }

            string txt = Text;
            int cursor = 0, ixOf = 0, brkLength = 0, brkCount = 0;

            while (brkCount < count)
            {
                ixOf = txt.IndexOfBreak(cursor, out brkLength);
                if (ixOf < 0)
                {
                    Clear();
                    return;
                }

                cursor = ixOf + brkLength;
                brkCount++;

            }

            Text = txt[cursor..];
        }
    }
}