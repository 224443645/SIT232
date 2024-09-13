class MyDate
{
    private int _year;
    private int _month;
    private int _day;

    private readonly string[] MONTHS = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    private readonly string[] DAYS = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    private readonly int[] DAYS_IN_MONTHS = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    public MyDate(int day, int month, int year)
    {
        if (day < 1 || day > 31) { throw new ArgumentOutOfRangeException("Invalid day"); }
        _day = day;
        if (month < 1 || month > 12) { throw new ArgumentOutOfRangeException("Invalid month"); }
        _month = month;
        if (year < 1 || year > 9999) { throw new ArgumentOutOfRangeException("Invalid year"); }
        _year = year;
    }

    public void SetYear(int year)
    {
        if (year < 1 || year > 9999) { throw new ArgumentOutOfRangeException("Invalid year"); }
        _year = year;
    }

    public void SetMonth(int month)
    {
        if (month < 1 || month > 12) { throw new ArgumentOutOfRangeException("Invalid month"); }
        _month = month;
    }

    public void SetDay(int day)
    {
        if (day < 1 || day > DAYS_IN_MONTHS[_month - 1]) { throw new ArgumentOutOfRangeException("Invalid day"); }
        _day = day;
    }

    public void SetDate(int day, int month, int year)
    {
        if (day < 1 || day > 31) { throw new ArgumentOutOfRangeException("Invalid day"); }
        _day = day;
        if (month < 1 || month > 12) { throw new ArgumentOutOfRangeException("Invalid month"); }
        _month = month;
        if (year < 1 || year > 9999) { throw new ArgumentOutOfRangeException("Invalid year"); }
        _year = year;
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

    public MyDate NextDay()
    {
        if (_day == 28 && _month == 2 && IsLeapYear(_year))
        {
            _day += 1;
        }
        else if (_day + 1 == DAYS_IN_MONTHS[_month - 1])
        {
            _day = 1;
            NextMonth();
        }
        else
        {
            _day += 1;
        }
        return this;
    }

    public MyDate PreviousDay()
    {
        if (IsLeapYear(_year) && _day - 1 < 1 && _month - 1 == 2)
        {
            PreviousMonth();
            _day = 29;
        }
        else if (_day - 1 < 1)
        {
            PreviousMonth();
            _day = DAYS_IN_MONTHS[_month - 1];
        }
        else
        {
            _day -= 1;
        }

        return this;
    }

    public MyDate NextMonth()
    {
        if (IsLeapYear(_year) && _month == 1 && _day > 29)
        {
            _month++;
            _day = 29;
        }
        else if (_month + 1 > 12)
        {
            NextYear();
            _month = 1;

        }
        else
        {
            _month++;

        }

        if (_day == DAYS_IN_MONTHS[_month - 1] && !IsLeapYear(_year))
        {
            _day = DAYS_IN_MONTHS[_month];
        }
        return this;
    }

    public MyDate PreviousMonth()
    {
        if (IsLeapYear(_year) && _month == 3 && _day > 29)
        {
            _month--;
            _day = 29;
        }
        else if (_month <= 1)
        {
            PreviousYear();
            _month = 1;
        }
        else
        {
            _month++;
        }

        if (_day == DAYS_IN_MONTHS[_month - 1] && !IsLeapYear(_year))
        {
            _day = DAYS_IN_MONTHS[_month];
        }
        return this;
    }

    public MyDate NextYear()
    {
        if (_year + 1 > 9999) { throw new InvalidOperationException("Year out of range!"); }
        if (IsLeapYear(_year) && _day == 29 && _month == 2) { _day = 28; }
        _year++;
        return this;
    }

    public MyDate PreviousYear()
    {
        if (_year - 1 < 1) { throw new InvalidOperationException("Year out of range!"); }
        if (IsLeapYear(_year) && _month == 2 && _day == 29) { _day = 28; }
        _year--;
        return this;
    }

    public bool IsLeapYear(int year)
    {
        return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }

    public override string ToString()
    {
        return $"{DAYS[GetDayOfWeek(_day, _month, _year)]} {_day} {MONTHS[_month - 1]} {_year}";
    }

    public bool IsValidDate(int year, int month, int day)
    {
        bool valid = true;

        if (year < 1 || year > 9999 || month < 1 || month > 12)
        {
            valid = false;
        }
        if (day < 1 || day > DAYS_IN_MONTHS[month - 1]) { valid = false; }
        if (day >= 1 && IsLeapYear(year) && day <= 29) { valid = true; }

        return valid;
    }

    public int GetDayOfWeek(int day, int month, int year)
    {
        int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

        if (month < 3) { year -= 1; }


        return (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;
    }
}