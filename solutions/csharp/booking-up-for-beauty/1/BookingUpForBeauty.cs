static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }


    public static bool HasPassed(DateTime appointmentDate)
    {
        var currentTime = DateTime.Now;
        int value = currentTime.CompareTo(appointmentDate);

        return value >= 0;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        var TimeOfTheDate = appointmentDate.TimeOfDay;
        return TimeOfTheDate >= new TimeSpan(12, 0, 0) && TimeOfTheDate < new TimeSpan(18, 0, 0);
    }

    public static string Description(DateTime appointmentDate)
    {
        string description = appointmentDate.ToString("G");
        string output = $"You have an appointment on {description}.";
        Console.WriteLine(output);
        return output;
    }

    public static DateTime AnniversaryDate()
    {
        var date = new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
        return date;
    }
}
