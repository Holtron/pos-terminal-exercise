using System;
using System.Text;

namespace PosTerminalExercise
{
    public class CashPayment : PaymentMethod
    {
        public decimal PaidAmount { get; set; }

        public decimal Change { get; set; }

        public CashPayment()
        {
            PaymentType = PaymentType.Cash;
        }

        public CashPayment(decimal amount)
        {
            PaymentType = PaymentType.Cash;
            Amount = amount;
        }

        public override void PayTheMan(decimal totalCharge)
        {
            Console.Write("Enter cash received: ");
            var input = Console.ReadLine();

            var validInput = false;
            while (!validInput)
            {
                if(decimal.TryParse(input, out var amount))
                {
                    if(amount < totalCharge)
                    {
                        Console.Write("Recieved cash is less than the required amount, try again: ");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        PaidAmount = amount;
                        validInput = true;
                    }                    
                }
                else
                {
                    Console.Write("Input was not a valid decimal. Please try again: ");
                    input = Console.ReadLine();
                }
            }

            Change = PaidAmount - totalCharge;
        }

        public override string EndOfReceiptOutput()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"Payment Method: {PaymentType}")
                .AppendLine($"Amount Paid: {PaidAmount}")
                .AppendLine($"Change: {Change}")
                .AppendLine("Thank you for coming in, please stop by again!");

            return builder.ToString();
        }
    }
}
