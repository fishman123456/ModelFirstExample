using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// id int . title string . calories double. proteins double.
// fats double. carbohydrates double. weght double

namespace ModelFirstExample.Model
{
    internal class Menuitem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Calories { get; set; }
        public int Proteins { get; set; }
        public int Fats { get; set; }
        public int Carbohydrates { get; set;}
        public int Weight { get; set; }
        public Menuitem() { }
        public Menuitem(int id, string title, int calories, int proteins, int fats, int carbohydrates, int weight)
        {
            Id = id;
            Title = title;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Id} - {Title} - {Calories} - {Proteins} - {Fats} - {Carbohydrates} - {Weight}";
        }
    }
}
