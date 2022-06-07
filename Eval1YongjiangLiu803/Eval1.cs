using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1YongjiangLiu803
{
    static class Eval1
    {
        //01_8
        public static void Exo01(List<DateFeriee> dateFeriees)
        {
            Console.WriteLine($"\n{"Evenement",-30} {"Jour",-20} {"Date",-20} " +
                              $"\n------------------------------------------------------------------------\n");
            foreach (var dateFerie in dateFeriees)
            {
                Console.WriteLine($"{dateFerie.Feriee.Titre,-30} { dateFerie.JourSemaine(),-20} {dateFerie.DateLongue(),-20}");
            }
        }

        //02_3
        public static void Exo02(Dictionary<int, Feriee> feriees)                               
        {
            Console.WriteLine($"\n{"Code",-10} {"Evenement",-20} {"Date",-20} " +
                              $"\n------------------------------------------------------------\n");
            foreach (var feriee in feriees.Values)
            {
                Console.WriteLine($"{feriee.Code,-10} { feriee.Titre,-20} {feriee.RegleCalcul,-20}");
            }
        }

        //Method tocatch the error for valid code number between 100 and 1231
        public static int Exo03(int code)
        {
            int validcode = 0;
            try
            {
                if (code < 101 || code > 1231)
                    throw new CodeValidException();
                validcode = code;
            }
            catch (CodeValidException ex)
            {
                Console.WriteLine($"{code} is Not a valid code, number must be between 101 and 1231!! \n");
            }
            return validcode;
        }
    }
}
