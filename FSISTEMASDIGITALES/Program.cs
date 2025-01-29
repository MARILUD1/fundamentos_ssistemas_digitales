// See https://aka.ms/new-console-template for more information


Console.WriteLine("BIENVENIDO A MIS PROYECTOS");
//Pila.run();
//Torres.run();



Console.WriteLine("semana3");

Console.WriteLine("");

    // Clase que representa un producto
    public class Producto
    {
        private int id;
        private string nombre;
        private decimal[] precio;

        // Crear un constructor
        public Producto(int Identificador, string nombreProducto, decimal[] costo)
        {
            id = Identificador;
            nombre = nombreProducto;
            precio = costo;
        }

        // Propiedades para acceder a los atributos
        
        // Método para mostrar información del producto
        public void MostrarInformacion()
        {
            Console.WriteLine($"id: {id}, nombre:{nombre}");
            Console.WriteLine("Precios: ");
            for (int item = 0; item < precio.Length; item++)
        {
             Console.WriteLine($" precio {item + 1}: {precio[item]:c}");
    }

        }
          public void correr()
        {
            // Crear instancias de productos
            Producto producto1 = new Producto(1, "Manzana", new decimal[] { 1m, 2m, 4m });
            Producto producto2 = new Producto(2, "Leche", new decimal[] { 0.9m, 4m, 5m });
            producto1.MostrarInformacion();
            producto2.MostrarInformacion();
    
        }
    }

