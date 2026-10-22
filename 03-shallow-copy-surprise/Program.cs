DroneVault vault = new DroneVault();
vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));

List<Drone> copy = vault.GetDrones();

copy[0].Name = "Changed";
copy.RemoveAt(0);

Console.WriteLine($"Vault count: {vault.Count}");
Console.WriteLine($"Copy count: {copy.Count}");
vault.PrintAll();

foreach (var item in copy)
{
    Console.WriteLine(item.Name);
}
