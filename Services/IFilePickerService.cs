using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CertView.Services;

internal interface IFilePickerService
{
    public FileInfo? PickFile();
}
