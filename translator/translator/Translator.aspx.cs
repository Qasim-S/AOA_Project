using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace translator
{
    public partial class Translator : System.Web.UI.Page
    {
        Dictionary dic;
        protected void Page_Load(object sender, EventArgs e)
        {
            dic = new Dictionary();
        }

        protected void btnTranslate_Click(object sender, EventArgs e)
        {
            string translatedText = "";
  
            int loopCount = 0;
  
            string wordToBeTranslated = "";

            string inputString = txtInputString.Text += " ";

            while (loopCount < inputString.Length)
            {
  
                wordToBeTranslated = wordToBeTranslated += inputString[loopCount];

                if (inputString[loopCount] == ' '){
                    wordToBeTranslated = wordToBeTranslated.Substring(0, (wordToBeTranslated.Length - 1));
                    string[] translatedWord = new string[2];
                    translatedWord = dic.search(wordToBeTranslated);
                    wordToBeTranslated = "";

                    if (translatedWord[0] == ""){
                        txtOutputString.Text = "Text contains unfamiliar words!";
                        return;
                    }

                    translatedText += " ";
                    translatedText += translatedWord[0];
                }
                loopCount++;

            }
            txtOutputString.Text = translatedText;
        }
    }
}