
// Тема: Рекурсия.
// --- Начало программы ----------------/\---/\------------------------------------------------
// --------------------------------------*---*-------------------------------------------------
// ---------------------------------------\*/--------------------------------------------------



// --- Блок методов ---------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------

static void ExitProgram() { // Досрочное завершение работы программы
    
    Console.Write("> Работа программы завершена досрочно!\n");
    System.Environment.Exit(1);

}
    
static int ReadInt(string text) // Прочитать целое число с консоли
{
    string? str;
    bool check = false;

    System.Console.Write(text);
    str = Console.ReadLine();

    //check = (Int32.TryParse(str, out int num) == false) ? false : true;
    check = Int32.TryParse(str, out int num) != false;

    while (check == false) {
        
        Console.Write("> Неудалось обнаружить число во введенной строке.\n");
        Console.Write("> Повторите ввод или введите символ 'q' для выхода из программы.\n");
        
        System.Console.Write(text);
        str = Console.ReadLine();

        check = Int32.TryParse(str, out num) != false;

        // str = str == null ? "" : str; // до первого упрощения
        // str = str ?? "";              // до второго упрощения

        str ??= "";

        if ((int)str[0] == 113 || (int)str[0] == 81) { ExitProgram(); }     

    }
    
    return num;

}

static string ReadStr(string text) // Прочитать строку с консоли
{
    
    string? str;
    
    System.Console.Write(text);
    str = Console.ReadLine();
 
    return str ?? "";

}

static void PrintDiapazon(int m, int n)
{
    if ( m <= n ) 
    {
        Console.WriteLine("> " + m);
        PrintDiapazon(++m, n);
    }
    
}

static int Akkerman(int M, int N, int cnt)
{
    
    int result = 0;
    
    Console.WriteLine("> Вызов {0}; M = {1}; N = {2}", cnt, M, N);

    if ( M == 0 ) 
    {
        Console.WriteLine("> Ветка 1");
        result = N+1;
    }
    else if ( M > 0 && N == 0 )
    {
        Console.WriteLine("> Ветка 2");
        result = Akkerman(M-1, 1, cnt+1);
    } 
    else if ( M > 0 && N > 0 )
    {
        Console.WriteLine("> Ветка 3");
        result = Akkerman(M-1, Akkerman(M, N-1, cnt+1), cnt+1);
    } 
    else
    {
        Console.WriteLine("> Обнаружен незаплонированный результат!");
    }

    return result;
    
}


// --- end ------------------------------------------------------------------------------------



// --- Основной блок --------------------------------------------------------------------------
// --------------------------------------------------------------------------------------------

// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("\n> Задача 1.\n");

int M = ReadInt("> Введите M: ");
int N = ReadInt("> Введите N: ");

PrintDiapazon(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("\n> Задача 2.\n");

M = ReadInt("> Введите M: ");
N = ReadInt("> Введите N: ");
            
//             _
//            /  
//            |   n + 1,              m = 0;
//            |    
//  A(m,n) = <    A(m-1, 1),          m > 0, n = 0;
//            |  
//            |   A(m-1, A(m, n-1)),  m > 0, n > 0.
//            \_
//

int A = Akkerman(M, N, 1);

Console.WriteLine("\n> A({0}, {1}) = {2}", M, N, A);


// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

Console.WriteLine("\n> Задача 3.\n");





// --- end ------------------------------------------------------------------------------------