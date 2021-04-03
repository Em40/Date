namespace Date
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public struct Date
    {
        private const int MAX_DAYS_IN_MONTH = 31;
        private const int MAX_COUNT_OF_MONTHS = 12;
        private const int MIN_COUNT_OF_MONTHS = 1;


        private int day;
        private int month;
        private int year;


        public int Day
        {
            get
            {
                return this.day;
            }
            set
            {
                if (value > 0 && value <= MAX_DAYS_IN_MONTH)
                {
                    this.day = value;
                }
                else
                {
                    throw new Exception("Invalid count of days!");
                }
            }
        }
        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                if (value >= MIN_COUNT_OF_MONTHS && value <= MAX_COUNT_OF_MONTHS)
                {
                    this.month = value;
                }
                else
                {
                    throw new Exception("Invalid count of months!");
                }
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value > 0)
                {
                    this.year = value;
                }
                else
                {
                    throw new Exception("Invalid year!");
                }
            }
        }
        public string Add(int days)
        {
            string output = "";
            int daysInMonth = 0;

            if (this.year % 4 == 0)
            {
                this.day += days;

                while (true)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            daysInMonth = 31;
                            break;
                        case 2:
                            daysInMonth = 29;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            daysInMonth = 30;
                            break;
                    }
                    if (daysInMonth < this.day)
                    {
                        this.day -= daysInMonth;
                        this.month++;
                    }
                    if (this.month > 12)
                    {
                        this.month -= 12;
                        this.year++;
                    }
                    if (this.day <= daysInMonth)
                    {
                        break;
                    }
                }

                output = $"{this.day}, {this.month}, {this.year}";
            }
            else
            {
                this.day += days;

                while (true)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            daysInMonth = 31;
                            break;
                        case 2:
                            daysInMonth = 28;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            daysInMonth = 30;
                            break;
                    }
                    if (daysInMonth < this.day)
                    {
                        this.day -= daysInMonth;
                        this.month++;
                    }
                    if (this.month > 12)
                    {
                        this.month -= 12;
                        this.year++;
                    }
                    if (this.day <= daysInMonth)
                    {
                        break;
                    }
                }
                //switch (month)
                //{
                //    case 1:
                //    case 3:
                //    case 5:
                //    case 7:
                //    case 8:
                //    case 10:
                //    case 12:
                //        daysInMonth = 31;
                //        break;
                //    case 2:
                //        daysInMonth = 28;
                //        break;
                //    case 4:
                //    case 6:
                //    case 9:
                //    case 11:
                //        daysInMonth = 30;
                //        break;
                //}
                //if (daysInMonth < this.day)
                //{
                //    this.day -= daysInMonth;
                //    this.month++;
                //}
                //if (this.month > 12)
                //{
                //    this.month -= 12;
                //    this.year++;
                //}
                output = $"{this.day}, {this.month}, {this.year}";
            }

            return output;
        }
        public string Remove(int days)
        {
            string output = "";
            int daysInMonth = 0;

            if (this.year % 4 == 0)
            {
                this.day -= days;

                while (true)
                {
                    if (0 >= this.day)
                    {
                        this.day = Math.Abs(this.day);
                        this.month--;
                    }

                    if (this.month == 0)
                    {
                        this.month = 12;
                        this.year--;
                    }

                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            daysInMonth = 31;
                            break;
                        case 2:
                            daysInMonth = 29;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            daysInMonth = 30;
                            break;
                    }

                    this.day -= daysInMonth;
                    if (this.day < daysInMonth)
                    {
                        month--;
                    }
                    if (this.day <= daysInMonth)
                    {
                        break;
                    }
                }

                //if (0 >= this.day)
                //{
                //    this.day = Math.Abs(this.day);
                //    this.month--;
                //}

                //if (this.month == 0)
                //{
                //    this.month = 12;
                //    this.year--;
                //}

                //switch (month)
                //{
                //    case 1:
                //    case 3:
                //    case 5:
                //    case 7:
                //    case 8:
                //    case 10:
                //    case 12:
                //        daysInMonth = 31;
                //        break;
                //    case 2:
                //        daysInMonth = 29;
                //        break;
                //    case 4:
                //    case 6:
                //    case 9:
                //    case 11:
                //        daysInMonth = 30;
                //        break;
                //}

                //this.day = daysInMonth - this.day;

                output = $"{this.day}, {this.month}, {this.year}";
            }
            else
            {
                this.day -= days;

                while (true)
                {
                    if (0 >= this.day)
                    {
                        this.day = Math.Abs(this.day);
                        this.month--;
                    }

                    if (this.month == 0)
                    {
                        this.month = 12;
                        this.year--;
                    }

                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            daysInMonth = 31;
                            break;
                        case 2:
                            daysInMonth = 28;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            daysInMonth = 30;
                            break;
                    }

                    this.day -= daysInMonth;
                    if (this.day < daysInMonth)
                    {
                        month--;
                    }
                    if (this.day <= daysInMonth)
                    {
                        break;
                    }
                }

                //if (0 >= this.day)
                //{
                //    this.day = Math.Abs(this.day);
                //    this.month--;
                //}

                //if (this.month == 0)
                //{
                //    this.month = 12;
                //    this.year--;
                //}

                //switch (month)
                //{
                //    case 1:
                //    case 3:
                //    case 5:
                //    case 7:
                //    case 8:
                //    case 10:
                //    case 12:
                //        daysInMonth = 31;
                //        break;
                //    case 2:
                //        daysInMonth = 28;
                //        break;
                //    case 4:
                //    case 6:
                //    case 9:
                //    case 11:
                //        daysInMonth = 30;
                //        break;
                //}

                //this.day = daysInMonth - this.day;

                output = $"{this.day}, {this.month}, {this.year}";
            }

            return output;
        }
    }
}
