
namespace AbstractFactory
{
    public class SprinfSkinFactory : ISkinFactory
    {
        public IBotton CreateBotton()
        {
            return new SpringButton();
        }

        public ITextField CreateTextField()
        {
            return new SpingTextFeild();
        }
    }
}
