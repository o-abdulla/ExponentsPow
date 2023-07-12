Console.WriteLine("Welcome to Exponents/Powers table");


bool runProgram = true;
while (runProgram)
{
    int num = 0;
    
    while (true)
    {
        Console.WriteLine("Please enter an integer");
        num = int.Parse(Console.ReadLine());
        
        if (num <= 0)
        {
            Console.WriteLine("Please enter a number greater than 0");
        }
        else if (num >= 1290)
        {
            Console.WriteLine("Number too high");
        }
        else
        {
            break;
        }
        
    }
        Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", "Number", "Square", "Cube"));
        Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", "=======", "=======", "======="));


        for (int counter = 1; counter <= num; counter++)
        {
            Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", counter, NumberSquared(counter), NumberCubed(counter)));
        }

    // ask user if they'd like to continue


    while (true)
    {

        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("See ya");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter either a y/n");
        }
    }
}


static int NumberSquared(int num)
{
    return num * num;
}

static int NumberCubed(int num)
{
    return num * num * num;
}

