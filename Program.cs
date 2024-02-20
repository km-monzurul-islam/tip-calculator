Console.WriteLine("Quick Tip");
Console.WriteLine("============");

try
{
    // Asking for a bill amount
    Console.Write("Enter Bill Amount :$ ");
    double billAmount = double.Parse(Console.ReadLine() ?? "");

    // asking for a tip amount
    Console.Write("Enter Tip in percent % : ");
    double tipAmount = double.Parse(Console.ReadLine() ?? "");


    // calculating total amount
    double tipToPay = billAmount * (tipAmount / 100);
    double totalAmount = tipToPay + billAmount;
    Console.WriteLine("=====================");
    Console.WriteLine($"Total amount: {totalAmount:C}\n");
    
    // split bill
    Console.Write("Split between how many person: ");
    int persons = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Bill each: {totalAmount / persons:C}");
    Console.WriteLine($"Tip each: {tipToPay / persons:C}");
}
catch(FormatException e)
{
    Console.WriteLine(e.Message);
    Environment.Exit(1);
}