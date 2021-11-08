namespace BuildAndRun.Forms.Errors {
    partial class FormErrorBuild {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTxtNumberOfErrors = new System.Windows.Forms.Label();
            this.lblNbErrors = new System.Windows.Forms.Label();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 139);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(601, 306);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colLine,
            this.colErrorText});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNbErrors);
            this.groupBox1.Controls.Add(this.lblTxtNumberOfErrors);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblTxtNumberOfErrors
            // 
            this.lblTxtNumberOfErrors.AutoSize = true;
            this.lblTxtNumberOfErrors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtNumberOfErrors.Location = new System.Drawing.Point(18, 51);
            this.lblTxtNumberOfErrors.Name = "lblTxtNumberOfErrors";
            this.lblTxtNumberOfErrors.Size = new System.Drawing.Size(141, 23);
            this.lblTxtNumberOfErrors.TabIndex = 0;
            this.lblTxtNumberOfErrors.Text = "Number of errors";
            // 
            // lblNbErrors
            // 
            this.lblNbErrors.AutoSize = true;
            this.lblNbErrors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbErrors.Location = new System.Drawing.Point(191, 51);
            this.lblNbErrors.Name = "lblNbErrors";
            this.lblNbErrors.Size = new System.Drawing.Size(27, 23);
            this.lblNbErrors.TabIndex = 2;
            this.lblNbErrors.Text = "10";
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 75;
            // 
            // colLine
            // 
            this.colLine.HeaderText = "Line";
            this.colLine.Name = "colLine";
            this.colLine.ReadOnly = true;
            this.colLine.Width = 50;
            // 
            // colErrorText
            // 
            this.colErrorText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colErrorText.HeaderText = "Error";
            this.colErrorText.Name = "colErrorText";
            this.colErrorText.ReadOnly = true;
            // 
            // FormErrorBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormErrorBuild";
            this.Text = "FormErrorBuild";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNbErrors;
        private System.Windows.Forms.Label lblTxtNumberOfErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorText;
    }
}