﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces
{
   public interface Icarscategory
    {
        IEnumerable<Category> AllCAtegories { get; }
    }
}
