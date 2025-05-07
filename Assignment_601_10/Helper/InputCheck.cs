namespace Assignment_601_10.Helper
{
    public static class InputCheck
    {
        public static string String(string message = "")
        {
            string? input;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
            }
            return input;
        }

        public static decimal Decimal(string message = "", bool isNullAllow = false)
        {
            string? input;
            decimal n;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (decimal.TryParse(input, out n) || isNullAllow)
                {
                    break;
                }
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
            }
            return n;
        }

        public static int Int(string message = "", bool isNullAllow = false)
        {
            string? input;
            int n;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (int.TryParse(input, out n) || isNullAllow)
                {
                    break;
                }
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
            }
            return n;
        }

        public static float Float(string message = "", bool isNullAllow = false)
        {
            string? input;
            float n;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (float.TryParse(input, out n) || isNullAllow)
                {
                    break;
                }
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
            }
            return n;
        }

        public static double Double(string message = "", bool isNullAllow = false)
        {
            string? input;
            double n;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (double.TryParse(input, out n) || isNullAllow)
                {
                    break;
                }
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
            }
            return n;
        }

        public static DateOnly GetDateOnly(string message = "", bool isNullAllow = false)
        {
            string? input;
            DateOnly n;
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (DateOnly.TryParse(input, out n) || isNullAllow)
                {
                    break;
                }
                Console.WriteLine("nhap khong hop le, moi nhap lai! ");
            }
            return n;
        }
    }
}