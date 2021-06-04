using System;
using System.Collections.Generic;
using System.Linq;

namespace PosTerminalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.LoadMenu("../../../../Menu.txt");

            var keepOrdering = true;
            while (keepOrdering)
            {
                Console.WriteLine(menu);

                Console.WriteLine("Please enter your selection(s) or \"End\" to finish your order: ");
                var order = new List<Product>();
                var input = Console.ReadLine();
                while (input.ToUpper() != "END")
                {
                    if (!int.TryParse(input, out var selection) || selection > menu.ItemMenu.Count || selection <= 0)
                    {
                        Console.Write("Invalid selection, please try again: ");
                        input = Console.ReadLine();
                        continue;
                    }

                    order.Add(menu.ItemMenu[selection - 1]);
                    Console.WriteLine($"Current Total: {order.Sum(o => o.Cost):C}");
                    Console.Write("Please enter another item or \"End\": ");
                    input = Console.ReadLine();
                }

                var total = order.Sum(o => o.Cost);
                var tax = total * 0.06m;
                var grandTotal = total + tax;

                Console.WriteLine($"Your total is: {total:C}");
                Console.WriteLine($"Tax: {tax:C}");
                Console.WriteLine($"Grand Total: {grandTotal:C}");
                Console.WriteLine("How will you be paying today? (Cash, Card, Check)");
                input = Console.ReadLine();

                PaymentMethod payment = null;
                var validInput = false;
                while (!validInput)
                {
                    switch (input.ToUpper())
                    {
                        case "CASH":
                            payment = new CashPayment();
                            payment.PayTheMan(grandTotal);
                            validInput = true;
                            break;
                        case "CARD":
                            // Card Logic
                            break;
                        case "CHECK":
                            // check Logic
                            break;
                        default:
                            Console.Write("That was not a valid payment type. Try again (Cash, Card, Check): ");
                            input = Console.ReadLine();
                            break;
                    }
                }

                var receipt = new Receipt();
                receipt.BuildReceipt(order, payment);

                Console.Write("Would you like to place another order (type \"n\" to finish)? ");
                input = Console.ReadLine();

                if (input.ToLower() == "n")
                {
                    keepOrdering = false;
                }
            }            
        }
    }
}
