    using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorMaterialChat.Shared.Models;

namespace BlazorMaterialChat.Client.ViewModels
{
    public class ProfileViewModel : IProfileViewModel
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        
        private HttpClient _httpClient;

        public ProfileViewModel() {}

        public ProfileViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetProfile()
        {
            User user = await _httpClient.GetFromJsonAsync<User>("user/getprofile/" + UserId);
            LoadCurrentObject(user);
            Message = "Profile loaded successfully";
        }

        private void LoadCurrentObject(ProfileViewModel profileViewModel)
        {
            Username = profileViewModel.Username;
            
        }
        
        public static implicit operator ProfileViewModel(User user)
        {
            return new()
            {
                Username = user.Username,
                UserId = user.UserId,
            };
        }

        public static implicit operator User(ProfileViewModel profileViewModel)
        {
            return new()
            {
                Username = profileViewModel.Username,
                UserId = profileViewModel.UserId
            };
        }
    }
}