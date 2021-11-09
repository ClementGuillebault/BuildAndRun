using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Automate {
    public async static Task<dynamic> Execute() {
        await Task.Delay(15000).ContinueWith(x => {
            try {
                throw new NullReferenceException();
            }
            catch {
            }
        });
        return "ok";
    }

    public static void Main() { }
}
