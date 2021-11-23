using System;
using System.Collections.Generic;
using System.IO;


namespace MyCommand
{
    class Program
    {
        // Abstract Shape class
        public abstract class Shape
        {
            public abstract string ToSVG(); //used to formant shapes in svg forms and used to diplay in svg form and to save format to svg file
        }

        // Circle Shape class
        public class Circle : Shape
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            public int R { get; private set; }

            public Circle(int x, int y, int r)
            {
                X = x; Y = y; R = r;
            }

              public override string ToString() //when a circle is Added to canvas this message is shown in cmd
              {
                 string dispSVG = String.Format(@"<circle x=""{0}"" y=""{1}"" r=""{2}"" stroke=""black"" stroke-width=""2"" fill=""blue"" />", X, Y, R); 
                 return dispSVG;
              }
             public override string ToSVG() //converts circle to svg form 
            {
                // convert the object to an SVG element descriptor string for circle
                string dispSVG = String.Format(@"<circle x=""{0}"" y=""{1}"" r=""{2}"" stroke=""black"" stroke-width=""2"" fill=""blue"" />", X, Y, R);
                return dispSVG;
            }
        }
        
        public class Rectangle : Shape
        {
            public int X { get; set; }
            public int Y { get;  set; }
            public int W { get;  set; }
            public int H { get;  set; }

            public Rectangle(int x, int y, int w, int h )
            {
                X = x; Y = y; W = w; H = h;
            }

            public override string ToString() //when a rectangle is Added to canvas this message is shown
            {
                string dispSVG = String.Format(@"<rect x=""{0}"" y=""{1}"" width=""{2}"" height=""{3}"" stroke=""black"" stroke-width=""2"" fill=""grey"" />", X, Y, W, H);
                return dispSVG;

            }
             public override string ToSVG() //converts rectangle to svg form
            {
               string dispSVG = String.Format(@"<rect x=""{0}"" y=""{1}"" width=""{2}"" height=""{3}"" stroke=""black"" stroke-width=""2"" fill=""grey"" />", X, Y, W, H);
               return dispSVG;
            }
        }

        public class Ellipse : Shape
        {
            public int CX { get; private set; }
            public int CY { get; private set; }
            public int RX { get; private set; }
            public int RY { get; private set; }

            public Ellipse(int cx, int cy, int rx, int ry )
            {
                CX = cx; CY = cy; RX = rx; RY = ry;
            }

            public override string ToString() //when a Ellipse is Added to canvas this message is shown
            {
                string dispSVG = String.Format(@"<ellipse cx=""{0}"" cy=""{1}"" rx=""{2}"" ry=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", CX, CY, RX, RY);
                return dispSVG;
            }
             public override string ToSVG() //converts Ellipse to svg form
            {
                
                string dispSVG = String.Format(@"<ellipse cx=""{0}"" cy=""{1}"" rx=""{2}"" ry=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", CX, CY, RX, RY);
                return dispSVG;
            }
        }

        public class Line : Shape
        {
            public int X1 { get; private set; }
            public int Y1 { get; private set; }
            public int X2 { get; private set; }
            public int Y2 { get; private set; }

            public Line (int x1, int y1, int x2, int y2 )
            {
                X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;
            }

             public override string ToString() //when a line is Added to canvas this message is shown
             {
                string dispSVG = String.Format(@"<line x1=""{0}"" y1=""{1}"" x2=""{2}"" y2=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", X1, Y1, X2, Y2);
                return dispSVG;
             }
              public override string ToSVG() //converts line to svg form
            {
               string dispSVG = String.Format(@"<line x1=""{0}"" y1=""{1}"" x2=""{2}"" y2=""{3}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", X1, Y1, X2, Y2);
               return dispSVG;
            }
        }

         public class Polygon : Shape
        {
            public int X1 { get; private set; }
            public int X2 { get; private set; }
            public int X3 { get; private set; }
            public int X4 { get; private set; }
            public int X5 { get; private set; }
            public int X6 { get; private set; }
            public string points { get; private set; }

            public Polygon (int x1, int x2, int x3, int x4, int x5, int x6 )
            {
                X1 = x1; X2 = x2; X3 = x3; X4 = x2; X5 = x5; X6 = x6;
                 points= x1 + "," + x2 + " " + x3 +"," + x4 + " "+ x5 + "," + x6;
            }

            public override string ToString() //when a polygon is Added to canvas this message is shown
            {
                string dispSVG = String.Format(@"<polygon points=""{0}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", points);
                return dispSVG;
            }
             public override string ToSVG() //converts polygon to svg form
            {
                string dispSVG = String.Format(@"<polygon points=""{0}"" stroke=""black"" stroke-width=""2"" fill=""yellow"" />", points);
                return dispSVG;
            }
        }


        public class Polyline : Shape
        {
            public int X1 { get; private set; }
            public int X2 { get; private set; }
            public int X3 { get; private set; }
            public int X4 { get; private set; }
            public int X5 { get; private set; }
            public int X6 { get; private set; }
            public int X7 { get; private set; }
            public int X8 { get; private set; }
            public int X9 { get; private set; }
            public int X10 { get; private set; }
            public int X11 { get; private set; }
            public int X12 { get; private set; }
            public string points { get; private set; }

