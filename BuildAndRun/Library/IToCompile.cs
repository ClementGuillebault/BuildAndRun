using System;
using System.Collections.Generic;

namespace BuildAndRun.Library {
    public interface IToCompile: IDisposable {
        IEnumerable<Automate> GetAutomates();
        Automate GetAutomate(int id);
    }
}
