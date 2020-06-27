using System;

namespace DeberPao2
{
    class Mouse
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Precio  { get; set; }

        Mouse mouse;
        public Mouse Mimouse
        {
            get
            {
                return mouse;
            }
            set
            {
                mouse = value;
            }

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
