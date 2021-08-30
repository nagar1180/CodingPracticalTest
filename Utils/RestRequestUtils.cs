using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodingPracticalTest.Utils
{
    public static class RestRequestUtils
    {
        public static async Task<string> GetRequest(string address)
        {
            //HttpClient client = new HttpClient();
            //return await client.GetStringAsync(address);
            var JSONResponse = string.Empty;
            var request = HttpWebRequest.Create(address);
            var response = await request.GetResponseAsync();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                JSONResponse = sr.ReadToEnd();
                sr.Close();
            }
            return JSONResponse;
        }
    }
}
