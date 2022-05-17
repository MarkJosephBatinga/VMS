using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Shared
{
    public class Appoint
    {
        public int Id { get; set; }
        //Last Name
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        //First Name
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }
        //Middle Name
        [Required(ErrorMessage = "Middle Name is Required")]
        public string MiddleName { get; set; }
        //Suffix
        public string Suffix { get; set; }
        //Barangay
        [Required(ErrorMessage = "Barangay is Required")]
        public string Barangay { get; set; }
        //Town
        [Required(ErrorMessage = "Town is Required")]
        public string Town { get; set; }
        //Province
        [Required(ErrorMessage = "Province is Required")]
        public string Province { get; set; }
        //ZipCode
        [Required(ErrorMessage = "Zipcod is Required")]
        public string Zipcode { get; set; }
        //ContactNo
        [Required(ErrorMessage = "Contact Number is Required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string ContactNumber { get; set; }
        //BirthDate
        [Required(ErrorMessage = "Birth Date is Required")]
        public DateTime BirthDate { get; set; }
        //Date
        public DateTime VaccDate { get; set; }
        //FName
        public string Facility { get; set; }
        //FNumber
        public string FacilityNumber { get; set; }
        //FBarangay
        public string FacilityBarangay { get; set; }
        //FTown
        public string FacilityTown { get; set; }
        //FProvince
        public string FacilityProvince { get; set; }

    }
}
