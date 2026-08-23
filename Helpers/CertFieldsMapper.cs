using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;
using CertView.Models;

namespace CertView.Helpers
{
    internal class CertFieldsMapper
    {
        public record CertificateField(string Name, string Value);

        public static List<CertificateField> Map(CertificateInfo certificateInfo)
        {
            return certificateInfo.GetType().GetProperties()
                .Select(prop => new CertificateField(prop.Name, prop.GetValue(certificateInfo)?.ToString() ?? string.Empty))
                .ToList();
        }

    }
}
