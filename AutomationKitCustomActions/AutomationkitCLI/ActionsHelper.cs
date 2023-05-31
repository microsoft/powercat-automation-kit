using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Security;

namespace AutomationkitCLI
{
    internal static class ActionsHelper
    {
        /// <summary>
        /// Creates a certificate with the given name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static X509Certificate2 CreateCertificate(string name, SecureString password)
        {
            string certificateName = name;

            // Create a new RSA key pair
            RSA rsa = RSA.Create();

            // Generate a certificate request
            CertificateRequest request = new CertificateRequest($"CN={certificateName}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            // Set certificate usage to code signing
            request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature, false));
            request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(new OidCollection { new Oid("1.3.6.1.5.5.7.3.3") }, false));

            // Create a self-signed certificate valid for one year
            DateTimeOffset startDate = DateTimeOffset.Now.AddDays(-1);
            DateTimeOffset expiryDate = startDate.AddYears(1);
            X509Certificate2 certificate = request.CreateSelfSigned(startDate, expiryDate);

            // Make the private key exportable
            byte[] exportedCertificate = certificate.Export(X509ContentType.Pfx, password);

            // Create a new X509Certificate2 object from the exported bytes and the secure password
            X509Certificate2 exportedCert = new X509Certificate2(exportedCertificate, password, X509KeyStorageFlags.Exportable);

            // Display the thumbprint of the created certificate
            return exportedCert;
        }

        internal static void ImportCertificateToTrustRoot(X509Certificate2 certificate)
        {
            // Open the local machine certificate store
            X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);

            try
            {
                // Add the certificate to the store
                store.Add(certificate);
                Console.WriteLine("Certificate imported successfully to trust root.");
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Failed to import certificate to trust root: {ex.Message}");
            }
            finally
            {
                // Close the certificate store
                store.Close();
            }
        }


    }
}
