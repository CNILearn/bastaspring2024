
int x = 1;

// pass by value
One(x);  // pass by value
Console.WriteLine($"after one: {x}");

// pass by reference
// Two(x); // error, must use ref
Two(ref x);
Console.WriteLine($"after two: {x}");

// pass by readonly reference
Three(x);  // warning, should use in or ref
Three(ref x); 
Three(in x); 

// pass by in reference
Four(x);
Four(ref x);  // warning - consider using in
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