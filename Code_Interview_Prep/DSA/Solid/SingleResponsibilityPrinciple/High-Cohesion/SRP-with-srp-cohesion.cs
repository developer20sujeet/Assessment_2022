using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_OOD_Solid_SysDesign.Solid.SingleResponsibilityPrinciple
{
    //[1] Always Aim for High Cohesion
    //Cohesion is the degree to which the various parts of a software component are related

    /// <summary>
    /// this class is using  Single Responsibility Principle
    /// https://paigeshin1991.medium.com/single-responsibility-principle-what-working-as-a-software-engineer-you-dont-know-it-e74883f92944
    /// After Refactoring 
    /// only one Responsibilities 
    /// - Measurements of squares 
    /// </summary>
    internal class Squares
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

    }

    /// <summary>
    /// this class is using  Single Responsibility Principle
    /// https://paigeshin1991.medium.com/single-responsibility-principle-what-working-as-a-software-engineer-you-dont-know-it-e74883f92944
    /// After Refactoring 
    /// only one Responsibilities 
    /// - Rendering images of squares 
    /// </summary>
    class SquareUI
    {

        public void draw()
        {
            bool highResolutionMonitor = false;
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
            // Rotate the iamge of the square clockwise to
            // the required degree and re-render 
        }

    }
}
