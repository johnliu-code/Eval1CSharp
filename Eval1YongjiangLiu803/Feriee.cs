using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1YongjiangLiu803
{
    class Feriee
    {
        public int code;                    //02_1
        public string titre;                //01_1
        public string regleCalcul;

        public Feriee (string titre, string reglecalcul)                          //01_2
        {
            this.titre = titre;
            this.regleCalcul = reglecalcul;
        }

        public Feriee(int code, string titre, string reglecalcul)                   //02_2
        {
            this.code = Eval1.Exo03(code);                                          //03 valid code with method form Exo03
            this.titre = titre;
            this.regleCalcul = reglecalcul;
        }

        public int  Code { get { return code; } }
        public string Titre { get { return titre; } set { this.titre = value; } }
        public string RegleCalcul { get { return regleCalcul; } set { this.regleCalcul = value; } }

        public override string ToString()                                         // 01_3
        {
            return $"{titre}, {regleCalcul}";
        }
    }
}
