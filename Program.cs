using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace money_sharp_hw
{

    class Money
    {
        public Money()
        {
            rubbles = 0;
            kopeiki = 0;
        }

        static int discount;
        public int Discount { get { return discount; } }

        int rubbles;
        public int Rubbles { get { return rubbles; } set { rubbles = value; } }
        int kopeiki;

        public int Kopeiki
        {
            get { return kopeiki; }
            set { 
                
                if (value >= 0 && value < 100)
                    kopeiki = value;               
                else
                    WriteLine("Ошибка! Число копеек не должно превышать 99");
            }
        }

        public void Plus(Money tmp, Money tmp2)
        {
            Money tmp3 = new Money();
            tmp3.rubbles = tmp.rubbles + tmp2.rubbles;
            tmp3.kopeiki = tmp.kopeiki + tmp2.kopeiki;
            if (tmp3.kopeiki > 99)
            {
                tmp3.rubbles += (tmp3.kopeiki / 100);
                tmp3.kopeiki %= 100;              
            }

            WriteLine($"{tmp.rubbles}.{tmp.kopeiki} + {tmp2.rubbles}.{tmp2.kopeiki} = {tmp3.rubbles}.{tmp3.kopeiki}");
        }
        
        public void disc(Money tmp)
        {
            WriteLine($"Ваша скидка 15%");
            WriteLine($"Начальная стоимость: {tmp.rubbles}.{tmp.kopeiki}");
            WriteLine($"Стоимость после скидки: {(tmp.rubbles - (tmp.rubbles* 15)/100)}.{tmp.kopeiki}");

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money();
            Write("Введите рубли: ");
            string r, k;
            int R, K;
            r = ReadLine();
            R = Convert.ToInt32(r);
            m.Rubbles = R;

            Write("Введите копейки: ");
            k = ReadLine();
            K = Convert.ToInt32(k);
            m.Kopeiki = K;

            WriteLine();

            Money m2 = new Money();
            Write("Введите рубли: ");
            string r2, k2;
            int R2, K2;
            r2 = ReadLine();
            R2 = Convert.ToInt32(r2);
            m2.Rubbles = R2;

            Write("Введите копейки: ");
            k2 = ReadLine();
            K2 = Convert.ToInt32(k2);
            m2.Kopeiki = K2;

            WriteLine();

            m.Plus(m, m2);
            WriteLine();

            string ch;
            WriteLine("1 - посчитать 15% от первого числа / 2 - посчитать 15% от второго числа");
            ch = ReadLine();
            if (ch == "1")
            {
                m.disc(m);
            }
            if (ch == "2")
            {
                m2.disc(m2);
            }
            else
                WriteLine("ОШИБКА");
        }

        
    }
}
