using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FluentMigrator.Wizard
{
    public static class SyntaxHighlight
    {
        internal static void Apply(RichTextBox txtOutput, int start = 0)
        {
            var currentText = txtOutput.Text.Substring(start);

            // getting keywords/functions
            string keywords = @"\b(DECLARE|SET|EXEC|AND|OR|DROP|INTO|SELECT|FROM|WHERE|ORDER|BY|DELETE|INSERT|VALUES|IN|ALTER|TABLE|COLUMN|INDEX|CONSTRAINT|PRIMARY|KEY|FOREIGN)\b";
            MatchCollection keywordMatches = Regex.Matches(currentText, keywords);

            // getting types/classes from the text
            string types = @"([\'-*+!=><\[\]\(\)]+)";
            MatchCollection typeMatches = Regex.Matches(currentText, types);

            // getting versions
            string versions = @"[1-9][0-9]{9,15}:";
            MatchCollection versionsMatches = Regex.Matches(currentText, versions);

            // getting comments (inline or multiline)
            string comments = @"(\-\-.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(currentText, comments, RegexOptions.Multiline);

            // getting strings
            string strings = @"\b(Beginning|Committing|Migrations|reverting|current|Task|task|completed|Completed|Begin|begin|Transaction|transaction|Rolling|back)\b";
            MatchCollection stringMatches = Regex.Matches(currentText, strings);

            string dates = @"\d{2}\/\d{2}\/\d{4} \d{2}:\d{2}:\d{2}";
            MatchCollection datesMatches = Regex.Matches(currentText, dates);

            // getting strings
            string errors = @"!!! (.*)";
            MatchCollection errorsMatches = Regex.Matches(currentText, errors);

            Color originalColor = Color.Black;
            Color originalBackColor = txtOutput.BackColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Orange;
            }

            foreach (Match m in typeMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.LightGreen;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            }

            foreach (Match m in commentMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Yellow;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            }

            foreach (Match m in versionsMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.Cyan;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            }

            foreach (Match m in datesMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.LightSlateGray;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Italic);
            }

            foreach (Match m in errorsMatches)
            {
                txtOutput.SelectionStart = start + m.Index;
                txtOutput.SelectionLength = m.Length;
                txtOutput.SelectionColor = Color.OrangeRed;
                txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Bold);
            }

            // restoring the original colors, for further writing
            txtOutput.SelectionStart = txtOutput.Text.Length;
            txtOutput.SelectionColor = originalColor;
            txtOutput.SelectionBackColor = originalBackColor;
            txtOutput.SelectionFont = new Font(txtOutput.Font, FontStyle.Regular);

            txtOutput.ScrollToCaret();
        }
    }
}