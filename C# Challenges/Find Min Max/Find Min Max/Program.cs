static int[] FindMinMax(int[] arr) {
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++) {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    return new int[] {min, max};
}

// tests
int[] test1 = FindMinMax(new int[] {1, 2, 3, 4, 5});
int[] test2 = FindMinMax(new int[] {2334454, 5});
int[] test3 = FindMinMax(new int[] {1});

Console.WriteLine("[" + test1[0] + ", " + test1[1] + "]");
Console.WriteLine("[" + test2[0] + ", " + test2[1] + "]");
Console.WriteLine("[" + test3[0] + ", " + test3[1] + "]");
