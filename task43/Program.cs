// Find the intersection point of two lines y=k1*x+b1 and y=k2*x+b2. User enters k1, b1, k2, b2.
// k1*x+b1=k2*x+b2
// x=(b2-b1)/(k1-k2)

double[] GetLine()
{
    Console.WriteLine("Enter k and b for the line: ");
    string[] str = Console.ReadLine().Split(" ");
    double[] line = new double[2];
    for (int i = 0; i < 2; i++)
        line[i] = Convert.ToDouble(str[i]);
    return line;
}

double[] Intersection(double[] line1, double[] line2)
{
    double[] x = new double[2];
    if (line1[0] != line2[0])
    {
        x[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]);
        x[1] = line1[0] * x[0] + line1[1];
        Console.WriteLine($"The intersection point is x={x[0]}, y={x[1]}.");
    }
    else
    {
        Console.WriteLine($"There is no intersection point. Lines are parallel.");
    }
    return x;
}

double[] line1 = GetLine();
double[] line2 = GetLine();

double[] x = Intersection(line1, line2);






