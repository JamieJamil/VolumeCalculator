namespace GPArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop som gør at programmet køre indtil man selv lukker det
            while (true)
            {
                // Loop af menuen
                Menu();
            }
        }

        static void Menu()
        {
            // Clear for bedre visualisering
            Console.Clear();
            Console.WriteLine("What do you want to calculate the volume of?\n\n[1] Cylinder\n[2] Sphere\n[3] Rectangle\n[4] Cone\n[5] Cube");
            Console.WriteLine("");
            Console.WriteLine("Go to:");
            // Switch cases med metoder, der kommer an på hvad brugeren indtaster
            switch (Console.ReadKey(true).Key)
            {
                // NumPad1, er så man også kan bruge numpad og de foeskellige metoder
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    CylinderVol();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SphereVol();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    RectangleVol();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    ConeVol();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    CubeVol();
                    break;
                default:
                    break;
            }
        }
        // Metode af Cylinder
        static double CylinderVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double radius = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double height = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget
            double volume = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine($"Volume of the cylinder is {volume:0.##}");
            Console.ReadKey();

            return volume;

        }
        // Metode af Sphere
        static double SphereVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double radius = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget
            double volume = (4.0 / 3 * Math.PI * radius * radius * radius);

            Console.WriteLine($"Volume of the sphere is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Rectangle
        static double RectangleVol()
        {
            Console.Clear();
            Console.WriteLine("Enter length: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double length = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double width = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double height = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget
            double volume = length * width * height;

            Console.WriteLine($"Volume of the rectangle is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Cone
        static double ConeVol()
        {
            Console.Clear();
            Console.WriteLine("Enter radius: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double radius = CheckDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double height = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget
            double volume = (1.0 / 3) * Math.PI * height * radius * radius;

            Console.WriteLine($"Volume of the cone is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode af Cube
        static double CubeVol()
        {
            Console.Clear();
            Console.WriteLine("Enter side length: ");
            // Tager brugerens input
            // CheckDouble checker om brugerens input er godkendt
            double length = CheckDouble(Console.ReadLine());

            // Udregning for at finde rumfanget
            double volume = length * length * length;

            Console.WriteLine($"Volume of the cube is {volume:0.##}");
            Console.ReadKey();

            return volume;
        }
        // Metode der checker brugerens input
        static double CheckDouble(string input)
        {
            bool b = double.TryParse(input, out double value);
            // Hviis input er mindre en 1 eller ikke et tal vil den give fejlmeddelelse 
            while (!b || value <= 0)
            {
                Console.WriteLine("Wrong input, try again");
                input = Console.ReadLine();
                // Tager brugerens nye input
                b = double.TryParse(input, out value);
            }
            return value;
        }
    }
}