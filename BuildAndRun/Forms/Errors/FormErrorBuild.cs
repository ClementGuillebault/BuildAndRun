using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAndRun.Forms.Errors {
    public partial class FormErrorBuild : Form {

        private IList<System.CodeDom.Compiler.CompilerResults> BuildErrors { get; set; }

        public FormErrorBuild() {
            InitializeComponent();
        }
        public FormErrorBuild(IList<System.CodeDom.Compiler.CompilerError> buildErrors) {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lblTxtNumberOfErrors.Text = $"Number of error{(buildErrors.Count > 1 ? "s" : "")}";
            lblNbErrors.Text = buildErrors.Count.ToString();
            foreach (var error in buildErrors) {
                dataGridView1.Rows.Add(Path.GetFileName(error.FileName), error.Line, error.ErrorText);
            }
        }
    }
}
