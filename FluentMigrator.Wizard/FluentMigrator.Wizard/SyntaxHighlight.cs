using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FluentMigrator.Wizard
{
    public static class SyntaxHighlight
    {
        internal static void Apply(RichTextBox txtOutput, int start = 0)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in)\b";
            MatchCollection keywordMatches = Regex.Matches(txtOutput.Text, keywords);

            // getting types/classes from the text
            string types = @"([-*+!=><\[\]]+)";
            MatchCollection typeMatches = Regex.Matches(txtOutput.Text, types);

            // getting versions
            string versions = @"[1-9][0-9]{9,15}:";
            MatchCollection versionsMatches = Regex.Matches(txtOutput.Text, versions);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(txtOutput.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txtOutput.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = txtOutput.SelectionStart;
            int originalLength = txtOutput.SelectionLength;
            Color originalColor = Color.Black;

            // removes any previous highlighting (so modified words won't remain highlighted)
            txtOutput.SelectionStart = start;
            txtOutput.SelectionLength = txtOutput.Text.Length;
            txtOutput.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtOutput.SelectionStart = m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                txtOutput.SelectionStart = m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Green;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            }

            foreach (Match m in commentMatches)
            {
                txtOutput.SelectionStart = m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtOutput.SelectionStart = m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Brown;
            }

            foreach (Match m in versionsMatches)
            {
                txtOutput.SelectionStart = m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Purple;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            }

            txtOutput.ScrollToCaret();

            // restoring the original colors, for further writing
            txtOutput.SelectionStart = originalIndex;
            txtOutput.SelectionLength = originalLength;
            txtOutput.SelectionColor = originalColor;
            txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Regular);
        }
    }
}