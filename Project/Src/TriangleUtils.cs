namespace Project.Src;

static class TriangleUtils
{
    public static Triangle CompareAreas(Triangle t1, Triangle t2)
    {
        if (t1.Area() >= t2.Area())
        {
            return t1;
        }
        else
        {
            return t2;
        }
    }
}