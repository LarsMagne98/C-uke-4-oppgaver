public class ArtifactService
{
    List<Artifact> artifacts = new List<Artifact>
    {
        new Artifact("Echo Stone", "Moon", 73),
        new Artifact("Broken Compass", "Earth", 12),
        new Artifact("Glass Seed", "Mars", 48),
        new Artifact("Signal Cube", "Moon", 91),
        new Artifact("Cold Lens", "Europa", 28)
    };

    public List<Artifact> AllArtifacts()
    {
        return new List<Artifact>(artifacts);
    }

    public List<Artifact> HighRisk()
    {
        return new List<Artifact>(artifacts.Where(a => a.Risk >= 60).ToList());
    }

    public List<Artifact> OriginSearch(string? origin)
    {

        if (!string.IsNullOrWhiteSpace(origin))
        {
            return new List<Artifact>(artifacts
                .Where(a => a.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase))
                .ToList());
        }
        return new List<Artifact>(artifacts);
    }
}