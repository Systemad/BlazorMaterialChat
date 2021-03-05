using System.Threading.Tasks;

namespace BlazorMaterialChat.Client.ViewModels
{
    public interface IProfileViewModel
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        
        public string Message { get; set; }

        public Task GetProfile();
    }
}