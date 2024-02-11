
int x = 1;

One(x);
Console.WriteLine($"after one: {x}");

Two(ref x);
Console.WriteLine($"after two: {x}");

Three(x);
Three(ref x);
Three(in x);

Four(in x);

void One(int x)
{
    Console.WriteLine($"One {x}");
    x = 2;
}

void Two(ref int x)
{
    Console.WriteLine($"Two {x}");
    x = 3;
}

void Three(ref readonly int x)
{
    Console.WriteLine($"Three, {x}");

    // x = 4; cannot assign - readonly variable
}

void Four(in int x)
{
    // x = 5; cannot assign - readonly variable
    int x1 = x;
    x1 = 5;
}