using CrudPrefeitura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudPrefeitura
{
    public class EditModel : PageModel
    {
        private DatabaseContext db;

        [BindProperty]
        public Product product { get; set; }

        public EditModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet(int id)
        {
            product = db.Products.Find(id);
        }

        public IActionResult OnPost()
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}