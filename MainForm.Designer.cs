namespace RSA_Cipher
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.LabelP = new System.Windows.Forms.Label();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.TextBoxQ = new System.Windows.Forms.TextBox();
            this.LabelQ = new System.Windows.Forms.Label();
            this.ButtonCalcParameters = new System.Windows.Forms.Button();
            this.LabelD = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.LabelE = new System.Windows.Forms.Label();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCipher = new System.Windows.Forms.Label();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxEuler = new System.Windows.Forms.TextBox();
            this.EulerLabel = new System.Windows.Forms.Label();
            this.RPanel = new System.Windows.Forms.Panel();
            this.LabelR = new System.Windows.Forms.Label();
            this.TextBoxR = new System.Windows.Forms.TextBox();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFilePlain = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFilePlain = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LabelChooseMode = new System.Windows.Forms.Label();
            this.RadioButtonDecipher = new System.Windows.Forms.RadioButton();
            this.RadioButtonCipher = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.RPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelP
            // 
            this.LabelP.Location = new System.Drawing.Point(6, 38);
            this.LabelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(144, 34);
            this.LabelP.TabIndex = 1;
            this.LabelP.Text = "P:";
            // 
            // TextBoxP
            // 
            this.TextBoxP.Location = new System.Drawing.Point(45, 34);
            this.TextBoxP.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(266, 34);
            this.TextBoxP.TabIndex = 2;
            this.TextBoxP.TextChanged += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxQ
            // 
            this.TextBoxQ.Location = new System.Drawing.Point(45, 82);
            this.TextBoxQ.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxQ.Name = "TextBoxQ";
            this.TextBoxQ.Size = new System.Drawing.Size(266, 34);
            this.TextBoxQ.TabIndex = 4;
            this.TextBoxQ.TextChanged += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LabelQ
            // 
            this.LabelQ.Location = new System.Drawing.Point(6, 87);
            this.LabelQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(144, 34);
            this.LabelQ.TabIndex = 3;
            this.LabelQ.Text = "Q:";
            // 
            // ButtonCalcParameters
            // 
            this.ButtonCalcParameters.Location = new System.Drawing.Point(11, 136);
            this.ButtonCalcParameters.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCalcParameters.Name = "ButtonCalcParameters";
            this.ButtonCalcParameters.Size = new System.Drawing.Size(300, 44);
            this.ButtonCalcParameters.TabIndex = 7;
            this.ButtonCalcParameters.Text = "Рассчитать параметры";
            this.ButtonCalcParameters.UseVisualStyleBackColor = true;
            this.ButtonCalcParameters.Click += new System.EventHandler(this.ButtonCalcParameters_Click);
            // 
            // LabelD
            // 
            this.LabelD.Location = new System.Drawing.Point(5, 201);
            this.LabelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(226, 34);
            this.LabelD.TabIndex = 8;
            this.LabelD.Text = "Приватный ключ D:";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(255, 198);
            this.TextBoxD.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(353, 34);
            this.TextBoxD.TabIndex = 9;
            this.TextBoxD.TextChanged += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxE
            // 
            this.TextBoxE.Location = new System.Drawing.Point(255, 240);
            this.TextBoxE.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxE.Multiline = true;
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.ReadOnly = true;
            this.TextBoxE.Size = new System.Drawing.Size(353, 34);
            this.TextBoxE.TabIndex = 14;
            // 
            // LabelE
            // 
            this.LabelE.Location = new System.Drawing.Point(4, 243);
            this.LabelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelE.Name = "LabelE";
            this.LabelE.Size = new System.Drawing.Size(227, 37);
            this.LabelE.TabIndex = 15;
            this.LabelE.Text = "Публичный ключ E:";
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(10, 348);
            this.PlainText.Margin = new System.Windows.Forms.Padding(4);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.ReadOnly = true;
            this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainText.Size = new System.Drawing.Size(471, 165);
            this.PlainText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Исходный текст:";
            // 
            // LabelCipher
            // 
            this.LabelCipher.Location = new System.Drawing.Point(501, 310);
            this.LabelCipher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCipher.Name = "LabelCipher";
            this.LabelCipher.Size = new System.Drawing.Size(264, 34);
            this.LabelCipher.TabIndex = 18;
            this.LabelCipher.Text = "Зашифрованный текст:";
            // 
            // CipherText
            // 
            this.CipherText.Location = new System.Drawing.Point(506, 348);
            this.CipherText.Margin = new System.Windows.Forms.Padding(4);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherText.Size = new System.Drawing.Size(463, 165);
            this.CipherText.TabIndex = 19;
            // 
            // ButtonResult
            // 
            this.ButtonResult.Enabled = false;
            this.ButtonResult.Location = new System.Drawing.Point(757, 213);
            this.ButtonResult.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(212, 61);
            this.ButtonResult.TabIndex = 20;
            this.ButtonResult.Text = "Зашифровать";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonClear.Enabled = false;
            this.ButtonClear.Location = new System.Drawing.Point(334, 136);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(212, 44);
            this.ButtonClear.TabIndex = 22;
            this.ButtonClear.Text = "Очистить поля";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.RPanel);
            this.panel3.Location = new System.Drawing.Point(334, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 87);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextBoxEuler);
            this.panel2.Controls.Add(this.EulerLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 40);
            this.panel2.TabIndex = 27;
            // 
            // TextBoxEuler
            // 
            this.TextBoxEuler.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextBoxEuler.Location = new System.Drawing.Point(83, 0);
            this.TextBoxEuler.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEuler.Multiline = true;
            this.TextBoxEuler.Name = "TextBoxEuler";
            this.TextBoxEuler.ReadOnly = true;
            this.TextBoxEuler.Size = new System.Drawing.Size(309, 40);
            this.TextBoxEuler.TabIndex = 13;
            // 
            // EulerLabel
            // 
            this.EulerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EulerLabel.Location = new System.Drawing.Point(0, 0);
            this.EulerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EulerLabel.Name = "EulerLabel";
            this.EulerLabel.Size = new System.Drawing.Size(68, 40);
            this.EulerLabel.TabIndex = 12;
            this.EulerLabel.Text = "φ(R):";
            // 
            // RPanel
            // 
            this.RPanel.Controls.Add(this.LabelR);
            this.RPanel.Controls.Add(this.TextBoxR);
            this.RPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RPanel.Location = new System.Drawing.Point(0, 0);
            this.RPanel.Name = "RPanel";
            this.RPanel.Size = new System.Drawing.Size(392, 36);
            this.RPanel.TabIndex = 26;
            // 
            // LabelR
            // 
            this.LabelR.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelR.Location = new System.Drawing.Point(0, 0);
            this.LabelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(33, 36);
            this.LabelR.TabIndex = 8;
            this.LabelR.Text = "R:";
            // 
            // TextBoxR
            // 
            this.TextBoxR.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextBoxR.Location = new System.Drawing.Point(83, 0);
            this.TextBoxR.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.ReadOnly = true;
            this.TextBoxR.Size = new System.Drawing.Size(309, 34);
            this.TextBoxR.TabIndex = 7;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFilePlain,
            this.OpenFileCipher});
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(217, 26);
            this.OpenFile.Text = "Открыть файл";
            // 
            // OpenFilePlain
            // 
            this.OpenFilePlain.Name = "OpenFilePlain";
            this.OpenFilePlain.Size = new System.Drawing.Size(211, 26);
            this.OpenFilePlain.Text = "Исходный текст";
            this.OpenFilePlain.Click += new System.EventHandler(this.OpenFilePlain_Click);
            // 
            // OpenFileCipher
            // 
            this.OpenFileCipher.Name = "OpenFileCipher";
            this.OpenFileCipher.Size = new System.Drawing.Size(211, 26);
            this.OpenFileCipher.Text = "Зашифрованный";
            this.OpenFileCipher.Click += new System.EventHandler(this.OpenFileCipher_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFilePlain,
            this.SaveFileCipher});
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(217, 26);
            this.SaveFile.Text = "Сохранить в файл";
            // 
            // SaveFilePlain
            // 
            this.SaveFilePlain.Name = "SaveFilePlain";
            this.SaveFilePlain.Size = new System.Drawing.Size(211, 26);
            this.SaveFilePlain.Text = "Исходный";
            this.SaveFilePlain.Click += new System.EventHandler(this.SaveFilePlain_Click);
            // 
            // SaveFileCipher
            // 
            this.SaveFileCipher.Name = "SaveFileCipher";
            this.SaveFileCipher.Size = new System.Drawing.Size(211, 26);
            this.SaveFileCipher.Text = "Зашифрованный";
            this.SaveFileCipher.Click += new System.EventHandler(this.SaveFileCipher_Click);
            // 
            // ClearStrip
            // 
            this.ClearStrip.Name = "ClearStrip";
            this.ClearStrip.Size = new System.Drawing.Size(14, 24);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(986, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LabelChooseMode
            // 
            this.LabelChooseMode.Location = new System.Drawing.Point(763, 38);
            this.LabelChooseMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChooseMode.Name = "LabelChooseMode";
            this.LabelChooseMode.Size = new System.Drawing.Size(223, 34);
            this.LabelChooseMode.TabIndex = 29;
            this.LabelChooseMode.Text = "Выберите режим:";
            // 
            // RadioButtonDecipher
            // 
            this.RadioButtonDecipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonDecipher.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonDecipher.Location = new System.Drawing.Point(777, 90);
            this.RadioButtonDecipher.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonDecipher.Name = "RadioButtonDecipher";
            this.RadioButtonDecipher.Size = new System.Drawing.Size(156, 35);
            this.RadioButtonDecipher.TabIndex = 28;
            this.RadioButtonDecipher.Text = "Дешифрация";
            this.RadioButtonDecipher.UseVisualStyleBackColor = true;
            this.RadioButtonDecipher.CheckedChanged += new System.EventHandler(this.RadioButtonDecipher_CheckedChanged);
            // 
            // RadioButtonCipher
            // 
            this.RadioButtonCipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonCipher.Checked = true;
            this.RadioButtonCipher.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonCipher.Location = new System.Drawing.Point(777, 63);
            this.RadioButtonCipher.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonCipher.Name = "RadioButtonCipher";
            this.RadioButtonCipher.Size = new System.Drawing.Size(156, 35);
            this.RadioButtonCipher.TabIndex = 27;
            this.RadioButtonCipher.TabStop = true;
            this.RadioButtonCipher.Text = "Шифрация";
            this.RadioButtonCipher.UseVisualStyleBackColor = true;
            this.RadioButtonCipher.CheckedChanged += new System.EventHandler(this.RadioButtonCipher_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(986, 532);
            this.Controls.Add(this.LabelChooseMode);
            this.Controls.Add(this.RadioButtonDecipher);
            this.Controls.Add(this.RadioButtonCipher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.LabelCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.LabelE);
            this.Controls.Add(this.TextBoxE);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.LabelD);
            this.Controls.Add(this.ButtonCalcParameters);
            this.Controls.Add(this.TextBoxQ);
            this.Controls.Add(this.LabelQ);
            this.Controls.Add(this.TextBoxP);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA шифратор";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.RPanel.ResumeLayout(false);
            this.RPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;

        private System.Windows.Forms.Button ButtonResult;

        private System.Windows.Forms.TextBox PlainText;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCipher;

        private System.Windows.Forms.TextBox CipherText;

        private System.Windows.Forms.Label LabelD;

        private System.Windows.Forms.TextBox TextBoxD;

        private System.Windows.Forms.TextBox TextBoxE;

        private System.Windows.Forms.Label LabelE;

        private System.Windows.Forms.Button ButtonCalcParameters;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.TextBox TextBoxQ;
        private System.Windows.Forms.Label LabelQ;

        #endregion
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxEuler;
        private System.Windows.Forms.Label EulerLabel;
        private System.Windows.Forms.Panel RPanel;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem ClearStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label LabelChooseMode;
        private System.Windows.Forms.RadioButton RadioButtonDecipher;
        private System.Windows.Forms.RadioButton RadioButtonCipher;
        private System.Windows.Forms.ToolStripMenuItem OpenFilePlain;
        private System.Windows.Forms.ToolStripMenuItem OpenFileCipher;
        private System.Windows.Forms.ToolStripMenuItem SaveFilePlain;
        private System.Windows.Forms.ToolStripMenuItem SaveFileCipher;
    }
}