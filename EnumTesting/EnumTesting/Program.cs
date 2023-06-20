namespace EnumTesting
{
    internal class Program
    {
        enum Season : short { Spring, Summer, Autumn, Winter, Fall = Autumn } //Fall will act the same as Autumn as they both refer to the same underlying value
        //Default enum underlying type is int but can be changed to any of the int types

        struct Time
        {
            private int hours, minutes, seconds;
            private int day = 5;//Struct default constructor initalizes fields to 0,false, or null.

            public Time(int a, int b, int c) //nondefault constructor for the struct, all fields must be initialized in this constructor, or set when declared in the field but the value will be initialized to 0,null,false
            {
                this.hours = a;
                this.minutes = b;
                this.seconds = c;
            }

            public void changeTime(int hours, int minutes, int seconds, int day) //Method to change values in the struct
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
                this.day = day;
            }

            public int getHours() { return this.hours;} //The getters for the fields in the struct
            public int getMinutes() { return this.minutes;}
            public int getSeconds() { return this.seconds;}
            public int getDay() { return this.day;}

            public override string ToString()
            {
                return $"{this.hours} {this.minutes} {this.seconds}";
            }

        }

        struct Date
        {
            private int year;
            private Season season;
            private int day;

            //Nondefault constructor
            public Date(int year, Season season, int day)
            {
                this.year = year - 2000;
                this.season = season;
                this.day = day - 1;
            }

            //Getters
            public int getYear() { return year+2000;}
            public Season getSeason() {  return season;}
            public int getDay() { return day+1;}

            public override string ToString()
            {
                return $"{getYear()} {getSeason()} {getDay()}";
            }
        }

        static void Main(string[] args)
        {
            var time = new Time(12, 30, 10);
            //time.changeTime(12, 30, 10, 3);
            var date = new Date();
            Console.WriteLine(date.ToString());
            Console.WriteLine(time.getDay()); //Return 4
            Console.WriteLine();
        }
    }
}