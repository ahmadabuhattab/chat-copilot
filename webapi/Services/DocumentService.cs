using System.Collections.Generic;

public class DocumentService
{
    private readonly MemoryService _memoryService;

    public DocumentService(MemoryService memoryService)
    {
        _memoryService = memoryService;
    }

    public void UploadDocument(Document document)
    {
        // Ensure document is stored in memory correctly
        _memoryService.Store(document);
    }

    public Document GetDocument(string documentName)
    {
        // Retrieve document from memory
        var document = _memoryService.Retrieve(documentName);
        if (document == null)
        {
            throw new Exception($"Document {documentName} not found in memory.");
        }
        return document;
    }
}

public class Document
{
    public string Name { get; set; }
    public string Content { get; set; }
}
