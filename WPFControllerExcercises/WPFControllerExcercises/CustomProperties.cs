using System.Windows;

public static class CustomProperties
{
    public static readonly DependencyProperty FirstName =
        DependencyProperty.RegisterAttached(
            "FirstName",
            typeof(string),
            typeof(CustomProperties),
            new PropertyMetadata("Default"));

    public static string GetFirstName(DependencyObject obj)
    {
        return (string)obj.GetValue(FirstName);
    }

    public static void SetFirstName(DependencyObject obj, string value)
    {
        obj.SetValue(FirstName, value);
    }

    public static readonly DependencyProperty LastName =
        DependencyProperty.RegisterAttached(
            "LastName",
            typeof(string),
            typeof(CustomProperties),
            new PropertyMetadata("Default"));

    public static string GetLastName(DependencyObject obj)
    {
        return (string)obj.GetValue(LastName);
    }

    public static void SetLastName(DependencyObject obj, string value)
    {
        obj.SetValue(LastName, value);
    }

    public static readonly DependencyProperty Email =
        DependencyProperty.RegisterAttached(
            "Email",
            typeof(string),
            typeof(CustomProperties),
            new PropertyMetadata("Default"));

    public static string GetEmail(DependencyObject obj)
    {
        return (string)obj.GetValue(Email);
    }

    public static void SetEmail(DependencyObject obj, string value)
    {
        obj.SetValue(Email, value);
    }
}