using System.ComponentModel.DataAnnotations;

namespace BonkaBallancio.Models.ViewModels
{
    public class ProfileViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Bio { get; set; }

        public string HomeTown { get; set; }
    }
}