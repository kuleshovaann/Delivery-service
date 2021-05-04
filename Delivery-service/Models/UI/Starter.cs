﻿using Models.Models;
using Models.Contracts;
using Models.UI;
using System;


namespace Models.UI
{
    public class Starter : IStarter
    {
        public void Start(ICompany company, ICustomer customer)
        {
            while (true)
            {
                Console.WriteLine("Сontinue as:");
                Console.WriteLine("1 - company");
                Console.WriteLine("2 - customer");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        CompanyUI.СompanyActions(company);
                        break;
                    case 2:
                        CustomerUI.СustomerActions(company, customer);
                        break;
                }
            }
        }
    }
}
