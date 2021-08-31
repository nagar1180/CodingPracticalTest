using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodingPracticalTest.Utils
{
    public static class RestRequestUtils
    {
        public static async Task<string> GetRequest(string address, Dictionary<string,string> headers = null)
        {   
            var JSONResponse = string.Empty;
            var request = HttpWebRequest.Create(address);
            if(headers != null && headers.Count > 0)
            {
                SetHeader(request, headers);
            }
            var response = await request.GetResponseAsync();            
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                JSONResponse = sr.ReadToEnd();
                sr.Close();
            }
            return JSONResponse;
        }

        private static void SetHeader(WebRequest request, Dictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }
    }
}
