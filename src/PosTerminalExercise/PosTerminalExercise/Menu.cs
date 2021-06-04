using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PosTerminalExercise
{
    public class Menu
    {
        public List<Product> ItemMenu { get; set; } = new List<Product>();

        public void LoadMenu(string file)
        {
            using var reader = new StreamReader(file);

            var line = reader.ReadLine();
            while(line != null)
            {
                var item = line.Split("|");
                ItemMenu.Add(new Product
                {
                    Name = item[0],
                    Cost = decimal.Parse(item[1]),
                    Description = item[2]
                });
                line = reader.ReadLine();
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            for(var i = 0; i < ItemMenu.Count; i++)
            {
                builder.AppendLine($"{i + 1}: {ItemMenu[i].Name} ({ItemMenu[i].Cost:C}) {ItemMenu[i].Description}");
            }

            return builder.ToString();
        }
    }
}
