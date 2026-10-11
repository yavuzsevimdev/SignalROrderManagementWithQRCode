using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BasketDtos;
using SignalRWebUI.Dtos.CategoryDtos;
using SignalRWebUI.Dtos.ProductDtos;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            ViewBag.v = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7091/api/Category");
            List<ResultCategoryDto> categories = new();
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                ViewBag.Categories = categories;
            }

            responseMessage = await client.GetAsync("https://localhost:7091/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                foreach (var item in values)
                {
                    var category = categories.FirstOrDefault(x => x.Id == item.CategoryId);
                    if (category != null)
                    {
                        item.CategoryName = category.Name;
                    }
                }
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddToBasket(int id, int menuTableId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7091/api/Product/GetById?id={id}");
            ResultProductDto product = new();
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                product = JsonConvert.DeserializeObject<ResultProductDto>(jsonData);
            }

            CreateBasketDto createBasketDto = new CreateBasketDto();
            createBasketDto.ProductId = id;
            createBasketDto.Price = product.Price;
            createBasketDto.MenuTableId = menuTableId;
            var json = JsonConvert.SerializeObject(createBasketDto);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            responseMessage = await client.PostAsync("https://localhost:7091/api/Basket/AddToBasket", stringContent);

            await client.GetAsync($"https://localhost:7091/api/MenuTables/ChangeMenuTableStatusToTrue?id={menuTableId}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return Json(createBasketDto);
        }

    }
}
