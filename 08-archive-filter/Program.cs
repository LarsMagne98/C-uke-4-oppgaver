List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


foreach (var artifact in artifacts.Where(artifact => artifact.Origin == "Moon"))
{
    Console.WriteLine($"Artifacts from the Moon: {artifact.Name}");
}

foreach (var artifact in artifacts.Where(artifact => artifact.Risk >= 60))
{
    Console.WriteLine($"Artifacts with risk bigger than or equal to 60: {artifact.Name}, Risk: {artifact.Risk}");
}

foreach (var artifact in artifacts.Where(artifact => artifact.Name.Contains('e', StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine($"Artifacts that contains the letter \"e\": {artifact.Name}");
}

// Ferdig.