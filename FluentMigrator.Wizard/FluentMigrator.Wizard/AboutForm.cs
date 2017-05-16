using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentMigrator.Wizard
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = ApplicationDeployment.IsNetworkDeployed
                   ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                   : Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dzfweb.com.br");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/dzfweb/fluentmigratorwizard");
        }
    }
}
