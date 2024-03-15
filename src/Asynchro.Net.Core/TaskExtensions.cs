namespace Asynchro.Net.Core;

public static class TaskExtensions
{
    public static void Deconstruct<T1,T2>(
        this Task<(T1, T2)> t, 
        out Task<T1> t1, 
        out Task<T2> t2
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
    }

    public static void Deconstruct<T1,T2, T3>(
        this Task<(T1, T2, T3)> t, 
        out Task<T1> t1, 
        out Task<T2> t2,
        out Task<T3> t3
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
        t3 = t.ContinueWith(a => a.Result.Item3);
    }

    public static void Deconstruct<T1,T2, T3, T4>(
        this Task<(T1, T2, T3, T4)> t, 
        out Task<T1> t1, 
        out Task<T2> t2,
        out Task<T3> t3,
        out Task<T4> t4
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
        t3 = t.ContinueWith(a => a.Result.Item3);
        t4 = t.ContinueWith(a => a.Result.Item4);
    }

    public static void Deconstruct<T1,T2, T3, T4, T5>(
        this Task<(T1, T2, T3, T4, T5)> t, 
        out Task<T1> t1, 
        out Task<T2> t2,
        out Task<T3> t3,
        out Task<T4> t4,
        out Task<T5> t5
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
        t3 = t.ContinueWith(a => a.Result.Item3);
        t4 = t.ContinueWith(a => a.Result.Item4);
        t5 = t.ContinueWith(a => a.Result.Item5);
    }

    public static void Deconstruct<T1,T2, T3, T4, T5, T6>(
        this Task<(T1, T2, T3, T4, T5, T6)> t, 
        out Task<T1> t1, 
        out Task<T2> t2,
        out Task<T3> t3,
        out Task<T4> t4,
        out Task<T5> t5,
        out Task<T6> t6
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
        t3 = t.ContinueWith(a => a.Result.Item3);
        t4 = t.ContinueWith(a => a.Result.Item4);
        t5 = t.ContinueWith(a => a.Result.Item5);
        t6 = t.ContinueWith(a => a.Result.Item6);
    }

