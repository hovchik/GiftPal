using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GiftPalServer.DbContext;
using GiftPalServer.Repository;
using Models;

namespace GiftPalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public FeedbacksController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Feedbacks
        [HttpGet]
        public IEnumerable<Feedbacks> GetFeedbacks() => _context.Feedback.List;


        // GET: api/Feedbacks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeedbacks([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var feedbacks = await _context.Feedback.FindById(id);

            if (feedbacks == null)
            {
                return NotFound();
            }

            return Ok(feedbacks);
        }

        // PUT: api/Feedbacks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedbacks([FromRoute] int id, [FromBody] Feedbacks feedbacks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != feedbacks.Id)
            {
                return BadRequest();
            }

            _context.Feedback.Update(feedbacks);

            try
            {
                await _context.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedbacksExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Feedbacks
        [HttpPost]
        public async Task<IActionResult> PostFeedbacks([FromBody] Feedbacks feedbacks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Feedback.Add(feedbacks);
            await _context.Save();

            return CreatedAtAction("GetFeedbacks", new { id = feedbacks.Id }, feedbacks);
        }

        // DELETE: api/Feedbacks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedbacks([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var feedbacks = await _context.Feedback.FindById(id);
            if (feedbacks == null)
            {
                return NotFound();
            }

            _context.Feedback.Delete(feedbacks);
            await _context.Save();

            return Ok(feedbacks);
        }

        private bool FeedbacksExists(int id)
        {
            return _context.Feedback.List.Any(e => e.Id == id);
        }
    }
}