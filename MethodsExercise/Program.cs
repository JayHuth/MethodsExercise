namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?"); // output
            //string name = Console.ReadLine(); // input

            //Console.WriteLine("What is your favorite color?"); // output
            //string favColor = Console.ReadLine(); // Input

            //Console.WriteLine("What is your favorite animal?"); // input 
            //string favAnimal = Console.ReadLine(); // output

            //Console.WriteLine("what is your favorite band?"); // input 
            //string favBand = Console.ReadLine(); // output

            //Console.WriteLine($"Hello {name}, this is your imaginary friend the {favColor} {favAnimal}. Hurry up! Its time for us to see {favBand} live!");

            int answer1 = Methods.Add(2,2);
            Console.WriteLine(answer1);

            int anwser2 = Methods.Add(5, 6);
            Console.WriteLine(anwser2);

            int answer3 = Methods.Multiply(2, 4);
            Console.WriteLine(answer3);

            int answer4 = Methods.Subtract(2, 4);
            Console.WriteLine(answer4);

            int answer5 = Methods.Divide(6, 3);
            Console.WriteLine(answer5);

            int answer6 = Methods.add(3, 3, 3);
            Console.WriteLine(answer6);
        }
    }
}
