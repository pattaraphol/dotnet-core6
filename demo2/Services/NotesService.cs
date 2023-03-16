using demo2.Models;
using Microsoft.EntityFrameworkCore;

namespace demo2.Services {
    public class NotesService {

        private readonly DbConfig _context;
        public NotesService(DbConfig context) {
            _context = context;
        }
        public async Task<List<NoteModels>> GetAllNotes() {
            return await _context.Notes.ToListAsync();
        }


    }
}
