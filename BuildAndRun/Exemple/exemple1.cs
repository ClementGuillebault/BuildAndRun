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
        Console.WriteLine("Exemple 1");
        return await Task.Delay(10000).ContinueWith(x => {
            return "ok";
        });
    }

    public static void Main() { }
}
