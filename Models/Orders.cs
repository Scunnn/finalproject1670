using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASM21670.Models
{
    public class Orders
    {
        public int Id { get; set; }

        [Display(Name = "Fullname")]
        public string Fullname { get; set; }

        [Display(Name = "CartItem")]
        public string CartItem { get; set; }

        [Display(Name = "Total")]
        public decimal? Total { get; set; }

        [Display(Name = "Order date")]
        public DateTime? Orderdate { get; set; }
    }
}
