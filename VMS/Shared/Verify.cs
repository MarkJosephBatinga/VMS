using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Shared
{
    public class Verify
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string VaccImgName { get; set; }
        public string IdImgName { get; set; }
        [Required(ErrorMessage = "Vaccination Card is Required")]
        public string VaccImg { get; set; }
        [Required(ErrorMessage = "Valid Id is Required")]
        public string IdImg { get; set; }

        [NotMapped]
        public string FullName { get; set; }
    }
}
