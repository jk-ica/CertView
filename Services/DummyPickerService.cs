using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CertView.Services
{
    internal class DummyPickerService : IFilePickerService
    {
        public FileInfo? PickFile()
        {
            // Return a dummy file path for testing purposes
            return new FileInfo("C:\\path\\to\\dummy.pfx");
        }
    }
}
