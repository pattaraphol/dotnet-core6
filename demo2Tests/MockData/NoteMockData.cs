using demo2.Models;

namespace demo2Tests.MockData {
    public class NoteMockData {
        public static List<NoteModels> GetNotes() {
            return new List<NoteModels> { 
                new NoteModels { 
                    Id = 1,
                    Title = "Need to Note My Task",
                    Details = "I have a lot of work to do, so much so that it's overwhelming.",
                    dtEdit = DateTime.Now
                },
                new NoteModels {
                    Id = 2,
                    Title = "Need to Cook Food",
                    Details = "Now, I want to cook Western cuisine.",
                    dtEdit = DateTime.Now
                }
            };
        }
    }
}
