using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Model
{
    public class Cuisine
    {
        public string Name { get; set; } = string.Empty;
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
        public override string ToString() => Name;
    }
}
