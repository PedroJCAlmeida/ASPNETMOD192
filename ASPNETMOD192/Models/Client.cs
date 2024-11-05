using System.ComponentModel.DataAnnotations;

namespace ASPNETMOD192.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateOnly Birthday { get; set; }

        [StringLength(100)]
        [Required]
        public string Address{ get; set; }

        [Required]
        public string VATNumber { get; set; }

        public DateOnly AdmissionDate { get; set; }

        public DateOnly DeactivationDate{ get; set; }

        public string? CellPhoneNumber { get; set; }

        [EmailAddress] //TODO Check me
        [Required]
        public string Email{ get; set; }


        //CreatedBy TODO FIXME

    }
}
