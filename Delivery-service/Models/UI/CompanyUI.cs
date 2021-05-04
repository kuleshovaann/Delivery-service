using System;
using Models.Models;
using Models.Services;
using Models.Contracts;

namespace Models.UI
{
    public class CompanyUI 
    {
        public static void СompanyActions(ICompany company)
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
