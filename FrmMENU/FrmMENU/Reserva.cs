using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMENU
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public int ID_Habitacion { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
