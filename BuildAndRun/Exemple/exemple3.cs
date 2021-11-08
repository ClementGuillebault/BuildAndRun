using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Automate {
    /// <summary>
    /// La function principal. Elle doit forcement retourner un object Retour
    /// Un object dynamique fonctionne aussi tant que vous respectez la
    /// nomanclature de la class Retour.
    /// </summary>
    /// <returns></returns>
    public async static Task<dynamic> Execute() {
        await Task.Delay(15000).ContinueWith(x => {
            throw new NullReferenceException();
        });
        return "ok";
    }

    public static void Main() { }
}
