using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Diagnostics;

namespace CertView.Helpers;

internal class FieldGetter
{

    public static string? GetSubjectField(X509Certificate2 cert, string oid)
    {
        return cert.SubjectName
        .EnumerateRelativeDistinguishedNames()
        .Where(x => !x.HasMultipleElements)
        .FirstOrDefault(x => x.GetSingleElementType().Value == oid)
        ?.GetSingleElementValue();
    }

    public static X509Extension? GetExtension(X509Certificate2 cert, string oid)
    {
        return cert.Extensions.FirstOrDefault(x => x.Oid?.Value == oid);
    }
}
