using BuildAndRun.CustomException;
using BuildAndRun.Forms.Errors;
using BuildAndRun.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildAndRun {

    public partial class Form1 : Form {
        public string PATH = @"your/path/";
        public Form1() {
            InitializeComponent();

            Automates.CollectionChanged += Automates_CollectionChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;

            Builds = new List<Build>();
            BuildErrors = new List<System.CodeDom.Compiler.CompilerError>();
            RunErrors = new List<Exception>();
            FileNameOfAutomatonAlreadyRun = new List<string>();
        }

        public ObservableCollection<Automate> Automates { get; set; } = new ObservableCollection<Automate>();
        public IList<System.CodeDom.Compiler.CompilerError> BuildErrors { get; set; }
        public IList<Build> Builds { get; set; }
        public IList<Exception> RunErrors { get; set; }
        public IList<string> FileNameOfAutomatonAlreadyRun { get; set; }


        public void Automate_StateOfBuild_Changed(object sender, StateChangedEventArgs e) {
            try {
                dataGridView1?.BeginInvoke((MethodInvoker)delegate () {
                    foreach (DataGridViewRow row in dataGridView1.Rows) {
                        if (row.Cells["FileName"].Value.ToString() == e.Name) {
                            row.Cells["ExecutedAt"].Value = e.ExecutedAt;
                            row.Cells["StateOfBuild"].Value = e.State;
                            if (e.State == State.Success) {
                                var temp = new DataGridViewTextBoxCell() {
                                    Value = "No Errors",
                                    Style = new DataGridViewCellStyle() {
                                        BackColor = Color.PaleGreen
                                    }
                                };
                                row.Cells["BuildError"] = temp;
                                row.Cells["BuildError"].ReadOnly = true;
                            }
                            break;
                        }
                    }
                });
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public void Automate_StateOfRun_Changed(object sender, StateChangedEventArgs e) {
            try {
                dataGridView1?.BeginInvoke((MethodInvoker)delegate () {
                    foreach (DataGridViewRow row in dataGridView1.Rows) {
                        if (row.Cells["FileName"].Value.ToString() == e.Name) {
                            row.Cells["ExecutedAt"].Value = e.ExecutedAt;
                            row.Cells["StateOfRun"].Value = e.State;
                            if (e.State == State.Success) {
                                var temp = new DataGridViewTextBoxCell() {
                                    Value = "No Errors",
                                    Style = new DataGridViewCellStyle() {
                                        BackColor = Color.PaleGreen
                                    }
                                };
                                row.Cells["RunError"] = temp;
                                row.Cells["RunError"].ReadOnly = true;
                            }
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

        public void BtnRun_Click(object sender, EventArgs e) {
            var compileRepository = new CompileRepository(new DirectoryInfo(PATH));
            var automates = compileRepository.GetAutomates();
            try {
                Parallel.ForEach(automates, async (automate) => {
                    Build build = new Build(automate);

                    /* Pour les nom de fichiers identique */
                    //if (FileNameOfAutomatonAlreadyRun.Contains(automate.Name)) {
                    //    var name = Path.GetFileNameWithoutExtension(automate.Name);
                    //    automate.Name = name + new Random().Next() + Path.GetExtension(automate.Name);
                    //}
                    Automates.Add(automate);

                    /* Pour les nom de fichier identique */
                    FileNameOfAutomatonAlreadyRun.Add(automate.Name);

                    build.BuildErrors_Updated += Compilation_BuildErrors_Updated;
                    automate.StateOfBuild_Changed += Automate_StateOfBuild_Changed;
                    automate.StateOfRun_Changed += Automate_StateOfRun_Changed;

                    build.Compile();
                    await build.Execute();
                });
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private void Automates_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            if (e.NewItems != null) {
                foreach (Automate automate in e.NewItems) {
                    if (automate is null) {
                        return;
                    }
                    if (FileNameOfAutomatonAlreadyRun.Contains(automate.Name)) {
                        //dataGridView1.Rows.RemoveAt()
                    }
                    else {
                        dataGridView1?.BeginInvoke((MethodInvoker)delegate () {
                            dataGridView1.Rows.Add(
                                automate.Id,
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
        }

        private void Compilation_BuildErrors_Updated(object sender, System.CodeDom.Compiler.CompilerErrorCollection e) {
            if (e.Count > 0) {
                foreach (System.CodeDom.Compiler.CompilerError error in e) {
                    BuildErrors.Add(error);
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) { return; }

            if (e.ColumnIndex == dataGridView1.Columns["BuildError"].Index) {
                if (dataGridView1.Rows[e.RowIndex].Cells["StateOfBuild"].Value.ToString() == State.Failed.ToString()) {
                    var Form2 = new FormErrorBuild(BuildErrors);
                    Form2.Show();
                    return;
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["RunError"].Index) {
                if (dataGridView1.Rows[e.RowIndex].Cells["StateOfRun"].Value.ToString() == State.Failed.ToString()) {
                    var Form2 = new FormErrorRun(dataGridView1.Rows[e.RowIndex].Cells["FileName"].Value.ToString(), RunErrors);
                    Form2.Show();
                    return;
                }
            }
        }
    }
}