            public Polyline (int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12 )
            {
                X1 = x1; X2 = x2; X3 = x3; X4 = x4; X5 = x5; X6 = x6; X7 = x7; X8 = x8; X9 = x9; X10 = x10; X11 = x11 ;X12 = x12;
                points= x1 + "," + x2 + " " + x3 + "," + x4 + " " + x5 + "," + x6 + " " + x7 + "," + x8 + " " + x9 + "," + x10 + " " + x11 + "," + x12;
            }

            public override string ToString() //when a polyline is Added to canvas this message is shown
            {
                string dispSVG = String.Format(@"<polyline points=""{0}"" stroke=""black"" stroke-width=""3"" fill=""none"" />", points);
                return dispSVG;
            }
            public override string ToSVG() //converts polyline to svg form
            {
                string dispSVG = String.Format(@"<polyline points=""{0}"" stroke=""black"" stroke-width=""3"" fill=""none"" />", points);
                return dispSVG;
            }   
        }

         public class Path : Shape
        {
            public int M1 { get; private set; }
            public int M2 { get; private set; }
            public int L1 { get; private set; }
            public int L2 { get; private set; }
            public int L3 { get; private set; }
            public int L4 { get; private set; }
            public string points { get; private set; }

            public Path ( int m1, int m2, int l1, int l2, int l3, int l4)
            {
                 M1 = m1; M2 = m2; L1 = l1; L2 = l2; L3 = l3; L4 = l4; 
                points= "M" + m1 + " " + m2 + " L" + l1 + " " + L2 + " L" + L3 +" " + L4 + " Z";
            }

            public override string ToString() //when a path is Added to canvas this message is shown
            {
                string dispSVG = String.Format(@"<path d=""{0}"" stroke=""black"" stroke-width=""3"" fill=""none"" />", points);
                return dispSVG;
            }
             public override string ToSVG() //converts path to svg form
            {
                string dispSVG = String.Format(@"<path d=""{0}"" stroke=""black"" stroke-width=""3"" fill=""none"" />", points);
                return dispSVG;
            }
        }

         public class Canvas
        {
            public Stack<Shape> canvas = new Stack<Shape>();
            public Stack<Shape> buffer = new Stack<Shape>(); // if you remove a shape it goes into buffer
            
            public void Add(Shape s) //adding shape to canvas
            {
                canvas.Push(s);
                buffer.Clear();
                Console.WriteLine("Added Shape to canvas: {0}" + Environment.NewLine, s);
            }
    
            public Shape Remove() //used for undoing
            {
                Shape s = canvas.Pop();
                Console.WriteLine("Removed Shape from canvas: {0}" + Environment.NewLine, s);
                return s;
            }
            public void DisplayCanvas () { //displays the canvas in svg form
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">";
                string svgClose = @"</svg>";
                List<string> lines= new List<string>();
                
                
                Console.WriteLine(svgOpen);
                
                foreach (var shape in canvas)Console.WriteLine("".PadLeft(3, ' ') + shape.ToSVG());
                
                Console.WriteLine(svgClose);
            }

            public void SaveCanvas () { //saving the canvas into an svg file using a lists to add lines to the file.
                List<string> lines= new List<string>();
                string file = @"canvas.svg";
                string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">";
                string svgClose = @"</svg>";
                lines.Add(svgOpen);
                string adding;
          
                foreach (var shape in canvas){
                    adding= "".PadLeft(3, ' ') + shape.ToSVG();
                    lines.Add(adding);
                }
                lines.Add(svgClose);
                File.AppendAllLines(file,lines);
            }

            public Canvas()
            {
                Console.WriteLine("\nCreated a new Canvas!"); Console.WriteLine();
            }

            
            public override string ToString()
            {
                String str = "Canvas (" + canvas.Count + " elements): " + Environment.NewLine + Environment.NewLine;
                foreach (Shape s in canvas)
                {
                    str += "   > " + s + Environment.NewLine;
                }
                return str;
            }    
        }
        private static void Help() //menu commands displayed when H is clicked
        {
            Console.Clear();
            Console.WriteLine("H	 	 Help	-	displays	this	message");
            Console.WriteLine("D	 	 Display	-	displays canvas in the console in svg form");
            Console.WriteLine("A <shape> Add	<shape	to	canvas");
            Console.WriteLine("U	 	 Undo	last	operation");
            Console.WriteLine("R	 	 Redo	last	operation");
            Console.WriteLine("S	 	 Save	canvas  to svg file	");
            Console.WriteLine("Q	 	 Quit	application	");
        }
        private static void createCircle(Canvas canvas) //creating a random circle and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Circle\n");

