using CodingPracticalTest.Model;
using System.Threading.Tasks;

namespace CodingPracticalTest.Services.Contract
{
    public interface IDomainDetailService
    {
        Task<DomainDetail> GetDetails(string address);
    }
}
