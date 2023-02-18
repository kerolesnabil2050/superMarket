using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    public enum position
    {
        Casher,
        Admin,
    }
    public class Users
    {
        [Key]
        public string UserName { get; set; }
        public int Password { get; set; }
        public float Salary { get; set; }
        public position Pos { get; set; }
        public virtual List<Sellinvoce> Sellinvos { get; set;}
    }
}
