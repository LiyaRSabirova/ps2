double k, e, p, step, mult;
k = 1;
e = 0.1;
p = 1;
mult = 1;
while ((Math.Abs(Math.PI - p)) > e)
{
    step = k * k;
    mult *= (4 * step) / (4 * step - 1);
    p = 2 * mult;
    k++;
}
Console.WriteLine(p);
Console.WriteLine(Math.Abs(Math.PI - p));