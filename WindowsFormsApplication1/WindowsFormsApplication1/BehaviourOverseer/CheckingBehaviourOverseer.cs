using System.Windows.Forms;

namespace WindowsFormsApplication1.BehaviourOverseer
{
    internal class CheckingBehaviourOverseer
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

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja1")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja1");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria1")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory1");
                        }
                    }
                }
                if (zmienionyIndex == 1)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja2")//to nie puszcza ALE TO TY DODALES Xd// a nie ma ten obrazek czasami a1
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja2");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria2")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory2");
                        }
                    }
                }
                if (zmienionyIndex == 2)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja3")//to nie puszcza ALE TO TY DODALES Xd// a nie ma ten obrazek czasami a1
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja3");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria3")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory3");
                        }
                    }
                }
                if (zmienionyIndex == 3)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja4")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja4");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria4")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory4");
                        }
                    }
                }
                if (zmienionyIndex == 4)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja5")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja5");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria5")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory5");
                        }
                    }
                }
                if (zmienionyIndex == 5)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja6")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja6");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria6")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory6");
                        }
                    }
                }
                if (zmienionyIndex == 6)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja7")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja7");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria7")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory7");
                        }
                    }
                }
                if (zmienionyIndex == 7)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja8")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja8");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria8")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory8");
                        }
                    }
                }
                if (zmienionyIndex == 8)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja9")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja9");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria9")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory9");
                        }
                    }
                }
                if (zmienionyIndex == 9)
                {
                    if (args.NewValue == CheckState.Unchecked)
                    {
                        //MessageBox.Show("Awaria potwierdzona");

                        if ((string)panel1.BackgroundImage.Tag == "awariapozycja10")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "pozycja10");
                        }

                        if ((string)panel1.BackgroundImage.Tag == "awaria10")
                        {
                            _form.ZmienObrazSektora(_form.PowiazanieIndexuzPanel(0), "tory9");
                        }
                    }
                }
            };
        }
    }
}