
namespace BuildAndRun {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpBoxTitle = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblNumberOfFileRun = new System.Windows.Forms.Label();
            this.lblNumberOfFileCompiled = new System.Windows.Forms.Label();
            this.lblNumberOfFileInDirectory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNameOfFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExecutedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStateOfBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeeBuildErrors = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colStateOfRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeeRunErrors = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusStateOfApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBoxTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // grpBoxTitle
            // 
            this.grpBoxTitle.Controls.Add(this.panel1);
            this.grpBoxTitle.Controls.Add(this.lblNumberOfFileRun);
            this.grpBoxTitle.Controls.Add(this.lblNumberOfFileCompiled);
            this.grpBoxTitle.Controls.Add(this.lblNumberOfFileInDirectory);
            this.grpBoxTitle.Controls.Add(this.label3);
            this.grpBoxTitle.Controls.Add(this.label1);
            this.grpBoxTitle.Controls.Add(this.label2);
            this.grpBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxTitle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.grpBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxTitle.Name = "grpBoxTitle";
            this.grpBoxTitle.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxTitle.Size = new System.Drawing.Size(1067, 225);
            this.grpBoxTitle.TabIndex = 5;
            this.grpBoxTitle.TabStop = false;
            this.grpBoxTitle.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnConfiguration);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(380, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 198);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(197, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButton1);
            this.flowLayoutPanel2.Controls.Add(this.radioButton2);
            this.flowLayoutPanel2.Controls.Add(this.radioButton3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 26);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(181, 137);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(4, 4);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In Directory";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(4, 34);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "In Database";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(4, 64);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "In File";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.Location = new System.Drawing.Point(525, 71);
            this.btnConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(153, 58);
            this.btnConfiguration.TabIndex = 1;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(525, 4);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(153, 58);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfFileRun
            // 
            this.lblNumberOfFileRun.AutoSize = true;
            this.lblNumberOfFileRun.Location = new System.Drawing.Point(263, 104);
            this.lblNumberOfFileRun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfFileRun.Name = "lblNumberOfFileRun";
            this.lblNumberOfFileRun.Size = new System.Drawing.Size(24, 18);
            this.lblNumberOfFileRun.TabIndex = 7;
            this.lblNumberOfFileRun.Text = "25";
            // 
            // lblNumberOfFileCompiled
            // 
            this.lblNumberOfFileCompiled.AutoSize = true;
            this.lblNumberOfFileCompiled.Location = new System.Drawing.Point(263, 71);
            this.lblNumberOfFileCompiled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfFileCompiled.Name = "lblNumberOfFileCompiled";
            this.lblNumberOfFileCompiled.Size = new System.Drawing.Size(24, 18);
            this.lblNumberOfFileCompiled.TabIndex = 6;
            this.lblNumberOfFileCompiled.Text = "50";
            // 
            // lblNumberOfFileInDirectory
            // 
            this.lblNumberOfFileInDirectory.AutoSize = true;
            this.lblNumberOfFileInDirectory.Location = new System.Drawing.Point(263, 37);
            this.lblNumberOfFileInDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfFileInDirectory.Name = "lblNumberOfFileInDirectory";
            this.lblNumberOfFileInDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumberOfFileInDirectory.Size = new System.Drawing.Size(30, 18);
            this.lblNumberOfFileInDirectory.TabIndex = 5;
            this.lblNumberOfFileInDirectory.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of files runs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of files in directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of files compiled:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameOfFile,
            this.colExecutedAt,
            this.colStateOfBuild,
            this.colSeeBuildErrors,
            this.colStateOfRun,
            this.colSeeRunErrors});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 368);
            this.dataGridView1.TabIndex = 6;
            // 
            // colNameOfFile
            // 
            this.colNameOfFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameOfFile.HeaderText = "Name";
            this.colNameOfFile.Name = "colNameOfFile";
            this.colNameOfFile.ReadOnly = true;
            // 
            // colExecutedAt
            // 
            this.colExecutedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExecutedAt.HeaderText = "Executed at";
            this.colExecutedAt.Name = "colExecutedAt";
            this.colExecutedAt.ReadOnly = true;
            // 
            // colStateOfBuild
            // 
            this.colStateOfBuild.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStateOfBuild.HeaderText = "State of build";
            this.colStateOfBuild.Name = "colStateOfBuild";
            this.colStateOfBuild.ReadOnly = true;
            // 
            // colSeeBuildErrors
            // 
            this.colSeeBuildErrors.HeaderText = "Build Errors";
            this.colSeeBuildErrors.Name = "colSeeBuildErrors";
            this.colSeeBuildErrors.ReadOnly = true;
            this.colSeeBuildErrors.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSeeBuildErrors.Width = 70;
            // 
            // colStateOfRun
            // 
            this.colStateOfRun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStateOfRun.HeaderText = "State of run";
            this.colStateOfRun.Name = "colStateOfRun";
            this.colStateOfRun.ReadOnly = true;
            // 
            // colSeeRunErrors
            // 
            this.colSeeRunErrors.HeaderText = "Run Errors";
            this.colSeeRunErrors.Name = "colSeeRunErrors";
            this.colSeeRunErrors.ReadOnly = true;
            this.colSeeRunErrors.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSeeRunErrors.Width = 70;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusStateOfApp,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(350, 16);
            // 
            // toolStripStatusStateOfApp
            // 
            this.toolStripStatusStateOfApp.Image = global::BuildAndRun.Properties.Resources.icon_led_green;
            this.toolStripStatusStateOfApp.Name = "toolStripStatusStateOfApp";
            this.toolStripStatusStateOfApp.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusStateOfApp.Text = "Running...";
            this.toolStripStatusStateOfApp.ToolTipText = "Status of the application";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(587, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.grpBoxTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BuildAndRun";
            this.grpBoxTitle.ResumeLayout(false);
            this.grpBoxTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox grpBoxTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblNumberOfFileRun;
        private System.Windows.Forms.Label lblNumberOfFileCompiled;
        private System.Windows.Forms.Label lblNumberOfFileInDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameOfFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExecutedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateOfBuild;
        private System.Windows.Forms.DataGridViewButtonColumn colSeeBuildErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateOfRun;
        private System.Windows.Forms.DataGridViewButtonColumn colSeeRunErrors;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusStateOfApp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

