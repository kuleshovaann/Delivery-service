using System;
using Models.Models;
using Models.Services;

namespace Models.UI
{
    public class CompanyUI
    {
        public static void СompanyActions(Company company)
        {
            Console.WriteLine("1 - Adding a new dish");
            Console.WriteLine("2 - View menu");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    CompanyServices.AddDish(company);
                    break;
                case 2:
                    CompanyServices.ShowMenu(company);
                    break;
            }

            Console.WriteLine();
        }       
    }
}
