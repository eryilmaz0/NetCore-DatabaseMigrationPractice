using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMigration
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public User User { get; set; }

    }
}
