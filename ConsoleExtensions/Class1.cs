namespace ConsoleExtensions
{
    public class ConsoleExtensions

    {
        public static int GetInt (string message)
        {
            Console.WriteLine (message);
            var input = Console.ReadLine ();
            if ( int.TryParse(input, out int result))
            {
                return result;

            }
            else
            {

            }
        }
    }
}
