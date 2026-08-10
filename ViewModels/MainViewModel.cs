using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CertView.ViewModels
{
    public class MainViewModel
    {
        public string? FilePath { get; set; }
        public FileInfo? File { get; set; }
        public bool IsFilePicked => File != null;
        

    }
}
