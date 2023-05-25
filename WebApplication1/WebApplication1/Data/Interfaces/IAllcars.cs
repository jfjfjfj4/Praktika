using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
   public interface IAllcars
    {
        IEnumerable<Car> cars { get;  }
        IEnumerable<Car> getfavcars { get; set; }
        Car getobjectcar(int carid);


    }
}
