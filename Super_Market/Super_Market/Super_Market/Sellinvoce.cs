using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
   public class Sellinvoce
    {
        [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int BonNumberr { get; set; }
       public int UsersId { get; set; }
        public virtual Users casherUserName { get; set; }
        //public string NameStore { get; set; }
        public virtual List<Proudect> Products { get; set; }


        public DateTime DateTime
        {
            set { }
            get
            {
                return this.datetime.HasValue
                   ? this.datetime.Value
                   : DateTime.Now;
            }

        }

        private DateTime? datetime = null;

        public double TotalPrice
        {
            set { }
            get
            {
                double total = 0;
                foreach (var item in Products)
                {
                    total += item.SellingPrice;
                }
                return total;

            }
        }


        public double PaidMoney { get; set; }


        public double RemainingMoney
        {
            set { }
            get
            {
                return PaidMoney - TotalPrice;
            }
        }

        
    }
}
