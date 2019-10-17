using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CandyCaneLane1._1.Data
{
    public class Orders
    {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int OderID { get; set; }
        public string ONumber { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
    }
}
