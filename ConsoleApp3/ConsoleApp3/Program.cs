using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
Console.WriteLine("Инструкция: \n 1) клавиши от a до u \n 2) при двойном нажатии на F1 или F2 переключаются тональности \n 3) по стандарту качества стоит F1 герцовка");
while (true)
{
    ConsoleKeyInfo sound = Console.ReadKey();

    int[] massive1 = new[] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087 };
    int[] massive2 = new[] { 3270, 3465, 3671, 3889, 4120, 3465, 4625, 4900, 5191, 5500, 5827, 6174 };
    int[] tonalnasti = new[] {0};

    if (sound.Key == ConsoleKey.F1)
    {
            tonalnasti = new int[massive1.Length];
            massive1.CopyTo(tonalnasti, 0);

            Console.WriteLine(String.Join(", ", tonalnasti));
    }
    else if (sound.Key == ConsoleKey.F2)
    {
        tonalnasti = new int[massive2.Length];
        massive2.CopyTo(tonalnasti, 0);

        Console.WriteLine(String.Join(", ", tonalnasti));
    }
    
    bool a = true;
    while (a)
    {
        if (sound.Key == ConsoleKey.A)
        {
            Console.Beep(tonalnasti[0], 100);
        }
        else if (sound.Key == ConsoleKey.W)
        {
            Console.Beep(tonalnasti[1], 100);
        }
        else if (sound.Key == ConsoleKey.S)
        {
            Console.Beep(tonalnasti[2], 100);
        }
        else if (sound.Key == ConsoleKey.E)
        {
            Console.Beep(tonalnasti[3], 100);
        }
        else if (sound.Key == ConsoleKey.D)
        {
            Console.Beep(tonalnasti[4], 100);
        }
        else if (sound.Key == ConsoleKey.R)
        {
            Console.Beep(tonalnasti[5], 100);
        }
        else if (sound.Key == ConsoleKey.F)
        {
            Console.Beep(tonalnasti[6], 100);
        }
        else if (sound.Key == ConsoleKey.T)
        {
            Console.Beep(tonalnasti[7], 100);
        }
        else if (sound.Key == ConsoleKey.G)
        {
            Console.Beep(tonalnasti[8], 100);
        }
        else if (sound.Key == ConsoleKey.Y)
        {
            Console.Beep(tonalnasti[9], 100);
        }
        else if (sound.Key == ConsoleKey.H)
        {
            Console.Beep(tonalnasti[10], 100);
        }
        else if (sound.Key == ConsoleKey.U)
        {
            Console.Beep(tonalnasti[11], 100);
        }
        sound = Console.ReadKey(true);

        if (sound.Key == ConsoleKey.F1)
        {
            a = false;
        }
        if (sound.Key == ConsoleKey.F2)
        {
            a = false;
        }
    }
}
