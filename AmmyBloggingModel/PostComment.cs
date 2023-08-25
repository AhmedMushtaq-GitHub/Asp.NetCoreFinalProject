using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmyBlogging.Model
{
    public class PostComment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CommentedOn { get; set; }
        public virtual Post Post { get; set; }
        public int PostId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
