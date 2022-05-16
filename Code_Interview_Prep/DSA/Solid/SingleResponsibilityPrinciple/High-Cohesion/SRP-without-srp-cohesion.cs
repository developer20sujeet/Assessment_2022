using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_OOD_Solid_SysDesign.Solid.SingleResponsibilityPrinciple
{
    /// <summary>
    /// this class is without following Single Responsibility Principle
    /// https://paigeshin1991.medium.com/single-responsibility-principle-what-working-as-a-software-engineer-you-dont-know-it-e74883f92944
    /// Before Refactoring **/  
    /// Too Many Responsibilities 
    /// - Measurements of squares 
    /// - Rendering images of squares 
    /// </summary>
    internal class Square
    {

        int side = 5;

        public int calculateArea()
        {
            return side * side;
        }

        public int calculatePerimeter()
        {
            return side * 4;
        }

        // draw and roatate is separate functionality that is in same class 
        public void draw()
        {
            bool highResolutionMonitor=false;

            if (highResolutionMonitor)
            {
                // Render a high resolution image of a square
            }
            else
            {
                // Render a normal image of a square
            }
        }

        public void rotate(int degree)
        {
            // Rotate the image of the square clockwise to
            // the required degree and re-render 
        }

    }
}
