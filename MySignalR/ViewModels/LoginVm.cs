using System.ComponentModel.DataAnnotations;

namespace MySignalR.ViewModels
{
    public class LoginVm
    {
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}