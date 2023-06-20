class Circle
{
    private double _radius;
    private string _color;
    public double GetRadius()
    {
        return _radius;
    }
    public string GetColor()
    {
        return _color;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
    ///// get set kati ///////////
    /*  public double GetRadius
     {
         get
         {
             return _radius;
         }
     }
     public string GetColor
     {
         get
         {
             return _color;
         }
     }
     public double GetArea
     {
         get
         {
             return Math.PI * _radius * _radius;
         }
     }
  */
    ///////////////////////////////////////////////////////
    public Circle() { }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }
}