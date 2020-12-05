using System;
namespace AbstractFactory
{
    public class SummerTextField:ITextField
    {
        public void Display()
        {
            Console.WriteLine("summer textfield");
        }
    }
}
