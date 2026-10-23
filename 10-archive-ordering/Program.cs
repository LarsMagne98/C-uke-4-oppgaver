List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


List<string> alphabeticalOrder = artifacts
    .Where(artifact => artifact.Risk >= 30)
    .OrderBy(artifact => artifact.Name)
    .Select(artifact => $"{artifact.Name}: {artifact.Risk}")
    .ToList();

alphabeticalOrder.ForEach(Console.WriteLine);

Console.WriteLine("----------------------------");

List<string> numericalOrder = artifacts
    .OrderBy(artifact => artifact.Risk)
    .Select(artifact => $"{artifact.Name}: {artifact.Risk}")
    .ToList();

numericalOrder.ForEach(Console.WriteLine);

// Ferdig.