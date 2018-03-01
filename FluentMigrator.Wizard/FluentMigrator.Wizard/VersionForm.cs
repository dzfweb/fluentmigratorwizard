using System;
using System.Windows.Forms;

namespace FluentMigrator.Wizard
{
    public partial class VersionForm : Form
    {
        public long? version = null;

        public VersionForm()
        {
            InitializeComponent();
        }

        private void VersionForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                version = long.Parse(textBox1.Text);
            else
            {
                MessageBox.Show("Invalid version!");
            }

            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}