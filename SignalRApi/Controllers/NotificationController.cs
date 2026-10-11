using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;

        public NotificationController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_notificationService.TGetAll());
        }

        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }

        [HttpGet("GetAllNotificationByFalse")]
        public IActionResult GetAllNotificationByFalse()
        {
            return Ok(_notificationService.TGetAllNotificationByFalse());
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _notificationService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateNotificationDto createNotificationDto)
        {
            createNotificationDto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            createNotificationDto.Status = false;
            _notificationService.TAdd(_mapper.Map<Notification>(createNotificationDto));
            return Ok("Bildirim eklendi.");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _notificationService.TGetById(id);
            _notificationService.TDelete(value);
            return Ok("Bildirim silindi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateNotificationDto updateNotificationDto)
        {
            _notificationService.TUpdate(_mapper.Map<Notification>(updateNotificationDto));
            return Ok("Bildirim güncellendi.");
        }

        [HttpGet("NotificationStatusChangeToFalse")]
        public IActionResult NotificationStatusChangeToFalse(int id)
        {
            _notificationService.TNotificationStatusChangeToFalse(id);
            return Ok("Güncelleme yapıldı.");
        }

        [HttpGet("NotificationStatusChangeToTrue")]
        public IActionResult NotificationStatusChangeToTrue(int id)
        {
            _notificationService.TNotificationStatusChangeToTrue(id);
            return Ok("Güncelleme yapıldı.");
        }
    }
}
