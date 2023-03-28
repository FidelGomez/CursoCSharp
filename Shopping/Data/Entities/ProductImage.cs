using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public Product Product { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://shoppingfidelgomez.azurewebsites.net/images/noimage.png"
            : $"https://shoppingdev.blob.core.windows.net/products/{ImageId}";
    }
}
