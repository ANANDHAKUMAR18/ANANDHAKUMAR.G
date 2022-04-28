using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCore3.Models
{
    public class movie
    {
        [Key]
        [Required]
        public int BillNo { get; set; }
        public int CustId { get; set; }
        public int ProdId { get; set; }
    }
}
