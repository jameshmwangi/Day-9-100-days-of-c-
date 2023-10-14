// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Mearsurement: {result}");

// }
// else

//     {Console.WriteLine("Unable to report the measuremennt");}
stringring[] values={"12.3","45","ABC","11","DEF"};

foreach(var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total+=number;
    }
    else{
        message+= value;
    }
}
Console.WriteLine($"Message:{message}");
Console.WriteLine($"Total:{total}");