using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordgenerator
{
    class Translator
    {
        public string
            lblMinimum,
            lblMaximum,
            checkIncludeUppercase,
            checkIncludeLowercase,
            checkIncludeNumbers,
            checkIncludeSymbols,
            checkIncludeSimilar,
            lblLength,
            btnGenerate,
            msgCheck,
            passwordGenerator,
            btnCopy,
            msgGenerate,
            msgCopied;

        public void SelectLanguage(string language)
        {
            if (language == "turkish")
            {
                lblMinimum = "En az: ";
                lblMaximum = "En çok: ";
                checkIncludeUppercase = "Büyük harf kullan";
                checkIncludeLowercase = "Küçük harf kullan";
                checkIncludeNumbers = "Rakam kullan";
                checkIncludeSymbols = "Sembol kullan";
                checkIncludeSimilar = "Benzer karakterler kullan (I, O, l) (büyük ı, büyük o, küçük L)";
                lblLength = "Şifre uzunluğu";
                btnGenerate = "Şifre Oluştur";
                msgCheck = "Lütfen en az bir karakter seti seçin.";
                passwordGenerator = "Şifre Oluşturucu";
                btnCopy = "Kopyala";
                msgGenerate = "Lütfen önce şifre oluşturun.";
                msgCopied = "Şifre kopyalandı.";
            }
            else if (language == "english")
            {
                lblMinimum = "Minimum: ";
                lblMaximum = "Maximum: ";
                checkIncludeUppercase = "Use uppercase";
                checkIncludeLowercase = "Use lowercase";
                checkIncludeNumbers = "Use numbers";
                checkIncludeSymbols = "Use symbols";
                checkIncludeSimilar = "Use similar characters and numbers (I, O, l) (big i, big o, small L)";
                lblLength = "Password length";
                btnGenerate = "Generate Password";
                msgCheck = "Please select a character set.";
                passwordGenerator = "Password Generator";
                btnCopy = "Copy";
                msgGenerate = "Please generate password.";
                msgCopied = "Password copied.";
            }
        }
    }
}
