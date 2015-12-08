using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StartUpConfig
            bool runApp = true;
            bool shapeSelect = true;
            string usersInput = "";
            double dimension;
            bool triangleType = false; //true if 90 degrees, false if otherwise
            Rectangle rectangle = null;
            RectangularPrism rp = null;
            Square square = null;
            Cube cube = null;
            Circle circle = null;                  
            Sphere sphere = null;
            Triangle triangle = null;
            Octagon octagon = null;
            Hexagon hexagon = null;
            Pentagon pentagon = null;
            
            // make sure to include any new shapes into the shapeList array
            string[] shapeList = 
            { 
                "Rectangle", 
                "Rectangular Prism",
                "Square", 
                "Cube", 
                "Circle", 
                "Sphere",
                "Triangle", 
                "Octagon", 
                "Hexagon", 
                "Pentagon"
            };
            #endregion
            Console.ForegroundColor = ConsoleColor.DarkGreen;          
            Console.WriteLine("============================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Shape Area Calculator");

            while (runApp == true)
            {
                if (shapeSelect == false)
                {
                    shapeSelect = true;
                }
                Console.Write("Enter a supported shape or a command (type \""); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("/help");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\" to see commands)\n\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                usersInput = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (usersInput == "/shapes" || usersInput == "/s")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                    Console.WriteLine("--------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    // Lists out all the shapes as long as they are included in the shapeList
                    shapeList.ToList().ForEach(i => Console.WriteLine(i));
                    Console.WriteLine();
                    
                }
                else if (usersInput == "/help" || usersInput == "/h")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("--------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\"");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("/shapes");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\" : shows a list of all supported shapes");
                    Console.Write("\"");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("/quit");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\" : exit the program");
                    Console.Write("\"");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("shapename");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\" : begins the process to gather area for shape\n");
                }
                else if (usersInput == "/quit" || usersInput == "/q")
                {
                    runApp = false;
                }
                else if (usersInput == "shapename")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("--------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("shapename is an invalid command\ntry entering an actual shape name such as \"");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("circle");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\"\n");
                }
                else
                {
                    Console.Clear();
                    while (shapeSelect == true)
                    {                        
                        switch (usersInput) // SWITH CASE FOR ALL SUPPORTED SHAPES TO CALCULATE THE AREA GOES HERE
                        {

                            #region Rectangle
                            case "rectangle":
                                try
                                {
                                    if (rectangle == null)
                                    {
                                        rectangle = new Rectangle();
                                    }
                                    Console.WriteLine("Rectangle\n");

                                    Console.Write("Enter length:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                               
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        rectangle.setLength(dimension); // Set Rectangle shapes length
                                        Console.Write("\nEnter height:\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("> ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        usersInput = Console.ReadLine();
                                        dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                        if (dimension > 0)
                                        {
                                            rectangle.setHeight(dimension); // Set Rectangle shapes height
                                            Console.WriteLine("");
                                            Console.WriteLine("Area: {0}", rectangle.getArea()); // Output the Area
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            shapeSelect = false; // Exits the shape selection loop
                                        } 
                                        else
                                        {
                                            Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                            usersInput = "rectangle";
                                        }
                                    } 
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "rectangle";
                                    }
                                    
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "rectangle";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Square
                            case "square":
                                try
                                {
                                    if (square == null)
                                    {
                                        square = new Square();
                                    }
                                    Console.WriteLine("Square\n");

                                    Console.Write("Enter length or width:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                              
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        square.setLength(dimension); // Set Square shapes length
                                        square.setHeight(dimension); // Set Square shapes height
                                        Console.WriteLine("");
                                        Console.WriteLine("Area: {0}", square.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "square";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "square";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Cube
                            case "cube":
                                try
                                {
                                    if (cube == null)
                                    {
                                        cube = new Cube();
                                    }
                                    Console.WriteLine("Cube\n");

                                    Console.Write("Enter edge(a length):\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                               
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        cube.setEdge(dimension); // Set Cube shapes edge
                                        Console.WriteLine("");
                                        Console.WriteLine("Volume: {0}", cube.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "cube";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "cube";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Circle
                            case "circle":
                                try
                                {
                                    if (circle == null)
                                    {
                                        circle = new Circle();
                                    }
                                    Console.WriteLine("Circle\n");

                                    Console.Write("Enter radius:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                               
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        circle.setRadius(dimension); // Set Circle shapes radius
                                        Console.WriteLine("");
                                        Console.WriteLine("Area: {0}", circle.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "circle";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "circle";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Sphere
                            case "sphere":
                                try
                                {
                                    if (sphere == null)
                                    {
                                        sphere = new Sphere();
                                    }
                                    Console.WriteLine("Sphere\n");

                                    Console.Write("Enter radius:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                                
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        sphere.setRadius(dimension); // Set Sphere shapes radius
                                        Console.WriteLine("");
                                        Console.WriteLine("Volume: {0}", sphere.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "sphere";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "sphere";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Triangle
                            case "triangle":
                                try
                                {
                                    if (triangle == null)
                                    {
                                        triangle = new Triangle();
                                    }
                                    Console.WriteLine("Triangle\n");

                                    Console.Write("90 Degree angle triangle? Please enter: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("yes ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("or ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("no");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("\n\n> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine().ToLower();
                                    Console.WriteLine();

                                    if (usersInput == "yes")
                                    {
                                        triangleType = true;
                                        Console.Write("Enter base:\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("> ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        usersInput = Console.ReadLine();
                                        dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                        if (dimension > 0)
                                        {
                                            triangle.setBase(dimension); // Set Triangle shapes base
                                            Console.Write("\nEnter height:\n\n");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("> ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            usersInput = Console.ReadLine();
                                            dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                            if (dimension > 0)
                                            {
                                                triangle.setHeight(dimension); // Set Triangle shapes height
                                                Console.WriteLine("");
                                                Console.WriteLine("Area: {0}", triangle.getArea()); // Output the Area
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("--------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                shapeSelect = false; // Exits the shape selection loop
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write("\nERROR");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine(": Number must be greater than 0\n");
                                                usersInput = "triangle";
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\nERROR");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(": Number must be greater than 0\n");
                                            usersInput = "triangle";
                                        }
                                    }
                                    else if (usersInput == "no")
                                    {
                                        triangleType = false;
                                        Console.Write("Enter base:\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("> ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        usersInput = Console.ReadLine();
                                        dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                        if (dimension > 0)
                                        {
                                            triangle.setBase(dimension); // Set Triangle shapes base
                                            Console.Write("\nEnter side length:\n\n");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("> ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            usersInput = Console.ReadLine();
                                            dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                            if (dimension > 0)
                                            {
                                                triangle.setSide(dimension); // Set Triangle shapes side

                                                Console.Write("\nEnter angle(degrees):\n\n");
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.Write("> ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                usersInput = Console.ReadLine();
                                                dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                                if (dimension > 0)
                                                {
                                                    triangle.setAngle(dimension); // Set Triangle shapes angle

                                                    Console.WriteLine("");                                                  
                                                    Console.WriteLine("Area: {0}", triangle.getAreaWithAngle()); // Output the Area
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.WriteLine("--------------------------------------------");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    shapeSelect = false; // Exits the shape selection loop
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.Write("\nERROR");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine(": Number must be greater than 0\n");
                                                    usersInput = "triangle";
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write("\nERROR");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine(": Number must be greater than 0\n");
                                                usersInput = "triangle";
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("\nERROR");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(": Number must be greater than 0\n");
                                            usersInput = "triangle";
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("ERROR");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(": Invalid Input\n");
                                        usersInput = "triangle"; // sets the userInput to triangle to put the user back into trying to get the area for triangle
                                    }                                    
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nERROR");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(": Invalid Input\n");
                                    usersInput = "triangle";
                                }
                                catch (Exception)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("\nERROR");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(": Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Octagon
                            case "octagon":
                                try
                                {
                                    if (octagon == null)
                                    {
                                        octagon = new Octagon();
                                    }
                                    Console.WriteLine("Octagon\n");

                                    Console.Write("Enter side:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                              
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        octagon.setSide(dimension); // Set Octagon shapes side length
                                        Console.WriteLine("");
                                        Console.WriteLine("Area: {0}", octagon.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "octagon";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "octagon";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Hexagon
                            case "hexagon":
                                try
                                {
                                    if (hexagon == null)
                                    {
                                        hexagon = new Hexagon();
                                    }
                                    Console.WriteLine("Hexagon\n");

                                    Console.Write("Enter side:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();                              
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        hexagon.setSide(dimension); // Set Hexagon shapes side length
                                        Console.WriteLine("");
                                        Console.WriteLine("Area: {0}", hexagon.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "hexagon";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "hexagon";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region Pentagon
                            case "pentagon":
                                try
                                {
                                    if (pentagon == null)
                                    {
                                        pentagon = new Pentagon();
                                    }
                                    Console.WriteLine("Pentagon\n");

                                    Console.Write("Enter side:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        pentagon.setSide(dimension); // Set Pentagon shapes side length
                                        Console.WriteLine("");
                                        Console.WriteLine("Area: {0}", pentagon.getArea()); // Output the Area
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("--------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        shapeSelect = false; // Exits the shape selection loop
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "pentagon";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "pentagon";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            #region RectangularPrism
                            case "rectangular prism":
                                try
                                {
                                    if (rp == null)
                                    {
                                        rp = new RectangularPrism();
                                    }
                                    Console.WriteLine("Rectangular Prism\n");

                                    Console.Write("Enter length:\n\n");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("> ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    usersInput = Console.ReadLine();
                                    dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                    if (dimension > 0)
                                    {
                                        rp.setLength(dimension); // Set RP shapes length
                                        Console.Write("\nEnter width:\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("> ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        usersInput = Console.ReadLine();
                                        dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                        if (dimension > 0)
                                        {
                                            rp.setWidth(dimension); // Set RP shapes width
                                            Console.Write("\nEnter height:\n\n");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("> ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            usersInput = Console.ReadLine();
                                            dimension = Convert.ToDouble(usersInput); // Parse Input to Double
                                            if (dimension > 0)
                                            {
                                                rp.setHeight(dimension); // Set RP shapes height
                                                Console.WriteLine("");
                                                Console.WriteLine("Volume: {0}", rp.getArea()); // Output the Area
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("--------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                shapeSelect = false; // Exits the shape selection loop
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                                usersInput = "rectangular prism";
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                            usersInput = "rectangular prism";
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nERROR: Number must be greater than 0\n");
                                        usersInput = "rectangular prism";
                                    }
                                }
                                catch (FormatException) // This catchs if they enter a string
                                {
                                    Console.WriteLine("\nERROR: Must enter a valid number\n");
                                    usersInput = "rectangular prism";
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("\nERROR: Unidentified error, returning you to main page\n");
                                    shapeSelect = false;
                                }
                                break;
                            #endregion
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("ERROR");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(": Invalid Input\n"); shapeSelect = false; break; // Note: Setting the shapeSelect to false to avoid infinite loops.
                        }
                    }
                }
            }
        }
    }
    
    //Shapes
    public abstract class Shape
    {
        public abstract double getArea();
    }
    
    
    public class Rectangle : Shape
    {
        private double length;
        private double height;

        public Rectangle()
        {
            length = 0;
            height = 0;
        }

        public Rectangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public virtual void setHeight(double height)
        {
            this.height = height;
        }

        public override double getArea()
        {
            return Math.Round(length * height, 2);
        }
    }
    
    
    
    
}
