﻿using System;
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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private bool onOff;
        IList<string> stringi = new List<string>();
        Stack<DateTime> stack = new Stack<DateTime>();

        public bool OnOff
        {
            get { return onOff; }
            set { onOff = value; SwitchButtonState(); }
        }

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
 
        public Form1()
        {
            InitializeComponent();


        }
        public Form1(InputChannel inputChannel
           )
        {
            InitializeComponent();

            UstwawTloWszystkichKontrolek();

            UtworzListeSektorow();

            panelSektorowAwarii.ItemCheck += ReakcjaNaZmianeCheckboxa;

            ConfigurationWindow configurationWindow = new ConfigurationWindow();
            configurationWindow.TopMost = true;
            configurationWindow.Show();

            panelSektorowAwarii.ItemCheck += Wysylanie_komunikatu_do_rpi;

   

            btnDebug.Click += delegate
            {
                CommunicationChannel.SendMessage(txtDebug.Text);
            };
            FormClosed += delegate { CommunicationChannel.EndCommunication(); };
            SetButtonOff();




            //reakcja na dane wejśiowe
            inputChannel.DataRecievedEvent += (sender, daneZrasberry) =>
            {
                ReakcjNaDaneZRasberry(daneZrasberry);





                /*
                listBox1.DataSource = null;
                stringi.Add(data);
                listBox1.DataSource = stringi.Skip(Math.Max(0, stringi.Count() - 10)).ToList(); ;
                MojaBaza mb = new MojaBaza();
            mb.Insert(new SqlCommand("INSERT INTO [dbo].[Events] ([Event]) VALUES ('XYZ')"));
                */
            };

            /*
            MojaBaza mb = new MojaBaza();
            mb.Insert(new SqlCommand("INSERT INTO [dbo].[Events] ([Event]) VALUES ('XYZ')"));
            var x =mb.Select(new SqlCommand("select * from NumberofFailures"));
            */
         //   btnTestAddData.Click += delegate { inputChannel.OnDataRecieved(null, DateTime.Now.Minute +":"+ DateTime.Now.Second+ "." + DateTime.Now.Millisecond); };
            btnTestAddData.Click += delegate { inputChannel.OnDataRecieved(null, txtDebug.Text); };


        }

        private void ReakcjNaDaneZRasberry(string toCoWysyłaKolejkaPrzezPython)
        {
            if (toCoWysyłaKolejkaPrzezPython == "E0:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(1), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E1:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(2), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E2:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(3), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E3:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(4), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E4:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(5), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E5:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(6), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E6:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(7), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E7:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(8), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E8:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(9), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }
            if (toCoWysyłaKolejkaPrzezPython == "E9:")
            {
                ZmienObrazSektora(PowiazanieIndexuzPanel(10), WindowsFormsApplication1.Properties.Resources._1pozycja);
            }


            if (toCoWysyłaKolejkaPrzezPython == "P0:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(1), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(1, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P1:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(2), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(2, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P2:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(3), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(3, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P3:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(4), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(4, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P4:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(5), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(5, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P5:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(6), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(6, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P6:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(7), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(7, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P7:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(8), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(8, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P8:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(9), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(9, true);
            }

            if (toCoWysyłaKolejkaPrzezPython == "P9:")
            {
                CzasOstatniegoOkrazenia(toCoWysyłaKolejkaPrzezPython);
                ZmienObrazSektora(PowiazanieIndexuzPanel(10), WindowsFormsApplication1.Properties.Resources._1awaria);

                panelSektorowAwarii.SetItemChecked(10, true);
            }
        }


        private void CzasOstatniegoOkrazenia(string data)
        {


            TimeSpan differnce = new TimeSpan();
            stack.Push(DateTime.Now);
            if (stack.Count == 1) { return; }
            if (stack.Count >= 2)
            {
                var top = stack.Pop();
                var topminusone = stack.Pop();
                stack.Push(topminusone);
                stack.Push(top);

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
            for (int i = 1; i < 10; i++)
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

        private void ZmienObrazSektora(Control sektorDoZmiany, Image wgrywanyObraz)
        {
            sektorDoZmiany.BackgroundImage = wgrywanyObraz;
        }

        private void ZmianaTlaWWybranymSektorze(int index, Control panel)
        {
            int numersektora = panelSektorowAwarii.SelectedIndex;
            if (numersektora == index)
            {
                ZmienObrazSektora(panel, WindowsFormsApplication1.Properties.Resources._1);

                if (panelSektorowAwarii.GetItemChecked(numersektora) == true)
                {
                    ZmienObrazSektora(panel, WindowsFormsApplication1.Properties.Resources._1awaria);

                }

            }
        }
        private Control PowiazanieIndexuzPanel(int index)
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


        private void ChangeState()
        {





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
