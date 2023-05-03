using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPI.Models;

namespace BankAPI.Repositories
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly AccountContext _accountContext;
        public async Task<AccountModel> Create(AccountModel account)
        {
            _accountContext.Accounts.Add(account);
            await _accountContext.SaveChangesAsync();
            return account;
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();

            //var accountNumber = _accountContext.Accounts.FindAsync(id);
            //_accountContext.Accounts.Remove(accountNumber);
            //await _accountContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AccountModel>> Get()
        {
            return await _accountContext.Accounts.ToListAsync();
        }

        public async Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AccountModel account)
        {
            throw new NotImplementedException();
        }

        Task<AccountModel> IAccountsRepository.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
