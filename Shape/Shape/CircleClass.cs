
namespace Shape
{
    /// <summary>
    ///  Class For Calculate Area And Perimeter Of Circle
    /// </summary>
    public class Circle : Oval
    {
        /// <summary>
        ///  Method For Calcualte Area Of Circle
        /// </summary>
        /// <param name="radius">radius of circle</param>
        /// <returns>Area Of Circle</returns>
        public double CalculateArea(double radius)
        {
            return base.CalculateArea(radius, radius);
        }

        /// <summary>
        /// Method For Calculate Perimeter Of Circle
        /// </summary>
        /// <param name="radius">radius of circle</param>
        /// <returns>Perimeter Of Circle</returns>
        public double CalculatePerimeter(double radius)
        {
            return base.CalculatePerimeter(radius, radius);
        }

        /// <summary>
        /// Method For Display ClassName
        /// </summary>
        /// <returns>Class Name</returns>
        public override string ClassName()
        {
            return typeof(Circle).Name;
        }
    }
}
