using HttpLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Proxy
{
    public class Program
    {
        public static ProxyHttp _proxyHttp = new ProxyHttp();

        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            try
            {
                var actions = new List<Func<string>>()
                {
                    RequestHttpBinDeleteMethod,
                    RequestHttpBinGetMethod,
                    RequestHttpBinPatchMethod,
                    RequestHttpBinPostMethod,
                    RequestHttpBinPutMethod
                };

                foreach (var action in actions) // Before cached
                {
                    string result = action.Invoke();
                    Console.WriteLine(result);
                }

                foreach (var action in actions) // After cached
                {
                    string result = action.Invoke();
                    Console.WriteLine(result);
                }

                RequestHttpNaverGetMethod(); // Test prohibited url
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string RequestHttpBinDeleteMethod()
        {
            int port = 80;
            string result = null;
            string hostName = "httpbin.org";
            string httpRawData = @"DELETE http://httpbin.org/delete HTTP/1.1
Origin: http://httpbin.org
Referer: http://httpbin.org/
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134
accept: application/json
Accept-Language: en-US,en;q=0.7,ko;q=0.3
Accept-Encoding: gzip, deflate
Content-Length: 0
Host: httpbin.org
Connection: Keep-Alive
Pragma: no-cache
Cookie: _gauges_unique_hour=1; _gauges_unique_month=1; _gauges_unique_day=1; _gauges_unique=1; _gauges_unique_year=1

";

            result = _proxyHttp.SendHttpRequest(port, hostName, httpRawData);
            return result;
        }

        private static string RequestHttpBinGetMethod()
        {
            int port = 80;
            string result = null;
            string hostName = "httpbin.org";
            string httpRawData = @"GET http://httpbin.org/get HTTP/1.1
Host: httpbin.org
Connection: keep-alive
Upgrade-Insecure-Requests: 1
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.84 Safari/537.36
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8
Accept-Encoding: gzip, deflate
Accept-Language: en-US,en;q=0.9

";

            result = _proxyHttp.SendHttpRequest(port, hostName, httpRawData);
            return result;
        }

        private static string RequestHttpBinPatchMethod()
        {
            int port = 80;
            string result = null;
            string hostName = "httpbin.org";
            string httpRawData = @"PATCH http://httpbin.org/patch HTTP/1.1
Origin: http://httpbin.org
Referer: http://httpbin.org/
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134
accept: application/json
Accept-Language: en-US,en;q=0.7,ko;q=0.3
Accept-Encoding: gzip, deflate
Content-Length: 0
Host: httpbin.org
Connection: Keep-Alive
Pragma: no-cache
Cookie: _gauges_unique_hour=1; _gauges_unique_month=1; _gauges_unique_day=1; _gauges_unique=1; _gauges_unique_year=1

";

            result = _proxyHttp.SendHttpRequest(port, hostName, httpRawData);
            return result;
        }

        private static string RequestHttpBinPostMethod()
        {
            int port = 80;
            string result = null;
            string hostName = "httpbin.org";
            string httpRawData = @"POST http://httpbin.org/post HTTP/1.1
Origin: http://httpbin.org
Referer: http://httpbin.org/
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134
accept: application/json
Accept-Language: en-US,en;q=0.7,ko;q=0.3
Accept-Encoding: gzip, deflate
Content-Length: 0
Host: httpbin.org
Connection: Keep-Alive
Pragma: no-cache
Cookie: _gauges_unique_hour=1; _gauges_unique_month=1; _gauges_unique_day=1; _gauges_unique=1; _gauges_unique_year=1

";

            result = _proxyHttp.SendHttpRequest(port, hostName, httpRawData);
            return result;
        }

        private static string RequestHttpBinPutMethod()
        {
            int port = 80;
            string result = null;
            string hostName = "httpbin.org";
            string httpRawData = @"PUT http://httpbin.org/put HTTP/1.1
Origin: http://httpbin.org
Referer: http://httpbin.org/
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134
accept: application/json
Accept-Language: en-US,en;q=0.7,ko;q=0.3
Accept-Encoding: gzip, deflate
Content-Length: 0
Host: httpbin.org
Connection: Keep-Alive
Pragma: no-cache
Cookie: _gauges_unique_hour=1; _gauges_unique_month=1; _gauges_unique_day=1; _gauges_unique=1; _gauges_unique_year=1

";

            result = _proxyHttp.SendHttpRequest(port, hostName, httpRawData);
            return result;
        }

        private static string RequestHttpNaverGetMethod()
        {
            int port = 80;
            string result = null;
            string hostName = "phrase.dict.naver.com";
            string httpRawData = @"GET https://phrase.dict.naver.com/detail.nhn?bigCategoryNo=7&middleCategoryNo=68&smallCategoryNo=307&targetLanguage=en HTTP/1.1
Host: phrase.dict.naver.com
Connection: keep-alive
Cache-Control: max-age=0
Upgrade-Insecure-Requests: 1
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.84 Safari/537.36
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8
Referer: https://www.naver.com/
Accept-Encoding: gzip, deflate, br
Accept-Language: en-US,en;q=0.9
Cookie: NNB=7VBGBFBQ3OLFU; npic=l0HRvNVtsEf4TooryLdlq81AkTY1IDnBamaIQ+ITtvZJJHxlN9Cn4xHwErqNr7tvCA==; __gads=ID=0388a9927cf8e0cc:T=1522103042:S=ALNI_MaUCVrNCy9RNEYtlWvmtlgRXZRnpw; nx_ssl=2; nid_inf=256302192; NID_AUT=bSw9aAVw3pdHtR/EKODqVIY7PUEH5kpJ/CnHprOhUvysBO/jRY/aRcT3wsNjwEES; NID_JKL=0hpu8r8oPLYZR2hXES9wsv8v+LYu7v6VnVarwQ+VcwQ=; NID_SES=AAABkL5tlHHg2R3LmEIv7YEp0/WCZ5UVUUYL1jyvZpFJQFesg5T9RbsEZXWipEOlbiDnAWdU/B3gDgyicAxxgp8b9xWcaWksJM/9cromdWfH7PYGe8pzTrD+k4kThlDh0aUIo6Yumw0ZzbZlo8U094e9yRS5oaRW+uh9uzob8+kG/dJ7V48LXPC05X7HPr3vGRPxdjX6Sqx0kfTPUZOAtnBsGttxQfFQIh98CJGVPNVE5z88vQG1zwfenstGk4Z4MQvSPD97tuoJDVCcZem+CRyAtm6xF4XOq4Nvg3OJ410+8sTRCq4BXE0lAjZJHdd6XUoZPpSnLvyVLqtN3TO2lGLvF+t0vDdGtAD+FflUN7URO9vU05qRYduwN96XfNuuAmoHM9tVUBodNLtUV/THOPKfrEcdsFP2zwW4q4WJMkngl9nx8hi8sIKJJ1nWdhntjR/DEVHHwUrnEANiaX/oLuLBvezT2AMZ3j5s5VR5iC6cfL2pJoDV8JoKhne/N6b3AVbZeAcaYGgXzPCmxSfJkrEuumM=; page_uid=T2Wodlpp6ydssiAuMoRssssssss-069788; contentFontSize=zoom_con_lv1; JSESSIONID=56A9D8EB9B055015F90D23132D9CD95D

";

            result = _proxyHttp.SendHttpRequest(port, hostName, httpRawData);
            return result;
        }
    }
}
