using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE.BaseEntity
{
    public interface IEntity<T>
    {
        
    }
    public interface IEntity : IEntity<long>
    {

    }
}
