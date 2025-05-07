namespace session38_50.Models;

public class FileUploadSettings
{
    public long MaxSizeFile { get; set; }
    public string[] AllowedExtensions { get; set; }
    public string UploadPath { get; set; }
}


public class UploadResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public string FilePath { get; set; }
}