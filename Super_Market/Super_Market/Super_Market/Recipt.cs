using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
   public class Recipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bon { get; set; }
        public int SuppliersId { get; set; }
        public virtual Suppliers supplier { get; set;}
        public virtual List<Proudect> products { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        public DateTime DateTime
        {
            set { }
            get
            {
                return this.dateTime.HasValue
                   ? this.dateTime.Value
                   : DateTime.Now;
            }

        }

        private DateTime? dateTime = null;
    }
}
