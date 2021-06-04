using System;
using System.Collections.Generic;
using System.Text;

namespace PosTerminalExercise
{
    public class Receipt
    {
        public void BuildReceipt(List<Product> order, PaymentMethod payment)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Thank you for your order!");

            foreach(var item in order)
            {
                builder.AppendLine(item.ToString());
            }

            builder.AppendLine(payment.EndOfReceiptOutput());

            WriteReceiptToFile("../../../Receipt.txt", builder.ToString());
            Console.WriteLine(builder.ToString());
        }

        private void WriteReceiptToFile(string file, string receipt)
        {
            // Write to file
        }
    }
}
