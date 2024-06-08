﻿using delegates;

namespace delegates_practical_example
{
    class Program
    {
        static void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
            stockExchangeMonitor.PriceChangeHandler = ShowPrice;
            stockExchangeMonitor.Start();
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is {price}");
        }
    }
}