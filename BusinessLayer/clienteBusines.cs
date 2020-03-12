using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BusinessLayer
{
    public class clienteBusines
    {
        public static bool GuardarCliente(ClientesEntity cliente)
        {
            return ClientesData.GuardarCliente(cliente);
        }
    }
}
