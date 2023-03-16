using demo2.Models;
using demo2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace demo2.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class NotesController : ControllerBase {

        private readonly INotesService _notesService;
        public NotesController(INotesService notesService) {
            _notesService = notesService;
        }

        [HttpGet]
        [Route("api/notes")]
        public async Task<ActionResult<IEnumerable<NoteModels>>> GetAllNotes() { 
            var notes = await _notesService.GetAllNotes();
            if(notes == null || !notes.Any()) { 
                return BadRequest("data not found.");
            }
            return Ok(notes);
        }
    }
}
