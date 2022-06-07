using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1YongjiangLiu803
{
    class Calendrier
    {
        public int anne;
        public List<DateFeriee> dateFeriees;
        public Dictionary<int, Feriee> feriees;

        public Calendrier (int anne, List<DateFeriee> dateFeriees, Dictionary<int, Feriee> feriees)
        {
            try
            {
                if (anne <= 0)
                    throw new IntAnneException("Anne sera pas 0 ou negative!!");
                else if (anne > 9999)
                    throw new IntAnneException("Anne ne peut pas plus que 9999!!");
                this.anne = anne;

            }
            catch (IntAnneException ex)
            {
                Console.WriteLine(ex);
            }

            this.dateFeriees = dateFeriees;
            this.feriees = feriees;
        }

        public int Anne { get { return anne; } }
        public List<DateFeriee> DateFeriees { get { return dateFeriees; } }
        public Dictionary<int, Feriee> Feriees { get { return feriees;} }
    }
}
