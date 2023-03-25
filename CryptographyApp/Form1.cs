using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyApp
{
    public partial class Form1 : Form
    {
        private EncryptedPacket encryptedBlock;
        private RsaEncryption rsaParams;
        private DigitalSignature digitalSignature;

        public Form1()
        {
            InitializeComponent();
            encryptedBlock = new EncryptedPacket();
            rsaParams = new RsaEncryption();
            digitalSignature = new DigitalSignature();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string textToEncrypt = textToEncryptLB.Text;
            rsaParams.AssignNewKey();
            digitalSignature.AssignNewKey();

            try
            {
                encryptedBlock = HybridEncryption.EncryptData(Encoding.UTF8.GetBytes(textToEncrypt), rsaParams,
                    digitalSignature);

                textEncryptedLB.Text = Encoding.UTF8.GetString(encryptedBlock.EncryptedData);
                
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            var decrypted = HybridEncryption.DecryptData(encryptedBlock, rsaParams, digitalSignature);
            textDecryptedLB.Text = decrypted;
        }
    }
}
