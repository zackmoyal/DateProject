public class Date
{
    // Declare three private fields: month, day, and year
    private int month;
    private int day;
    private int year;

    // Default constructor
    public Date()
    {
        // Set everything to 0
        month = 0;
        day = 0;
        year = 0;
    }

    // Parameterized constructor
    public Date(int month, int day, int year)
    {
        // Call SetMonth and pass it month
        SetMonth(month);
        // Call SetDay and pass it day
        SetDay(day);
        // Call SetYear and pass it year
        SetYear(year);
    }

    // Property for Month
    public int Month
    {
        get { return month; }
        set { SetMonth(value); }
    }

    // Property for Day
    public int Day
    {
        get { return day; }
        set { SetDay(value); }
    }

    // Property for Year
    public int Year
    {
        get { return year; }
        set { SetYear(value); }
    }

    // SetMonth method
    public void SetMonth(int month)
    {
        // Set the field month to the parameter month iff the parameter month is between 1 and 12.
        if (month >= 1 && month <= 12)
        {
            this.month = month;
        }
    }

    // SetDay method
    public void SetDay(int day)
    {
        // Set the field day to the parameter day
        // iff the parameter day is between 1 and 28/30/31 depending on the month.
        // If the month is not yet set, the day cannot be set.
        int max = 31;

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (day >= 1 && day <= max)
                {
                    this.day = day;
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                if (day >= 1 && day <= 30)
                {
                    this.day = day;
                }
                break;
            case 2:
                int daysInFebruary;
                if (year % 4 != 0)
                {
                    daysInFebruary = 28;
                }
                else if (year % 100 != 0)
                {
                    daysInFebruary = 29;
                }
                else if (year % 400 != 0)
                {
                    daysInFebruary = 28;
                }
                else
                {
                    daysInFebruary = 29;
                }

                if (day >= 1 && day <= daysInFebruary)
                {
                    this.day = day;
                }
                break;
        }
    }

    // SetYear method
    public void SetYear(int year)
    {
        // Set the field year to the parameter year iff the parameter year is a non-negative integer.
        if (year >= 0)
        {
            this.year = year;
        }
    }

    // Overriding Equals method
    public override bool Equals(object obj)
    {
        bool retVal = false;
        if (obj is Date d)
        {
            // retVal is true if all attributes are the same
            retVal = (year == d.year) && (month == d.month) && (day == d.day);
        }
        return retVal;
    }

    // Overriding ToString method
    public override string ToString()
    {
        // Return a useful string to the user.
        return $"{month}-{day}-{year}";
    }
}