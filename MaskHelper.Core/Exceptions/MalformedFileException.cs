using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskHelper.Core.Exceptions
{
    public class MalformedFileException : MaskHelperException
    {
        public string FilePath { get; }

        public MalformedFileException(string filePath, string message)
            : base(message)
        {
            FilePath = filePath;
        }
    }
}
