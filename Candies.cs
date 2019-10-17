using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandyCaneLane1._1.Data
{
    public class Candies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CandyID { get; set; }
        public string CandyName { get; set; }
        public int Price { get; set; }



        public int StoreID { get; set; }
        [ForeignKey("StoreID")]
        public Stores Store { get; set; }


        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Orders Order { get; set; }
    }
}
