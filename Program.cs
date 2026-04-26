

using Structural_patterns.Composite;
using Structural_patterns.Decorator;
using Structural_patterns.Facade;
using Structural_patterns.FlyWeight;
using Structural_patterns.Proxy;
using File = Structural_patterns.Composite.File;

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
