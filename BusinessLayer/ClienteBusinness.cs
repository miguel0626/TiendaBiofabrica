﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataLayer;

namespace BusinessLayer
{
    public class BusinessLayer
    {
        public static bool ProbarConexion()
        {
            return ClienteData.ProbarConexion();
        }
    }
    
}
