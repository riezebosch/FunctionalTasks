namespace FunctionalTasks;

public static class Factory
{
    public static Task Or(this Task t1, Task t2) => Task.WhenAny(t1, t2);
    public static Task<Task<T>> Or<T>(this Task<T> t1, Task<T> t2) => Task.WhenAny(t1, t2);
    public static Task And(this Task t1, Task t2) => Task.WhenAll(t1, t2);
}