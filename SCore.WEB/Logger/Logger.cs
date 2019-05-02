﻿using log4net;
using SCore.WEB.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCore.WEB.Logger
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ILog Log
        {
            get { return log; }
        }

    }
}
