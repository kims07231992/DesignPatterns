
namespace MobileLibrary.Mobiles
{
    public interface IMobile
    {
        void SendMMS(string attachedFileName);
        void SendSMS(string message);
    }
}
