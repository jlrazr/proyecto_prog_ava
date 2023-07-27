using Libreria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    public class ClienteDTORequest
    {
        public int IdCliente { get; set; }
    }

    public class ClienteDTOResponse
    {
        public bool Existe { get; set; }
        public Cliente Cliente { get; set; }
    }
}

