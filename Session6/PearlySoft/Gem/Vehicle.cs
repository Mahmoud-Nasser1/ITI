using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    internal class Vehicle
    {

        //Members:
        //(1) Attributes:
        // Access/Protection Levels (private)
        // Access Modifiers (private - public)

        //New Methode Encabulation

        //1. Full Properties (Code Snippet: propfull)
        private string color;

        public string Color
        {
            get
            {
                if (color == null)
                    return string.Empty;
                else
                    return color.ToUpper();
            }
            set
            {
                //if(value.ToLower() == "yellow")
                if (value.ToUpper() == "YELLOW") //C# is case-sensitive
                {
                    Console.WriteLine("Yellow is not allowed.");
                }
                else
                {
                    color = value;
                }
            }
        }


    }
    //    2. old Methode Encabulation

    //        //Setter
    //        public void SetColor(string value)
    //        {
    //            //if(value.ToLower() == "yellow")
    //            if (value.ToUpper() == "YELLOW") //C# is case-sensitive
    //            {
    //                Console.WriteLine("Yellow is not allowed.");
    //            }
    //            else
    //            {
    //                color = value;
    //            }
    //        }

    //        public string GetColor()
    //        {
    //            if (color == null)
    //                return string.Empty;
    //            else
    //                return color.ToUpper();
    //        }

    //}

}