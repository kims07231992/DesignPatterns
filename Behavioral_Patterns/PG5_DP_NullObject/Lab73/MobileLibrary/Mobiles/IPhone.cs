using System;

namespace MobileLibrary.Mobiles
{
    public class IPhone : IMobile
    {
        public void SendMMS(string attachedFileName)
        {
            Console.WriteLine($"Phone: {nameof(IPhone)} \t Action: {nameof(SendMMS)} \t FileName: {attachedFileName}");
        }

        public void SendSMS(string message)
        {
            Console.WriteLine($"Phone: {nameof(IPhone)} \t Action: {nameof(SendSMS)} \t Message: {message}");
        }
    }
}
