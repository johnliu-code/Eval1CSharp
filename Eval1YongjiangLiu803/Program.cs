using System;
using System.Collections.Generic;
using System.Globalization;

namespace Eval1YongjiangLiu803
{
    class Program
    {
        //Method to add instance de Feriee
        static Calendrier AddCalendrier(int anne, List<DateFeriee> dateFeriees, Dictionary<int, Feriee> feriees) 
        {       
            Console.WriteLine("Code entre 101 - 1231");
            int code = Eval1.Exo03(int.Parse(Console.ReadLine()));
            Console.WriteLine("Titre de Feriee");
            string titre = Console.ReadLine();
            Console.WriteLine("Regle Calcul date");
            string regleCalcul = Console.ReadLine();

            Feriee feriee = new Feriee(code, titre, regleCalcul);

            Console.WriteLine("Date de Feriee: yyyy-mm-dd");           
            var cultureInfo = new CultureInfo("es-ES");
            string inputDate = Console.ReadLine();
            string formatDateTime = "yyyy-MM-dd";
            DateTime date = DateTime.ParseExact(inputDate, formatDateTime, cultureInfo);

            DateFeriee dateFeriee = new DateFeriee(date, feriee);
            dateFeriees.Add(dateFeriee);
            feriees.Add(feriee.Code, feriee);

            Console.WriteLine("Countinuez ajouter Feriee? Y/N");
            string option = Console.ReadLine().ToUpper();
            if (option == "Y")
                return AddCalendrier(anne, dateFeriees, feriees);

            Calendrier calendrier = new Calendrier(anne, dateFeriees, feriees);
            return calendrier;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluation 1 Yongjiang Liu Group 803: \n");

            //  Question 01
            Console.WriteLine("EXERCICE 1 \n------------------------\n");
            //Instance de Feriee  01_9
            Feriee feriee1 = new Feriee("Fête du Canada", "1er juillet");
            Feriee feriee2 = new Feriee("Fête du travail", "1er lundi de septembre");
            Feriee feriee3 = new Feriee("Action de grâces", "2e lundi d’octobre");
            Feriee feriee4 = new Feriee("jour de Noël", "25 décembre");

            //Instance de DateFeriee  01_10
            DateFeriee dateFeriee1 = new DateFeriee(new DateTime(2022, 07, 01), feriee1);
            DateFeriee dateFeriee2 = new DateFeriee(new DateTime(2022, 09, 05), feriee2);
            DateFeriee dateFeriee3 = new DateFeriee(new DateTime(2022, 10, 10), feriee3);
            DateFeriee dateFeriee4 = new DateFeriee(new DateTime(2022, 12, 26), feriee4);

            //01_11
            List<DateFeriee> dateFeriees = new List<DateFeriee>();

            dateFeriees.Add(dateFeriee1);
            dateFeriees.Add(dateFeriee2);
            dateFeriees.Add(dateFeriee3);
            dateFeriees.Add(dateFeriee4);

            Eval1.Exo01(dateFeriees);

            // Question 02
            //02_4
            Dictionary<int, Feriee> feriees = new Dictionary<int, Feriee>();
            //02_5
            Console.WriteLine("\nEXERCICE 2 \n------------------------\n");
            Feriee feriee5 = new Feriee(701, "Fête du Canada", "1er juillet");
            Feriee feriee6 = new Feriee(901, "Fête du travail", "1er lundi de septembre");
            Feriee feriee7 = new Feriee(1012, "Action de grâces", "2e lundi d’octobre");
            Feriee feriee8 = new Feriee(1225, "jour de Noël", "25 décembre");

            //Dictionary instance
            feriees.Add(feriee5.Code, feriee5);
            feriees.Add(feriee6.Code, feriee6);
            feriees.Add(feriee7.Code, feriee7);
            feriees.Add(feriee8.Code, feriee8);

            //02_6
            Console.WriteLine("\n02_6 Dictionary instance objet  feriees Values: \n");
            Eval1.Exo02(feriees);

            Console.WriteLine("\nOn peut faire ca avec ToString \n");
            foreach(var feriee in feriees)
            {
                Console.WriteLine(feriee.Value.ToString());
            }
            //02_7
            Console.WriteLine("\n02_7 Keys: \n");
            foreach (var feriee in feriees)
            {
                Console.WriteLine(feriee.Key);
            }

            //02_8
            Console.WriteLine($"\nTrouver valeur avec le key : 901, detail de objet: {feriees[901].Code}, {feriees[901].Titre}, {feriees[901].RegleCalcul}. \n" );

            // Question 03
            //Instance for testing errors
            Feriee feriee9 = new Feriee(100, "Fête du Canada", "1er juillet");
            Feriee feriee10 = new Feriee(1240, "Fête du Canada", "1er juillet");

            //Add instance to 2022 calendar, we can get any data from calendar instance...
            Calendrier calendrier2022 = new Calendrier(2022, dateFeriees, feriees);
            calendrier2022 = AddCalendrier(2022, dateFeriees, feriees);               //User peut ajouter autre Feriees a Calendrier..

            //Afficher list de canlendrier instance
            Console.WriteLine("\nPourrait faire la même chose avec l'instance du calendrier 2022...\n");
            Eval1.Exo01(calendrier2022.DateFeriees);
            Eval1.Exo02(calendrier2022.Feriees);


        }

    }
}
