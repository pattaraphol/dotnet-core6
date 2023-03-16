using demo2.Models;

namespace demo2.Services {
    public interface INotesService {
        Task<List<NoteModels>> GetAllNotes();
    }
}
