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
            var choice = int.TryParse(Console.ReadLine(), out int number);
            switch (number)
            {
                case 1:
                    UserUI.СompanyActionsUI(company);
                    break;
                case 2:
                    CustomerServices.СustomerActions(company, customer);
                    break;
                default:
                    Console.WriteLine("Please, start again.");
                    break;

            }
        }        
    }
}
