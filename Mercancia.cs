using System;

namespace DeberProgra2
{
    public class Mercancia : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Cliente Dueño { get; set; }


        public Mercancia() : base()
        {
        }
    }
}
