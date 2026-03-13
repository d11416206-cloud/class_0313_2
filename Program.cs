namespace _0313_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test joe, mary, tom;

            joe = new Test();

            mary = new Test();

            tom = new Test();

            // joe.Mid = 60;
            //joe.Final = 100;

            //mary.Mid = 80;
            //mary.Final = 95;

            joe.SetGrade(70, 80);
            mary.SetGrade(60, 90);




            Console.WriteLine(joe.Mid);
            Console.WriteLine(joe.Final);

            Console.WriteLine(mary.Mid);
            Console.WriteLine(mary.Final);



        }
    }
}
