using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordgenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string _Uppercase = "ABCDEFGHJKLMNPRSTUVYZXWQ";
        string _Lowercase = "abcdefghijkmnoprstuvyzxwq";
        string _Similar = "IOl";
        string _Numbers = "0123456789";
        string _Symbols = @"!@#$%&*()_-+={[}]|\:;'<,>.?/";
        string _Password = "";
        Random rnd = new Random();
        Translator _Translator = new Translator();

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkIncludeUppercase.Checked && !checkIncludeLowercase.Checked && !checkIncludeNumbers.Checked && !checkIncludeSymbols.Checked && !checkIncludeSimilar.Checked)
            {
                MessageBox.Show(_Translator.msgCheck, _Translator.passwordGenerator, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _Password = "";
                FillTempPass();
            }
        }

        private void FillTempPass()
        {
            string _TempPass = "";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (checkIncludeUppercase.Checked) { _TempPass += _Uppercase[rnd.Next(0, _Uppercase.Length)]; }
                if (checkIncludeLowercase.Checked) { _TempPass += _Lowercase[rnd.Next(0, _Lowercase.Length)]; }
                if (checkIncludeNumbers.Checked) { _TempPass += _Numbers[rnd.Next(0, _Numbers.Length)]; }
                if (checkIncludeSymbols.Checked) { _TempPass += _Symbols[rnd.Next(0, _Symbols.Length)]; }
                if (checkIncludeSimilar.Checked) { _TempPass += _Similar[rnd.Next(0, _Similar.Length)]; }
            }
            FillPass(_TempPass[rnd.Next(0, _TempPass.Length - 1)]);
        }
        private void FillPass(char _TempChar)
        {
            _Password += _TempChar;
            if (_Password.Length != numericUpDown1.Value)
            {
                FillTempPass();
            }
            else
            {
                textBox1.Text = _Password;
            }
        }

        private void BringLanguageButton(object sender, EventArgs e)
        {
            Button me = (Button)sender;
            if (me.Name == "btnTR") { _Translator.SelectLanguage("turkish"); }
            else if (me.Name == "btnEN") { _Translator.SelectLanguage("english"); }
            BringLanguage();
        }
        private void BringLanguage()
        {
            lblMinimum.Text = _Translator.lblMinimum + "8";
            lblMaximum.Text = _Translator.lblMaximum + numericUpDown1.Maximum.ToString();
            checkIncludeUppercase.Text = _Translator.checkIncludeUppercase;
            checkIncludeLowercase.Text = _Translator.checkIncludeLowercase;
            checkIncludeNumbers.Text = _Translator.checkIncludeNumbers;
            checkIncludeSymbols.Text = _Translator.checkIncludeSymbols;
            checkIncludeSimilar.Text = _Translator.checkIncludeSimilar;
            lblLength.Text = _Translator.lblLength;
            btnGenerate.Text = _Translator.btnGenerate;
            this.Text = _Translator.passwordGenerator;
            btnCopy.Text = _Translator.btnCopy;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _Translator.SelectLanguage("english");
            BringLanguage();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) { Clipboard.SetText(textBox1.Text); MessageBox.Show(_Translator.msgCopied, _Translator.passwordGenerator, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else { MessageBox.Show(_Translator.msgGenerate, _Translator.passwordGenerator, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
