﻿using Distance.Business.Dropdown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Data.Dropdown
{
    public interface IAmphurDao
    {
        List<DDAmphur> GetAmphurList(int id);
        
    }
}
