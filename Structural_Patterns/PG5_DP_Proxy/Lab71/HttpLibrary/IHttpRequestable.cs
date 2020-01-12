namespace HttpLibrary
{
    public interface IHttpRequestable
    {
        string SendHttpRequest(int port, string hostName, string httpRawData);
    }
}
