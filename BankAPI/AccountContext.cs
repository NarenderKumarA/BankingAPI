using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPI.Models;

namespace BankAPI
{
    public class AccountContext : DbContext 
    {
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options) { 

        
        Database.EnsureCreated();
        
        }

        public DbSet<AccountModel> Accounts { get; set; }
     
    }
}
