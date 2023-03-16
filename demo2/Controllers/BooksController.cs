using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace demo2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase {

        [HttpGet]
        public async Task<dynamic> Get() {
            try {
                using var client = new HttpClient() { Timeout = TimeSpan.FromSeconds(20) };
                var response = await client.GetAsync("https://api.nytimes.com/svc/books/v3/lists/overview.json?api-key=H9fKw4sWd05i1PzW6cWDOCcu2GAT4lLn");
                var content = await response.Content.ReadAsStringAsync();

                if(string.IsNullOrEmpty(content)) {
                    return "";
                }
                JsonDocument document = JsonDocument.Parse(content);
                if(document.RootElement.ValueKind == JsonValueKind.Null) {
                    return "";
                }
                return document.RootElement;
            } catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                return new JsonResult(new { Message = "An error occurred while retrieving data from the API" });
            }
        }
    }
}
