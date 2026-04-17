

using Structural_patterns.Composite;
using File = Structural_patterns.Composite.File;

class Program
{
    public static void Main(string[] args)
    {
        Folder root = new Folder("root");
        Folder documents = new Folder("documents");
        Folder music = new Folder("music");

        documents.Add(new File("readme.txt", 10));
        documents.Add(new File("cover_letter.docx", 85));

        music.Add(new File("song1.mp3", 4500));
        music.Add(new File("song2.mp3", 3200));

        root.Add(documents);
        root.Add(music);
        root.Add(new File("readme.txt", 10));

        Console.WriteLine($"{root.GetName()}: {root.GetSize()} KB");
    }
}
