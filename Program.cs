// See https://aka.ms/new-console-template for more information



for (int i = 0; i < 30; i++)
{
    Console.WriteLine(GetoutputString(i));
}

static string GetoutputString(int i)
{
    return (i % 3, i % 5) switch
    {
        (0,0)=>"FizzBuzz",
        (_,0)=>"Bizz",
        (0,_)=>"Fizz",
        (_,_)=> i.ToString()
    };
}


