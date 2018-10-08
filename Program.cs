public class Program
    {
        static bool CheckArmstrong(string num)
        {
            var len = num.Length;

            double numberInput = Convert.ToDouble(num);
            double numberOutput = 0;
            double[] digits = new double[len];
            double[] cubedDigits = new double[digits.Length];

            char[] val = num.ToCharArray();

            for (var i = 0; i < len; i++)
            {
                digits[i] = Convert.ToInt32(val[i]) - '0';
            }

            for (var i = 0; i < digits.Length; i++)
            {
                cubedDigits[i] = (double)Math.Pow(digits[i], len);
            }

            foreach (var t in cubedDigits)
            {
                numberOutput += t;
            }

            if (numberInput.Equals(numberOutput))
            {
                return true;
            }

            return false;
        }
        public static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter a number");
            string abc = Console.ReadLine();
            Console.WriteLine(CheckArmstrong(abc) ? "Narcissistic" : "Not a narcissistic number!!");
            goto start;
        }
 }
