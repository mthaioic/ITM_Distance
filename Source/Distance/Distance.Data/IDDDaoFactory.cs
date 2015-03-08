﻿using Distance.Data.Dropdown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Data
{
    public interface IDDDaoFactory
    {
        IStatusDao StatusDao { get; }
        IProviceDao ProviceDao { get; }
        IAmphurDao AmphurDao { get; }
        ITambonDao TambonDao { get; }
    }
}
