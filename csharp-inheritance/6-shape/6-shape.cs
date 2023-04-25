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

    // Represents the width of the Rectangle.
    private int width;
    // Represents the heigth of the Rectangle.
    private int height;

    /// <summary>Represents the width of the Rectangle.</summary>

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

            else
                this.width = value;
        }
    }

    /// <summary>Represents the height of the Rectangle.</summary>

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

            else
                this.height = value;
        }
    }
}
