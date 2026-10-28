public class SpecimenVault
{
    private List<string> specimens = new List<string>();

    public void Add(string specimen)
    {
        specimens.Add(specimen);
    }

    public bool Remove(string specimen)
    {
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
        specimens.ForEach(Console.WriteLine);
    }
}

// Ferdig.