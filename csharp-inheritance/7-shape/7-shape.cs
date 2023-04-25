using System;

/// <summary>Write a class Shape</summary>
class Shape
{

    /// <summary>Throws an NotImplementedException with the message Area() is not implemented</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Rectangle class that inherits from shape base class.</summary>
class Rectangle : Shape
{

    private int width;
    private int height;

    /// <summary>Gets/sets the width of the Rectangle.</summary>
    public int Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");

            this.width = value;
        }
    }

    /// <summary>Gets/sets the height of the Rectangle.</summary>
    public int Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");

            this.height = value;
        }
    }

    /// <summary>Method Area that returns the area of the class</summary>
    public new int Area()
    {
        return this.width * this.height;
    }

    /// <summary>Returns the string representation of the class.</summary>
    public override string ToString()
    {
        return $"[{this.GetType().Name}] {this.width} / {this.height}";
    }

}
