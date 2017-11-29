using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int instrumentID { get; set; }

        public String instDescription { get; set; }
        public String type { get; set; }
        public decimal price { get; set; }

        [ForeignKey("Client")]
        public int? clientID { get; set; }
        public virtual Client Client { get; set; }
    }
}