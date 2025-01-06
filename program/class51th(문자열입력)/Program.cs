namespace class51th_문자열입력_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            String s2 = input[1];
            
            String result = s1;

            Console.WriteLine(result.Replace(" ", String.Empty));
        }
    }
}
