namespace Project.Src;

class Triangle
{
    public string Name = "ABC";
    public double Side1;
    public double Side2;
    public double Side3;

    public double Area()
    {
        double p = (Side1 + Side2 + Side3) / 2.0;
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }
}