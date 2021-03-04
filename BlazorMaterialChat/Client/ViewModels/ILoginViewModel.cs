using System.Threading.Tasks;

namespace BlazorMaterialChat.Client.ViewModels
{
    public interface ILoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Task LoginUser();
    }
}