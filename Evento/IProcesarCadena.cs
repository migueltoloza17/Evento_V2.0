﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento
{
    interface IProcesarCadena
    {
        void RecorrerListaTipo();
        string ObtenerCadena();
        string[] ObtenerCadenaMensaje(List<IProcesarFechaTipo> lstIvalidarFechas);
    }
}
