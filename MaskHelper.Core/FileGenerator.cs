using MaskHelper.Core.Exceptions;

namespace MaskHelper.Core
{
    public class FileGenerator : IFileGenerator
    {
        public async Task GenerateFiles(string firstPath, string outputDirectory, int lastMask)
        {
            var fileInfo = new FileInfo(firstPath);

            var filePrefix = GetNamePrefix(fileInfo.Name);

            var lines = await File.ReadAllLinesAsync(firstPath);

            if (lines.Length < 24 || !lines[23].StartsWith("MaskID="))
                throw new MalformedFileException(firstPath, "Expected line 24 to start with 'MaskID='.");

            var maskIdPrefix = GetNamePrefix(lines[23].Split('=')[1]);

            for (int i = 0; i < lastMask; i++)
            {
                lines[23] = $"MaskID={maskIdPrefix}_{FormatIdNumber(i + 1)}";

                await File.WriteAllLinesAsync(Path.Combine(outputDirectory, $"{filePrefix}_{FormatFileNumber(i + 1)}.apf"), lines);
            }
        }

        private string GetNamePrefix(string firstFileName)
        {
            var split = firstFileName.Split('_');

            return string.Join('_', split.Take(split.Length - 1));
        }

        private string FormatIdNumber(int index)
        {
            return Convert.ToString(index).PadLeft(2, '0');
        }

        private string FormatFileNumber(int index)
        {
            return Convert.ToString(index);
        }
    }
}
