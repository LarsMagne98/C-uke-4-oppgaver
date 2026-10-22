public class SpecimenVault
{
    private List<string> specimens = new List<string>();

    public void Add(string specimen)
    {
        // TODO
        specimens.Add(specimen);
    }

    public bool Remove(string specimen)
    {
        // TODO
        if (specimens.Remove(specimen))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PrintAll()
    {
        // TODO
        foreach (var specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }
}

// Ferdig.