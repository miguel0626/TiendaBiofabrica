﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientesEntity
    {
        public int IdCliente { get; set; }

        public string NumeroDocumento { get; set; }
        public string Primerombre { get; set; }
 
        public string PrimerApellido { get; set; }
     public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
