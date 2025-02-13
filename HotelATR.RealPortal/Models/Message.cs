using System.ComponentModel.DataAnnotations;

namespace HotelATR.RealPortal.Models
{
    public class Message
    {
        [Required(ErrorMessage = "ZAPOLNIIIIII")]
        [EmailAddress(ErrorMessage = "Указан не корректный email адрес")]
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
        [CustomDate]
        public DateTime createDate { get; set; }
        [NameValidate(NotAllowed = new string[] { "Шымкент" },
            ErrorMessage = "Отправлять форму с города Шымкент нельзя")]
        public string city { get; set; }
    }
}
