using System;

namespace MobileLibrary.Mobiles
{
    public class AndroidPhone : IMobile
    {
        public void SendMMS(string attachedFileName)
        {
            Console.WriteLine($"Phone: {nameof(AndroidPhone)} \t Action: {nameof(SendMMS)} \t FileName: {attachedFileName}");
        }

        public void SendSMS(string message)
        {
            Console.WriteLine($"Phone: {nameof(AndroidPhone)} \t Action: {nameof(SendSMS)} \t Message: {message}");
        }
    }
}
