using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public  abstract class BaseModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public virtual void Validate(){}
    }
}
