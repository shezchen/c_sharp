namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_27;

using System;

#region INCLUDE
interface IAngle
{
    void MoveTo(int degrees, int minutes, int seconds);
}

struct Angle : IAngle
{
    #region EXCLUDE
    public Angle(int degrees, int minutes, int seconds)
    {
        _Degrees = degrees;
        _Minutes = minutes;
        _Seconds = seconds;
    }
    #endregion EXCLUDE

    // NOTE:  This makes Angle mutable, against the general
    //        guideline
    public void MoveTo(int degrees, int minutes, int seconds)
    {
        _Degrees = degrees;
        _Minutes = minutes;
        _Seconds = seconds;
    }
    #region EXCLUDE
    public int Degrees
    {
        get { return _Degrees; }
    }
    private int _Degrees;

    public int Minutes
    {
        get { return _Minutes; }
    }
    private int _Minutes;

    public int Seconds
    {
        get { return _Seconds; }
    }
    private int _Seconds;
    #endregion EXCLUDE
}
public class Program
{
    public static void Main()
    {
        // ...

        Angle angle = new(25, 58, 23);
        // Example 1: Simple box operation
        object objectAngle = angle;  // Box
        Console.Write(((Angle)objectAngle).Degrees);

        // Example 2: Unbox, modify unboxed value,
        //            and discard value
        ((Angle)objectAngle).MoveTo
            (26, 58, 23);
        Console.Write(", " + ((Angle)objectAngle).Degrees);

        // Example 3: Box, modify boxed value,
        //            and discard reference to box
        ((IAngle)angle).MoveTo(26, 58, 23);
        Console.Write(", " + ((Angle)angle).Degrees);

        // Example 4: Modify boxed value directly
        ((IAngle)objectAngle).MoveTo(26, 58, 23);
        Console.WriteLine(", " + ((Angle)objectAngle).Degrees);

        // ...
    }
}
#endregion INCLUDE
