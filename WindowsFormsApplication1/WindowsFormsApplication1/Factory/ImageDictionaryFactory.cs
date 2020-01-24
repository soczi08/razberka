using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Factory
{
    public static class ImageDictionaryFactory
    {
      public static Dictionary<string,Image> CreateImageDictiornary()
        {
            var dictionary = new Dictionary<string, Image>();

            dictionary.Add("pozycja1", WindowsFormsApplication1.Properties.Resources._1pozycja);
            dictionary["pozycja1"].Tag = "pozycja1";

            dictionary.Add("pozycja2", WindowsFormsApplication1.Properties.Resources._2);
            dictionary["pozycja2"].Tag = "pozycja2";

            dictionary.Add("pozycja3", WindowsFormsApplication1.Properties.Resources._3);
            dictionary["pozycja3"].Tag = "pozycja3";

            dictionary.Add("pozycja4", WindowsFormsApplication1.Properties.Resources._4);
            dictionary["pozycja4"].Tag = "pozycja4";

            dictionary.Add("pozycja5", WindowsFormsApplication1.Properties.Resources._5);
            dictionary["pozycja5"].Tag = "pozycja5";

            dictionary.Add("pozycja6", WindowsFormsApplication1.Properties.Resources._6);
            dictionary["pozycja6"].Tag = "pozycja6";

            dictionary.Add("pozycja7", WindowsFormsApplication1.Properties.Resources._7);
            dictionary["pozycja7"].Tag = "pozycja7";

            dictionary.Add("pozycja8", WindowsFormsApplication1.Properties.Resources._8);
            dictionary["pozycja8"].Tag = "pozycja8";

            dictionary.Add("pozycja9", WindowsFormsApplication1.Properties.Resources._9);
            dictionary["pozycja9"].Tag = "pozycja9";

            dictionary.Add("pozycja10", WindowsFormsApplication1.Properties.Resources._10);
            dictionary["pozycja10"].Tag = "pozycja10";



            dictionary.Add("awaria1", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria1"].Tag = "awaria1";

            dictionary.Add("awaria2", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria2"].Tag = "awaria2";

            dictionary.Add("awaria3", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria3"].Tag = "awaria3";

            dictionary.Add("awaria4", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria4"].Tag = "awaria4";

            dictionary.Add("awaria5", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria5"].Tag = "awaria5";

            dictionary.Add("awaria6", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria6"].Tag = "awaria6";

            dictionary.Add("awaria7", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria7"].Tag = "awaria7";

            dictionary.Add("awaria8", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria8"].Tag = "awaria8";

            dictionary.Add("awaria9", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria9"].Tag = "awaria9";

            dictionary.Add("awaria10", WindowsFormsApplication1.Properties.Resources._1awaria);
            dictionary["awaria10"].Tag = "awaria10";


            dictionary.Add("awariaPozycja1", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja1"].Tag = "awariaPozycja1";

            dictionary.Add("awariaPozycja2", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja2"].Tag = "awariaPozycja2";

            dictionary.Add("awariaPozycja3", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja3"].Tag = "awariaPozycja3";

            dictionary.Add("awariaPozycja4", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja4"].Tag = "awariaPozycja4";

            dictionary.Add("awariaPozycja5", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja5"].Tag = "awariaPozycja5";

            dictionary.Add("awariaPozycja6", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja6"].Tag = "awariaPozycja6";

            dictionary.Add("awariaPozycja7", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja7"].Tag = "awariaPozycja7";

            dictionary.Add("awariaPozycja8", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja8"].Tag = "awariaPozycja8";

            dictionary.Add("awariaPozycja9", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja9"].Tag = "awariaPozycja9";

            dictionary.Add("awariaPozycja10", WindowsFormsApplication1.Properties.Resources._1awariapozycja);
            dictionary["awariaPozycja10"].Tag = "awariaPozycja10";

            return dictionary;
        }

    }
}
