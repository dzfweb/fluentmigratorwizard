using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FluentMigrator.Wizard
{
    public partial class CommandsForm : Form
    {
        public CommandsForm()
        {
            InitializeComponent();

            string resource_data = Resource.Commands;
            resource_data
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .ToList()
                .ForEach(el =>
            {
                richTextBox1.Text += Environment.NewLine;
                richTextBox1.Text += el;
            });


        }
    }
}