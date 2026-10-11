using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var values = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Create(CreateSliderDto createSliderDto)
        {
            _sliderService.TAdd(_mapper.Map<Slider>(createSliderDto));
            return Ok("Slider bilgisi eklendi.");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _sliderService.TGetById(id);
            _sliderService.TDelete(value);
            return Ok("Slider bilgisi silindi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateSliderDto updateSliderDto)
        {
            _sliderService.TUpdate(_mapper.Map<Slider>(updateSliderDto));
            return Ok("Slider bilgisi güncellendi.");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _sliderService.TGetById(id);
            return Ok(value);
        }
    }
}
