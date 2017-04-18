using ManageItLinux.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBasic.Controllers
{
    [Route("api/[controller]")]
    public class BoardController : Controller
    {
        private readonly ManageItContext _context;

        public BoardController(ManageItContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public IActionResult CreateNewBoard([FromBody]Board board)
        {
            _context.Add(board);
            _context.SaveChanges();

            return Ok();
        } 
        
        [HttpGet("[action]")]
        public IActionResult GetAllBoards()
        {
            var result = _context.Boards.ToList();

            return Ok(result);
        }
    }
}
