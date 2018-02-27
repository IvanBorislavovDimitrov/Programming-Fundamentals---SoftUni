using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Rectangle
    {
        public double TopLeftPointX1 { get; set; }
        
        public double TopLeftPointY1 { get; set; }
        
        public double BottomRightX1 { get; set; }
        
        public double BottomRightY1 { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            Rectangle firstRectangle = new Rectangle();
            Rectangle secondRectangle = new Rectangle();
            double[] propertiesOfInputRectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            firstRectangle.TopLeftPointX1 = propertiesOfInputRectangle[0];
            firstRectangle.TopLeftPointY1 = propertiesOfInputRectangle[1];
            firstRectangle.BottomRightX1 = propertiesOfInputRectangle[0] + propertiesOfInputRectangle[2];
            firstRectangle.BottomRightY1 = propertiesOfInputRectangle[1] + propertiesOfInputRectangle[3];
            
            propertiesOfInputRectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            secondRectangle.TopLeftPointX1 = propertiesOfInputRectangle[0];
            secondRectangle.TopLeftPointY1 = propertiesOfInputRectangle[1];
            secondRectangle.BottomRightX1 = propertiesOfInputRectangle[0] + propertiesOfInputRectangle[2];
            secondRectangle.BottomRightY1 = propertiesOfInputRectangle[1] + propertiesOfInputRectangle[3];

            Console.WriteLine(IsFirstRectangleInSecond(firstRectangle, secondRectangle) ? "Inside" : "Not inside");
        }

        public static bool IsFirstRectangleInSecond(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            if (firstRectangle.TopLeftPointX1 >= secondRectangle.TopLeftPointX1 &&
                firstRectangle.TopLeftPointY1 >= secondRectangle.TopLeftPointY1 &&
                firstRectangle.BottomRightX1 <= secondRectangle.BottomRightX1 &&
                firstRectangle.BottomRightY1 <= secondRectangle.BottomRightY1)
            {
                return true;
            }
            return false;
        }
    }
}
