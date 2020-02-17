using System;
namespace Assignment2_QA
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
       {
            if((side1 == side2) && (side2 == side3))
            {
                return "Equilateral";
            }
            
            if((side1 == side2) && (side2 != side3))
            {
                return "Isosceles";
            }

            return "Scalene";
       }

    }
}
