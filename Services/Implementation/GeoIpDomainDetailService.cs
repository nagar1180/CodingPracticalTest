using CodingPracticalTest.Model;
using CodingPracticalTest.Services.Contract;
using CodingPracticalTest.Utils;
using System.Threading.Tasks;

namespace CodingPracticalTest.Services.Implementation
{
    public class GeoIpDomainDetailService : IDomainDetailService
    {
        public async Task<DomainDetail> GetDetails(string address)
        {
            var result = await RestRequestUtils.GetRequest($"https://freegeoip.app/json/{address}");
            var geoIpResult = Newtonsoft.Json.JsonConvert.DeserializeObject<GeoIpServiceResponse>(result);
            return geoIpResult.ConvertToDomainDetail();
        }
    }
}
