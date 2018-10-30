using System;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        bool isSbyte = sbyte.TryParse(input, out sbyte sbyteResult);
        bool isByte = byte.TryParse(input, out byte byteResult);
        bool isShort = short.TryParse(input, out short shortResult);
        bool isUshort = ushort.TryParse(input, out ushort ushortResult);
        bool isInt = int.TryParse(input, out int intResult);
        bool isUint = uint.TryParse(input, out uint uintResult);
        bool isLong = long.TryParse(input, out long longResult);

        if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
        {
            Console.WriteLine($"{input} can fit in:");

            if (isSbyte)
            {
                Console.WriteLine("* sbyte");
            }
            if (isByte)
            {
                Console.WriteLine("* byte");
            }
            if (isShort)
            {
                Console.WriteLine("* short");
            }
            if (isUshort)
            {
                Console.WriteLine("* ushort");
            }
            if (isInt)
            {
                Console.WriteLine("* int");
            }
            if (isUint)
            {
                Console.WriteLine("* uint");
            }
            if (isLong)
            {
                Console.WriteLine("* long");
            }
        }
        else
        {            
            Console.WriteLine($"{input} can't fit in any type");
        }
    }
}

