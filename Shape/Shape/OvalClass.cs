using System;

namespace Shape
{
    /// <summary>
    ///  Oval Class For Calculate Area And perimeter
    /// </summary>
    public class Oval : Shape
    {
        /// <summary>
        /// Method For Calculate Area Of Oval
        /// </summary>
        /// <param name="minoraxis">minoraxis of oval</param>
        /// <param name="majoraxis">majoraxis of oval</param>
        /// <returns>Area Of Oval</returns>
        public override double CalculateArea(double minoraxis, double majoraxis)
        {
            return Math.PI * minoraxis * majoraxis;
        }

        /// <summary>
        /// Method For Calculate Perimeter Of Oval
        /// </summary>
        /// <param name="minoraxis">minoraxis of oval</param>
        /// <param name="majoraxis">majoraxis of oval</param>
        /// <returns>Perimeter Of Oval</returns>
        public override double CalculatePerimeter(double minoraxis, double majoraxis)
        {
            double Perimeter;
            Perimeter = (double)2 * Math.PI * Math.Sqrt((minoraxis * minoraxis + majoraxis * majoraxis) / (2));
            return Perimeter;
        }

        /// <summary>
        /// Method For display class Name
        /// </summary>
        /// <returns>Class Name</returns>
        public override string ClassName()
        {
            return typeof(Oval).Name;
        }
    }
}
