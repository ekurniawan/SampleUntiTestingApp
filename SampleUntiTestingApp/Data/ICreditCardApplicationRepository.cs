using SampleUntiTestingApp.Models;
using System.Threading.Tasks;

namespace SampleUntiTestingApp.Data
{
    public interface ICreditCardApplicationRepository
    {
        Task AddAsync(CreditCardApplication application);
    }
}
