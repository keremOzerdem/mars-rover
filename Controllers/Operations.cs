public static class Operations
{


    public static void ShowMenu()
    {
        Console.WriteLine("Please choose a process between the operations are below(1-2-3): ");
        Console.WriteLine("1. Deploy Rover");
        Console.WriteLine("2. Steer one of the deployed rovers");
        Console.WriteLine("3. Exit the program");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Deploy();
        }
        else if (choice == 2)
        {
            Move();
        }
        else if (choice == 3)
        {
            Exit();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a number is between 1 and 3!!! ");
            ShowMenu();
        }

    }
    public static void Deploy()
    {
        Console.Write("Please enter the rover's position on the x-axis...");
        int roverX = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the rover's position on the y-axis...");
        int roverY = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the rover's direction(north-south-east-west)");
        string roverDirection = Console.ReadLine().ToLower();


        if (roverDirection == "north")
        {
            roverDirection = "N";
        }
        else if (roverDirection == "south")
        {
            roverDirection = "S";
        }
        else if (roverDirection == "east")
        {
            roverDirection = "E";
        }
        else if (roverDirection == "west")
        {
            roverDirection = "W";
        }

        RoverListModel.RoverList.Add(new RoverModel(roverX, roverY, roverDirection));
    }
    public static void Move()
    {

    }
    public static void Exit()
    {
        Console.WriteLine("Press a button to halt the program");
        Console.ReadLine();
    }
    public static void ListRovers(int[] myArray)
    {
        for (int i = 0; i < myArray.GetUpperBound(0); i++)
        {
            for (int j = 0; j < myArray.GetUpperBound(1); j++)
            {
                Console.Write(RoverModel);
            }
        }
    }
}