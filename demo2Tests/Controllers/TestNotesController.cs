using demo2.Controllers;
using demo2.Models;
using demo2.Services;

using demo2Tests.MockData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace demo2Tests.Controllers {
    public class TestNotesController {

        public class Startup {
            public void ConfigureServices(IServiceCollection services) { }
        }

        [Fact]
        public async Task GetAllNotes_ShouldReturn200Status() {
            // Arrange 
            var notesService = new Mock<INotesService>();
            notesService.Setup(_ => _.GetAllNotes()).ReturnsAsync(NoteMockData.GetNotes());
            var sut = new NotesController(notesService.Object);

            // Act
            var result = await sut.GetAllNotes();

            // Assert
            Assert.IsType<ActionResult<IEnumerable<NoteModels>>>(result);
            Assert.IsType<OkObjectResult>(result.Result);
        }

    }
}
