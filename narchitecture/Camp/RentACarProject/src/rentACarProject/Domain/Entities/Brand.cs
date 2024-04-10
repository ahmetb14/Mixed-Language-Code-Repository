using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Brand:Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }  
}

//CQRS 