using System;
using DeliveryService.Contracts;
using DeliveryService.UI;
using DeliveryService.Models;

namespace DeliveryService.Services
{
    public class Starter : IStarter
    {
        public void Start(Company company, Customer customer)
        {
            while (true)
            {
                UserUI.StartUI();

                Starter.GetChoice(company, customer);
            }
        }

        public static void GetChoice(Company company, Customer customer)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    UserUI.СompanyActionsUI(company);
                    break;
                case 2:
                    CustomerServices.СustomerActions(company, customer);
                    break;
            }
        }        
    }
}
