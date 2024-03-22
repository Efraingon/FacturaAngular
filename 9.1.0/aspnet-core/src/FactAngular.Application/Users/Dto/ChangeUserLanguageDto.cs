using System.ComponentModel.DataAnnotations;

namespace FactAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}