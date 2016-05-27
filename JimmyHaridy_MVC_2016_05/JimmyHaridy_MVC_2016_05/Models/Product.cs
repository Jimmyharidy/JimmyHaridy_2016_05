using System.ComponentModel.DataAnnotations;
using JimmyHaridy_MVC_2016_05.Models.Attributes;

namespace JimmyHaridy_MVC_2016_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

       [Required, MaxLength(60)]
        public string ProductText { get; set; }

        [ExtraSafeValidation]
        [Required, MaxLength(11)]
        public string ProductNumber { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int ProductsinStock { get; set; }
        public virtual int StoreId { get; set; }
    }
}