using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class Arac:IEntity
    {
        public int ID { get; set; }
        public string AracPlaka { get; set; }
        public string Marka { get; set; }
        public string KM { get; set; }
        public string YakitTuru { get; set; }
        public int Model { get; set; }
        public string Renk { get; set; }
        public int Ucret { get; set; }
        public bool Durum { get; set; }
    }
}
