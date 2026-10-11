using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var values = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            _aboutService.TAdd(_mapper.Map<About>(createAboutDto));
            return Ok("Hakkında bilgisi eklendi.");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Hakkında bilgisi silindi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            _aboutService.TUpdate(_mapper.Map<About>(updateAboutDto));
            return Ok("Hakkında bilgisi güncellendi.");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
