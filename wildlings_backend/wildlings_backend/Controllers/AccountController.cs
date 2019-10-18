using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using wildlings_backend.Models;
using wildlings_backend.Models.Service;
using wildlings_backend.Models.Service.Interface;

namespace wildlings_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        [HttpGet]
        public IEnumerable<Course> GetIncomeStatement(int month)
        {
            return _accountService.GetIncomeStatement();
        }

      
    }

    public class AccountService 
    {
        public IEnumerable<Statement> GetIncomeStatement()
        {
            var statement = new Statement();

        }
    }

    public class Statement
    {
    }
}