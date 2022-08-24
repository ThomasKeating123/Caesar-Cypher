using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void BTNencrypt_Click(object sender, EventArgs e)
        {
            // Creates a char array containing each letter of the alphabet
            char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            // Set an in variable to the offset which the user wants
            int Offset = Convert.ToInt32(NUDoffset.Value);
            // Creates a char array containing each character of the input message
            char[] Message = TXTinput.Text.ToUpper().ToCharArray();
            // Creates a char array with other character the user may enter into the message
            char[] OtherCharacters = " ,./?;:'@#~[{]}=+-_0)9(8*7&6^5%4$|3£21!`¬\\<>".ToCharArray();
            // Creates a list for the output characters
            List<char> Output = new List<char>();
            // Foreach loop to cycle through each character in the message array
            foreach (char Letter in Message)
            {
                // If statement to check if the character is in the other characters array
                if (OtherCharacters.Contains(Letter))
                {
                    // Adds the letter to the output list
                    Output.Add(Letter);
                }
                // For loop to cycle through 26 times, the length of the alphabaet
                for (int i = 0; i < 26; i++)
                {
                    // If statement to check if the character is equal to the a character in the alphabet array with the index of the i
                    if (Letter == Alphabet[i])
                    {
                        // Creates a new value for the index of the new character in the array
                        int NewValue = i + Offset;
                        // If the new value is less than 0
                        if (NewValue < 0)
                        {
                            // The new value is equal to 26 + the new value
                            NewValue = 26 + NewValue;
                        }
                        // Else if the new value is greater than 25
                        else if (NewValue > 25)
                        {
                            // The new value is equal to new value - 26
                            NewValue = NewValue - 26;
                        }
                        // Gets the new character with the new value
                        char NewLetter = Alphabet[NewValue];
                        // Adds the character to the output list
                        Output.Add(NewLetter);
                    }
                }
            }
            // Joins the ouput list into a string, with no separation
            string NewMessage = string.Join("", Output);
            // Sets the text of the output textbox to the new message
            TXToutput.Text = NewMessage;
        }
    }
}
