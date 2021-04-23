using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Program
    {
        public static void Start()
        {
            Console.WriteLine("Сontinue as:");
            Console.WriteLine("1 - company");
            Console.WriteLine("2 - customer");
        }
        public static bool GetChoice()
        {
            var choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                return true;
            if (choice == 2)
                return false;
            return false;
        }

        public static void ToAddDish(Company company)
        {
            Console.WriteLine("Enter name:");
            var name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter price:");
            var price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter composition:");
            var composition = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter weight in grams:");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter calories:");
            var calories = int.Parse(Console.ReadLine());

            company.AddMenu(name, price, composition, weight, calories);
        }

        static void Main(string[] args)
        {
            var restraunt = new Company("Drink&Food");
            restraunt.AddMenu("Coffee", 40.0, "Instant coffee", 90, 1);
            restraunt.AddMenu("Black tea", 30.0, "Ceylon long leaf tea", 200, 0);
            restraunt.AddMenu("Green tea", 30.0, "Green tea leaves", 200, 0);
            Console.Clear();

            while (true)
            {
                Start();

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Do you want to add a dish? 1 - Yes, 2 - No");
                        var choice = GetChoice();
                        while (choice)
                        {
                            ToAddDish(restraunt);
                            Console.WriteLine("Do you want to continue adding dishes? 1 - Yes, 2 - No");
                            choice = GetChoice();

                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Do you want to choose a dish? 1 - Yes, 2 - No");
                        var choiceCustomer = GetChoice();
                        Order order = new Order();
                        while (choiceCustomer)
                        {
                            restraunt.ShowMenu();

                            Console.WriteLine("Select dish or drink number:");
                            var index = int.Parse(Console.ReadLine());
                            order.AddToOrder(restraunt, index);

                            Console.WriteLine("Do you want to continue choosing dishes? 1 - Yes, 2 - No");
                            choiceCustomer = GetChoice();
                        }
                        order.ShowOrder();
                        break;
                }
            }
        }
    }
}
