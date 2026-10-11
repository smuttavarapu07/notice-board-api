using Microsoft.AspNetCore.Mvc;
using NoticeBoardAPI.Data;
using NoticeBoardAPI.Models;
using Microsoft.AspNetCore.SignalR;
using NoticeBoardAPI.Hubs;

namespace NoticeBoardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NoticesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetNotices()
        {
            return Ok(
                _context.Notices
                .OrderByDescending(n => n.PostedAt)
                .ToList()
            );
        }

        [HttpPost]
        public IActionResult AddNotice([FromBody] Notice notice)
        {
            notice.PostedAt = DateTime.Now;

            _context.Notices.Add(notice);

            _context.SaveChanges();

            return Ok(notice);
        }
    }
}
