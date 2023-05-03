using BankAPI.Models;
using BankAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsRepository _accountsRepository;
        public AccountsController(IAccountsRepository accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountModel>> GetAccounts()
        {
            return await _accountsRepository.Get();
        }

        //[HttpGet("{id}")]
        //public async Task<IEnumerable<AccountModel>> GetAccounts(int id)
        //{
        //    return (IEnumerable<AccountModel>)await _accountsRepository.Get(id);
        //}
    }
}
