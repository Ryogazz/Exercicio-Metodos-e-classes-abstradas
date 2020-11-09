using Exercicio_Metodos_e_classes_abstradas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Metodos_e_classes_abstradas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Healt expenditures: ");
                    double healtExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIcome, healtExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIcome, numberOfEmployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                
                Console.WriteLine(taxPayer.Name +": $ "+ taxPayer.Tax().ToString("f2",CultureInfo.InvariantCulture));
                sum += taxPayer.Tax();
            }
            
            Console.WriteLine();
            Console.Write("TAXES: " + sum.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
