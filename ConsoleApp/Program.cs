using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shapes;
using ClassLibrary;
using Rectangle = ClassLibrary.Rectangle;

class Program
{
    static async Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true" },
            { "FeatureManagement:Rectangle", "false" },
            { "FeatureManagement:Triangle", "true" }
        };

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Square feature is enabled.");
            // Provide access to Square
            Console.WriteLine("Enter side length for Square:");
            double sideLength = double.Parse(Console.ReadLine());
            var square = new Square(sideLength); // Example instantiation
            Console.WriteLine($"Area of the square: {square.CalculateArea()}");
            Console.WriteLine($"Perimeter of the square: {square.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Square feature is disabled.");
        }

        // Check if Rectangle feature is enabled
        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Rectangle feature is enabled.!");

            Console.WriteLine();
            Console.WriteLine("Enter the length: ");
            if (double.TryParse(Console.ReadLine(), out double l))
            {
                Console.WriteLine();
                Console.WriteLine("Enter the width: ");
                if (double.TryParse(Console.ReadLine(), out double w))
                {
                    var rectangle = new Rectangle(l, w);

                    Console.WriteLine();
                    Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
                    Console.WriteLine($"Perimeter of Rectangle: {rectangle.CalculatePerimeter()}");
                }
                else
                {
                    Console.WriteLine("Invalid input for width.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for length.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Rectangle feature is disabled.!");
        }

        // Check if Triangle feature is enabled
        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Triangle feature is enabled.!");
            Console.WriteLine();
            Console.WriteLine("Enter the length of side 1: ");
            if (double.TryParse(Console.ReadLine(), out double s1))
            {
                Console.WriteLine("Enter the length of side 2: ");
                if (double.TryParse(Console.ReadLine(), out double s2))
                {
                    Console.WriteLine("Enter the length of side 3: ");
                    if (double.TryParse(Console.ReadLine(), out double s3))
                    {
                        var triangle = new Triangle(s1, s2, s3);

                        Console.WriteLine();
                        Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}");
                        Console.WriteLine($"Perimeter of Triangle: {triangle.CalculatePerimeter()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for side 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for side 2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for side 1.");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Triangle feature is disabled.!");
        }
    }
}
