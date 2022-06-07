using System;
using System.Collections.Generic;

namespace Eval1YongjiangLiu803
{
    class Program
    {
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
            feriees.Add(701, feriee5);
            feriees.Add(901, feriee6);
            feriees.Add(1012, feriee7);
            feriees.Add(1225, feriee8);

            //02_6
            Console.WriteLine("\n02_6 objet Feriee Values: \n");
            Eval1.Exo02(feriees);

            //02_7
            Console.WriteLine("\n02_7 Keys: \n");
            foreach (var feriee in feriees)
            {
                Console.WriteLine(feriee.Key);
            }

            //02_8
            Console.WriteLine($"\nCode 901 avec object: {feriees[901].Code}, {feriees[901].Titre}, {feriees[901].RegleCalcul}. \n" );

            // Question 03
            //Instance for testing errors
            Feriee feriee9 = new Feriee(100, "Fête du Canada", "1er juillet");
            Feriee feriee10 = new Feriee(1240, "Fête du Canada", "1er juillet");

            //Add instance to 2022 calendar, we can get any data from calendar instance...
            Calendrier calendrier2022 = new Calendrier(2022, dateFeriees, feriees);
            Console.WriteLine("\nPourrait faire la même chose avec l'instance du calendrier 2022...\n");
            Eval1.Exo01(calendrier2022.DateFeriees);
            Eval1.Exo02(calendrier2022.Feriees);
        }

    }
}
