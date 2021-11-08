using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuildAndRun.Library {

    public class Build {
        public const string PATH = @"C:\inetpub\wwwroot\e-archivsystem-TZ\AutomateManager\Automates\";

        public Build() {
        }

        public Build(Automate automate) => TemplateAutomate = automate;

        public event EventHandler<CompilerErrorCollection> BuildErrors_Updated;

        public CompilerResults CompilerResults { get;set; }

        private CompilerErrorCollection _buildErrors { get; set; }
        public CompilerErrorCollection BuildErrors {
            get => _buildErrors;
            set {
                _buildErrors = value;
                OnBuildErrorsUpdated();
            }
        }
        public CompilerParameters CompilerParameters { get; set; } = null;

        public bool ErrorInExecution { get; set; } = false;
        public Exception BuildExceptions { get; set; }
        public Exception RunExceptions { get; set; }

        public MethodInfo MethInfo { get; set; } = null;
        public Module Module { get; set; } = null;
        public Type Mt { get; set; } = null;
        public string Name { get; set; } = "";
        public CodeDomProvider Provider { get; set; } = null;
        public dynamic Retour { get; set; } = null;
        public StringBuilder SbErrors { get; set; } = new StringBuilder();
        public FileInfo SourceFile { get; set; } = null;
        public Automate TemplateAutomate { get; set; } = new Automate();

        public virtual void OnBuildErrorsUpdated() {
            BuildErrors_Updated.Invoke(this, BuildErrors);
        }


        public void Compile(string filename = "") {
            string sourceName = string.IsNullOrEmpty(filename) ? TemplateAutomate.FileName : filename;

            SourceFile = new FileInfo(sourceName);

            GetProvider();

            if (Provider is null) {
                SbErrors.Append("Source file must have a .cs or .vb extension. You: " + SourceFile.Extension);
                return;
            }

            Name = Path.GetRandomFileName() + ".exe";

            SetCompilerParameters();
            SetAssemblies();

            List<string> assemblies = new List<string> {
                //@"C:\inetpub\wwwroot\e-archivsystem-TZ\AutomateManager\bin\Debug\Syncfusion.Pdf.Base.dll",
                //@"C:\inetpub\wwwroot\e-archivsystem-TZ\AutomateManager\bin\Debug\FluentFTP.dll",
                //@"C:\inetpub\wwwroot\e-archivsystem-TZ\AutomateManager\bin\Debug\EASLib.dll"
            };
            AddAssemblies(assemblies);

            try {
                CompilerResults = Provider.CompileAssemblyFromFile(CompilerParameters, sourceName);
            }
            catch (Exception ex) {
                BuildExceptions = ex;
                TemplateAutomate.StateOfBuild = State.Error;
                return;
            }

            if (CompilerResults.Errors.Count > 0) {
                BuildErrors = CompilerResults.Errors;
                TemplateAutomate.StateOfBuild = State.Failed;
            }
            else {
                TemplateAutomate.StateOfBuild = State.Success;
            }
            
        }

        public async Task Execute() {
            if (TemplateAutomate.StateOfBuild != State.Success) { return; }
            Module = CompilerResults.CompiledAssembly.GetModules()[0];
            if (Module != null) {
                Mt = Module.GetType("Automate");
            }

            if (Mt != null) {
                // le 0 correspond à la premiere fonction (fn Execute)
                MethInfo = ((MethodInfo[])((TypeInfo)Mt).DeclaredMethods)[0];
            }

            if (MethInfo != null) {
                try {
                    Type attType = typeof(AsyncStateMachineAttribute);
                    var attrib = (AsyncStateMachineAttribute)MethInfo.GetCustomAttribute(attType);
                    if (attrib != null) {
                        Retour = await (Task<dynamic>)MethInfo?.Invoke(null, null);
                    }
                    else {
                        Retour = (dynamic)MethInfo?.Invoke(null, null);
                    }

                    // Retour = MethInfo?.Invoke(null, new object[1] { TemplateAutomate.Parametres[0] });
                    TemplateAutomate.ExecutedAt = DateTime.Now;

                    ErrorInExecution = false;
                    TemplateAutomate.StateOfRun = State.Success;
                }
                catch (Exception ex) {
                    TemplateAutomate.ExecutedAt = DateTime.Now;
                    TemplateAutomate.StateOfRun = State.Failed;
                    ErrorInExecution = true;
                    RunExceptions = ex;
                }
            }
        }

        private void AddAssemblies(List<string> assemblies) {
            if (assemblies != null && assemblies.Count > 0) {
                foreach (string assemblie in assemblies) {
                    try {
                        CompilerParameters.ReferencedAssemblies.Add(assemblie);
                    }
                    catch (Exception ex) {
                        BuildExceptions = ex;
                    }
                }
            }
        }

        private void GetProvider() {
            string extention = SourceFile.Extension.ToUpper(
                CultureInfo.InvariantCulture);

            if (extention.Equals(".CS")) {
                Provider = CodeDomProvider.CreateProvider("CSharp");
            }
            else if (extention.Equals(".VB")) {
                Provider = CodeDomProvider.CreateProvider("VisualBasic");
            }
        }

        private void SetAssemblies() {
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies()) {
                CompilerParameters.ReferencedAssemblies.Add(asm.Location);
            }
        }

        private void SetCompilerParameters() {
            CompilerParameters = new CompilerParameters {
                OutputAssembly = Name,
                CompilerOptions = "/optimize",
                GenerateInMemory = false,
                GenerateExecutable = true,
                TreatWarningsAsErrors = false,
                IncludeDebugInformation = true
            };
        }
    }

}