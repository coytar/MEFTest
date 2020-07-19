﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFTest
{
    public interface IDriver
    {
        bool Load();

        List<Alarm> getActiveAlarms();

        bool Unload();
    }
}
