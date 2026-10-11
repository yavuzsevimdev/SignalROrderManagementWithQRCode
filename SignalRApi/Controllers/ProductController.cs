using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetAll());
            return Ok(values);
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }

        [HttpGet("HamburgerAvgPrice")]
        public IActionResult HamburgerAvgPrice()
        {
            return Ok(_productService.THamburgerAvgPrice());
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var values = _mapper.Map<List<ResultProductWithCategory>>
                (_productService.TGetProductWithCategories());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Create(CreateProductDto createProductDto)
        {
            _productService.TAdd(_mapper.Map<Product>(createProductDto));
            return Ok("Ürün bilgisi eklendi.");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün bilgisi silindi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(_mapper.Map<Product>(updateProductDto));
            return Ok("Ürün bilgisi güncellendi.");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
    }
}
