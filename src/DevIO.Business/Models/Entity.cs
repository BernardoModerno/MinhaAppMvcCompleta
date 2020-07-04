using System;

namespace DevIO.Business.Models
{
    
    //abstract pq a classe não pode ser instanciada, apenas herdada
    public abstract class Entity 
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
