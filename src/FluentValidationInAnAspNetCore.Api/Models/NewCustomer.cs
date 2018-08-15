using System.ComponentModel.DataAnnotations;

namespace FluentValidationInAnAspNetCore.Api.Models
{
    public class NewCustomer
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A cidade é obrigatória")]
        public string City { get; set; }
    }
}
