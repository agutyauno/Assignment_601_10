namespace Assignment_601_10.Helper
{
    public static class InputCheck
    {
        public static string String(string message = "", bool isNullAllow = false)
        {
            while (true)
            {
            Console.Write(message);
            var input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                if (isNullAllow) return string.Empty;
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
                continue;
            }
            return input;
            }
        }

        public static T? GetValue<T>(string message = "", bool isNullAllow = false) where T : IConvertible
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                
                try
                {
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        if (isNullAllow) return default;
                        Console.WriteLine("nhap khong hop le, moi nhap lai! ");
                        continue;
                    }

                    if (typeof(T) == typeof(DateOnly) && DateOnly.TryParse(input, out var date))
                        return (T)(object)date;

                    object? converted = Convert.ChangeType(input, typeof(T));
                    return converted == null ? default : (T)converted;
                }
                catch
                {
                    Console.WriteLine("nhap khong hop le, moi nhap lai! ");
                }
            }
        }
    }
}