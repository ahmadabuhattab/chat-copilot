using System.Collections.Generic;

public class MemoryService
{
    private readonly Dictionary<string, string> _memory;

    public MemoryService()
    {
        _memory = new Dictionary<string, string>();
    }

    public void Store(Document document)
    {
        _memory[document.Name] = document.Content;
    }

    public Document Retrieve(string documentName)
    {
        _memory.TryGetValue(documentName, out var content);
        return content != null ? new Document { Name = documentName, Content = content } : null;
    }
}
