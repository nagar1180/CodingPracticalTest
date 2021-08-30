using CodingPracticalTest.Model;
using CodingPracticalTest.Services.Contract;
using CodingPracticalTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingPracticalTest.Services.Implementation
{
    public class ReverseDNSDetailService : IDomainDetailService
    {
        public async Task<DomainDetail> GetDetails(string address)
        {
            try
            {
                var result = await RestRequestUtils.GetRequest($"https://rapidapi.com/whoisapi/api/dns-lookup");
                var geoIpResult = Newtonsoft.Json.JsonConvert.DeserializeObject<GeoIpServiceResponse>(result);
                return geoIpResult.ConvertToDomainDetail();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
