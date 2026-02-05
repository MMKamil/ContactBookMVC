using System.ComponentModel.DataAnnotations;

namespace ContactBookMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CanLogin(string inputPassword)
        {
            return Password == inputPassword;
        } 
    }
}
