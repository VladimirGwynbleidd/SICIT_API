using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace SICIT.API.UTILITIES
{
    public class Cifrado
    {

        const string C_IV = "I7a1N/aD2Zkn0tX3tbqnIw==";
        static string configurationDecryptionKey = Environment.GetEnvironmentVariable("consarkey");
        //static string configurationDecryptionKey = "lBz8YWVwX7grF/8HfFu4Q0Rar6QRfsF1hpG7W1qdioM=";

        public static string Desencriptar(string strValor)
        {
            try
            {

                byte[] message = Convert.FromBase64String(strValor);
                byte[] iv = Convert.FromBase64String(C_IV);
                byte[] key = Convert.FromBase64String(configurationDecryptionKey);

                using (AesManaged aesAlg = new AesManaged())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(message))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar el método Desencriptar: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return string.Empty;
        }


        public static string Encriptar(string strValor)
        {
            try
            {
                byte[] iv = Convert.FromBase64String(C_IV);
                byte[] key = Convert.FromBase64String(configurationDecryptionKey);

                using (AesManaged aesAlg = new AesManaged())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(strValor);
                            }
                            var encrypted = msEncrypt.ToArray();
                            return Convert.ToBase64String(encrypted);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar el método Encriptar: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return string.Empty;
        }

    }
}
