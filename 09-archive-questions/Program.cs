List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};



Console.WriteLine($"Any risk above 90? {artifacts.Any(artifact => artifact.Risk > 90)}");
Console.WriteLine($"How many artifacts from Mars? {artifacts.Count(artifact => artifact.Origin == "Mars")}");
// .Count returnerer en innebygd telling av ting i en List.
// .Count() sjekker om du bruker den på en List, og returnere den innebygde
// telleren hvis du gjør det, eller så teller den faktisk over tingene
// en etter en og gir deg resultatet.
Console.WriteLine($"How many artifacts in total? {artifacts.Count}");
Console.WriteLine($"Any artifacts from Venus? {artifacts.Any(artifact => artifact.Origin == "Venus")}");

// Ferdig.