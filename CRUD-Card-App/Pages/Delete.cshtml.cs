using CRUDCardApp.DataSource;
using CRUDCardApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCardApp.Pages
{
    public class DeleteModel : PageModel
    {
        public Student Student { get; set; }
        public Data data = Data.GetInstance();

        public void OnGet(string StudentNumber)
        {
            Student = data.myList.Find(item => item.StudentNumber == StudentNumber);
        }

        public IActionResult OnPost(string StudentNumber)
        {
            data.myList.RemoveAll(item => item.StudentNumber == StudentNumber);
            return RedirectToPage("Index");
        }
    }
}
