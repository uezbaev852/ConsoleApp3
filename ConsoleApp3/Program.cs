using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Counter(string args)
        {
            args = args.ToLower();//всю строку к нижнему регистру
            Dictionary<char,int> occur = new Dictionary<char, int>();//сделал словарем, показалось что самое удобное
            for (int i = 0; i < args.Length; i++)
                if (occur.ContainsKey(args[i]))//буква - ключ, счетчик - значение, проверяем на наличие ключа в словаре
                    occur[args[i]]++;//пропускаем итерацию при наличии
                else
                    occur.Add(args[i], 1);//записываем значение в ключ
            foreach (var count in occur)
                Console.Write("{0}:{1}"+" ", count.Key, count.Value.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше слово");
            string word = Console.ReadLine();
            Counter(word);
            Console.Read();
        }
    }
}