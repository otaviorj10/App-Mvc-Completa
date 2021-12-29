using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBasicaMvc.Models
{
    //deveram herdar dela , nao poderá ser instancia motivo : ela é abstrata
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
