using System.ComponentModel.DataAnnotations;

namespace AddressApp.Models
{
    public class AddressData
    {
        [Key]
        public string Postcode { get; set; }
        public string Street { get; set; }
        public long House_Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}