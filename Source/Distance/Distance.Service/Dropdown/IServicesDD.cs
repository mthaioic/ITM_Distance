﻿using Distance.Business.Dropdown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Service.Dropdown
{
    public interface IServicesDD
    {
        List<DDStatus> GetStatusList();
    }
}
