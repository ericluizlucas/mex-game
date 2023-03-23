class Solver
{

    static int Solve(int[] arr)
    {
        int mex = -1;
        for (int i = 0; i <= arr.Length; i++)
        {
            bool exists = false;
            foreach (var item in arr)
            {
                if (item == i)
                    exists = true;
            }
            if (!exists) return mex = i;
        }
        return mex;
    }

    static void Main()
    {
        int[] arr = new int[] { 1, 0, 2, 5 };
        int mex = Solve(arr);

        Console.WriteLine(mex);

    }
}




