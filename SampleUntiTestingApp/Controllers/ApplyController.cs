using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleUntiTestingApp.Data;
using SampleUntiTestingApp.Dtos;
using SampleUntiTestingApp.Models;
using System.Threading.Tasks;

namespace SampleUntiTestingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplyController : ControllerBase
    {
        private readonly ICreditCardApplicationRepository _applicationRepository;

        public ApplyController(ICreditCardApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<ActionResult> Add(NewCreditCardApplicationDetails applicationDetails)
        {
            var creditCardApplication = new CreditCardApplication
            {
                FirstName = applicationDetails.FirstName,
                LastName = applicationDetails.LastName,
                Age = applicationDetails.Age.Value,
                GrossAnnualIncome=applicationDetails.GrossAnnualIncome.Value
            };
            await _applicationRepository.AddAsync(creditCardApplication);
            return Ok(creditCardApplication);
        }
    }
}
