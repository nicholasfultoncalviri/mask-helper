namespace MaskHelper.Core.FileSystem
{
    public interface IFileWrapper
    {
        DirectoryInfo? GetParentDirectory(FileInfo file);

        string[] ReadFileLines(string filePath);

        
    }
}
