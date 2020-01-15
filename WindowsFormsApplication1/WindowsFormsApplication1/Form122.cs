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
using System.Collections.Generic;
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

            button2.Click += delegate
            {

                CommunicationChannel.SendMessage("S2:");


            };


            button3.Click += delegate
            {

                CommunicationChannel.SendMessage("A0:");


            };


            btnDebug.Click += delegate
            {
                CommunicationChannel.SendMessage(txtDebug.Text);


            };
            FormClosed += delegate { CommunicationChannel.EndCommunication(); };
            SetButtonOff();
            inputChannel.DataRecievedEvent += (sender, data) => { MessageBox.Show("Test"); };
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
           };


        }

        /*
        Funckaj ReakcjaNaZmianeCheckboxa
        Funkcja ZmianaTlaWWybranymSektorze
        Funckja PowiazanieIndexuzPanel
        */


        private void ReakcjaNaZmianeCheckboxa(object sender, ItemCheckEventArgs e)
        {
            int numersektora = panelSektorowAwarii.SelectedIndex;
            ZmianaTlaWWybranymSektorze(numersektora, PowiazanieIndexuzPanel(numersektora));
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
                ZmienObrazSektora(panel, WindowsFormsApplication1.Properties.Resources.tory);

                if (panelSektorowAwarii.GetItemChecked(numersektora) == true)
                {
                    ZmienObrazSektora(panel, WindowsFormsApplication1.Properties.Resources.awarias);

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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OnOff = !OnOff;
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
            CommunicationChannel.SendMessage("S1:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CommunicationChannel.SendMessage("A0:");

        }


        private void button8_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-VH1486P\KOLEJKA;Initial Catalog=kolejka;User ID=admin;Password=admin";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select ID_events,Event from Events";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-VH1486P\KOLEJKA;Initial Catalog=kolejka;User ID=admin;Password=admin";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Events (ID_events,Event) values (4,'" + "kali" + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-VH1486P\KOLEJKA;Initial Catalog=kolejka;User ID=admin;Password=admin";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into Events (ID_events,Event) values (4,'" + "kali" + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
    }
}
