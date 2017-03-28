using System;

namespace Classes
{

	class Classes1
	{
		static void Main(string[] args)
		{
			Cup cup = new Cup();
			cup.Colour = "Red";
			cup.Handle = "Small";
            cup.Shape = "Some mad shape";
            cup.Size = "Big";
            cup.Transparency = 2;
			cup.DisplayCup();

            Cup2 cup2 = new Cup2();
            cup.Colour = "Rasta";
            cup.Handle = "Just a handle";
            cup.Shape = "Rhombus";
            cup.Size = "Mahoosive";
            cup.Transparency = 3;
            cup.DisplayCup();


			// 1) step through the running of this code using F11
			//    watch the variables in the 'Locals' window
			
			// 2) add Shape, Size and Transparancy values to the above cup instance
			//    then run the program again
			
			// 3) add some more of your own cup instances
			//    with values for Colour, Handle, Shape, Size, Transparancy, and Handle
			//    step through the running of this code using F11
			//    watch the variables in the 'Locals' window
			
			System.Console.ReadLine();
		}
	}

	public class Cup 
	{
		public string Shape;
		public string Colour;
		public string Size;
		public int Transparency;
		public string Handle;

		public void DisplayCup()
		{
			System.Console.WriteLine("Cup is {0}, {1}, {2}, {3}, {4}", Colour, Handle, Shape, Size, Transparency);
		}

	}

    public class Cup2
    {
        public string Shape;
        public string Colour;
        public string Size;
        public int Transparency;
        public string Handle;

        public void DisplayCup()
        {
            System.Console.WriteLine("Cup is {0}, {1}, {2}, {3}, {4}", Colour, Handle, Shape, Size, Transparency);
        }
    }

	
}
