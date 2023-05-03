using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPI.Models;

namespace BankAPI.Repositories
{
    public interface IAccountsRepository
    {
        Task<IEnumerable<AccountModel>> Get();
        Task<AccountModel> Get(int id);
        Task<AccountModel> Create(AccountModel account);
        Task Update(AccountModel account);
       Task Delete(int id);



    }
}
