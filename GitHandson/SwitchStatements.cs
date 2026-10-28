using System;
public class SwitchStatements
{
	
    public static string GetDayOfWeek(int dayNumber)
    {
        String dayName;
        switch(dayNumber)
        {
            case 0: 
            dayName = "Sunday";
            break;
            case 1: 
            dayName = "Monday";
            break;
            case 2: 
            dayName = "Tuesday";
            break;
            case 3: 
            dayName = "Wednesday";
            break;      
            case 4: 
            dayName = "Thursday";
            break;
            case 5: 
            dayName = "Friday";
            break;
            case 6: 
            dayName = "Saturday";
            break;          
            default: 
            dayName = "Invalid day Number";
            break;
        }
        return dayName;
    }
}
