using System;

namespace Restaurant;

public class Egg
{
    public ushort Crack()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 100);
        return (ushort)number;
    }
    public void Cook(){}
    public void Diskard(){}
}