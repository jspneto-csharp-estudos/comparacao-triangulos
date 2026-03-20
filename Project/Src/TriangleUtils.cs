namespace Project.Src;

static class TriangleUtils
{
    public static Triangle CompareAreas(Triangle t1, Triangle t2)
    {
        return t1.Area() >= t2.Area() ? t1 : t2;
    }
}