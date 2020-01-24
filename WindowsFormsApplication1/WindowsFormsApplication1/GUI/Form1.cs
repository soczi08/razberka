using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using WindowsFormsApplication1.Factory;
using WindowsFormsApplication1.BehaviourOverseer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Dictionary<string, Image> _imageRepository = new Dictionary<string, Image>();

        private bool _onOff;
        IList<string> _stringi = new List<string>();
        Stack<DateTime> _stos = new Stack<DateTime>();

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(InputChannel inputChannel)
        {
            InitializeComponent();
            InputChannel = inputChannel;
            _imageRepository = ImageDictionaryFactory.CreateImageDictiornary();
            UstwawTloWszystkichKontrolek();

            UtworzListeSektorow();

            CommunicationOverseer overseer = new CommunicationOverseer(this);
            CheckingBehaviourOverseer overseerc = new CheckingBehaviourOverseer(this);
            //panelSektorowAwarii.ItemCheck += ReakcjaNaZmianeCheckboxa;

            ConfigurationWindow configurationWindow = new ConfigurationWindow();
            configurationWindow.TopMost = true;
            configurationWindow.Show();

            panelSektorowAwarii.ItemCheck += Wysylanie_komunikatu_do_rpi;



            btnDebug.Click += delegate
            {
                CommunicationChannel.SendMessage(txtDebug.Text);
            };

            SetButtonOff();




            ////reakcja na dane wejśiowe
            //inputChannel.DataRecievedEvent += (sender, daneZrasberry) =>
            //{
            //    ReakcjNaDaneZRasberry(daneZrasberry);





            //    /*
            //    listBox1.DataSource = null;
            //    stringi.Add(data);
            //    listBox1.DataSource = stringi.Skip(Math.Max(0, stringi.Count() - 10)).ToList(); ;
            //    MojaBaza mb = new MojaBaza();
            //mb.Insert(new SqlCommand("INSERT INTO [dbo].[Events] ([Event]) VALUES ('XYZ')"));
            //    */
            //};

            /*
            MojaBaza mb = new MojaBaza();
            mb.Insert(new SqlCommand("INSERT INTO [dbo].[Events] ([Event]) VALUES ('XYZ')"));
            var x =mb.Select(new SqlCommand("select * from NumberofFailures"));
            */
            //   btnTestAddData.Click += delegate { inputChannel.OnDataRecieved(null, DateTime.Now.Minute +":"+ DateTime.Now.Second+ "." + DateTime.Now.Millisecond); };
            btnTestAddData.Click += delegate { inputChannel.OnDataRecieved(null, txtDebug.Text); };
            //panelSektorowAwarii.ItemCheck += (sender, args) =>
            //{
            //    var zmienionyIndex = args.Index;
            //    if (zmienionyIndex == 0)
            //    {
            //        if (args.NewValue == CheckState.Unchecked)
            //        {
            //            MessageBox.Show("Awaria potwierdzona");

            //            if (panel1.BackgroundImage == WindowsFormsApplication1.Properties.Resources._1awariapozycja)//to nie puszcza ALE TO TY DODALES Xd// a nie ma ten obrazek czasami a1
            //            {
            //                ZmienObrazSektora(PowiazanieIndexuzPanel(0), "pozycja1");
            //            }

            //            if (panel1.BackgroundImage == WindowsFormsApplication1.Properties.Resources._1awaria)
            //            {
            //                ZmienObrazSektora(PowiazanieIndexuzPanel(0), "pozycja1");
            //            }

            //        }

            //    }


            //};
            FormClosed += delegate { CommunicationChannel.EndCommunication(); };
        }


        public bool OnOff
        {
            get { return _onOff; }
            set { _onOff = value; SwitchButtonState(); }
        }

        public InputChannel InputChannel { get; }

        private void SwitchButtonState()
        {
            button4.BackColor = Color.Green;

            button1.BackColor = Color.Red;

            if (!OnOff)
            {

                // CommunicationChannel.SendMessage("A1:");
                button4.Enabled = false;
                button1.Enabled = true;
                button4.BackColor = Color.Green;
                button1.BackColor = Color.Black;

            }
            else
            {
                button4.Enabled = true;
                button1.Enabled = false;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Black;
            }


        }


        public void HandleError(int indexNaSektorzeAwarii, string rasberyMessage, string nazwaObrazka)
        {
            CzasOstatniegoOkrazenia(rasberyMessage);
            ZmienObrazSektora(PowiazanieIndexuzPanel(indexNaSektorzeAwarii), nazwaObrazka);
            panelSektorowAwarii.SetItemChecked(indexNaSektorzeAwarii, true);
        }

        public void CzasOstatniegoOkrazenia(string data)
        {


            TimeSpan differnce = new TimeSpan();
            _stos.Push(DateTime.Now);
            if (_stos.Count == 1) { return; }
            if (_stos.Count >= 2)
            {
                var top = _stos.Pop();
                var topminusone = _stos.Pop();
                _stos.Push(topminusone);
                _stos.Push(top);

                differnce = top.Subtract(topminusone);
                textBox2.Text = differnce.Seconds.ToString() + "." + differnce.Milliseconds.ToString();
            }


            /*
      
             MojaBaza mb = new MojaBaza();
            mb.Insert(new SqlCommand($"INSERT INTO [dbo].[Events] ([Event]) VALUES ({differnce})"));
             
    */
        }


        private void Wysylanie_komunikatu_do_rpi(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    CommunicationChannel.SendMessage("E0:");
                    break;
                case 1:
                    CommunicationChannel.SendMessage("E1:");
                    break;
                case 2:
                    CommunicationChannel.SendMessage("E2:");
                    break;
                case 3:
                    CommunicationChannel.SendMessage("E3:");
                    break;
                case 4:
                    CommunicationChannel.SendMessage("E4:");
                    break;
                case 5:
                    CommunicationChannel.SendMessage("E5:");
                    break;
                case 6:
                    CommunicationChannel.SendMessage("E6:");
                    break;
                case 7:
                    CommunicationChannel.SendMessage("E7:");
                    break;
                case 8:
                    CommunicationChannel.SendMessage("E8:");
                    break;
                case 9:
                    CommunicationChannel.SendMessage("E9:");
                    break;
                default:
                    Console.WriteLine("Kali murzyn");
                    break;
            }




        }

        //Funkcja tworząca listę sektorów
        private void UtworzListeSektorow()
        {
            for (int i = 1; i < 11; i++)
            {
                panelSektorowAwarii.Items.Add("sektor" + " " + i);
            }

        }
        //Funkcja tworząca tory        
        private void UstwawTloWszystkichKontrolek()
        {

            var lista = new List<Control>()
           {
               Controls["panel1"],
               Controls["panel2"],
               Controls["panel3"],
               Controls["panel4"],
               Controls["panel5"],
               Controls["panel6"],
               Controls["panel7"],
               Controls["panel8"],
               Controls["panel9"],
               Controls["panel10"],
           };


        }
        private void ReakcjaNaZmianeCheckboxa(object sender, ItemCheckEventArgs e)
        {
            int numersektora = panelSektorowAwarii.SelectedIndex;
            //ZmianaTlaWWybranymSektorze(numersektora, PowiazanieIndexuzPanel(numersektora));
        }

        public void ZmienObrazSektora(Control sektorDoZmiany, string nazwaObrazka)
        {
            sektorDoZmiany.BackgroundImage = _imageRepository[nazwaObrazka];
        }

        private void ZmianaTlaWWybranymSektorze(int index, Control panel)
        {
            int numersektora = panelSektorowAwarii.SelectedIndex;
            if (numersektora == index)
            {
                ZmienObrazSektora(panel, "pozycja1");

                if (panelSektorowAwarii.GetItemChecked(numersektora) == true)
                {
                    ZmienObrazSektora(panel, "pozycja1");

                }

            }
        }
        public Control PowiazanieIndexuzPanel(int index)
        {
            if (index == 0)
                return panel1;
            if (index == 1)
                return panel2;
            if (index == 2)
                return panel3;
            if (index == 3)
                return panel4;
            if (index == 4)
                return panel5;
            if (index == 5)
                return panel6;
            if (index == 6)
                return panel7;
            if (index == 7)
                return panel8;
            if (index == 8)
                return panel9;
            if (index == 9)
                return panel10;
            return null;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            OnOff = !OnOff;
            CommunicationChannel.SendMessage("A1:");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OnOff = !OnOff;
            CommunicationChannel.SendMessage("A0:");
        }


        private void SetButtonOff()
        {
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CommunicationChannel.SendMessage("S0:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CommunicationChannel.SendMessage("S1:");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CommunicationChannel.SendMessage("S2:");
        }
    }
}
