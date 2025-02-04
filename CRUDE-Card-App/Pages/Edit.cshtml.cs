using CRUDECardApp.DataSource;
using CRUDECardApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CRUDECardApp.Pages
{
    public class EditModel : PageModel
    {
        public Student Student { get; set; }
        public Data data = Data.GetInstance();
        public void OnGet(string StudentNumber)
        {
            Student = data.myList.Find(item => item.StudentNumber == StudentNumber);
        }

        public IActionResult OnPost(string StudentNumber, string FullName, string Email, string Password, string Picture)
        {
            int index = data.myList.FindIndex(item => item.StudentNumber == StudentNumber);
            data.myList[index] = new Student(StudentNumber, FullName, Email, Password, Picture);

            return RedirectToPage("Index");
        }
    }
}
