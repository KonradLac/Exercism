namespace BookingUpForBeauty;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        if(DateTime.TryParse(appointmentDateDescription, out DateTime appointmentDate))
        {
            return appointmentDate;
        }
        else
        {
            throw new ArgumentException("Invalid date format. Please provide a valid date string.");
        }
    }

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}";

    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 9, 15);
}