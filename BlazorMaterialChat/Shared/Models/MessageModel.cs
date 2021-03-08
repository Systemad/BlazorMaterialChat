using System.ComponentModel.DataAnnotations;

namespace BlazorMaterialChat.Shared.Models
{
    public class MessageModel
    {
        [Required(ErrorMessage = "Message can not be empty.")]
        public string Message { get; set; } = string.Empty;

        public MessageStatus MessageStatus { get; set; }
    }
}