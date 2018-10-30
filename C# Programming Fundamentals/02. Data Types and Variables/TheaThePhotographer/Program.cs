using System;


class Program
{
    static void Main(string[] args)
    {
        uint numberOfPictures = uint.Parse(Console.ReadLine());
        uint filterTime = uint.Parse(Console.ReadLine());
        byte filterFactor = byte.Parse(Console.ReadLine());
        uint filteredPicturesTime = uint.Parse(Console.ReadLine());

        double usefulPictures = Math.Ceiling(numberOfPictures * (filterFactor / 100.0));

        uint totalTimeInSeconds = (uint)((numberOfPictures * filterTime) + (usefulPictures * filteredPicturesTime));        

        TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);
        string result = time.ToString(@"d\:hh\:mm\:ss");
        Console.WriteLine(result);
    }
}

