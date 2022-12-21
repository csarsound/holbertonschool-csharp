using System;

/// <summary>
/// (C#)
/// </summary>
class Shape
{
    /// <summary>
    /// (C#)
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// class Rectangle
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// public Rectangle int Width
    /// </summary>
    public int Width
    {
        get => this.width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                this.width = value;
        }
    }
    /// <summary>
    /// public int Height
    /// </summary>
    public int Height
    {
        get => this.height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                this.height = value;
        }
    }
}
