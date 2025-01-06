namespace class12th__Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string 빌런;
            string 본인;

            System.Console.WriteLine("문자열 입력");

            System.Console.Write("코멘트 :  " +);
             빌런= Console.ReadLine();

            System.Console.Write("코멘트 : " +);
             본인= Console.ReadLine();

            System.Console.WriteLine("내 이름은 : {0}, 나이는 : {1}", 빌런, 본인);
        }
    }
}
