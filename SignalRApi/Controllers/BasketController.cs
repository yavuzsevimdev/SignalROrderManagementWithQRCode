using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet("GetBasketByMenuTableNumber")]
        public IActionResult GetBasketByMenuTableNumber(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }

        [HttpPost("AddToBasket")]
        public IActionResult AddToBasket(CreateBasketDto createBasketDto)
        {
            _basketService.TAdd(new Basket
            {
                Price = createBasketDto.Price,
                Count = 1,
                TotalPrice = 1 * createBasketDto.Price,
                ProductId = createBasketDto.ProductId,
                MenuTableId = createBasketDto.MenuTableId
            });
            return Ok();
        }

        [HttpDelete("DeleteBasket")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki seçilen ürün silindi");
        }
    }
}
