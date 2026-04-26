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
        _role = role;
    }
    public void Read()
    {
        if (_role.ToUpper() != "ADMIN" && _role.ToUpper() != "VIEWER")
            throw new NotSupportedException("Only ADMIN and VIEWER are supported");
        _document.Read();
    }

    public void Edit()
    {
        if(_role.ToUpper() != "ADMIN")
            throw new NotSupportedException("Only ADMIN are supported");
        _document.Edit();
    }
}