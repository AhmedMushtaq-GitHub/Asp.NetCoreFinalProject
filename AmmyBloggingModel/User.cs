using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmyBlogging.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAdress { get; set; }
        public int Password { get; set; }
        public double PhoneNumber { get; set; }
        public bool IsConfimred { get; set; }
        public virtual UserReload UserReload { get; set; }
        public int UserReloadId { get; set; }


    }
}
