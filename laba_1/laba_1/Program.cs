using System;
namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Num num1 = new Num("Фланець", "З", 3, 450);
            Num num2 = new Num("Перехiдник", "К", 8, 74);
            Num num3 = new Num("Станина", "Про", 1, 117050);
            Console.WriteLine("Найменування Тип Кiлькiсть Вага 1 деталi(г)");
            Console.WriteLine(num1.Details());
            Console.WriteLine(num2.Details());
            Console.WriteLine(num3.Details());
        }
    }
    class Num
    {
        public string name { get; set; }
        public string type { get; set; }
        public short number { get; set; }
        public double weight { get; set; }
        public Num(Num previousNum)
        {
            name = previousNum.name;
            type = previousNum.type;
            number = previousNum.number;
            weight = previousNum.weight;
        }
        public Num(string Name, string Type, short Number, double Weight)
        {
            name = Name;
            type = Type;
            number = Number;
            weight = Weight;
        }
        public string Details()
        {
            return name + "        " + type + "       " + number.ToString() + "     "
           + weight.ToString();
        }
    }
}