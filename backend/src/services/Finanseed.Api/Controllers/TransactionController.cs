using Finanseed.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finanseed.Api.Controllers
{
    [ApiController]
    public class TransactionController:Controller
    {
        [HttpGet]
        public void Get()
        {
            
        }
        
        [HttpPost]
        public void Post(Transaction transaction)
        {
            
        }
    }
}