    public static void Deconstruct<T1,T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2, T3, T4, T5, T6, T7)> t, 
        out Task<T1> t1, 
        out Task<T2> t2,
        out Task<T3> t3,
        out Task<T4> t4,
        out Task<T5> t5,
        out Task<T6> t6,
        out Task<T7> t7
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
        t3 = t.ContinueWith(a => a.Result.Item3);
        t4 = t.ContinueWith(a => a.Result.Item4);
        t5 = t.ContinueWith(a => a.Result.Item5);
        t6 = t.ContinueWith(a => a.Result.Item6);
        t7 = t.ContinueWith(a => a.Result.Item7);
    }

    public static void Deconstruct<T1,T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3, T4, T5, T6, T7, T8)> t, 
        out Task<T1> t1, 
        out Task<T2> t2,
        out Task<T3> t3,
        out Task<T4> t4,
        out Task<T5> t5,
        out Task<T6> t6,
        out Task<T7> t7,
        out Task<T8> t8
    )
    {
        t1 = t.ContinueWith(a => a.Result.Item1);
        t2 = t.ContinueWith(a => a.Result.Item2);
        t3 = t.ContinueWith(a => a.Result.Item3);
        t4 = t.ContinueWith(a => a.Result.Item4);
        t5 = t.ContinueWith(a => a.Result.Item5);
        t6 = t.ContinueWith(a => a.Result.Item6);
        t7 = t.ContinueWith(a => a.Result.Item7);
        t8 = t.ContinueWith(a => a.Result.Item8);
    }

    public static async Task<(T1, T2)> Splice<T1, T2>(
        this Task<T1> a, Task<T2> b
    )
    {
        return (await a, await b);
    }

    public static async Task<(T1, T2, T3)> Splice<T1, T2, T3>(
        this Task<T1> t1, Task<T2> t2, Task<T3> t3
    )
    {
        return (await t1, await t2, await t3);
    }

    public async static Task<(T1, T2, T3)> Splice<T1, T2, T3>(
        this Task<(T1, T2)> a, Task<T3> b
    )
    {
        var (t1, t2) = a;
        var t3 = b;
        return (await t1, await t2, await t3);
    }

    public static async Task<(T1, T2, T3)> Splice<T1, T2, T3>(
        this Task<T1> a, Task<(T2, T3)> b
    )
    {
        var t1 = a;
        var (t2, t3) = b;
        return (await t1, await t2, await t3);
    }

    public static async Task<(T1, T2, T3, T4)> Splice<T1, T2, T3, T4>(
        this Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4
    )
    {
        return (await t1, await t2, await t3, await t4);
    }

    public static async Task<(T1, T2, T3, T4)> Splice<T1, T2, T3, T4>(
        this Task<T1> a, Task<(T2, T3, T4)> b
    )
    {
        var t1 = a;
        var (t2, t3, t4) = b;
        return (await t1, await t2, await t3, await t4);
    }

    public static async Task<(T1, T2, T3, T4)> Splice<T1, T2, T3, T4>(
        this Task<(T1, T2)> a, Task<(T3, T4)> b
    )
    {
        var (t1, t2) = a;
        var (t3, t4) = b;
        return (await t1, await t2, await t3, await t4);
    }

    public static async Task<(T1, T2, T3, T4)> Splice<T1, T2, T3, T4>(
        this Task<(T1, T2, T3)> a, Task<T4> b
    )
    {
        var (t1, t2, t3) = a;
        var t4 = b;
        return (await t1, await t2, await t3, await t4);
    }

    public static async Task<(T1, T2, T3, T4, T5)> Splice<T1, T2, T3, T4, T5>(
        this Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5
    )
    {
        return (await t1, await t2, await t3, await t4, await t5);
    }

    public static async Task<(T1, T2, T3, T4, T5)> Splice<T1, T2, T3, T4, T5>(
        this Task<T1> a, Task<(T2, T3, T4, T5)> b
    )
    {
        var t1 = a;
        var (t2, t3, t4, t5) = b;
        return (await t1, await t2, await t3, await t4, await t5);
    }

    public static async Task<(T1, T2, T3, T4, T5)> Splice<T1, T2, T3, T4, T5>(
        this Task<(T1, T2)> a, Task<(T3, T4, T5)> b
    )
    {
        var (t1, t2) = a;
        var (t3, t4, t5) = b;
        return (await t1, await t2, await t3, await t4, await t5);
    }

    public static async Task<(T1, T2, T3, T4, T5)> Splice<T1, T2, T3, T4, T5>(
        this Task<(T1, T2, T3)> a, Task<(T4, T5)> b
    )
    {
        var (t1, t2, t3) = a;
        var (t4, t5) = b;
        return (await t1, await t2, await t3, await t4, await t5);
    }

    public static async Task<(T1, T2, T3, T4, T5)> Splice<T1, T2, T3, T4, T5>(
        this Task<(T1, T2, T3, T4)> a, Task<T5> b
    )
    {
        var (t1, t2, t3, t4) = a;
        var t5 = b;
        return (await t1, await t2, await t3, await t4, await t5);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Splice<T1, T2, T3, T4, T5, T6>(
        this Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5, Task<T6> t6
    )
    {
        return (await t1, await t2, await t3, await t4, await t5, await t6);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Splice<T1, T2, T3, T4, T5, T6>(
        this Task<T1> a, Task<(T2, T3, T4, T5, T6)> b
    )
    {
        var t1 = a;
        var (t2, t3, t4, t5, t6) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Splice<T1, T2, T3, T4, T5, T6>(
        this Task<(T1, T2)> a, Task<(T3, T4, T5, T6)> b
    )
    {
        var (t1, t2) = a;
        var (t3, t4, t5, t6) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Splice<T1, T2, T3, T4, T5, T6>(
        this Task<(T1, T2, T3)> a, Task<(T4, T5, T6)> b
    )
    {
        var (t1, t2, t3) = a;
        var (t4, t5, t6) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Splice<T1, T2, T3, T4, T5, T6>(
        this Task<(T1, T2, T3, T4)> a, Task<(T5, T6)> b
    )
    {
        var (t1, t2, t3, t4) = a;
        var (t5, t6) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Splice<T1, T2, T3, T4, T5, T6>(
        this Task<(T1, T2, T3, T4, T5)> a, Task<T6> b
    )
    {
        var (t1, t2, t3, t4, t5) = a;
        var t6 = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5, Task<T6> t6, Task<T7> t7
    )
    {
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<T1> a, Task<(T2, T3, T4, T5, T6, T7)> b
    )
    {
        var t1 = a;
        var (t2, t3, t4, t5, t6, t7) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2)> a, Task<(T3, T4, T5, T6, T7)> b
    )
    {
        var (t1, t2) = a;
        var (t3, t4, t5, t6, t7) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2, T3)> a, Task<(T4, T5, T6, T7)> b
    )
    {
        var (t1, t2, t3) = a;
        var (t4, t5, t6, t7) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2, T3, T4)> a, Task<(T5, T6, T7)> b
    )
    {
        var (t1, t2, t3, t4) = a;
        var (t5, t6, t7) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2, T3, T4, T5)> a, Task<(T6, T7)> b
    )
    {
        var (t1, t2, t3, t4, t5) = a;
        var (t6, t7) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Splice<T1, T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2, T3, T4, T5, T6)> a, Task<T7> b
    )
    {
        var (t1, t2, t3, t4, t5, t6) = a;
        var t7 = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5, Task<T6> t6, Task<T7> t7, Task<T8> t8
    )
    {
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<T1> a, Task<(T2, T3, T4, T5, T6, T7, T8)> b
    )
    {
        
        var t1 = a;
        var (t2, t3, t4, t5, t6, t7, t8) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2)> a, Task<(T3, T4, T5, T6, T7, T8)> b
    )
    {
        
        var (t1, t2) = a;
        var (t3, t4, t5, t6, t7, t8) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3)> a, Task<(T4, T5, T6, T7, T8)> b
    )
    {
        
        var (t1, t2, t3) = a;
        var (t4, t5, t6, t7, t8) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3, T4)> a, Task<(T5, T6, T7, T8)> b
    )
    {
        
        var (t1, t2, t3, t4) = a;
        var (t5, t6, t7, t8) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3, T4, T5)> a, Task<(T6, T7, T8)> b
    )
    {
        
        var (t1, t2, t3, t4, t5) = a;
        var (t6, t7, t8) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3, T4, T5, T6)> a, Task<(T7, T8)> b
    )
    {
        
        var (t1, t2, t3, t4, t5, t6) = a;
        var (t7, t8) = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Splice<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3, T4, T5, T6, T7)> a, Task<T8> b
    )
    {
        
        var (t1, t2, t3, t4, t5, t6, t7) = a;
        var t8 = b;
        return (await t1, await t2, await t3, await t4, await t5, await t6, await t7, await t8);
    }

    public static Task<T1> Out<T1, T2>(
        this Task<(T1, T2)> t, out Task<T2> result
    )
    {
        var (output, t2) = t;
        result = t2;
        return output;
    }

    public static Task<T1> Out<T1, T2, T3>(
        this Task<(T1, T2, T3)> t, out Task<(T2, T3)> result
    )
    {
        var (output, t2, t3) = t;
        result = Splice(t2, t3);
        return output;
    }

    public static Task<T1> Out<T1, T2, T3, T4>(
        this Task<(T1, T2, T3, T4)> t, out Task<(T2, T3, T4)> result
    )
    {
        var (output, t2, t3, t4) = t;
        result = Splice(t2, t3, t4);
        return output;
    }

    public static Task<T1> Out<T1, T2, T3, T4, T5>(
        this Task<(T1, T2, T3, T4, T5)> t, out Task<(T2, T3, T4, T5)> result
    )
    {
        var (output, t2, t3, t4, t5) = t;
        result = Splice(t2, t3, t4, t5);
        return output;
    }

    public static Task<T1> Out<T1, T2, T3, T4, T5, T6>(
        this Task<(T1, T2, T3, T4, T5, T6)> t, out Task<(T2, T3, T4, T5, T6)> result
    )
    {
        var (output, t2, t3, t4, t5, t6) = t;
        result = Splice(t2, t3, t4, t5, t6);
        return output;
    }

    public static Task<T1> Out<T1, T2, T3, T4, T5, T6, T7>(
        this Task<(T1, T2, T3, T4, T5, T6, T7)> t, out Task<(T2, T3, T4, T5, T6, T7)> result
    )
    {
        var (output, t2, t3, t4, t5, t6, t7) = t;
        result = Splice(t2, t3, t4, t5, t6, t7);
        return output;
    }

    public static Task<T1> Out<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Task<(T1, T2, T3, T4, T5, T6, T7, T8)> t, out Task<(T2, T3, T4, T5, T6, T7, T8)> result
    )
    {
        var (output, t2, t3, t4, t5, t6, t7, t8) = t;
        result = Splice(t2, t3, t4, t5, t6, t7, t8);
        return output;
    }
}
