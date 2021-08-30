using CodingPracticalTest.Model;
using CodingPracticalTest.Services.Contract;
using CodingPracticalTest.Utils;
using System.Threading.Tasks;

namespace CodingPracticalTest.Services.Implementation
{
    public class RdapDomainDetailService : IDomainDetailService
    {
        public async Task<DomainDetail> GetDetails(string address)
        {
            var result = await RestRequestUtils.GetRequest($"https://rdap.arin.net/registry/ip/{address}");
            //var rdapServiceResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<RdapServiceResponse>(result);
            return new DomainDetail { ServiceName = Constants.RDAP, Address = address };
        }
    }
}
