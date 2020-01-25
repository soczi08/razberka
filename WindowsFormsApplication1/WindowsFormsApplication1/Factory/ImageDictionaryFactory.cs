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

            

            dictionary.Add("tory1", WindowsFormsApplication1.Properties.Resources.tory1);
            dictionary["tory1"].Tag = "tory1";

            dictionary.Add("tory2", WindowsFormsApplication1.Properties.Resources.tory2);
            dictionary["tory2"].Tag = "tory2";

            dictionary.Add("tory3", WindowsFormsApplication1.Properties.Resources.tory3);
            dictionary["tory3"].Tag = "tory3";

            dictionary.Add("tory4", WindowsFormsApplication1.Properties.Resources.tory4);
            dictionary["tory4"].Tag = "tory4";

            dictionary.Add("tory5", WindowsFormsApplication1.Properties.Resources.tory5);
            dictionary["tory5"].Tag = "tory5";

            dictionary.Add("tory6", WindowsFormsApplication1.Properties.Resources.tory6);
            dictionary["tory6"].Tag = "tory6";

            dictionary.Add("tory7", WindowsFormsApplication1.Properties.Resources.tory7);
            dictionary["tory7"].Tag = "tory7";

            dictionary.Add("tory8", WindowsFormsApplication1.Properties.Resources.tory8);
            dictionary["tory8"].Tag = "tory8";

            dictionary.Add("tory9", WindowsFormsApplication1.Properties.Resources.tory9);
            dictionary["tory9"].Tag = "tory9";

            dictionary.Add("tory10", WindowsFormsApplication1.Properties.Resources.tory10);
            dictionary["tory10"].Tag = "tory10";


            dictionary.Add("pozycja1", WindowsFormsApplication1.Properties.Resources.pozycja1);
            dictionary["pozycja1"].Tag = "pozycja1";

            dictionary.Add("pozycja2", WindowsFormsApplication1.Properties.Resources.pozycja2);
            dictionary["pozycja2"].Tag = "pozycja2";

            dictionary.Add("pozycja3", WindowsFormsApplication1.Properties.Resources.pozycja3);
            dictionary["pozycja3"].Tag = "pozycja3";

            dictionary.Add("pozycja4", WindowsFormsApplication1.Properties.Resources.pozycja4);
            dictionary["pozycja4"].Tag = "pozycja4";

            dictionary.Add("pozycja5", WindowsFormsApplication1.Properties.Resources.pozycja5);
            dictionary["pozycja5"].Tag = "pozycja5";

            dictionary.Add("pozycja6", WindowsFormsApplication1.Properties.Resources.pozycja6);
            dictionary["pozycja6"].Tag = "pozycja6";

            dictionary.Add("pozycja7", WindowsFormsApplication1.Properties.Resources.pozycja7);
            dictionary["pozycja7"].Tag = "pozycja7";

            dictionary.Add("pozycja8", WindowsFormsApplication1.Properties.Resources.pozycja8);
            dictionary["pozycja8"].Tag = "pozycja8";

            dictionary.Add("pozycja9", WindowsFormsApplication1.Properties.Resources.pozycja9);
            dictionary["pozycja9"].Tag = "pozycja9";

            dictionary.Add("pozycja10", WindowsFormsApplication1.Properties.Resources.pozycja10);
            dictionary["pozycja10"].Tag = "pozycja10";



            dictionary.Add("awaria1", WindowsFormsApplication1.Properties.Resources.awaria1);
            dictionary["awaria1"].Tag = "awaria1";

            dictionary.Add("awaria2", WindowsFormsApplication1.Properties.Resources.awaria2);
            dictionary["awaria2"].Tag = "awaria2";

            dictionary.Add("awaria3", WindowsFormsApplication1.Properties.Resources.awaria3);
            dictionary["awaria3"].Tag = "awaria3";

            dictionary.Add("awaria4", WindowsFormsApplication1.Properties.Resources.awaria4);
            dictionary["awaria4"].Tag = "awaria4";

            dictionary.Add("awaria5", WindowsFormsApplication1.Properties.Resources.awaria5);
            dictionary["awaria5"].Tag = "awaria5";

            dictionary.Add("awaria6", WindowsFormsApplication1.Properties.Resources.awaria6);
            dictionary["awaria6"].Tag = "awaria6";

            dictionary.Add("awaria7", WindowsFormsApplication1.Properties.Resources.awaria7);
            dictionary["awaria7"].Tag = "awaria7";

            dictionary.Add("awaria8", WindowsFormsApplication1.Properties.Resources.awaria8);
            dictionary["awaria8"].Tag = "awaria8";

            dictionary.Add("awaria9", WindowsFormsApplication1.Properties.Resources.awaria9);
            dictionary["awaria9"].Tag = "awaria9";

            dictionary.Add("awaria10", WindowsFormsApplication1.Properties.Resources.awaria10);
            dictionary["awaria10"].Tag = "awaria10";


            dictionary.Add("awariaPozycja1", WindowsFormsApplication1.Properties.Resources.awariapozycja1);
            dictionary["awariaPozycja1"].Tag = "awariaPozycja1";

            dictionary.Add("awariaPozycja2", WindowsFormsApplication1.Properties.Resources.awariapozycja2);
            dictionary["awariaPozycja2"].Tag = "awariaPozycja2";

            dictionary.Add("awariaPozycja3", WindowsFormsApplication1.Properties.Resources.awariapozycja3);
            dictionary["awariaPozycja3"].Tag = "awariaPozycja3";

            dictionary.Add("awariaPozycja4", WindowsFormsApplication1.Properties.Resources.awariapozycja4);
            dictionary["awariaPozycja4"].Tag = "awariaPozycja4";

            dictionary.Add("awariaPozycja5", WindowsFormsApplication1.Properties.Resources.awariapozycja5);
            dictionary["awariaPozycja5"].Tag = "awariaPozycja5";

            dictionary.Add("awariaPozycja6", WindowsFormsApplication1.Properties.Resources.awariapozycja6);
            dictionary["awariaPozycja6"].Tag = "awariaPozycja6";

            dictionary.Add("awariaPozycja7", WindowsFormsApplication1.Properties.Resources.awariapozycja7);
            dictionary["awariaPozycja7"].Tag = "awariaPozycja7";

            dictionary.Add("awariaPozycja8", WindowsFormsApplication1.Properties.Resources.awariapozycja8);
            dictionary["awariaPozycja8"].Tag = "awariaPozycja8";

            dictionary.Add("awariaPozycja9", WindowsFormsApplication1.Properties.Resources.awariapozycja9);
            dictionary["awariaPozycja9"].Tag = "awariaPozycja9";

            dictionary.Add("awariaPozycja10", WindowsFormsApplication1.Properties.Resources.awariapozycja10);
            dictionary["awariaPozycja10"].Tag = "awariaPozycja10";

            return dictionary;
        }

    }
}
