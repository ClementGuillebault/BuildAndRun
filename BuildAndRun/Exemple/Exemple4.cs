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
        return await Task.Delay(5000).ContinueWith(x => {
            var data = Enumerable.Range(1, 10000000);
            return data.Select(z => z++).Where(y => y % 8 == 0).ToList();
        });
    }
    public static void Main() { }
}

