using System;

namespace DeberPao2
{
    class Cliente
    {
        //atributos o propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }

        Computadora computador;

        public Computadora MiCompu
        {
            get
            {
                return computador;
            }
            set
            {
                computador = value;
                computador.Dueño = this;
            }

        }

        
        public string Saludar(string nombre)
        {
            return $"Gracias {nombre} ,verifique si la computadora tiene las siguientes especificaciónes: Marca = Asus, Modelo = VivoBook S510, Precio = 800.";
        }

        public string Comprar()
        {
            if (computador != null)
                return "Si, gracias muy amable.";
            else
                return "No, esta no es mi computadora";
        }

        public string Confirmar()
        {
            return "Para cotinuar por favor da enter";
        }
        public string Guardar()
        {
            return "";
        }
    }
}
  
