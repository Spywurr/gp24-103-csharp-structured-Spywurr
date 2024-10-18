int timer = 5;

void Countdown()
    {
    Console.WriteLine($"{timer}...");
    timer = timer - 1;
    if (timer > -1)
    {
        Countdown();
    }
    else
    {
    Console.WriteLine("Launch!");
    }
}

Countdown();