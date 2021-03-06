using SampleUntiTestingApp.Models;
using System.Threading.Tasks;

namespace SampleUntiTestingApp.Data
{
    public class CreditCardApplicationRepository : ICreditCardApplicationRepository
    {
        private readonly ApplicationDbContext _db;
        public CreditCardApplicationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Task AddAsync(CreditCardApplication application)
        {
            _db.CreditCardApplications.Add(application);
            return _db.SaveChangesAsync();
        }
    }
}
