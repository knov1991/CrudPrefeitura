using System.Collections.Generic;
using System.Linq;
using CrudPrefeitura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudPrefeitura
{
    public class IndexModel : PageModel
    {
        private DatabaseContext db;

        public IndexModel(DatabaseContext _db)
        {
            db = _db;
        }

        public List<Product> Products;

        public void OnGet()
        {
            Products = db.Products.ToList();
        }

        public IActionResult OnGetDelete(int id)
        {
            var product = db.Products.Find(id);
            db.Remove(product);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}