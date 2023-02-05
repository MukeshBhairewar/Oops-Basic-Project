using System;

namespace Shape
{
    /// <summary>
    /// Class For Calculate Area And Perimeter Of Shape
    /// </summary>
    internal class TestClass
    {
        /// <summary>
        /// Main method display calulation for area and perimeter
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("{0,60}", "*******************");
            Console.WriteLine("{0,60}", "SHAPE'S CALCULATION");
            Console.WriteLine("{0,60}", "*******************");
            int choice = 1;

            while (choice != 4)
            {
                Console.WriteLine($"============================================================================================={Environment.NewLine}");
                Console.WriteLine($"Different Shape's Option{Environment.NewLine}");
                Console.WriteLine($"1.rectangle{ Environment.NewLine}");
                Console.WriteLine($"2.oval{Environment.NewLine}");
                Console.WriteLine($"3.circle{ Environment.NewLine}");
                Console.WriteLine($"4.exit{ Environment.NewLine}");
                Console.WriteLine("=============================================================================================");

                // User input for choice Shape
                Console.Write("choose shape you want to work on:");
                string input = Console.ReadLine();
                int.TryParse(input, out choice);

                // Switch block is use for Choice
                switch (choice)
                {
                    case 1:
                        // Method to display rectangle
                        TestClass.RectangleCalculationDisplay();
                        break;
                    case 2:
                        // Method to display oval
                        TestClass.OvalCalculationDisplay();
                        break;
                    case 3:
                        // Method to display circle
                        TestClass.CircleCalculationDisplay();
                        break;
                    case 4:
                        // If user Enter Exit Input case 4 excute
                        Console.WriteLine("The program is Exit Thank You!!");
                        break;
                    default:
                        //  Default message 
                        Console.WriteLine("Invalid choice Enter Correct choice ");
                        break;
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method For Rectangle Class Calculation
        /// </summary>
        public static void RectangleCalculationDisplay()
        {

            Console.WriteLine($"{Environment.NewLine}Input:-");
            Console.WriteLine("-------");
            Console.Write($"{Environment.NewLine}Enter The Length Of Rectangle : ");
            bool sucess = false;
            // Userinput using takeuserinput method
            double length = TakeUserInput(ref sucess);
            // If blocks for validation and display message
            if (sucess != true)
            {
                return;
            }
            if (length <= 0)
            {
                return;
            }

            Console.Write($"{Environment.NewLine}Enter The Width Of Rectangle: ");
            // Userinput using takeuserinput method
            double width = TakeUserInput(ref sucess);
            // If blocks for validation and display message
            if (sucess != true)
            {
                return;
            }
            if (width <= 0)
            {
                return;
            }

            Shape rectangle = new Rectangle();
            // Passing parameter to rectangle class to calculate area and perimeter
            double rectangleArea = rectangle.CalculateArea(length, width);
            double rectanglePerimeter = rectangle.CalculatePerimeter(length, width);
            int objectCount = Shape.SerialNumber;
            string className = rectangle.ClassName();
            // Method for output
            CalcualtionDisplay(rectangleArea, rectanglePerimeter, className, objectCount);
        }

        /// <summary>
        /// Method For Oval Class Calculation
        /// </summary>
        public static void OvalCalculationDisplay()
        {

            Console.WriteLine("Input:-");
            Console.WriteLine("-------");
            Console.Write($"{Environment.NewLine}Enter The Major Axis: ");
            bool sucess = false;
            // Userinput using takeuserinput method
            double majoraxis = TakeUserInput(ref sucess);
            // If blocks for validation and display message
            if (sucess != true)
            {
                return;
            }
            if (majoraxis <= 0)
            {
                return;
            }

            Console.Write($"{Environment.NewLine}Enter The Minor Axis: ");
            // Userinput using takeuserinput method
            double minoraxis = TakeUserInput(ref sucess);
            // If blocks for validation and display message
            if (sucess != true)
            {
                return;
            }
            if (minoraxis <= 0)
            {
                return;
            }

            Shape Oval = new Oval();
            // Passing parameter to Oval class to calculate area and perimeter
            double ovalArea = Oval.CalculateArea(majoraxis, minoraxis);
            double ovalPerimeter = Oval.CalculatePerimeter(majoraxis, minoraxis);
            string objectCount = Oval.ClassName();
            int className = Shape.SerialNumber;
            // Method for output display
            CalcualtionDisplay(ovalArea, ovalPerimeter, objectCount, className);
        }

        /// <summary>
        /// Method For Circle Class Calculation
        /// </summary>
        public static void CircleCalculationDisplay()
        {

            Console.WriteLine($"{Environment.NewLine}Input:-");
            Console.WriteLine("-------");
            Console.Write($"{Environment.NewLine}Enter The Radius: ");
            bool sucess = false;
            double radius = TakeUserInput(ref sucess);
            // If blocks for validation and display message
            if (sucess != true)
            {
                return;
            }
            if (radius <= 0)
            {
                return;
            }

            Circle circle = new Circle();
            // Passing parameter to calculate circle area perimeter
            double circleArea = circle.CalculateArea(radius);
            double circlePerimeter = circle.CalculatePerimeter(radius);
            int objectCount = Shape.SerialNumber;
            string className = circle.ClassName();
            // Method for output 
            CalcualtionDisplay(circleArea, circlePerimeter, className, objectCount);
        }

        /// <summary>
        /// Exception methd is used for catch the exception
        /// </summary>
        /// <returns>user input value</returns>
        public static double TakeUserInput(ref bool sucess)
        {
            double userinput = 0;
            try
            {
                string input = Console.ReadLine();
                sucess = double.TryParse(input, out userinput);
                if (!sucess)
                {
                    Console.WriteLine($"{Environment.NewLine}String Format Is invalid ");
                    return userinput;
                }
                if (userinput <= 0)
                {
                    Console.WriteLine($"{Environment.NewLine}Negative value or 0 are invalid inputs");
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                Console.WriteLine($"{Environment.NewLine}String Format Is invalid ");
            }
            return userinput;
        }

        /// <summary>
        /// CalcultionDisplay method is use for show area perimeter classname and serialnumber
        /// </summary>
        /// <param name="area">show the area</param>
        /// <param name="perime">show the perimeter</param>
        /// <param name="name">used for shoe classname</param>
        /// <param name="num">used for serialnumber</param>
        public static void CalcualtionDisplay(double area, double perime, string name, int num)
        {
            Console.WriteLine($"{Environment.NewLine}Output:-");
            Console.WriteLine("-------");
            Console.WriteLine($"{Environment.NewLine}Area of {name}: " + area);
            Console.WriteLine($"{Environment.NewLine}Perimeter of {name}: " + perime);
            //if block is used to remove class name at debug time
#if DEBUG
            Console.WriteLine($"{Environment.NewLine}classname " + name);
#endif
            Console.WriteLine($"{Environment.NewLine}SerialNumber: " + num);
        }
    }
}
