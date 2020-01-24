using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //startuje wątek nasłuchu
            var inputChannel = new InputChannel();
            var thread = new Thread(new ThreadStart(inputChannel.Run));
            thread.Start();

            //inputChannel.DataRecievedEvent += (sender,args)=>{ MessageBox.Show(args);};

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(inputChannel));
        }
    }



}
