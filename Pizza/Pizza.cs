using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Pizza
    {
        char[] forrasbolEltavolitandoKarakterek = new char[] { '\"', '\\', ' ' };

        int pizza;
        string pizzaNev;
        int pizzaAr;

        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            PizzaAzonosito = int.Parse(sor[0]);
            PizzaNev = sor[1];
            PizzaAr = int.Parse(sor[2]);
        }

        public int PizzaAzonosito { get => pizza; set => pizza = value; }
        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }
        public int PizzaAr { get => pizzaAr; set => pizzaAr = value; } 

        public override string ToString()
        {
            return $"{PizzaNev} pizza ára: {PizzaAr.ToString()}Ft";
        }

    }
}
