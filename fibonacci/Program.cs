class Program
{
    static int p1 =0, p2=1, p3;


static void Main(string[] args) {
    Console.WriteLine("Please provide the input");
    int count = Int32.Parse(Console.ReadLine());
    Console.Write(p1 + " " + p2);

    for (int i = 0; i < count; i++)
    {
        p3 = p1 + p2;
        System.Console.Write(" " + p3);
        p1 =p2;
        p2 = p3;
    }
    Console.WriteLine();
    
}
}