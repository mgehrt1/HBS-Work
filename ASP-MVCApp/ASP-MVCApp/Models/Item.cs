using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVCApp.Models {
    public class Item {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }
        [DisplayName("Item name")]
        [Required]
        public string ItemName { get; set; }
    }
}
