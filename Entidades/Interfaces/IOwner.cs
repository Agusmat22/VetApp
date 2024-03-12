using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IOwner
    {
        int Dni { get; set; }
        int Phone { get; set; }
    }
}
