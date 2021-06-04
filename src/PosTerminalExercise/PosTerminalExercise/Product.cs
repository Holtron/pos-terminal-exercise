namespace PosTerminalExercise
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Cost:C}";
        }
    }
}
