 class Math
{
    public const  double PI = 3.14;
    public const double E = 2.71;

    public double Abs(double value)
    {
        if (value < 0)
            return -value;
        else
            return value;
    }

    public float Abs(float value)
    {
        if (value < 0)
            return -value;
        else
            return value;
    }

    public int Abs(int value)
    {
        if (value < 0)
            return -value;
        else
            return value;
    }

    public double Pow(double x, double y)
    {
        return System.Math.Pow(x, y);
    }

    public double Sqrt(int d)
    {
        return System.Math.Sqrt(d);
    }

    public int Max(int val1, int val2)
    {
        if (val1 > val2)
            return val1;
        else
            return val2;
    }

    public int Min(int val1, int val2)
    {
        if (val1 < val2)
            return val1;
        else
            return val2;
    }
}


