using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BuildAndRun.Forms.Errors {
    public partial class FormErrorRun : Form {

        private IList<System.CodeDom.Compiler.CompilerResults> BuildErrors { get; set; }

        public FormErrorRun() {
            InitializeComponent();
        }
        public FormErrorRun(string fileName, IList<Exception> runErrors) {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lblTxtNumberOfErrors.Text = $"Number of error{(runErrors.Count > 1 ? "s" : "")}";
            lblNbErrors.Text = runErrors.Count.ToString();
            foreach (var error in runErrors) {
                dataGridView1.Rows.Add(Path.GetFileName(fileName), "", error.Message);
            }
        }
    }
}
