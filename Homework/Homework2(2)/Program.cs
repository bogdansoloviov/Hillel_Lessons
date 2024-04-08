namespace Homework2_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hours = 6;       
            int minutes = 54;    
            int seconds = 15;   

           
            int totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

            
            Console.WriteLine("total time in hours, minutes and seconds: {0}:{1}:{2}", hours, minutes, seconds);
            Console.WriteLine("total time in seconds: " + totalTimeInSeconds);
            Console.ReadKey();  
        }
    }
}
    

