using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CertView.Services;

internal class FilePickerService : IFilePickerService
{
    public FileInfo? PickFile()
    {
        var openFileDialog = new Microsoft.Win32.OpenFileDialog
        {
            Filter = "Certificate Files (*.pfx,*.cer)|*.pfx;*.cer|All Files (*.*)|*.*",
            Title = "Select a Certificate File"
        };

        return openFileDialog.ShowDialog() == true 
            ? new FileInfo(openFileDialog.FileName) 
            : null;
    }

}
