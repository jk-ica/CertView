using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CertView.Helpers;

namespace CertView.Models;

internal class CertificateInfo
{
    #region Certificate Fields  
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
    #endregion
    public CertificateInfo() { }
    public CertificateInfo(X509Certificate2 certificate)
    {
        GivenName = FieldGetter.GetSubjectField(certificate, "2.5.4.42");
        SurName = FieldGetter.GetSubjectField(certificate, "2.5.4.4");
        CountryName = FieldGetter.GetSubjectField(certificate, "2.5.4.6");
        OrganizationName = FieldGetter.GetSubjectField(certificate, "2.5.4.10");
        OrganizationIdentifier = FieldGetter.GetSubjectField(certificate, "2.5.4.9");
        OrganizationalUnitNames = FieldGetter.GetSubjectField(certificate, "2.5.4.11")?.Split(',');
        Title = FieldGetter.GetSubjectField(certificate, "2.5.4.12")?.Split(',');
        Issuer = certificate.Issuer;
        NotBefore = certificate.NotBefore;
        NotAfter = certificate.NotAfter;
    }

}
