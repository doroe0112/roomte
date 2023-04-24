using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.VisualStyles;

namespace Voice_Recognition_Test1
{
    public partial class Form1 : Form
    {
        SerialPort port;
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine hearEngine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine tvEngine = new SpeechRecognitionEngine();
        bool lichtp = false;
        bool tmp = false;

        String gehört = "Abby";


        public Form1()
        {
            InitializeComponent();
            port = new SerialPort("COM7", 9600);//Set your board COM

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                port.Open();
            }
            catch
            {
                lblText.Text = "Port konnte nicht geöffnet werden. checke ob der Port " + "COM7" + " verbunden ist. Das Programm wird nicht funktionieren. es ist ein Neustart erforderlich";
            }


            //hearEngine
            GrammarBuilder hBuilder = new GrammarBuilder();
            hBuilder.Append(gehört);
            Grammar hgrammar = new Grammar(hBuilder);

            hearEngine.LoadGrammarAsync(hgrammar);
            hearEngine.SetInputToDefaultAudioDevice();
            hearEngine.SpeechRecognized += HearEngine_SpeechRecognized; 


             //recEngin
             Choices commands = new Choices();
            commands.Add(new string[] { "Fernseh", "Hoch", "Runter", "Musik", "lauter", "leiser", "mute", "effekt", "Eingang", "Licht", "fade", "jump", "blau", "rot", "grün","abbrechen" });

            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

            //tvEngine+
            Choices tvcommands = new Choices();
            tvcommands.Add(new string[] { "An", "Aus", "Home", "Quelle" });
            
            GrammarBuilder tvBuilder = new GrammarBuilder();
            tvBuilder.Append(tvcommands);
            Grammar tvgrammar = new Grammar(tvBuilder);

            tvEngine.LoadGrammarAsync(tvgrammar);
            tvEngine.SetInputToDefaultAudioDevice();
            tvEngine.SpeechRecognized += TvEngine_SpeechRecognized;
            
        }


        private void btnEin_Click_1(object sender, EventArgs e)
        {
            hearEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnEin.Enabled = false;
            btnAus.Enabled = true;
            lblText.Text = "Sprachsteuerung gestartet";
            //port.Open();
        }

        private void btnAus_Click_1(object sender, EventArgs e)
        {
            hearEngine.RecognizeAsyncStop();
            //recEngine.RecognizeAsyncStop();
            btnEin.Enabled = true;
            btnAus.Enabled = false;
            port.Close();
        }



