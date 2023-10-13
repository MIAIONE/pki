using UnisgnTrustedNetworkCertificates;

namespace Host;

internal class Program
{
    private static void Main(string[] args)
    {
        UTNCert.Install();
    }
}