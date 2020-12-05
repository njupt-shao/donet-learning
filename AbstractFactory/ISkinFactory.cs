using System;
namespace AbstractFactory
{
    public interface ISkinFactory
    {
        IBotton CreateBotton();
        ITextField CreateTextField();
    }
}
 