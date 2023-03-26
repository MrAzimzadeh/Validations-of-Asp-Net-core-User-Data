using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ValidationsofAspNetcoreUserData.Models.ModelMetadataTypes;

namespace ValidationsofAspNetcoreUserData.Models
{

    [ModelMetadataType(typeof(ProdactMetadata))]
    public class Prodact
    {
        //public int Id { get; set; }
            public string Name { get; set; }

        public int Quantity { get; set; }

        public string Email { get; set; }

    }
}
