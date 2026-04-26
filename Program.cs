


using Structural_patterns.Proxy;

class Program
{
    public static void Main(string[] args)
    {
        IDocument adminDoc = new DocumentProxy("admin");
        IDocument viewerDoc = new DocumentProxy("viewer");
        
        adminDoc.Read();
        adminDoc.Edit();
        
        viewerDoc.Read();
        viewerDoc.Edit();
    }
}
