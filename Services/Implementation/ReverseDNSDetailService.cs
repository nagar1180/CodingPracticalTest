using CodingPracticalTest.Model;
using CodingPracticalTest.Services.Contract;
using CodingPracticalTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingPracticalTest.Services.Implementation
{
    public class ReverseDNSDetailService : IDomainDetailService
    {  
        public async Task<DomainDetail> GetDetails(string address)
        {
            var domainDetail = new DomainDetail { ServiceName = "Reverse DNS", Address = address };
            try
            {                           
                var result = await RestRequestUtils.GetRequest($"https://rapidapi.com/whoisapi/api/dns-lookup/{address}");
                domainDetail = Newtonsoft.Json.JsonConvert.DeserializeObject<DomainDetail>(result);                
            }           
            catch(Exception ex)
            {
                domainDetail.ErrorMessage = ex.Message;
            }
            return domainDetail;
        }
    }
}
