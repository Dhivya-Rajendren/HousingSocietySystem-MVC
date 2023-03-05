using System.ComponentModel.DataAnnotations;

namespace HousingSocietySystem_MVC.Models
{
    public class Flat
    {
        [Key]
        public int FlatNo{ get; set; }
        public string FlatName { get; set; }
        public string FlatOwner { get; set; }
        public string Wing { get; set; }
        public int Aadhar { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public Boolean IsActive { get; set; }
    }
}
