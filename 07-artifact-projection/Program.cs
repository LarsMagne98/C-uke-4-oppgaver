List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


foreach (var artifact in artifacts.Select(artifact => artifact.Name))
{
    Console.WriteLine(artifact);
}

foreach (var artifact in artifacts.Select(artifact => artifact.Risk))
{
    Console.WriteLine(artifact);
}

foreach (var artifact in artifacts.Select(artifact =>
    $"{artifact.Name} ({artifact.Origin})"))

{
    Console.WriteLine(artifact);
}

// Ferdig.