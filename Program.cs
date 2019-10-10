using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>{
                1,2,3,4,5,93
            };
            // First for find in JSJ
            int foundNum = nums.Find(n => n == 93);
            //filter
            List<int> filteredNums = nums.Where(n => n < 100).ToList();

            //sort
            List<int> orderedAndFiltered = nums.Where(n => n < 100).OrderBy(n => n).ToList();

            //reduce
            int sum = nums.Sum();

            int smallest = nums.Min();
            int biggest = nums.Max();

            // map
            List<int> doubled = nums.Select(num => num * 2).ToList();

            List<string> stringedNums = nums.Select(n =>
            {
                return n.ToString();
            }).ToList();

            /*
 Start with a collection that is of type IEnumerable, which
 List is and initialize it with some values. This is the
 class sizes for a selection of NSS cohorts.
*/
            List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };

            /*
                Now we need to determine which cohorts fell within the range
                of acceptable size - between 20 and 26 students. Also, sort
                the new enumerable collection in ascending order.
            */
            IEnumerable<int> idealSizes = from count in cohortStudentCount
                                          where count < 27 && count > 19
                                          orderby count ascending
                                          select count;

            // Display each number that was the acceptable size
            foreach (int c in idealSizes)
            {
                Console.WriteLine($"{c}");
            }
            Console.WriteLine($"Average ideal size is {idealSizes.Average()}");

            // The @ symbol lets you create multi-line strings in C#
            Console.WriteLine($@"
            There were {idealSizes.Count()} ideally sized cohorts
            There have been {cohortStudentCount.Count()} total cohorts");

            List<int> idealSizesLambda = cohortStudentCount.Where(count => count < 27 && count > 19)
            .OrderBy(count => count)
            .ToList();

            List<Shape> shapes = new List<Shape>()
            {
                new Shape(){NumberOfSides = 3, Height = 10.5, Width = 15.2,Color = "Orange"},
                new Shape(){NumberOfSides = 4, Height = 10.5, Width = 10.5,Color = "Red"},
                new Shape(){NumberOfSides = 1, Height = 10, Width = 10,Color = "Blue"},
            };
            Shape foundSquare = shapes.Find(shape => shape.NumberOfSides == 4);

            List<Shape> notCircles = shapes.Where(shapes=> shapes.NumberOfSides > 1).ToList();

            double sumOfHeights = shapes.Select(shape => shape.Height).Sum();
        }
    }

}

