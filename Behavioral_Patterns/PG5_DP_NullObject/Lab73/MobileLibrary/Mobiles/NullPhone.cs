using System.Diagnostics;

namespace MobileLibrary.Mobiles
{
    public class NullPhone : IMobile
    {
        public void SendMMS(string attachedFileName)
        {
            // Write a message using Debug.WriteLine()
            Debug.WriteLine($"Phone: {nameof(NullPhone)} \t Action: {nameof(SendMMS)} \t FileName: {attachedFileName}");
        }

        public void SendSMS(string message)
        {
            // Write a message using Debug.WriteLine()
            Debug.WriteLine($"Phone: {nameof(NullPhone)} \t Action: {nameof(SendSMS)} \t Message: {message}");
        }
    }
}
