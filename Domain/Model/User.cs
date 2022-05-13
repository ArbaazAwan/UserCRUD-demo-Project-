using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }
        public string userAddress { get; set; }
            
    }
}
