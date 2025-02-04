namespace CRUDCardApp.Models
{
    public class Student
    {
        public string StudentNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string Picture { get; set; }

        public Student(string studentNumber, string fullName, string email, string password, string picture)
        {
            StudentNumber = studentNumber;
            FullName = fullName;
            Email = email;
            Password = password;
            Picture = picture;
        }

        public bool ValidatePassword(string password)
        {
            return Password == password;
        }

        public string GetPassword(string password)
        {
            return Password;
        }

        public void SetPassword(string password)
        {
            Password = password;
        }
    }
}
