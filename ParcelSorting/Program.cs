﻿﻿namespace ParcelSorting
{
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FirstParcelLine(boxSizes);
        }


        public static void FirstParcelLine(List<BoxSize> boxSizes)
        {
            //bool parcelFits = false;


            foreach (BoxSize box in boxSizes) 
            {
                Console.WriteLine("New sorting line starts");

                var boxLengthInHalf = box.Length /2;
                var halfBoxDiagonalNotSqrt = (boxLengthInHalf * boxLengthInHalf) + (box.Width * box.Width);
                var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSqrt);


                foreach (SortingLineParam sortingLine in box.SortingLineParams)
                {

                    foreach (Boxsize box in boxSizes)
                    {
                        Console.WriteLine("New sorting line starts");

                    var boxLength = box.Length;
                    var BoxDiagonalNotSqrt = (boxLengthInHalf * boxLengthInHalf) + (box.Width * box.Width);
                    var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSqrt);

                    }


                    if (sortingLine.Width >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and fits", sortingLine.Width);
                    }
                    else if (sortingLine.Width >= box.Width)
                    {
                        Console.WriteLine("Sorting line width or length is and fits", sortingLine.Width);
                    }

                    else if (sortingLine.Width <= halfParcelDiagonal && sortingLine.Width >= sortingLineDiagonal)

                    else
                    {
                        Console.WriteLine("It dosent fit to the sorting line and needs to be wider");
                    }


                }

                Console.WriteLine("\n");

            }

            //return parcelFits;
        }


        public static readonly List<BoxSize> boxSizes = new List<BoxSize>
        {
            new BoxSize
            {
                Length = 120,
                Width = 60,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 75
                    }
                }
            },
            new BoxSize
            {
                Length = 100,
                Width = 35,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 75
                    },
                    new SortingLineParam
                    {
                        Width = 50
                    },
                    new SortingLineParam
                    {
                        Width = 80
                    },
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 37
                    }
                }
            },

            new BoxSize
            {
                Length = 70,
                Width = 50,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 60
                    },
                    new SortingLineParam
                    {
                        Width = 60
                    },
                    new SortingLineParam
                    {
                        Width = 55
                    },
                    new SortingLineParam
                    {
                        Width = 90
                    }
                }
            }
        };
    }

    

    class BoxSize
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public List<SortingLineParam> SortingLineParams { get; set; }
            = new List<SortingLineParam>();
    }

    class SortingLineParam
    {
        public int Width { get; set; }
    }
}