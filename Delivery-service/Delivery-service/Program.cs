﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture1
{
    internal class DataDelivery
    {
        private decimal GetFullPrice(
                                    IEnumerable<string> destinations,
                                    IEnumerable<string> clients,
                                    IEnumerable<int> infantsIds,
                                    IEnumerable<int> childrenIds,
                                    IEnumerable<decimal> prices,
                                    IEnumerable<string> currencies)
        {
            decimal fullPrice = default;

            if (Validate(destinations.Count(), clients.Count(), prices.Count(), currencies.Count()))
            {
                var pricesDiscounts = prices.ToArray();

                pricesDiscounts = GetPricesInUSD(pricesDiscounts, currencies);

                pricesDiscounts = GetFirstDiscount(pricesDiscounts, destinations);

                var amountOfInterest = GetAmountOfInterest(destinations.Count(), infantsIds, childrenIds);

                var adsressWithOtherDiscount = GetAddressWithOtherDiscount(destinations);

                amountOfInterest = GetUpdateAmountOfInterest(destinations, amountOfInterest, adsressWithOtherDiscount);

                pricesDiscounts = GetPriceWithAllDiscount(pricesDiscounts, amountOfInterest);

                fullPrice = GetFullPrice(fullPrice, pricesDiscounts);
            }

            return fullPrice;
        }

        private decimal GetFullPrice(decimal fullPrice, decimal[] pricesDiscounts)
        {
            for (int order = 0; order < pricesDiscounts.Length; order++)
            {
                fullPrice += pricesDiscounts[order];
            }

            return fullPrice;
        }

        private decimal[] GetPriceWithAllDiscount(decimal[] pricesDiscounts, int[] amountOfInterest)
        {
            for (int orderNumber = 0; orderNumber < pricesDiscounts.Length; orderNumber++)
            {
                if (amountOfInterest[orderNumber] != 0)
                    pricesDiscounts[orderNumber] -= pricesDiscounts[orderNumber] * amountOfInterest[orderNumber] / 100;
            }

            return pricesDiscounts;
        }

        private int[] GetUpdateAmountOfInterest(IEnumerable<string> destinations, int[] amountOfInterest, List<string> adsressWithOtherDiscount)
        {
            var count = 0;

            foreach (var address in destinations)
            {
                foreach (var addressWithDiscount in adsressWithOtherDiscount)
                {
                    if (address.Contains(addressWithDiscount))
                    {
                        amountOfInterest[count] += 15;
                    }
                }
                count++;
            }

            return amountOfInterest;
        }

        private bool Validate(int destinations, int clients, int prices, int currencies)
        {
            if (destinations == clients && destinations == prices && destinations == currencies)
            {
                return true;
            }

            return false;
        }

        private decimal[] GetPricesInUSD(decimal[] pricesDiscounts, IEnumerable<string> currencies)
        {
            int numberOrderInEUR = 0;

            foreach (var eur in currencies)
            {
                if (eur == "EUR")
                {
                    pricesDiscounts[numberOrderInEUR] *= 1.19m;
                }
                numberOrderInEUR++;
            }

            return pricesDiscounts;
        }

        private decimal[] GetFirstDiscount(decimal[] pricesDiscounts, IEnumerable<string> destinations)
        {
            var countOrder = 0;

            foreach (var order in destinations)
            {
                if (order.Contains("Wayne Street"))
                {
                    pricesDiscounts[countOrder] += 10.0m;
                }

                if (order.Contains("North Heather Street"))
                {
                    pricesDiscounts[countOrder] -= 5.36m;
                }

                countOrder++;
            }

            return pricesDiscounts;
        }
        private int[] GetAmountOfInterest(int length, IEnumerable<int> infantsIds, IEnumerable<int> childrenIds)
        {
            int[] amountOfDiscounts = new int[length];

            for (int orderNumber = 0; orderNumber < length; orderNumber++)
            {
                if (infantsIds.Contains(orderNumber))
                {
                    amountOfDiscounts[orderNumber] += 50;
                }

                if (childrenIds.Contains(orderNumber))
                {
                    amountOfDiscounts[orderNumber] += 25;
                }
            }

            return amountOfDiscounts;
        }

        private List<string> GetAddressWithOtherDiscount(IEnumerable<string> destinations)
        {
            var addressWithDiscount = new List<string>();

            var address = destinations.Select(a => a.Substring(0, a.IndexOf(","))).OrderBy(a => a).ToArray();

            var houseNumbers = address.Select(a => a.Substring(0, a.IndexOf(" "))).ToArray();

            var streetNames = destinations.Select(a => a.Substring(a.IndexOf(" "), a.IndexOf(",") - 3)).ToArray();

            int[] houseNumb = Array.ConvertAll(houseNumbers, s => int.TryParse(s, out var x) ? x : -1);

            int i;

            for (int number = 0; number < destinations.Count() - 1; number++)
            {
                if (houseNumb[number + 1] - houseNumb[number] == 1 && streetNames[number + 1] == streetNames[number])
                {
                    addressWithDiscount.Add(address[number + 1]);
                }
            }

            return addressWithDiscount;
        }
        public decimal InvokePriceCalculatiion()
        {
            var destinations = new[]
            {
                "949 Fairfield Court, Madison Heights, MI 48071",
                "367 Wayne Street, Hendersonville, NC 28792",
                "910 North Heather Street, Cocoa, FL 32927",
                "911 North Heather Street, Cocoa, FL 32927",
                "706 Tarkiln Hill Ave, Middleburg, FL 32068",
            };

            var clients = new[]
            {
                "Autumn Baldwin",
                "Jorge Hoffman",
                "Amiah Simmons",
                "Sariah Bennett",
                "Xavier Bowers",
            };

            var infantsIds = new[] { 2 };
            var childrenIds = new[] { 3, 4 };

            var prices = new[] { 100, 25.23m, 58, 23.12m, 125 };
            var currencies = new[] { "USD", "USD", "EUR", "USD", "USD" };

            return GetFullPrice(destinations, clients, infantsIds, childrenIds, prices, currencies);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dataDelivery = new DataDelivery();
            var fullPrice = dataDelivery.InvokePriceCalculatiion();
            Console.WriteLine(fullPrice);
        }
    }
}
