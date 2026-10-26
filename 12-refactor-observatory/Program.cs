var print = new ArtifactService();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Show all");
    Console.WriteLine("2 - Show high risk");
    Console.WriteLine("3 - Search origin");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        foreach (var artifact in print.AllArtifacts())
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Origin} | {artifact.Risk}");
        }
    }
    else if (choice == "2")
    {
        foreach (var item in print.HighRisk())
        {
            Console.WriteLine($"{item.Name} | {item.Risk}");
        }
    }
    else if (choice == "3")
    {
        Console.Write("Origin: ");
        string? origin = Console.ReadLine();

        if (origin == "")
        {
            Console.WriteLine("No artifacts found.");
        }
        else
        {
            foreach (var artifact in print.OriginSearch(origin))
            {
                Console.WriteLine(artifact.Name);
            }
        }

    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}

// Ferdig.