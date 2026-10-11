using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Create(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(_mapper.Map<Discount>(createDiscountDto));
            return Ok("İndirim bilgisi eklendi.");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim bilgisi silindi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(_mapper.Map<Discount>(updateDiscountDto));
            return Ok("İndirim bilgisi güncellendi.");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ChangeStatusToFalse")]
        public async Task<IActionResult> ChangeStatusToFalse(int id)
        {
            _discountService.TChangeStatusToFalse(id);
            return Ok("Ürün indirimi pasif hale getirildi.");
        }

        [HttpGet("ChangeStatusToTrue")]
        public async Task<IActionResult> ChangeStatusToTrue(int id)
        {
            _discountService.TChangeStatusToTrue(id);
            return Ok("Ürün indirimi aktif hale getirildi.");
        }
    }
}
