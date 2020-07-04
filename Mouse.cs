using System;

namespace DeberProgra2
{
    public class Mouse : GeneradorProductosTecnologicos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }


        public Mouse() : base()
        {
        }

        public string MoverIzquierdo(string nombre)
        {
            return "Gracias Paola, por su compra";
        }
        public string MoverDerecho()
        {
            return "";
        }

        public string Subir()
        {
            return "Tu compra se ha guardado exitosamente";
        }
        public string Bajar()
        {
            return "";
        }

    }
}
