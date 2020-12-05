using System;
namespace AbstractFactory
{
    public class SpringButton : IBotton
    {
        void IBotton.Display()
        {
            Console.WriteLine("spring botton");
        }
    }
}
