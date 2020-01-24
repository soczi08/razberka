using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.BehaviourOverseer
{
    class CheckingBehaviourOverseer
    {


        private CheckedListBox panelSektorowAwarii;
        private Control panel1;
        private Control _c3;
        private InputChannel _inputChannel;
        private Form1 _form;

        public CheckingBehaviourOverseer(Form1 form1)
        {
            panelSektorowAwarii = (CheckedListBox)form1.Controls["panelSektorowAwarii"];
            panel1 = form1.Controls["panel1"];
            _c3 = form1.Controls[""];
            _form = form1;

            panelSektorowAwarii.ItemCheck += (sender, args) =>
            {
                //tutaj decydujesz co ma się dziać jak odznaczasz konkretny chcekbox
                var zmienionyIndex = args.Index;
                if (zmienionyIndex == 0)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja1")//to nie puszcza ALE TO TY DODALES Xd// a nie ma ten obrazek czasami a1
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja1");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria1")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja1");
                        }

                    }

                }
                if (zmienionyIndex == 1)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja1")//to nie puszcza ALE TO TY DODALES Xd// a nie ma ten obrazek czasami a1
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja1");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria1")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja1");
                        }

                    }

                }



            };

        }





    }
}