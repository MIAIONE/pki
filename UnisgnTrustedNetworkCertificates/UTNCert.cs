using Microsoft.Win32;

namespace UnisgnTrustedNetworkCertificates;

public static class UTNCert
{
    public static string UTNVersion => "Ver 2023.EVTrust";

    public static bool Install()
    {
        try
        {
            InstallRootCA();
            InstallPartnerCA();
            InstallThirdCA();
            InstallTimestampCA();
            return true;
        }
        catch// (Exception ex)
        {
            //Console.WriteLine(ex);
            return false;
        }
    }

    private static void InstallRootCA()
    {
        Registry.LocalMachine.CreateSubKey(
            @"SOFTWARE\Microsoft\SystemCertificates\ROOT\Certificates\C87AB0C1C4E19A9A39002B65A06A03A3D015C363",
            RegistryKeyPermissionCheck.ReadWriteSubTree
            )
            .SetValue("Blob", Properties.Resources.RootCA, RegistryValueKind.Binary);
    }

    private static void InstallPartnerCA()
    {
        Registry.LocalMachine.CreateSubKey(
            @"SOFTWARE\Microsoft\SystemCertificates\CA\Certificates\E14FFF255232EB1BF846408F56F3A07D64FB3DE1",
            RegistryKeyPermissionCheck.ReadWriteSubTree
            )
            .SetValue("Blob", Properties.Resources.PartnerCA, RegistryValueKind.Binary);
    }

    private static void InstallThirdCA()
    {
        Registry.LocalMachine.CreateSubKey(
            @"SOFTWARE\Microsoft\SystemCertificates\CA\Certificates\1EBDE475DE77288491C1A51FBE7B2A4CD60BF4B2",
            RegistryKeyPermissionCheck.ReadWriteSubTree
            )
            .SetValue("Blob", Properties.Resources.ThirdCA, RegistryValueKind.Binary);
    }

    private static void InstallTimestampCA()
    {
        Registry.LocalMachine.CreateSubKey(
            @"SOFTWARE\Microsoft\SystemCertificates\CA\Certificates\299D1DD5D194C2C208BBA02678251E05CC061ECA",
            RegistryKeyPermissionCheck.ReadWriteSubTree
            )
            .SetValue("Blob", Properties.Resources.TimestampCA, RegistryValueKind.Binary);
    }
}