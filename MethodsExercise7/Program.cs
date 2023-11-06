namespace MethodsExercise7;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();

        Console.WriteLine($"Hi {name}. What is your favorite color?");
        var color = Console.ReadLine();

        Console.WriteLine($"{color} is a great color! What is your favorite hobby?");
        var hobby = Console.ReadLine();

        Console.WriteLine($"That's a fun {hobby}. What is your favorite song?");
        var song = Console.ReadLine();

        Console.WriteLine($"{song})");



        Console.WriteLine(Add(8, 10));
        Console.WriteLine(Multiply(8, 10));
        Console.WriteLine(Subtract(8, 10));
        Console.WriteLine(Modulus(8, 10));
        Console.WriteLine(MultiplyWithParams(1, 2, 3));



    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Multiply(int num1, int num2)

    { return num1 * num2;
    }

    static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    static int Modulus(int num1, int num2)
    {
        var modulus = num1 % num2;
        return modulus;

    }
    static int MultiplyWithParams(params int[] nums)
    { int answer = 1;
        return answer;
    }
}

