namespace Structural_patterns.Composite;

public class File: IFileSystemItem
{
    private string _name;
    private decimal _size;

    public File(string name, decimal size)
    {
        _name = name;
        _size = size;
    }
    
    public decimal GetSize()
    {
        return  _size;
    }

    public string GetName()
    {
        return _name;
    }
}

public class Folder: IFileSystemItem
{
    private string _name;
    private decimal _size = 0.0m;
    private LinkedList<IFileSystemItem> _items = [];
    public Folder(string name)
    {
        _name = name;
    }

    public decimal GetSize()
    {
        foreach (var item in _items)
        {
            _size += item.GetSize();
        }
        return _size;
    }

    public string GetName()
    {
        return _name;
    }

    public void Add(IFileSystemItem item)
    {
        _items.AddLast(item);
    }
}