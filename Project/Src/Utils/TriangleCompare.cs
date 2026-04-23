namespace Project.Src.Utils;

class TriangleCompare
{
    public static Triangle GetLargestAreaTriangle(Triangle t1, Triangle t2)
    {
        return t1.Area() >= t2.Area() ? t1 : t2;
    }
}