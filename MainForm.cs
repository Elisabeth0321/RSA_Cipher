using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RSA_Cipher
{

    public partial class MainForm : Form
    {
        int R { get; set; }
        int FuncR { get; set; }
        int E { get; set; }
        int D { get; set; }

        byte[] OpenedPlainFileBytes { get; set; }
        byte[] OpenedCipherFileBytes { get; set; }

        ushort[] CipherResult { get; set; }
        byte[] DecipherResult { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void SanitizeInput()
        {
            TextBoxP.Text = string.Join("", TextBoxP.Text.Where(char.IsDigit));
            TextBoxQ.Text = string.Join("", TextBoxQ.Text.Where(char.IsDigit));
            TextBoxD.Text = string.Join("", TextBoxD.Text.Where(char.IsDigit));
        }

        private bool TryParsePrimes(out int p, out int q)
        {
            p = q = 0;

            if (TextBoxP.Text == "")
            {
                MessageBox.Show("Введите P", "Ошибка");
                return false;
            }

            if (TextBoxQ.Text == "")
            {
                MessageBox.Show("Введите Q", "Ошибка");
                return false;
            }

            try
            {
                p = int.Parse(TextBoxP.Text);
                if (!RSA.IsPrime(p))
                {
                    MessageBox.Show("Введённое P не является простым", "Ошибка");
                    return false;
                }

                q = int.Parse(TextBoxQ.Text);
                if (!RSA.IsPrime(q))
                {
                    MessageBox.Show("Введённое Q не является простым", "Ошибка");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Числа P и Q некорректны", "Ошибка");
                return false;
            }

            return true;
        }

        private bool TryCalculateRAndEuler(int p, int q)
        {
            R = p * q;
            if (R < 256 || R > ushort.MaxValue)
            {
                MessageBox.Show($"Произведение P и Q должно быть не меньше 256 и не больше {ushort.MaxValue}", "Ошибка");
                return false;
            }

            TextBoxR.Text = R.ToString();

            FuncR = RSA.CalcEulerPhi(R);
            TextBoxEuler.Text = FuncR.ToString();

            return true;
        }

        private bool TryParsePrivateKey()
        {
            if (TextBoxD.Text.Length == 0)
            {
                MessageBox.Show("Введите приватный ключ D", "Ошибка");
                return false;
            }

            D = int.Parse(TextBoxD.Text);
            if (D <= 1 || D >= FuncR)
            {
                MessageBox.Show("Введённый приватный ключ D должен быть больше 1 и меньше функции Эйлера", "Ошибка");
                return false;
            }

            return true;
        }

        private bool TryCalculatePublicKey()
        {
            int gcd = RSA.FindGcd(D, FuncR);
            if (gcd != 1)
            {
                MessageBox.Show("Вычисленный публичный ключ E должен быть взаимно простым с функцией Эйлера!", "Ошибка");
                return false;
            }

            var extendedEuclidResult = RSA.ExtendedEuclidean(FuncR, D);
            E = extendedEuclidResult.y;
            TextBoxE.Text = E.ToString();

            return true;
        }

        void ButtonCalcParameters_Click(object sender, EventArgs e)
        {
            SanitizeInput();

            if (!TryParsePrimes(out int p, out int q))
                return;

            if (!TryCalculateRAndEuler(p, q))
                return;

            if (!TryParsePrivateKey())
                return;

            if (!TryCalculatePublicKey())
                return;

            ButtonResult.Enabled = true;
        }

        private void Cipher()
        {
            if (PlainText.Text.Length == 0)
            {
                MessageBox.Show("Данные для шифровки отсутствуют", "Ошибка");
                return;
            }

            CipherResult = new ushort[OpenedPlainFileBytes.Length];
            for (int i = 0; i < CipherResult.Length; i++)
            {
                CipherResult[i] = OpenedPlainFileBytes[i];
            }

            for (int i = 0; i < CipherResult.Length; i++)
            {
                CipherResult[i] = (ushort)RSA.QuickPowerMod(CipherResult[i], E, R);
            }

            CipherText.Text = string.Join(" ", CipherResult);
        }

        public void Decipher()
        {
            if (CipherText.Text.Length == 0)
            {
                MessageBox.Show("Данные для расшифровки отсутствуют",
                    "Ошибка");
                return;
            }

            ushort[] tempShort = new ushort[CipherResult.Length];

            for (int i = 0; i < tempShort.Length; i++)
            {
                tempShort[i] = (ushort)RSA.QuickPowerMod(CipherResult[i], D, R);
            }

            DecipherResult = new byte[tempShort.Length];
            for (var index = 0; index < tempShort.Length; index++)
            {
                var item = tempShort[index];
                var bytes = BitConverter.GetBytes(item);
                if (!BitConverter.IsLittleEndian)
                    Array.Reverse(bytes);
                DecipherResult[index] = bytes[0];

            }

            PlainText.Text = string.Join(" ", tempShort);
        }

        void ButtonResult_Click(object sender, EventArgs e)
        {
            if (RadioButtonCipher.Checked)
            {
                Cipher();
            }

            if (RadioButtonDecipher.Checked)
            {
                Decipher();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxR.Clear();
            TextBoxEuler.Clear();
            TextBoxE.Clear();
            PlainText.Clear();
            CipherText.Clear();
            ButtonResult.Enabled = false;
        }

        void RadioButtonCipher_CheckedChanged(object sender, EventArgs e)
        {
            ButtonResult.Text = "Зашифровать";
            CipherText.Clear();
        }

        void RadioButtonDecipher_CheckedChanged(object sender, EventArgs e)
        {
            ButtonResult.Text = "Дешифровать";
            PlainText.Clear();
        }

        private void OpenFilePlain_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                OpenedPlainFileBytes = File.ReadAllBytes(OpenFileDialog.FileName);
                PlainText.Text = string.Join(" ", OpenedPlainFileBytes);
            }
        }

        private void OpenFileCipher_Click(object sender, EventArgs e)
        {

            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                OpenedCipherFileBytes = File.ReadAllBytes(OpenFileDialog.FileName);

                //Если в каком-то рандомном файле не кратное двум число байт
                if (OpenedCipherFileBytes.Length % 2 != 0)
                {
                    OpenedCipherFileBytes = OpenedCipherFileBytes.Append((byte)0).ToArray();
                }

                CipherResult = new ushort[OpenedCipherFileBytes.Length / 2];

                for (int i = 0; i < OpenedCipherFileBytes.Length; i += 2)
                {
                    byte[] bytes = new byte[] { OpenedCipherFileBytes[i], OpenedCipherFileBytes[i + 1] };
                    ushort combinedShort = BitConverter.ToUInt16(bytes, 0);
                    CipherResult[i / 2] = combinedShort;
                }

                CipherText.Text = string.Join(" ", CipherResult);  // 3e mod 5 = 1
            }
        }

        private void SaveFilePlain_Click(object sender, EventArgs e)
        {
            if (PlainText.Text.Length == 0)
            {
                MessageBox.Show("Поле пустое", "Внимание");
                return;
            }

            if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                File.WriteAllBytes(SaveFileDialog.FileName, DecipherResult);
            }
        }

        private void SaveFileCipher_Click(object sender, EventArgs e)
        {
            if (CipherText.Text.Length == 0)
            {
                MessageBox.Show("Поле пустое", "Внимание");
                return;
            }
            if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                using (FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create))
                {
                    foreach (var item in CipherResult)
                    {
                        byte[] bytes = BitConverter.GetBytes(item);
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }
            }
        }
    }
}