using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CertView.Models;

internal class CertificateInfo
{
    public string? GivenName { get; set; }
    public string? SurName { get; set; }
    public string? CountryName { get; set; }
    public string? OrganizationName { get; set; }
    public string? OrganizationIdentifier { get; set; }
    public string[]? OrganizationalUnitNames { get; set; }
    public string[]? Title { get; set; }
    public string? Issuer { get; set; }
    public DateTime NotBefore { get; set; }
    public DateTime NotAfter { get; set; }

}
