using FluentMigrator.Wizard.IniParser;
using FluentMigrator.Wizard.IniParser.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FluentMigrator.Wizard
{
    public partial class Main : Form
    {
        private IniData data = null;
        private string formTitle = "Fluent Migrator Wizard";
        private FileIniDataParser parser = new FileIniDataParser();
        private string arguments = string.Empty;
        private Process p;

        private delegate void updateDelegate(string output);

        private delegate void updateProgressBarDelegate(bool visible);
        private delegate void updateCancelButtonDelegate(bool visible);
        private delegate void updateSelectedTabIndex(int tabIndex);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                UpdateProgressBar(true);
                UpdateCancelButton(true);
                ExecuteProcess();
            }
            catch (Exception ex)
            {
                PrintToOutput(ex.Message);
                UpdateCancelButton(false);
                UpdateProgressBar(false);
                ChangeTab(1);
            }
        }

        private void ChangeTab(int tabIndex)
        {
            if (tabControl1.InvokeRequired)
            {
                tabControl1.Invoke(new updateSelectedTabIndex(ChangeTab), tabIndex);
            }
            else
            {
                if (tabControl1.SelectedIndex != tabIndex)
                    tabControl1.SelectedIndex = 1;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fluent Migrator Wizard Files (*.fmw)|*.fmw";
            dialog.Title = "Select the setting file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                data = parser.ReadFile(dialog.FileName);
                txtConsole.Text = data["paths"]["console"];
                txtMigrator.Text = data["paths"]["migrator"];
                txtRunner.Text = data["paths"]["runner"];
                txtMigrations.Text = data["paths"]["migrations"];
                txtConnection.Text = data["paths"]["connection"];
                txtProvider.Text = data["paths"]["provider"];
                txtContext.Text = data["paths"]["context"];
            }
            this.Text = $"{formTitle} - ({dialog.SafeFileName})";
            PrintToOutput($"File opened: {dialog.FileName}");
        }

        private void UpdateProgressBar(bool visible)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new updateProgressBarDelegate(UpdateProgressBar), visible);
            }
            else
            {
                progressBar1.Visible = visible;
            }
        }

        private void UpdateCancelButton(bool visible)
        {
            if (btnCancel.InvokeRequired)
            {
                btnCancel.Invoke(new updateCancelButtonDelegate(UpdateCancelButton), visible);
            }
            else
            {
                btnCancel.Visible = visible;
            }
        }

        private void PrintToOutput(string text)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new updateDelegate(PrintToOutput), text);
            }
            else
            {
                txtOutput.AppendText(Environment.NewLine);
                txtOutput.AppendText($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}: {text}");
                txtOutput.ScrollToCaret();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Select the file to save this settings";
            dialog.Filter = "Fluent Migrator Wizard Files (*.fmw)|*.fmw";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(dialog.FileName))
                    using (var fs = File.Create(dialog.FileName))
                    {
                        PrintToOutput($"File created: {dialog.FileName}");
                    }

                try
                {
                    data = parser.ReadFile(dialog.FileName);

                    data["paths"]["console"] = txtConsole.Text;
                    data["paths"]["migrator"] = txtMigrator.Text;
                    data["paths"]["runner"] = txtRunner.Text;
                    data["paths"]["migrations"] = txtMigrations.Text;
                    data["paths"]["connection"] = txtConnection.Text;
                    data["paths"]["provider"] = txtProvider.Text;
                    data["paths"]["context"] = txtContext.Text;

                    parser.WriteFile(dialog.FileName, data);

                    PrintToOutput($"File save: {dialog.FileName}");
                    this.Text = $"{formTitle} - ({dialog.FileName})";
                }
                catch (Exception ex)
                {
                    PrintToOutput($"Error while saving file: {dialog.FileName}");
                }
            }
        }

        private bool IsWorkerBusy()
        {
            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show("Wait until the current process finish");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (!IsWorkerBusy())
            {
                arguments = GetDefaultArguments() + " --t=listmigrations";
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!IsWorkerBusy())
            {
                arguments = GetDefaultArguments() + "--t=migrate";
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to rollback one version ??",
                                     "Confirm rollback!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (!IsWorkerBusy())
                {
                    arguments = GetDefaultArguments() + " --t=rollback";
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void ExecuteProcess()
        {
            p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.FileName = txtConsole.Text;

            p.StartInfo.Arguments = arguments;

            if (cbxVerbose.CheckState == CheckState.Checked)
                p.StartInfo.Arguments += " --verbose=true ";

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.ErrorDialog = false;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.EnableRaisingEvents = true;
            p.OutputDataReceived += process_OutputDataReceived;
            p.ErrorDataReceived += process_OutputDataReceived;
            p.Exited += process_Exited;
            p.Start();
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();

        }

        void process_Exited(object sender, System.EventArgs e)
        {
            UpdateProgressBar(false);
            UpdateCancelButton(false);
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            ChangeTab(1);
            PrintToOutput(e.Data);
        }

        void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            ChangeTab(1);
            PrintToOutput(e.Data);
        }

        private void btnDownAll_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to rollback all versions ??",
                                     "Confirm rollback!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                if (!IsWorkerBusy())
                {
                    arguments = GetDefaultArguments() + "--t=rollback:all";
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void btnArgument_Click(object sender, EventArgs e)
        {
            if (!IsWorkerBusy())
            {
                arguments = GetDefaultArguments() + txtArguments.Text;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private string GetDefaultArguments() =>
            $"--connectionString \"{txtConnection.Text}\" --a {txtMigrations.Text} --provider {txtProvider.Text} --context {txtContext.Text} ";

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AboutForm())
            {
                form.ShowDialog();
            }
        }

        private void btnSelectConsole_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Migrate Console (*.exe)|*.exe";
            dialog.Title = "Select the Migrate Console";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtConsole.Text = dialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "FluentMigrator Assembly (*.dll)|*.dll";
            dialog.Title = "Select the FluentMigrator Assembly";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMigrator.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "FluentMigrator.Runner Assembly (*.dll)|*.dll";
            dialog.Title = "Select the FluentMigrator.Runner Assembly";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtRunner.Text = dialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Migrations Assembly (*.dll)|*.dll";
            dialog.Title = "Select the Assembly containing the migrations";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMigrations.Text = dialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintToOutput("Process canceled!");
            p.Kill();
        }

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CommandsForm();
            form.Show();

        }
    }
}