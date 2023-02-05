namespace Shape
{
    /// <summary>
    ///  Abstract Class
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// static variable for calculate Object count
        /// </summary>
        public static int SerialNumber;

        /// <summary>
        ///  Abstract Method For AreaCalculation
        /// </summary>
        public abstract double CalculateArea(double width, double height);

        /// <summary>
        ///  Abstract Method For PerimeterCalculation
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public abstract double CalculatePerimeter(double width, double height);

        /// <summary>
        /// Shape constructor to increment Serialnumber
        /// </summary>
        public Shape()
        {
            SerialNumber = SerialNumber + 1;
        }

        /// <summary>
        /// Method For Display Class Name
        /// </summary>
        /// <returns>Class Name</returns>
        public virtual string ClassName()
        {
            return typeof(Shape).Name;
        }
    }
}
