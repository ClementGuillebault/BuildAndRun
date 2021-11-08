using BuildAndRun.Forms.Errors;
using BuildAndRun.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAndRun {
    public partial class Form1 : Form {
        public string PATH = @"C:\Users\Ours\Desktop\BuildAndRun\BuildAndRun\Exemple";
        public IList<Build> Builds { get; set; }
        public ObservableCollection<Automate> Automates { get; set; } = new ObservableCollection<Automate>();
        public IList<System.CodeDom.Compiler.CompilerError> BuildErrors { get; set; }

        public Form1() {
            InitializeComponent();
            Automates.CollectionChanged += Automates_CollectionChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            Builds = new List<Build>();
            BuildErrors = new List<System.CodeDom.Compiler.CompilerError>();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) { return; }

            if (e.ColumnIndex == dataGridView1.Columns["colSeeBuildErrors"].Index) {
                if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["colStateOfBuild"].Value) == (int)State.Failed) {
                    var Form2 = new FormErrorBuild(BuildErrors);
                    Form2.Show();
                    return;
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["colSeeRunErrors"].Index) {

            }
        }

        private void Automates_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            if (e.NewItems != null) {
                foreach (Automate automate in e.NewItems) {
                    if (automate is null) {
                        return;
                    }
                    dataGridView1?.BeginInvoke((MethodInvoker) delegate () {
                        dataGridView1.Rows.Add(
                            automate.Name,
                            automate.ExecutedAt,
                            automate.StateOfBuild.ToString(),
                            null, // button see errors
                            automate.StateOfRun.ToString(),
                            null // button see errors
                        );
                    });
                }
            }
        }

        public void BtnRun_Click(object sender, EventArgs e) {
            var compileRepository = new CompileRepository(new DirectoryInfo(PATH));
            var automates = compileRepository.GetAutomates();
            try {
                Parallel.ForEach(automates, async (automate) => {
                    Build compilation = new Build(automate);
                    compilation.BuildErrors_Updated += Compilation_BuildErrors_Updated;
                    Automates.Add(automate);
                    automate.StateOfBuild_Changed += Automate_StateOfBuild_Changed;
                    automate.StateOfRun_Changed += Automate_StateOfRun_Changed;
                    compilation.Compile();
                    await compilation.Execute();
                });
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private void Compilation_BuildErrors_Updated(object sender, System.CodeDom.Compiler.CompilerErrorCollection e) {
            if (e.Count > 0) {
                foreach (System.CodeDom.Compiler.CompilerError error in e) {
                    BuildErrors.Add(error);
                }
            }
        }

        public void Automate_StateOfRun_Changed(object sender, StateChangedEventArgs e) {
            try {
                dataGridView1?.BeginInvoke((MethodInvoker)delegate () {
                    foreach (DataGridViewRow row in dataGridView1.Rows) {
                        string executedAt = Convert.ToString(row.Cells["colExecutedAt"].Value);
                        if (row.Cells["colNameOfFile"].Value.ToString() == e.Name && executedAt.Length == 0) {
                            row.Cells["colExecutedAt"].Value = e.ExecutedAt;
                            row.Cells["colStateOfRun"].Value = e.State;
                            break;
                        }
                    }
                });
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void Automate_StateOfBuild_Changed(object sender, StateChangedEventArgs e) {
            try {
                dataGridView1?.BeginInvoke((MethodInvoker)delegate () {
                    foreach (DataGridViewRow row in dataGridView1.Rows) {
                        string executedAt = Convert.ToString(row.Cells["colExecutedAt"].Value);
                        if (row.Cells["colNameOfFile"].Value.ToString() == e.Name && executedAt.Length == 0) {
                            row.Cells["colExecutedAt"].Value = e.ExecutedAt;
                            row.Cells["colStateOfBuild"].Value = e.State;
                            break;
                        }
                    }
                });
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void BtnConfiguration_Click(object sender, EventArgs e) {

        }
    }
}
