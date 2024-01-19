using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public string GetName()
        {
            return $"Pizza:{Name}";
        }
        public string GetPrice()
        {
            return $"Pizza:{Price}";
        }
        public bool Ispresent(string pizza)
        {
            bool ans;
            if(pizza== "Margarita" || pizza== "Pepperoni")
            {
               ans= true;
            }
            else
            {
                ans= false;
            }
            return ans;
        }

       
    }
}
