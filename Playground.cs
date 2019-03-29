using System;
using System.Text;

namespace C__7._0_in_a_Nutshell
{
    class Program
    {
        public class PriceChangedEventArgs : System.EventArgs {
            public readonly float oldPrice;
            public readonly float newPrice;

            public PriceChangedEventArgs (float oldPrice, float newPrice) {
                this.oldPrice = oldPrice;
                this.newPrice = newPrice;
            }
        }

        public class Stock {
            float price;

            public event EventHandler<PriceChangedEventArgs> PriceChanged;
            // this is defined as delegate void EventHandler<Object, TEvent> (object source, TEvent evt);

            protected virtual void OnPriceChanged(PriceChangedEventArgs e) {
                PriceChanged?.Invoke(this, e);    
            }

            public float Price {
                set {
                    if (price == value) return;
                    PriceChangedEventArgs args = new PriceChangedEventArgs(price, value);
                    price = value;
                    this.OnPriceChanged(args);
                }
                get {
                    return price;
                }
            }
        }

        static void Main(string[] args)
        {
            Stock stock = new Stock();

            EventHandler<PriceChangedEventArgs> cb = (Object o, PriceChangedEventArgs e) => {
                Stock t = o as Stock ?? new Stock();
                System.Console.WriteLine(t.Price);  
                System.Console.WriteLine(e.oldPrice);  
            };

            stock.PriceChanged += cb;
            stock.Price = 12;
        }
    }
}