            Random rnd=new Random();
            Circle c1 = new Circle(rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500));

            canvas.Add(c1);
        }
        private static void createRectangle(Canvas canvas) //creating a random rectangle and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Rectangle\n");

            Random rnd=new Random();
            Rectangle r1 = new Rectangle(rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500));

            canvas.Add(r1); 
        }
        private static void createEllipse(Canvas canvas)//creating a random Ellipse and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Ellipse\n");

            Random rnd=new Random();
            Ellipse e1 = new Ellipse(rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500));

            canvas.Add(e1); 
        }
        private static void createLine(Canvas canvas)//creating a random Line and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Line\n");

            Random rnd=new Random();
            Line l1 = new Line(rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500));

            canvas.Add(l1);
        }
        private static void createPolyline(Canvas canvas) //creating a random Polyline and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Polyline\n");

            Random rnd=new Random();
            Polyline pl1 = new Polyline(rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500),rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500),rnd.Next(1, 500), rnd.Next(1, 500));

            canvas.Add(pl1);
        }
         private static void createPolygon(Canvas canvas) //creating a random Polygon and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Polygon\n");

            Random rnd=new Random();
            Polygon p1 = new Polygon(rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500),rnd.Next(1, 500), rnd.Next(1, 500));

            canvas.Add(p1);  
        }
        private static void createPath(Canvas canvas) //creating a random Path and adding it to the canvas
        {
            Console.Clear();
            Console.WriteLine("Created a Random Polygon\n");

            Random rnd=new Random();
            Path pt1 = new Path( rnd.Next(1, 500),rnd.Next(1, 500), rnd.Next(1, 500),rnd.Next(1, 500), rnd.Next(1, 500), rnd.Next(1, 500));

            canvas.Add(pt1);
        }

          private static void DisplayCanvas(Canvas canvas) //displaying canvas in cmd
         {
        
             Console.Clear();
             Console.WriteLine("Displaying Canvas (as SVG)\n\n");
             canvas.DisplayCanvas();
         }
        
        private static void SaveCanvas(Canvas canvas) //save to svg file
        {
            // menu header output
            Console.Clear();
            Console.WriteLine("Saving Canvas (as SVG)\n\n");
            canvas.SaveCanvas();
        }
         private static void UndoCommand(Canvas canvas) 
        {
            // menu header output
            Console.Clear();
            Console.WriteLine("Undoing last command\n\n");
            if (canvas.canvas.Count > 0)
            {
                canvas.buffer.Push(canvas.Remove()); //pushes removed shape into the buffer
            } else {
                Console.WriteLine("Cannot undo");
            }
        }
         private static void RedoCommand(Canvas canvas)
        {
            // menu header output
            
            Console.Clear();
            Console.WriteLine("Redoing last command\n\n");
            if (canvas.buffer.Count > 0)
            {
                canvas.canvas.Push(canvas.buffer.Pop()); //pushes shape on top of buffer onto the canvas
            } else {
                Console.WriteLine("Cannot Redo");
            }
        }

         private static bool MainMenu(Canvas canvas)
        {
            switch (Console.ReadKey().KeyChar)
            {
                case 'H':
                    Console.WriteLine();
                    Help();    //displays list of commands
                return true;

                case 'D':
                    DisplayCanvas(canvas); //displays canvas in svg form in the cmd
                    Console.WriteLine();      
                return true;

                case 'A':
                    string input =  Console.ReadLine();
                    if(input == " Circle"){
                       Console.WriteLine();
                       createCircle(canvas); //adds random circle to the canvas
                       Console.WriteLine("Added Circle to the canvas");
                   }
                   if(input == " Rectangle"){
                       Console.WriteLine();
                       createRectangle(canvas); //adds random rectangle to the canvas
                       Console.WriteLine("Added Rectangle to the canvas");
                   }
                   if(input == " Ellipse"){
                       Console.WriteLine();
                       createEllipse(canvas); //adds random ellipse to the canvas
                       Console.WriteLine("Added Ellipse to the canvas");
                   }
                   if(input == " Line"){
                       Console.WriteLine();
                       createLine(canvas); //adds random line to the canvas
                       Console.WriteLine("Added Line to the canvas");
                   }
                   if(input == " Polyline"){
                       Console.WriteLine();
                       createPolyline(canvas); //adds random polyline to the canvas
                       Console.WriteLine("Added Polyline to the canvas");
                   }
                   if(input == " Polygon"){
                       Console.WriteLine();
                       createPolygon(canvas); //adds random polygon to the canvas
                       Console.WriteLine("Added Polygon to the canvas");
                   }
                   if(input == " Path"){
                       Console.WriteLine();
                       createPath(canvas); //adds random line to the canvas
                       Console.WriteLine("Added Path to the canvas");
                   }
                return true;
               
                case 'U':
                    Console.WriteLine();
                    UndoCommand(canvas); //undos the last command
                return true;
                    
                case 'R':
                    Console.WriteLine();
                    RedoCommand(canvas); //redos the undo command that was just done
                return true;
                
                case 'S':
                    SaveCanvas(canvas); //converts svg to file format
                    Console.WriteLine();     
                return true;
                
                case 'q':
                case 'Q':
                    Console.WriteLine(); //ends the program
                    Console.WriteLine("Goodbye!");
                    return false;

                default:
                return true;
            }
        }

        static void Main()
        {
            bool showTheMenu = true;   // menu control
            Canvas canvas = new Canvas();

            while (showTheMenu) 
            {
                showTheMenu = MainMenu(canvas);
            }
        }
    }
}