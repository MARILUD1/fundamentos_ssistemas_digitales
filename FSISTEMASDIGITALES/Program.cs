// See https://aka.ms/new-console-template for more information


Console.WriteLine("BIENVENIDO A MIS PROYECTOS");

        
        Console.WriteLine("SEMANA7 STACK");
        Console.WriteLine("");

   
  

        // Agregar caracteres de apertura y cierre a la pila
    Stack<char> pila = new Stack<char>();

        // Fórmula matemática
        string formula = "{8+(8*7)-[(9-3)+(2+1)]}";

        bool estaBalanceada = true;

        // Lista para almacenar los caracteres de apertura y cierre en orden
        List<char> caracteresOrdenados = new List<char>();

        foreach (char caracterFormula in formula)
        {
            // Agregar caracteres de apertura y cierre a la lista
            if (caracterFormula == '{' || caracterFormula == '[' || caracterFormula == '(' ||
                caracterFormula == '}' || caracterFormula == ']' || caracterFormula == ')')
            {
                caracteresOrdenados.Add(caracterFormula);
            }

            if (caracterFormula == '{' || caracterFormula == '[' || caracterFormula == '(')
            {
                pila.Push(caracterFormula);
            }
            else if (caracterFormula == '}' || caracterFormula == ']' || caracterFormula == ')')
            {
                if (pila.Count == 0)
                {
                    estaBalanceada = false;
                    break;
                }

                char apertura = pila.Pop();
                if ((caracterFormula == '}' && apertura != '{') ||
                    (caracterFormula == ']' && apertura != '[') ||
                    (caracterFormula == ')' && apertura != '('))
                {
                    estaBalanceada = false;
                    break;
                }
            }
        }

        // Mostrar caracteres en orden
        Console.WriteLine("Caracteres de apertura y cierre en orden:");
        Console.WriteLine();
        foreach (char item in caracteresOrdenados)
        {
            Console.WriteLine(item);
        }

        // Verificar si la fórmula está balanceada
        if (estaBalanceada && pila.Count == 0)
        {
            Console.WriteLine("Respuesta: La fórmula está balanceada.");
        }
        else
        {
            Console.WriteLine("Respuesta: La fórmula NO está balanceada por desorden en símbolos de apertura o cierre.");
        }
    