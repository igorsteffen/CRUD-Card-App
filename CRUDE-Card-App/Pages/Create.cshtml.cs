using CRUDECardApp.DataSource;
using CRUDECardApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CRUDECardApp.Pages
{
    public class CreateModel : PageModel
    {
        public Data data = Data.GetInstance();
        public void OnGet()
        {
        }

        public IActionResult OnPost(string StudentNumber, string FullName, string Email, string Password, string Picture)
        {
            if (string.IsNullOrWhiteSpace(StudentNumber) ||
                string.IsNullOrWhiteSpace(FullName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(Picture))
            {
                ViewData["ErrorMessage"] = "All fields are required. Please fill in all fields.";
                return Page();
            }
            data.myList.Add(new Student(StudentNumber, FullName, Email, Password, Picture));
            return RedirectToPage("Index");
        }
    }
}
