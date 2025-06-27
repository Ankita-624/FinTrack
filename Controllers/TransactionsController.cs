using FinTrack.Data;
using FinTrack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using FinTrack.Models.DTOs;

namespace FinTrack.Controllers
{
//[AllowAnonymous]
     [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyTransactions()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var transactions = await _context.Transactions
                .Where(t => t.UserId == userId)
                .ToListAsync();

            return Ok(transactions);
        }

        [HttpPost]
public async Task<IActionResult> Create([FromBody] CreateTransactionRequest request)
{
    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

    var transaction = new Transaction
    {
        Type = request.Type,
        Amount = request.Amount,
        Description = request.Description,
        Date = DateTime.UtcNow,
        UserId = userId
    };

    _context.Transactions.Add(transaction);
    await _context.SaveChangesAsync();

    return Ok(transaction);
}


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var transaction = await _context.Transactions
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (transaction == null)
                return NotFound();

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Deleted" });
        }
    }
}
