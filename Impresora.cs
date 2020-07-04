using System;

namespace DeberProgra2
{
        public class Impresora : GeneradorProductosTecnologicos
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public float Precio { get; set; }

           
            public new string Prender()
            {
                return $"La impresora {Id} {Marca} {Modelo} {base.Apagar()}";

            }
            public string Imprimir()
            {
                return "";
            }

            public string Escanear()
            {
                return "";
            }

            public string Copiar()
            {
                return "";
            }
            public Impresora() : base()
            {
            }
            public new string Apagar()
            {
                return $"La impresora {Id} {Marca} {Modelo} {base.Apagar()}";

            }
         }
    }
