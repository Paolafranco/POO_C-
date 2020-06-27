using System;

namespace DeberPao2
{
    class DiscoDuro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public float Memoria { get; set; }

        DiscoDuro discoduro;
        public DiscoDuro Midisco
        {
            get
            {
                return discoduro;
            }
            set
            {
                discoduro = value;
            }

        }
        public string Almacenar(string nombre)
        {
            return "";
        }

        public string GuardaInfor()
        {
            return "";
        }

        public string Registrar()
        {
            return "";
        }

        public string EliminaInfor()
        {
            return "";
        }
    }
}
