namespace CStephens_Homework3;
class Program
{
    static void Main(string[] args)
    {
    // Get value from user
    Console.WriteLine("Input an integer:");
    int inputInteger = Convert.ToInt16(Console.ReadLine());
    int divCounter = 2;
    do {
    
    divCounter++;
    } while (divCounter<inputInteger&&inputInteger%divCounter!=0);
    if (inputInteger%divCounter==0)
    {
        Console.WriteLine($"{inputInteger} is not prime.");
    } else if (inputInteger%divCounter!=0){
            Console.WriteLine($"{inputInteger} is prime.");
        }
    }
}
