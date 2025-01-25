// See https://aka.ms/new-console-template for more information


Console.WriteLine("BIENVENIDO A MIS PROYECTOS");


   //Pila.run(); 
    
  
    
        Stack<char> caracter = new Stack<char>();
        // Fórmula matemática
        string formula = "{8+(8*7)-[(9-3)+(2+1)]}";

        bool estaBalanceada = true;

        foreach (char caracterFormula in formula)
        {
            switch (caracterFormula)
            {
                // Caracteres de apertura
                case '{':
                case '[':
                case '(':
                    caracter.Push(caracterFormula);
                    break;

                // Caracteres de cierre
                case '}':
                case ']':
                case ')':
                    if (caracter.Count == 0)
                    {
                        estaBalanceada = false;
                        break;
                    }

                    char apertura = caracter.Pop();
                    switch (caracterFormula)
                    {
                        case '}':
                            if (apertura != '{') estaBalanceada = false;
                            break;

                        case ']':
                            if (apertura != '[') estaBalanceada = false;
                            break;

                        case ')':
                            if (apertura != '(') estaBalanceada = false;
                            break;
                    }
                    break;
            }

            if (!estaBalanceada) break;
        }
        Console.WriteLine();
        // Mostrar caracteres de apertura y cierre en orden
        Console.WriteLine("Caracteres de apertura y cierre en orden:");
        foreach (char item in formula)
        {
            switch (item)
            {
                case '{':
                case '}':
                case '[':
                case ']':
                case '(':
                case ')':
                    Console.Write(item + " ");
                    break;
            }
        }

        // Verificar si la fórmula está balanceada
        if (estaBalanceada && caracter.Count == 0)
        {
            Console.WriteLine("Respuesta: La fórmula está balanceada.");
        }
        else
        {
            Console.WriteLine("Respuesta: La fórmula NO está balanceada por desorden en símbolos de apertura o cierre.");
        }
        Console. WriteLine();
