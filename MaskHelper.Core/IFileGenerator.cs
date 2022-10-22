namespace MaskHelper.Core
{
    public interface IFileGenerator
    {
        Task GenerateFiles(string firstPath, string outputDirectory, int lastMask);
    }
}
