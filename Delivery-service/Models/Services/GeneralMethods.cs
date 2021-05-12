using System;
using Models.Contracts;
using Models.UI;


namespace Models.Services
{
    public class GeneralMethods : IStarter
    {
        public void Start(ICompany company, ICustomer customer)
        {
            while (true)
            {
                UserUI.StartUI();

                GeneralMethods.GetChoice(company, customer);
            }
        }

        public static void GetChoice(ICompany company, ICustomer customer)
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
