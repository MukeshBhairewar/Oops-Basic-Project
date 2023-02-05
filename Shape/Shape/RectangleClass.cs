namespace Shape
{
    /// <summary>
    /// Class For Calculate Area And Perimeter Of Rectangle
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Method For Calculate Area Of Rectangle
        /// </summary>
        /// <param name="length">length of rectangle</param>
        /// <param name="width">width of rectangle</param>
        /// <returns>Area Of Rectangle</returns>
        public override double CalculateArea(double length, double width)
        {
            return length * width;
        }

        /// <summary>
        /// Method For Calculate Perimeter of Rectangle
        /// </summary>
        /// <param name="length">length of rectangle</param>
        /// <param name="width">width of reactangle</param>
        /// <returns>Perimeter of Rectangle</returns>
        public override double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        /// <summary>
        /// Method For Display Class Name
        /// </summary>
        /// <returns>Class Name</returns>
        public override string ClassName()
        {
            return typeof(Rectangle).Name;
        }
    }
}
