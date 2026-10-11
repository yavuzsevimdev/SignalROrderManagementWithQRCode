using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BookingDtos;
using SignalRWebUI.Dtos.ContactDtos;
using System.Text;
using System.Text.Json;

namespace SignalRWebUI.Controllers
{
    public class BookATableController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookATableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7091/api/Contact");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            ViewBag.Location = values.FirstOrDefault().Location;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7091/api/Contact");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            ViewBag.Location = values.FirstOrDefault().Location;

            createBookingDto.Description = "-";
            client = _httpClientFactory.CreateClient();
            jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            responseMessage = await client.PostAsync("https://localhost:7091/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                var errorContent = await responseMessage.Content.ReadAsStringAsync();
                using var document = JsonDocument.Parse(errorContent);
                var root = document.RootElement;
                if (root.ValueKind == JsonValueKind.Array)
                {
                    foreach (var error in root.EnumerateArray())
                    {
                        var propertyName = error.TryGetProperty("propertyName", out var property) ? property.GetString() : null;
                        var errorMessage = error.TryGetProperty("errorMessage", out var message) ? message.GetString() : null;
                        if (!string.IsNullOrWhiteSpace(errorMessage))
                        {
                            ModelState.AddModelError(propertyName ?? string.Empty, errorMessage);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Rezervasyon oluşturulamadı.");
                }
            }
            return View(createBookingDto);
        } 
    }
}
