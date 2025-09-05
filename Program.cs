
    
        Console.Write("Введи перше число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введи дію (+ - * /): ");
        string op = Console.ReadLine();

        Console.Write("Введи друге число: ");
        int b = int.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine("Результат: " + (a + b));
                break;
            case "-":
                Console.WriteLine("Результат: " + (a - b));
                break;
            case "*":
                Console.WriteLine("Результат: " + (a * b));
                break;
            case "/":
                Console.WriteLine("Результат: " + (a / b));
                break;
            default:
                Console.WriteLine("Невірна дія");
                break;
        }
