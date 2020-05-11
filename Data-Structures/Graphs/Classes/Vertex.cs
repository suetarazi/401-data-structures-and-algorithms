using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Vertex<T>
{
	public T Value { get; set; }

	public Vertex (T value)
    {
        Value = value;
    }

}