using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace binaryConvertor
{
    public partial class MainForm : Form
    {
        //Needed variables
        string default_output = "0000 0000 0000 0000";

        public MainForm()
        {
            InitializeComponent();

            //Set up the boxes
            DecimalBox.Text = "0";
            HexadecimalBox.Text = "0";
            binaryBox.Text = "0";

            //Assign default output
            DecimalBox.Text = default_output;
            HexadecimalBox.Text = default_output;
            binaryBox.Text = default_output;
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DecimalBox.Text = FormatDigits(DecimalBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DecimalBox.Text = default_output;
            }
            try
            {
                HexadecimalBox.Text = FormatDigits(HexadecimalBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HexadecimalBox.Text = default_output;
            }
            try
            {
                binaryBox.Text = FormatDigits(binaryBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                binaryBox.Text = default_output;
            }

            //Prepare the strings for the functions
            string decimalNumber = DecimalBox.Text.Replace(" ", "");
            string hexadecimalNumber = HexadecimalBox.Text.Replace(" ", "");
            string binaryNumber = binaryBox.Text.Replace(" ", "");

            //Determine the problems
            if (DectoHex.Checked)
            {
                HexadecimalBox.Text = FormatDigits(DecimalToHexadecimal(decimalNumber)).ToUpper();
            }
            else if (decimalToBinary.Checked)
            {
                binaryBox.Text = FormatDigits(DecimalToBinary(decimalNumber)).ToUpper();
            }
            else if (HexToDec.Checked)
            {
                DecimalBox.Text = FormatDigits(HexToDecimal(hexadecimalNumber).ToString()).ToUpper();
            }
            else if (hexadecimalToBinary.Checked)
            {
                binaryBox.Text = FormatDigits(HexadecimalToBinary(hexadecimalNumber)).ToUpper();
            }
            else if (BintoHex.Checked)
            {
                HexadecimalBox.Text = FormatDigits(BinaryToHexadecimal(binaryNumber)).ToUpper();
            }
            else if (BintoDec.Checked)
            {
                DecimalBox.Text = FormatDigits(BinaryToDecimal(binaryNumber).ToString()).ToUpper();
            } else
            {
                string message = "Please select an option.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Version: 1.0\n" +
               "Release Date: April 23rd 2023\n" +
               "Developers: Deniz K Acikbas, Kyle McCarthy, Samuel Stenerson \n"
               + "Annotation: Released as a project for CIS 375";
            string title = "About Assemblex";

            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        private void hexadecimalErrors(object sender, EventArgs e)
        {
            string input = HexadecimalBox.Text.Trim().ToUpper(); // Get input and convert to uppercase

            bool isValidHex = true;

            // Check if input contains only valid hexadecimal digits
            foreach (char c in input)
            {
                if (!Char.IsDigit(c) && !(c == ' ') && (c < 'A' || c > 'F') || (c < 0))
                {
                    isValidHex = false;
                    break;
                }
            }

            if (!isValidHex)
            {
                string message3 = "Input must be a positive number or one of the hexadecimal digits (A-F).";
                string title3 = "Error";
                MessageBox.Show(message3, title3, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void binaryErrors(object sender, EventArgs e)
        {
            string input2 = binaryBox.Text.Trim().ToUpper(); // Get input and convert to uppercase

            bool isValidBin = true;
            // Warn user if they enter a negative number 
            string message2 = "Your input must be either 0 or 1";
            string title2 = "Error";
            foreach (char c in input2)
            {
                if (c != '0' && c != '1' && c != ' ')
                {
                    isValidBin = false;
                }
            }

            if (!isValidBin)
            {
                MessageBox.Show(message2, title2, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpMenu hmenu = new HelpMenu();
            hmenu.Show();
        }

        public string FormatDigits(string input)
        {
            // Remove any spaces from the input string
            input = input.Replace(" ", "");

            if (input.Length > 16)
            {
                throw new ArgumentException("Input string must not exceed 16 digits.");
            }

            //Check whether DecimalBox is digit or not
            string inputDecimal = DecimalBox.Text.Replace(" ", "");
            if (long.TryParse(inputDecimal, NumberStyles.Integer, CultureInfo.InvariantCulture, out long value))
            {

            }
            else
            {
                throw new ArgumentException("Your value must be a digit.");
            }

            //Check whether HexadecimalBox is hexadecimal or not
            string inputHexadecimal = HexadecimalBox.Text.Replace(" ", "");
            if (Regex.IsMatch(inputHexadecimal, "^[0-9a-fA-F]{16}$") && long.TryParse(inputHexadecimal, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out long value2))
            {
            }
            else
            {
                throw new ArgumentException("Your value must be a hexadecimal.");
            }

            //Check whether BinaryBox is binary or not
            string inputBinary = binaryBox.Text.Replace(" ", "");
            if (Regex.IsMatch(inputBinary, "^[01]{16}$") && long.TryParse(inputBinary, NumberStyles.Integer, CultureInfo.InvariantCulture, out long value3))
            {
            }
            else
            {
                throw new ArgumentException("Your value must be a binary number.");
            }

            // Pad the input string with leading zeros if necessary
            input = input.PadLeft(16, '0');

            // Split the input string into four parts
            string part1 = input.Substring(0, 4);
            string part2 = input.Substring(4, 4);
            string part3 = input.Substring(8, 4);
            string part4 = input.Substring(12);

            // Concatenate the four parts with spaces in between
            return $"{part1} {part2} {part3} {part4}";
        }

        public static string DecimalToHexadecimal(string decimalString)
        {
            if (long.TryParse(decimalString, out long decimalValue))
            {
                return Convert.ToString(decimalValue, 16);
            }
            else
            {
                throw new ArgumentException("Invalid decimal string");
            }
        }

        public static string DecimalToBinary(string decimalString)
        {
            if (long.TryParse(decimalString, out long decimalValue))
            {
                string binaryString = Convert.ToString(decimalValue, 2);
                return binaryString.TrimStart('0').PadLeft(1, '0');
            }
            else
            {
                throw new ArgumentException("Invalid decimal string");
            }
        }
        public static long HexToDecimal(string hexString)
        {
            if (long.TryParse(hexString, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out long decimalValue))
            {
                return decimalValue;
            }
            else
            {
                throw new ArgumentException("Invalid hexadecimal string");
            }
        }
    public static string HexadecimalToBinary(string hexadecimalString)
        {
            if (long.TryParse(hexadecimalString, System.Globalization.NumberStyles.HexNumber, null, out long hexadecimalValue))
            {
                string binaryString = Convert.ToString(hexadecimalValue, 2);
                return binaryString.TrimStart('0').PadLeft(1, '0');
            }
            else
            {
                throw new ArgumentException("Invalid hexadecimal string");
            }
        }
    public static string BinaryToHexadecimal(string binaryString)
        {
            if (!Regex.IsMatch(binaryString, "^[01]+$"))
            {
                throw new ArgumentException("Input string is not a valid binary string.");
            }

            int padding = binaryString.Length % 4;
            if (padding != 0)
            {
                binaryString = new string('0', 4 - padding) + binaryString;
            }

            StringBuilder result = new StringBuilder(binaryString.Length / 4);

            for (int i = 0; i < binaryString.Length; i += 4)
            {
                string hexDigit = Convert.ToInt32(binaryString.Substring(i, 4), 2).ToString("X");
                result.Append(hexDigit);
            }

            return result.ToString();
        }
        public static int BinaryToDecimal(string binary)
        {
            int decimalValue = 0;
            int baseValue = 1;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                int binaryDigit = binary[i] - '0';
                decimalValue += binaryDigit * baseValue;
                baseValue *= 2;
            }

            return decimalValue;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stackCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stack stack = new Stack();
            stack.Show();
        }
    }
}