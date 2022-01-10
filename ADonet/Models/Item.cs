using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADonet.Models
{
    public enum Types { Vegetable,  Fruit };
    public enum Colors {Red, Green, Yellow, Violet };
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Types Type { get; set; }
        public Colors Color { get; set; }
        public int Calories { get; set; }
    }
}
