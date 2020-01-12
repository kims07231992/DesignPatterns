using MobileLibrary.Mobiles;

namespace PG5_DP_Null
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var mobileTypes = new MobileType[]
            {
                MobileType.Android,
                MobileType.IPhone,
                MobileType.WindowsPhone,
                MobileType.QNXPhone,
                MobileType.Other
            };

            foreach (var mobileType in mobileTypes)
            {
                var mobile = MobileFactory.CreateTestMobile(mobileType);
                string fileName = "This is a test file name for mms.";
                string message = "This is a test message for sms.";

                mobile.SendMMS(fileName);
                mobile.SendSMS(message);
            }
        }
    }
}
