namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22
{
    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            #region HIGHLIGHT
            checked
            {
                #endregion
                // int.MaxValue equals 2147483647
                int n = int.MaxValue;
                n = n + 1;
                System.Console.WriteLine(n);
                #region HIGHLIGHT
            }
            #endregion
        }
    }
    #endregion
}
