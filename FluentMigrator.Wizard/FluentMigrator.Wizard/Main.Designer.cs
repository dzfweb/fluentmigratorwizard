namespace FluentMigrator.Wizard
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Geral = new System.Windows.Forms.TabPage();
            this.Options = new System.Windows.Forms.GroupBox();
            this.btnArgument = new System.Windows.Forms.Button();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxVerbose = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectConsole = new System.Windows.Forms.Button();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMigrations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRunner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMigrator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnDownAll = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Geral.SuspendLayout();
            this.Options.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Console.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Geral);
            this.tabControl1.Controls.Add(this.Console);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 440);
            this.tabControl1.TabIndex = 1;
            // 
            // Geral
            // 
            this.Geral.Controls.Add(this.Options);
            this.Geral.Controls.Add(this.cbxVerbose);
            this.Geral.Controls.Add(this.groupBox1);
            this.Geral.Location = new System.Drawing.Point(4, 22);
            this.Geral.Name = "Geral";
            this.Geral.Padding = new System.Windows.Forms.Padding(3);
            this.Geral.Size = new System.Drawing.Size(536, 414);
            this.Geral.TabIndex = 0;
            this.Geral.Text = "General";
            this.Geral.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.btnArgument);
            this.Options.Controls.Add(this.txtArguments);
            this.Options.Controls.Add(this.label8);
            this.Options.Location = new System.Drawing.Point(6, 312);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(524, 75);
            this.Options.TabIndex = 15;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // btnArgument
            // 
            this.btnArgument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArgument.Location = new System.Drawing.Point(384, 34);
            this.btnArgument.Name = "btnArgument";
            this.btnArgument.Size = new System.Drawing.Size(124, 23);
            this.btnArgument.TabIndex = 16;
            this.btnArgument.Text = "Execute";
            this.btnArgument.UseVisualStyleBackColor = true;
            this.btnArgument.Click += new System.EventHandler(this.btnArgument_Click);
            // 
            // txtArguments
            // 
            this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArguments.Location = new System.Drawing.Point(9, 37);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(353, 20);
            this.txtArguments.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Arguments";
            // 
            // cbxVerbose
            // 
            this.cbxVerbose.AutoSize = true;
            this.cbxVerbose.Checked = true;
            this.cbxVerbose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxVerbose.Location = new System.Drawing.Point(459, 393);
            this.cbxVerbose.Name = "cbxVerbose";
            this.cbxVerbose.Size = new System.Drawing.Size(65, 17);
            this.cbxVerbose.TabIndex = 14;
            this.cbxVerbose.Text = "Verbose";
            this.cbxVerbose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSelectConsole);
            this.groupBox1.Controls.Add(this.txtContext);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProvider);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtConnection);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMigrations);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRunner);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMigrator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConsole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(489, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(489, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(489, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelectConsole
            // 
            this.btnSelectConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectConsole.Location = new System.Drawing.Point(489, 39);
            this.btnSelectConsole.Name = "btnSelectConsole";
            this.btnSelectConsole.Size = new System.Drawing.Size(25, 23);
            this.btnSelectConsole.TabIndex = 17;
            this.btnSelectConsole.Text = "...";
            this.btnSelectConsole.UseVisualStyleBackColor = true;
            this.btnSelectConsole.Click += new System.EventHandler(this.btnSelectConsole_Click);
            // 
            // txtContext
            // 
            this.txtContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContext.Location = new System.Drawing.Point(270, 264);
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(242, 20);
            this.txtContext.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Context";
            // 
            // txtProvider
            // 
            this.txtProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvider.Location = new System.Drawing.Point(9, 264);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(238, 20);
            this.txtProvider.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Provider";
            // 
            // txtConnection
            // 
            this.txtConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnection.Location = new System.Drawing.Point(9, 220);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(505, 20);
            this.txtConnection.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Connection";
            // 
            // txtMigrations
            // 
            this.txtMigrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMigrations.Location = new System.Drawing.Point(9, 175);
            this.txtMigrations.Name = "txtMigrations";
            this.txtMigrations.Size = new System.Drawing.Size(472, 20);
            this.txtMigrations.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Migrations";
            // 
            // txtRunner
            // 
            this.txtRunner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRunner.Location = new System.Drawing.Point(9, 128);
            this.txtRunner.Name = "txtRunner";
            this.txtRunner.Size = new System.Drawing.Size(472, 20);
            this.txtRunner.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Runner";
            // 
            // txtMigrator
            // 
            this.txtMigrator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMigrator.Location = new System.Drawing.Point(9, 81);
            this.txtMigrator.Name = "txtMigrator";
            this.txtMigrator.Size = new System.Drawing.Size(472, 20);
            this.txtMigrator.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Migrator";
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(9, 42);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(472, 20);
            this.txtConsole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Console";
            // 
            // Console
            // 
            this.Console.Controls.Add(this.txtOutput);
            this.Console.Location = new System.Drawing.Point(4, 22);
            this.Console.Name = "Console";
            this.Console.Padding = new System.Windows.Forms.Padding(3);
            this.Console.Size = new System.Drawing.Size(536, 414);
            this.Console.TabIndex = 1;
            this.Console.Text = "Output";
            this.Console.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(530, 408);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // btnDownAll
            // 
            this.btnDownAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownAll.Image = global::FluentMigrator.Wizard.Resource.down_arrow_4;
            this.btnDownAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownAll.Location = new System.Drawing.Point(252, 473);
            this.btnDownAll.Name = "btnDownAll";
            this.btnDownAll.Size = new System.Drawing.Size(96, 23);
            this.btnDownAll.TabIndex = 6;
            this.btnDownAll.Text = "DOWN ALL";
            this.btnDownAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownAll.UseVisualStyleBackColor = true;
            this.btnDownAll.Click += new System.EventHandler(this.btnDownAll_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Image = global::FluentMigrator.Wizard.Resource.orbit;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(150, 473);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(96, 23);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Image = global::FluentMigrator.Wizard.Resource.down_arrow_1;
            this.btnDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDown.Location = new System.Drawing.Point(354, 473);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(96, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUp.Location = new System.Drawing.Point(456, 473);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(96, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(362, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.arquivoToolStripMenuItem.Text = "File";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.abrirToolStripMenuItem.Text = "Open";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.salvarToolStripMenuItem.Text = "Save as ...";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ajudaToolStripMenuItem.Text = "Help";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sobreToolStripMenuItem.Text = "About";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(281, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 20);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Clear Output";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 508);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDownAll);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "FluentMigrator Wizard";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Console.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Geral;
        private System.Windows.Forms.TabPage Console;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMigrations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRunner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMigrator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownAll;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button btnArgument;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxVerbose;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSelectConsole;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

