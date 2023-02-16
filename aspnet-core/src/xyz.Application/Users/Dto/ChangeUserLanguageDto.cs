using System.ComponentModel.DataAnnotations;

namespace xyz.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}