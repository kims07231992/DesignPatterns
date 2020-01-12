
namespace MobileLibrary.Mobiles
{
    public enum MobileType
    {
        Android,
        IPhone,
        WindowsPhone,
        QNXPhone,
        Other
    };

    public static class MobileFactory
    {
        public static IMobile CreateTestMobile(MobileType mobileType)
        {
            switch (mobileType)
            {
                case MobileType.Android:
                    return new AndroidPhone();

                case MobileType.IPhone:
                    return new IPhone();

                default:
                    return new NullPhone();
            }
        }
    }
}
