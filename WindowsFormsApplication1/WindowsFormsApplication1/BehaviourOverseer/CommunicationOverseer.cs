using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.BehaviourOverseer
{
    class CommunicationOverseer
    {
        //private CheckedListBox panelSektorowAwarii;
        //private Control _c2;
        //private Control _c3;
        private InputChannel _inputChannel;
        private Form1 _form;

        public CommunicationOverseer(Form1 form1)
        {
            //panelSektorowAwarii = (CheckedListBox)form1.Controls["panelSektorowAwarii"];
            //_c2 = form1.Controls[""];
            //_c3 = form1.Controls[""];
            _form = form1;
            _inputChannel = form1.InputChannel;
            _inputChannel.DataRecievedEvent += React;

        }


        public void React(object sender, string args)
        {
            ReakcjNaDaneZRasberry(args);
        }

        private void ReakcjNaDaneZRasberry(string toCoWysyłaKolejkaPrzezPython)
        {
            if (toCoWysyłaKolejkaPrzezPython == "P0:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja1");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P1:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(1), "pozycja2");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P2:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(2), "pozycja3");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P3:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(3), "pozycja4");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P4:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(4), "pozycja5");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P5:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(5), "pozycja6");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P6:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(6), "pozycja7");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P7:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(7), "pozycja8");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P8:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(8), "pozycja9");
            }
            if (toCoWysyłaKolejkaPrzezPython == "P9:")
            {
                _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(9), "pozycja10");
            }


            if (toCoWysyłaKolejkaPrzezPython == "E0:")
            {
                _form.HandleError(0, toCoWysyłaKolejkaPrzezPython, "awaria1");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E1:")
            {
                _form.HandleError(1, toCoWysyłaKolejkaPrzezPython, "awaria2");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E2:")
            {
                _form.HandleError(2, toCoWysyłaKolejkaPrzezPython, "awaria3");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E3:")
            {
                _form.HandleError(3, toCoWysyłaKolejkaPrzezPython, "awaria4");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E4:")
            {
                _form.HandleError(4, toCoWysyłaKolejkaPrzezPython, "awaria5");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E5:")
            {
                _form.HandleError(5, toCoWysyłaKolejkaPrzezPython, "awaria6");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E6:")
            {
                _form.HandleError(6, toCoWysyłaKolejkaPrzezPython, "awaria7");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E7:")
            {
                _form.HandleError(7, toCoWysyłaKolejkaPrzezPython, "awaria8");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E8:")
            {
                _form.HandleError(8, toCoWysyłaKolejkaPrzezPython, "awaria9");
            }

            if (toCoWysyłaKolejkaPrzezPython == "E9:")
            {
                _form.HandleError(9, toCoWysyłaKolejkaPrzezPython, "awaria10");
            }   
        }






    }
}
