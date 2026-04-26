namespace Structural_patterns.Proxy;

public interface IDocument
{
    void Read();
    void Edit();
}


public class Document: IDocument
{
    public void Read()
    {
        Console.WriteLine("Reading document");
    }

    public void Edit()
    {
        Console.WriteLine("Editing document");
    }
}

public class DocumentProxy: IDocument
{
    private readonly IDocument _document = new Document();
    private string _role;
    public DocumentProxy(string role)
    {
        
        _role = role.TrimStart().TrimEnd().ToUpper();
    }
    
    public void Read()
    {
        if (_role != "ADMIN" && _role != "VIEWER" && _role != "EDITOR")
            throw new NotSupportedException("Only ADMIN, VIEWER and EDITOR are supported");
        _document.Read();
    }

    public void Edit()
    {
        if(_role != "ADMIN" && _role != "EDITOR")
            throw new NotSupportedException("Only ADMIN and EDITOR, are supported");
        _document.Edit();
    }
}