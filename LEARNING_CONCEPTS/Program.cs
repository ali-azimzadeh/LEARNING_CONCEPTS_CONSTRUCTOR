namespace LEARNING_CONCEPTS
{
    internal static class Program
    {
        static Program()
        {
        }

        internal static void Main(string[] args)
        {
            //Googooli googooli = 
            //    new Googooli(age: 30, fullName: "ali");

            //var googooli = new Googooli()
            // **************************************************
            //Person person = new Person();

            //person.Age = 20;
            //person.FullName = "Ali Reza Alavi";



            // **************************************************

            // **************************************************
            //Person person = new Person() { FullName = "Ali Reza Alavi", Age = 20 };
            // **************************************************

            // **************************************************
            //Person person =
            //    new Person() { Age = 20, FullName = "Ali Reza Alavi" };
            // **************************************************

            // **************************************************
            //Person person =
            //    new Person()
            //    {
            //        FullName = "Ali Reza Alavi",
            //        Age = 20
            //    };
            // **************************************************

            // **************************************************
            //Person person =
            //    new Person
            //    {
            //        FullName = "Ali Reza Alavi",
            //        Age = 20
            //    };
            // **************************************************

            // **************************************************
            //Person person =
            //	new Person
            //	{
            //		FullName = "Ali Reza Alavi",
            //		Age = 20,
            //	};
            // **************************************************

            // **************************************************
            //Person person =
            //    new Person
            //    {
            //        Age = 20,
            //        FullName = "Ali Reza Alavi",
            //    };
            // **************************************************

            // **************************************************
            //Circle circle = new Circle(); // Compile Error!

            //circle.BorderWidth = 2;

            Circle circle1 = new Circle(2, 3, 10);

            Circle circle2 = new Circle(x: 2, y: 3, radius: 10);

            Circle circle3 =
                new Circle(x: 2, y: 3, radius: 10)
                {
                    BorderWidth = 5,
                    
                };
            // **************************************************

            System.Console.Write("Press [ENTER] To Exit... ");
            System.Console.ReadLine();
        }
    }
}
