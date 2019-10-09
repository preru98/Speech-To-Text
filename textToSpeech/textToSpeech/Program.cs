using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textToSpeech
{
    class Program
    {
        static void Main(string[] args)
        {
            String text;
            SpeechSynthesizer S = new SpeechSynthesizer();
            S.SetOutputToDefaultAudioDevice();
            Console.WriteLine("Enter the text");
            S.Speak("Enter the text");
            text=Console.ReadLine();
            S.Speak(text);
            Console.Read();


        }
    }
}
