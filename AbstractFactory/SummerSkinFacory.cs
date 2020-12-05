using System;
namespace AbstractFactory
{
    public class SummerSkinFacory : ISkinFactory
    {
        public IBotton CreateBotton()
        {
            return new SummerButton();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}
