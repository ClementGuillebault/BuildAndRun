using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAndRun.Library {
    class CompileRepository : IToCompile, IDisposable {
        private bool disposedValue;

        private FileInfo File { get; set; }
        private DataTable Dt { get; set; }
        private DirectoryInfo Directory { get; set; }

        private IList<Automate> Automates { get; set; }
        public CompileRepository() { }
        public CompileRepository(FileInfo file) {
            File = file;
        }

        public CompileRepository(DataTable dt) {
            Dt = dt;
            foreach(DataRow dr in dt.Rows) {
                Automates.Add(new Automate() {
                    Name = dr["name"].ToString(),
                    FileName = dr["path"].ToString()
                });
            }
        }

        public CompileRepository(DirectoryInfo directory) {
            Directory = directory;
            Automates = new List<Automate>();
            
            Directory.EnumerateFiles("*.cs", SearchOption.AllDirectories)
                .ToList()
                .ForEach(file => {
                    Automates.Add(new Automate() {
                        Name = file.Name,
                        FileName = file.FullName
                    });
                });
        }

        public Automate GetAutomate(int id) => Automates[id];

        public IEnumerable<Automate> GetAutomates() => Automates;

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    if (Dt != null) {
                        Dt.Dispose();
                    }
                    // TODO: supprimer l'état managé (objets managés)
                }

                // TODO: libérer les ressources non managées (objets non managés) et substituer le finaliseur
                // TODO: affecter aux grands champs une valeur null
                disposedValue = true;
            }
        }

        public void Dispose() {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
