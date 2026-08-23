using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CertView.Models;

namespace CertView.Services;

internal interface ICertificateReaderService
{
    public CertificateInfo? ReadCertificate(FileInfo fileInfo);
}
