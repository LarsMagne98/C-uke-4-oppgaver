Archive archive = new Archive();
archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");

List<string> outsideList = archive.GetEntries();

// Kommenter ut for å sjekke at outsideList får en kopi
// av archive
outsideList.Clear();

Console.WriteLine($"Archive count: {archive.Count}");

foreach (var item in outsideList)
{
    Console.WriteLine($"OutsideList: {item}");
}