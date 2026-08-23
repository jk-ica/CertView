using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CertView.Models;

namespace CertView.Services
{
    internal class DummyReaderService : ICertificateReaderService
    {
        public CertificateInfo? ReadCertificate(FileInfo fileInfo)
        {
            return new CertificateInfo
            {
                GivenName = "John",
                SurName = "Doe",
                CountryName = "US",
                OrganizationName = "Example Corp",
                OrganizationIdentifier = "123456789",
                OrganizationalUnitNames = new[] { "IT", "Security" },
                Title = new[] { "Engineer", "Developer" },
                Issuer = "Example CA",
                NotBefore = DateTime.UtcNow.AddYears(-1),
                NotAfter = DateTime.UtcNow.AddYears(1)
            };
        }
    }
}