        //hearEngine
        private void HearEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == gehört)
            {
                lblText.Text = gehört;
                //port.Write("3");        //muted
                //System.Threading.Thread.Sleep(2400);

                /*if (lichtp == false)
                { 
                    port.Write("32");   //wenn Licht aus is wirds angemacht
                    tmp = true;
                    System.Threading.Thread.Sleep(2400);
                }
                port.Write("42");       //grünes licht4
               */ hearEngine.RecognizeAsyncStop();
                System.Threading.Thread.Sleep(200);
                recEngine.RecognizeAsync(RecognizeMode.Multiple);

            }
        }

        //recEngine
        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Random var = new Random();
            //throw new NotImplementedException();
            lblText.Text = ("sendet..." + Convert.ToString(var.Next(-100, 100)));
            bool f = false;


            switch (e.Result.Text)
            {
                case "Fernseh":
                    recEngine.RecognizeAsyncStop();
                    lblText.Text = "Fernseh";
                    tvEngine.RecognizeAsync(RecognizeMode.Multiple);
                    f = true;
                    break;

                case "Hoch":
                    port.Write("2");
                    break;

                case "Runter":
                    port.Write("3");
                    break;

                case "Musik":
                    port.Write("1");
                    break;

                case "lauter":
                    port.Write("6");
                    break;

                case "leiser":
                    port.Write("7");
                    break;

                case "mute":
                    port.Write("3");
                    break;

                case "effekt":
                    port.Write("5");
                    break;

                case "Eingang":
                    port.Write("2");
                    break;

                case "Licht":
                    port.Write("32");
                    tmp = false;
                    break;

                case "fade":
                    port.Write("39");
                    tmp = false;
                    break;

                case "jump":
                    port.Write("38");
                    tmp = false;
                    break;

                case "blau":
                    port.Write("42");
                    tmp = false;
                    break;

                case "rot":
                    port.Write("43");
                    tmp = false;
                    break;

                case "grün":
                    port.Write("41");
                    break;








                case "abbrechen":
                    break;
                    /*
                case "":
                    port.Write("");
                    break;
                    */
            }

            if(f == false)
            {
                recEngine.RecognizeAsyncStop();
                hearEngine.RecognizeAsync(RecognizeMode.Multiple);
                if (tmp == true)
                    port.Write("32");

            }
        }

        private void TvEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            lblText.Text = "TV hört";
            switch(e.Result.Text)
            {
                case ("An"):
                    port.Write("1");
                    lblText.Text = ("gesendet");
                    break;

                case ("Aus"):
                    port.Write("8");
                    break;

                case ("Home"):
                    port.Write("22");
                    break;
                case ("Quelle"):
                    port.Write("9");
                    break;

                    
            }
            tvEngine.RecognizeAsyncStop();
            hearEngine.RecognizeAsync(RecognizeMode.Multiple);
            lblText.Text = "Gesendet";
        }




        private void btnSetup_Click(object sender, EventArgs e)
        {
            int delay = 255;
            port.Write("1");
            System.Threading.Thread.Sleep(delay);
            port.Write("2");
            System.Threading.Thread.Sleep(delay);
            port.Write("3");
            System.Threading.Thread.Sleep(delay);
            port.Write("4");
            System.Threading.Thread.Sleep(delay);
            port.Write("5");
            System.Threading.Thread.Sleep(delay);
            port.Write("6");
            System.Threading.Thread.Sleep(delay);
            port.Write("7");
            System.Threading.Thread.Sleep(delay);
            port.Write("8");
            System.Threading.Thread.Sleep(delay);
            port.Write("9");
            System.Threading.Thread.Sleep(delay);
            port.Write("10");
            System.Threading.Thread.Sleep(delay);
            port.Write("11");
            System.Threading.Thread.Sleep(delay);
            port.Write("12");
            System.Threading.Thread.Sleep(delay);
            port.Write("13");
            System.Threading.Thread.Sleep(delay);
            port.Write("14");
            System.Threading.Thread.Sleep(delay);
            port.Write("15");
            System.Threading.Thread.Sleep(delay);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private void btnSetup_Click_1(object sender, EventArgs e)
        {
            int delay = 255;
            port.Write("1");
            System.Threading.Thread.Sleep(delay);
            port.Write("2");
            System.Threading.Thread.Sleep(delay);
            port.Write("3");
            System.Threading.Thread.Sleep(delay);
            port.Write("4");
            System.Threading.Thread.Sleep(delay);
            port.Write("5");
            System.Threading.Thread.Sleep(delay);
            port.Write("6");
            System.Threading.Thread.Sleep(delay);
            port.Write("7");
            System.Threading.Thread.Sleep(delay);
            port.Write("8");
            System.Threading.Thread.Sleep(delay);
            port.Write("9");
            System.Threading.Thread.Sleep(delay);
            port.Write("10");
            System.Threading.Thread.Sleep(delay);
            port.Write("11");
            Sys
            
            
             tem.Threading.Thread.Sleep(delay);
            port.Write("12");
            System.Threading.Thread.Sleep(delay);
            port.Write("13");
            System.Threading.Thread.Sleep(delay);
            port.Write("14");
            System.Threading.Thread.Sleep(delay);
            port.Write("15");
            System.Threading.Thread.Sleep(delay);

        }
    }
}
