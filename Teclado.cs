using System;

namespace DeberPao2
{
    class Teclado
    {
        public int Id { get; set; }
        public string Modelo { get; set; }

        Teclado teclados;
        public Teclado Miteclado
        {
            get
            {
                return teclados;
            }
            set
            {
                teclados = value;
            }

        }
        public string Escribir(string nombre)
        {
            return "Porfavor, Verifique si está bien el teclado, el Mouse y el disco duro";
        }

        public string Borrar() 
        {
            if (teclados != null)
                return "Si, todo esta bien muchas gracias";
            else
                return "No, esta bien tienen fallas";
        }

        public string Enumerar()
        {
            return "";
        }

        public string CapturaPantalla()
        {
            return "";
        }

    }
}
