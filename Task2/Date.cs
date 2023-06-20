class Date
{
    private int _year;
    private int _month;
    private int _day;
    public Date(int year, int month, int day)
    {
        if (year >= 1000 && year <= 9999)
        {
            _year = year;
        }
        else
        {
            System.Console.WriteLine("Year must be between 1000 and 9999");
        }
        if (month >= 1 && month <= 12)
        {
            _month = month;
        }
        else
        {
            System.Console.WriteLine("Month must be between 1 and 12");
        }
        if (day >= 1 && day <= 31)
        {
            _day = day;
        }
        else
        {
            System.Console.WriteLine("Day must be between 1 and 31");
        }
    }
    public int GetYear()
    {
        return _year;
    }
    public int GetMonth()
    {
        return _month;
    }
    public int GetDay()
    {
        return _day;
    }
    public void SetYear(int year)
    {
        if (year >= 1000 && year <= 9999)
        {
            _year = year;
        }
        else
        {
            System.Console.WriteLine("Year must be between 1000 and 9999");
        }
    }
    public void SetMonth(int month)
    {
        if (month >= 1 && month <= 12)
        {
            _month = month;
        }
        else
        {
            System.Console.WriteLine("Month must be between 1 and 12");
        }
    }
    public void SetDay(int day)
    {
        if (day >= 1 && day <= 31)
        {
            _day = day;
        }
        else
        {
            System.Console.WriteLine("Day must be between 1 and 31");
        }
    }

    ///////////// get set ///////////
    /* public int GetYear
    {
        get
        {
            return _year;
        }
    }
    public int GetMonth
    {
        get
        {
            return _month;
        }
    }
    public int GetDay
    {
        get
        {
            return _day;
        }
    } */
    /* public int SetYear
    {
        set
        {
            if (value >= 1000 && value <= 9999)
            {
                _year = value;
            }
            else
            {
                System.Console.WriteLine("Year must be between 1000 and 9999");
            }
        }
    }
    public int SetMonth
    {
        set
        {
            if (value >= 1 && value <= 12)
            {
                _month = value;
            }
            else
            {
                System.Console.WriteLine("Month must be between 1 and 12");
            }
        }
    }
    public int SetDay
    {
        set
        {
            if (value >= 1 && value <= 31)
            {
                _day = value;
            }
            else
            {
                System.Console.WriteLine("Day must be between 1 and 31");
            }
        }
    } */
    public string ToString()
    {
        return $"{_month}/{_day}/{_year}";
    }
    public void SetDate(int year, int month, int day)
    {
        if (year >= 1000 && year <= 9999)
        {
            _year = year;
        }
        else
        {
            System.Console.WriteLine("Year must be between 1000 and 9999");
        }
        if (month >= 1 && month <= 12)
        {
            _month = month;
        }
        else
        {
            System.Console.WriteLine("Month must be between 1 and 12");
        }
        if (day >= 1 && day <= 31)
        {
            _day = day;
        }
        else
        {
            System.Console.WriteLine("Day must be between 1 and 31");
        }
    }
}