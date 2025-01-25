Console.WriteLine("BIENVENIDO A MIS PROYECTOS");
Console.WriteLine();
Console.WriteLine("torre de Hanoi");
//Pila.run(); 
  
       // Declarar e inicializar tres pilas
        Stack<int> origen = new Stack<int>();
        Stack<int> destino = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();

        // Agregar elementos a la pila de origen
        origen.Push(4);
        origen.Push(3);
        origen.Push(2);
        origen.Push(1);

        // Mostrar las pilas iniciales
        Console.WriteLine("Estado inicial:");
        MostrarPilas(origen, destino, auxiliar);

        // Mover fichas de origen a destino usando auxiliar
        MoverFichas(origen.Count, origen, destino, auxiliar);

        // Mostrar las pilas finales
        Console.WriteLine("Estado final:");
        MostrarPilas(origen, destino, auxiliar);
    

    static void MoverFichas(int item, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (item > 0)
        {
            MoverFichas(item - 1, origen, auxiliar, destino);
            destino.Push(origen.Pop());
            MoverFichas(item - 1, auxiliar, destino, origen);
        }
    }

    static void MostrarPilas(Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        Console.WriteLine(" A : " + string.Join(", ", origen));//Join:separar los elementos en una linea al ser imprimidos
        Console.WriteLine(" B: " + string.Join(", ", destino));
        Console.WriteLine(" Puente : " + string.Join(", ", auxiliar));
        Console.WriteLine();
    }
