using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandyCaneLane1._1.Data
{
    public class Stores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Adress { get; set; }
        public string city { get; set; }
        public string State { get; set; }
       
    }
}
