using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pehtok1111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона родителей");
            string dfg;
            dfg = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            string sao;
            sao = Console.ReadLine();
            int age;
            age = Convert.ToInt32(sao);
            if (age < 18)
            {
                Console.WriteLine("Малой, иди нахуй. Или я позвоню твоим родителям по этому номеру телефона: " + dfg);
            }
            if (age >= 18) 
            {
                Process.Start("http://vsexshop.ru");
            }

        }
    }
}
