class Program {
    static void Main(string[] args) {
        Console.WriteLine($"Enter the factorial number");
        int factNumber = Int32.Parse(Console.ReadLine());
        int factResult = 1;
        if (factNumber <=0){
            Console.WriteLine($"Please enter a positive nubmer");
            
        }
        else
        {
            
        for (int i = 1; i <= factNumber; i++)
        {
            factResult = factResult *i;
        }
        Console.WriteLine("factorial of {0} is {1}",factNumber,factResult);
        
        }
        
    }
}