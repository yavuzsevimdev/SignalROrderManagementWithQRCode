using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductWithCategories()
        {
            using var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public decimal HamburgerAvgPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(w => w.CategoryId == (context.Categories.Where(x => x.Name == "Hamburger").Select(y => y.Id)).FirstOrDefault()).Average(z => z.Price);
        }

        public int ProductCount()
        {
            using var context = new SignalRContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new SignalRContext();
            return context.Products.Count(x => x.CategoryId == (context.Categories.Where(y => y.Name == "İçecek").Select(z => z.Id).FirstOrDefault()));
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new SignalRContext();
            return context.Products.Count(x => x.CategoryId == (context.Categories.Where(y => y.Name == "Hamburger").Select(z => z.Id).FirstOrDefault()));
        }

        public int ProductCountByCategoryNamePasta()
        {
            using var context = new SignalRContext();
            return context.Products.Count(x => x.CategoryId == (context.Categories.Where(y => y.Name == "Makarna").Select(z => z.Id).FirstOrDefault()));
        }

        public int ProductCountByCategoryNameSalad()
        {
            using var context = new SignalRContext();
            return context.Products.Count(x => x.CategoryId == (context.Categories.Where(y => y.Name == "Salata").Select(z => z.Id).FirstOrDefault()));
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.Name).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.Name).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new SignalRContext();
            return context.Products.Average(x => x.Price);
        }
    }
}
