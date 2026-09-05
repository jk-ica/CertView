using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using CertView.Models;

namespace CertView.Services;
 
internal class CertificateReaderService : ICertificateReaderService
{
    private CertificateInfo? ReadCertificateFromCer(FileInfo fileInfo)
    {
        try
        {
            throw new NotImplementedException("Reading from .cer files is not implemented yet.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading certificate from .cer file: {ex.Message}");
            return null;
        }
    }

    private CertificateInfo? ReadCertificateFromPfx(FileInfo fileInfo)
    {
        try
        {
            throw new NotImplementedException("Reading from .pfx files is not implemented yet.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading certificate from .pfx file: {ex.Message}");
            return null;
        }
    }
    public CertificateInfo? ReadCertificate(FileInfo fileInfo)
    {
        switch (fileInfo.Extension.ToLower())
        {
            case ".cer":
                return ReadCertificateFromCer(fileInfo);
            case ".pfx":
                return ReadCertificateFromPfx(fileInfo);
            default:
                throw new NotSupportedException($"File extension '{fileInfo.Extension}' is not supported.");
            }
        }

}
