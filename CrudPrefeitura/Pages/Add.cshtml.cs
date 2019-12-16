using CrudPrefeitura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudPrefeitura
{
    public class AddModel : PageModel
    {

        private DatabaseContext db;

        [BindProperty]
        public Product product { get; set; }

        public AddModel(DatabaseContext _db)
        {
            db = _db;
        }

        public void OnGet()
        {
            product = new Product();
        }

        public IActionResult OnPost()
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}