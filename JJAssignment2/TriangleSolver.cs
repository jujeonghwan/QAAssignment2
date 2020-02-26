/*
 * TriangleSolver.cs
 * Assignment2
 * 
 *  Revision History
 *      Jeonghwan Ju, 2020.02.25: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJAssignment2
{
    /// <summary>
    /// TriangleSolver class
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// Check triangle
        /// </summary>
        /// <param name="dimension1">dimension 1</param>
        /// <param name="dimension2">dimension 2</param>
        /// <param name="dimension3">dimension 3</param>
        /// <returns></returns>
        public static string Analyze(int dimension1, int dimension2, int dimension3)
        {
            string result = "";

            if (dimension1 <= 0 || dimension2 <= 0 || dimension3 <= 0)
            {
                result = "NOT a triangle";
            }
            else if (dimension1 >= (dimension2 + dimension3) ||
                dimension2 >= (dimension3 + dimension1) ||
                dimension3 >= (dimension1 + dimension2))
            {
                result = "NOT a triangle";
            }
            else if ((dimension1 == dimension2) && (dimension2 == dimension3))
            {
                result = "An equilateral triangle";
            }
            else if (((dimension1 == dimension2) && (dimension1 != dimension3)) ||
                ((dimension2 == dimension3) && (dimension2 != dimension1)) ||
                ((dimension3 == dimension1) && (dimension3 != dimension2)))
            {
                result = "An isosceles triangle";
            }
            else
            {
                result = "A scalene triangle";
            }

            return result;
        }
    }
}
