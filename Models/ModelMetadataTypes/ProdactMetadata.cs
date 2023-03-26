using System.ComponentModel.DataAnnotations;

namespace ValidationsofAspNetcoreUserData.Models.ModelMetadataTypes
{
    public class ProdactMetadata
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name ")] // Girilmis olmalidir 
        [StringLength(100, ErrorMessage = "Max 100 ")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please Enter Email ")]
        public string Email { get; set; }

    }
}
