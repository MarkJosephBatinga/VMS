using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Shared
{
    public class SearchToken
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
    }
}
