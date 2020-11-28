using System;
using System.Collections.Generic;
using Finanseed.Api.Data.Entities;
using Finanseed.Api.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finanseed.Api.Controllers
{
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(List<Transaction>), StatusCodes.Status200OK)]
        public ActionResult Get()
        {
            try
            {
                return Ok(_transactionRepository.List());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        [HttpPost]
        public ActionResult Post(Transaction transaction)
        {
            try
            {
                _transactionRepository.Register(transaction);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}