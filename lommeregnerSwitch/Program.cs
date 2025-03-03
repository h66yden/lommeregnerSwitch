string output = "0";
bool looping = true;
while (true)
{
    Console.Clear();
    Console.WriteLine("Enter first number: \n");
    string input1 = Console.ReadLine();

    Console.WriteLine("Enter operator: \n");
    string input2 = Console.ReadLine();

    Console.WriteLine("Enter second number: \n");
    string input3 = Console.ReadLine();
    double int1 = (Convert.ToDouble(input1));
    double int2 = (Convert.ToDouble(input3));

    switch (input2)
    {
        case "-":
            output = $"{int1 - int2}";
            break;
        case "+":
            output = $"{int1 + int2}";
            break;
        case "/":
            output = $"{int1 / int2}";
            break;
        case "*":
            output = $"{int1 * int2}";
            break;
        default:
            Console.WriteLine("Error, press any key...");
            Console.ReadKey();
            break;

    }
    Console.WriteLine($"= " + output);
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
