using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{


    public abstract class Vehicle
    {
   
        //Members:
        //(1) Attributes:
        // Access/Protection Levels (private)
        // Access Modifiers (private - public)
     
        private string color;

        //    1. old Methode Encabulation

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

        //===================================================================================


        //New Methode Encabulation
        //2. Full Properties (Code Snippet: propfull) with logic
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

        //===================================================================================

        //3. Auto-implemented Properties (Code Snippet: prop) without any logic
        public string Model { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public int MaxSpeed { get; set; }
        public string Engine { get; set; }

        //Behavior (Methods)
        public string ShowSpecifications() //Parameterless
        {
            return $"Model\t: {Model}\nColor\t: {Color}" +
            $"\nWidth\t: {Width}\nLength\t: {Length}" +
            $"\nHeight\t: {Height}";
        }

        //2. Polymorphism
        //Method Overloading (Compile-time Polymorphism)
        //virtual -> makes the method's behavior/implementation overridable
        public virtual string ShowSpecifications(string type)
        {
            if (type == "full")
            {
                return $"Model\t\t: {Model}\nColor\t\t: {Color}" +
                $"\nWidth\t\t: {Width}\nLength\t\t: {Length}" +
                $"\nHeight\t\t: {Height}" +
                $"\nMaximum Speed\t: {MaxSpeed}\nEngine\t\t: {Engine}";
            }
            else
            {
                return $"Model\t: {Model}\nColor\t: {Color}";
            }
        }
        //Constructor Overloading


        public Vehicle() //Default Constructor
        {
            Model = "Unknown";
            Color = "Unknown";
            Width = 0;
            Length = 0;
            Height = 0;
            MaxSpeed = 0;
            Engine = "Unknown";
        }
        //Parameterized Constructor
        public Vehicle(string model, string color)
        {
            Model = "<<<" + model + ">>>";
            Color = color;
        }

        public Vehicle(string mdl, string clr,
                       double wdt, double len, double hght)
            : this(mdl, clr)
        {
            Width = wdt;
            Length = len;
            Height = hght;
        }

        public Vehicle(string model, string color, double width,
                       double length, double height, int maxSpeed, string engine)
            : this(model, color, width, length, height)
        {
            MaxSpeed = maxSpeed;
            Engine = engine;
        }

      
        public abstract string GetDescription();

        //Non-abstract/Concrete method
        public string GreetVisitor()
        {
            return "Welcome to Pearly Soft!";
        }


    }
  

}