ArtifactArchive archive = new ArtifactArchive();
archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));

var x = archive.FindArtifacts(artifact => artifact.Risk >= 50);
var y = archive.FindArtifacts(artifact => artifact.Origin == "Moon");
var z = archive.FindArtifacts(artifact => artifact.Name.Contains("g", StringComparison.OrdinalIgnoreCase));



// For å få ut resultatet til consolen, selv om det ikke står i oppgaveteksten.
foreach (var item in x)
{
    Console.WriteLine($"{item.Name}, {item.Origin}, {item.Risk}");
}

Console.WriteLine("----------------------------------------------------");

foreach (var item in y)
{
    Console.WriteLine($"{item.Name}, {item.Origin}, {item.Risk}");
}

Console.WriteLine("----------------------------------------------------");

foreach (var item in z)
{
    Console.WriteLine($"{item.Name}, {item.Origin}, {item.Risk}");
}