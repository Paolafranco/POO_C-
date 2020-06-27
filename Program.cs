using System;

namespace DeberPao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMPUTADORA ASUS:");
            Random generador = new Random();

            int id = generador.Next();
            string nombre = "Asus";

            //computadora
            Computadora computadora = new Computadora
            {
                Id = new Random().Next(),
                Marca = "Asus",
                Modelo = "VivoBook S510",
                Precio = 800
            };

            

            //teclado
            Teclado teclado = new Teclado
            {
                Id = new Random().Next(),
                Modelo = "Rectangular"
            };
           
            Teclado compradorTeclado = new Teclado
            {
                Id = new Random().Next(),
                Modelo = "Rectangular",
                Miteclado = teclado,
            };

            computadora.Cliente = compradorTeclado;
            string mensaje1 = "Teclado";
            string saludo1 = compradorTeclado.Escribir(mensaje1);
            string catalogoTeclado = compradorTeclado.Borrar();
            string confirmar1 = compradorTeclado.Enumerar();
            string guardar1 = compradorTeclado.CapturaPantalla();


            //discoduro
            DiscoDuro discoduro = new DiscoDuro
            {
                Id = new Random().Next(),
                Modelo = "3,5"
            };

            

            //mouse
            Mouse mouse = new Mouse
            {
                Id = new Random().Next(),
                Modelo = "Redondo"
            };

            Mouse compradormouse = new Mouse
            {
                Id = new Random().Next(),
                Modelo = "Rectangular",
                Mimouse = mouse,
            };

            computadora.Clientes = compradormouse;
            string mensaje2 = "Mouse";
            string saludo2 = compradormouse.MoverIzquierdo(mensaje2);
            string catalogoMouse = compradormouse.MoverDerecho();
            string confirmar2 = compradormouse.Subir();
            string guardar2 = compradormouse.Bajar();
            
            //disco duro
            DiscoDuro compradorDisco = new DiscoDuro
            {
                Id = new Random().Next(),
                Modelo = "3,5",
                Midisco = discoduro,
            };

            computadora.Compras = compradorDisco;
            string mensaje3 = "Disco Duro";
            string saludo3 = compradorDisco.Almacenar(mensaje3);
            string catalogoDisco = compradorDisco.GuardaInfor();
            string confirmar3 = compradorDisco.Registrar();
            string guardar3 = compradorDisco.EliminaInfor();

            //cliente
            Cliente comprador = new Cliente
            {
                Id = id,
                Nombre = nombre,
                MiCompu = computadora,
            };

            computadora.Dueño = comprador;
            string mensaje= "Paola";
            string saludo = comprador.Saludar(mensaje);
            string catalogoCompu = comprador.Comprar();
            string confirmar = comprador.Confirmar();
            string guardar = comprador.Guardar();




            Console.WriteLine(saludo);
            Console.WriteLine(catalogoCompu);
            Console.WriteLine(confirmar);
            Console.ReadKey();
            Console.WriteLine(saludo1);
            Console.WriteLine(catalogoTeclado);
          //Console.WriteLine(confirmar1); 
         //Console.WriteLine(guardar1);
            Console.WriteLine(saludo2);
            //Console.WriteLine(catalogoMouse);
            Console.WriteLine(confirmar2);
           //Console.WriteLine(guardar2);
            Console.ReadKey();

        }
    }
}
  
