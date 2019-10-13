using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textToSpeechWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
          

                string textInput; int type;
                SpeechSynthesizer S = new SpeechSynthesizer();
               // Console.WriteLine("Please Enter Voice type");
               // S.Speak("Please Enter Voice type. Press 1 to select female voice");

               // type = Int32.Parse(Console.ReadLine());
               // if (type == 1)
                    S.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1);
              //  else;

              //  Console.WriteLine("Please Enter text");
                S.Speak("Please Enter Text");
            textInput = text.Text;

                S.Speak(textInput);
                S.Pause();                                      //pausing the object
                S.Resume();                                     //resuming the object
                S.Speak("Thankyou for using this software developed by Prerna Sharma.!");
                S.Pause();                                      //pausing the object
                S.Resume();
                S.Speak("Have a nice day ahead");

                S.Dispose();                                    // to free the resources
              

            

}
    }
}
