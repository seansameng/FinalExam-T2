using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Model
{
    public class Recipe
    {
        public string Name { get; set; } = string.Empty;
        public List<string> Images { get; set; } = [];
        public List<string> Ingredients { get; set; } = [];
        public string Instructions { get; set; } = "";

    }
}
