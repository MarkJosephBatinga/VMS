using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Shared
{
    public class Vaccine
    {
        public int Id { get; set; }
        public int UserId { get; set; }
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
        //FDate
        public DateTime FirstDate { get; set; }
        //FManufacturer
        public string FirstManufacturer { get; set; }
        //FVaccinator
        public string FirstVaccinator { get; set; }
        //FBatch
        public string FirstBatch { get; set; }
        //FLot
        public string FirstLot { get; set; }
        //SDate
        public DateTime SecondDate { get; set; }
        //SManufacturer
        public string SecondManufacturer { get; set; }
        //SVacccinator
        public string SecondVaccinator { get; set; }
        //SBatch
        public string SecondBatch { get; set; }
        //SLot
        public string SecondLot { get; set; }
        //Facility
        public string Facility { get; set; }
        //FacContact
        public string FacilityContact { get; set; }


    }
}
