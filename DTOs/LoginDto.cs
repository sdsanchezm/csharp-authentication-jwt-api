using System.ComponentModel.DataAnnotations;

namespace AuthenticationAPI2.DTOs
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
