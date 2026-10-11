using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;
        private readonly IMapper _mapper;

        public MenuTablesController(IMenuTableService menuTableService, IMapper mapper)
        {
            _menuTableService = menuTableService;
            _mapper = mapper;
        }

        [HttpGet("MenuTableCount")]
        public IActionResult MenuTableCount()
        {
            return Ok(_menuTableService.TMenuTableCount());
        }

        [HttpGet]
        public IActionResult List()
        {
            var values = _mapper.Map<List<ResultMenuTableDto>>(_menuTableService.TGetAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Create(CreateMenuTableDto createMenuTableDto)
        {
            _menuTableService.TAdd(_mapper.Map<MenuTable>(createMenuTableDto));
            return Ok("Masa bilgisi eklendi.");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _menuTableService.TGetById(id);
            _menuTableService.TDelete(value);
            return Ok("Masa bilgisi silindi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateMenuTableDto updateMenuTableDto)
        {
            _menuTableService.TUpdate(_mapper.Map<MenuTable>(updateMenuTableDto));
            return Ok("Masa bilgisi güncellendi.");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _menuTableService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ChangeMenuTableStatusToFalse")]
        public IActionResult ChangeMenuTableStatusToFalse(int id)
        {
            _menuTableService.TChangeMenuTableStatusToFalse(id);
            return Ok("İşlem başarılı");
        }

        [HttpGet("ChangeMenuTableStatusToTrue")]
        public IActionResult ChangeMenuTableStatusToTrue(int id)
        {
            _menuTableService.TChangeMenuTableStatusToTrue(id);
            return Ok("İşlem başarılı");
        }
    }
}
