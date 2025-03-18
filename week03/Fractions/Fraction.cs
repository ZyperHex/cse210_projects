class Fraction {


    // Private attributes for the numerator and denominator of the fraction.
    // Using 'private' ensures that these attributes can only be accessed from within the class.
    private int _top;
    private int _bottom;

    // Constructor without parameters
    public Fraction()
    {
       _top = 1;
       _bottom = 1;
    }

    // Constructor with 1 parameter
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }
    
    // Constructor with 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    ///////////////////// GETTER AND SETTER ///////////////////////////
    public int Top
    {
        get{ return _top; } // Get the _top value
        set{ _top = value; } // set the value previously taken and uses its value to _top
    }

    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }

    
    // This is a way to display the content 
    public string GetFractionString()
    {
        string text = $"{Top}/{Bottom}";
        return text;

    }
    public double GetDecimalValue()
    {
        return (double)Top / (double)Bottom; 
    }
}

// IT IS IMPORTANT TO KNOW HOW TO USE PUBLIC AND PRIVATE TO ACCESS IT IN THE MAIN CLASS.