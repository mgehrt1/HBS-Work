static bool CheckEquality<A, B>(A a, B b) {
    return Equals(a, b);
}

// tests
Console.WriteLine(CheckEquality(1, true));
Console.WriteLine(CheckEquality(0, "0"));
Console.WriteLine(CheckEquality(1, 1));