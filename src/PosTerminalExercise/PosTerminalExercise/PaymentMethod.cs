namespace PosTerminalExercise
{
    public abstract class PaymentMethod
    {
        public PaymentType PaymentType { get; set; }

        public decimal Amount { get; set; }

        public abstract void PayTheMan(decimal totalCharge);

        public abstract string EndOfReceiptOutput();
    }
}
