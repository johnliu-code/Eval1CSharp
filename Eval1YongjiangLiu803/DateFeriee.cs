using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval1YongjiangLiu803
{
    //01_4
    class DateFeriee
    {
        public DateTime date;
        public Feriee feriee;

        public DateFeriee (DateTime date, Feriee feriee)                   //01_5
        {
            this.date = date;
            this.feriee = feriee;
        }

        public DateTime Date { get { return date; } } 
        public Feriee Feriee { get { return feriee; } }

        // Ajouter une méthode JourSemaine qui retourne le nom du jour de la semaine en français
        public string JourSemaine ()                              //01_6
        {
            string joursemaine = null;
            if (date != null)
                //joursemaine = date.DayOfWeek.ToString();
                joursemaine = date.ToString("dddd", new System.Globalization.CultureInfo("fr-FR"));

            return joursemaine;
        }

        // Ajouter une méthode DateLongue() qui retourne une date en format long.
        public string DateLongue()                                //01_7
        {
            return date.ToLongDateString();
        }

    }
}
