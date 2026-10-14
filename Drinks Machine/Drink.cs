using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drinks_Machine
{
    public abstract class Drink
    {
        private int price;
        private int volume;
        public string Name { get; set; }

        public int Price
        {
            get { return price; }
            set { if (price > 0) this.price = Price; }
        }

        public int Volume
        {
            get { return volume; }
            set { if (volume > 50 && volume < 1500) this.volume = Volume; }
        }


        public Drink(string name, int price, int volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }

        public virtual double ResultPrice()
        {
            return Price*1.1;
        }

        public class ColdDrink : Drink
        {
            private bool sparkly;
            public bool Sparkly
            {
                get { return sparkly; }
                set { sparkly = value; }
            }
            public ColdDrink(bool sparkly, string name, int price, int volume) : base(name, price, volume)
            {
                Sparkly = sparkly;
            }

        }
        public class HotDrink : Drink
        {
            private double temp;
            public double Temp
            {
                get { return temp; }
                set { if (value >= 30 && value <= 95) temp = value; }
            }
            public HotDrink(double temp, string name, int price, int volume) : base(name, price, volume)
            {
                Temp = temp;
            }
        }
        public class Espresso : HotDrink
        {
            private int shots;
            public int Shots { get; set; }
            public Espresso(int shots, double temp, string name, int price, int volume) : base(temp, name, price, volume)
            {
                Shots = shots;
            }
        }

        public class Affogato:Espresso
        {
           
            public int IceCreamScoops { get; set; }
            public Affogato(int iceCreamScoops, int shots, double temp, string name, int price, int volume) : base(shots, temp, name, price, volume)
            {
                IceCreamScoops=iceCreamScoops;
            }

            public override double ResultPrice()
            {
                return base.ResultPrice() + 5*IceCreamScoops;
            }


        }
    }
}
