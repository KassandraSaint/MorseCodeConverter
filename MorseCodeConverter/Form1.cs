using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeConverter
{
    public partial class Form1 : Form
    {
        // Initializing constant variable to hold size of the arrays
        const int SIZE = 50;
        // Creating an array of 50 characters
        char[] characters = new char[SIZE] 
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '.', ',', ':', '"', '\'', '!', '?', '@', '-', ';', '(', ')', '=',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' '
        };
        // Creating an array of 50 morse code symbols
        string[] mCode = new string[SIZE]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
            "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..",
            ".-.-.-", "--..--", "---...", ".-..-.", ".----.", "-.-.--", "..--..", ".--.-.", "-....-", "-.-.-.", "-.--.", "-.--.-", "-...-",
            ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----", "/"
        };
        public Form1()
        {
            InitializeComponent();
        }

        // Creating a method to convert string to a mrse code
        private string stringyMorse(string stringy)
        {
            // Initializing a string variable to hold resulting string of morse code
            string morseString = "";

            // Traversing over every character of the string and looking for a index number in the array of chars
            for (int i = 0; i < stringy.Length; i++)
            {
                // Looking for a position of the character from the string in the array of charachters
                int position = Array.IndexOf(characters, stringy[i]);

                // if position is out of range, aka if charachter is not in the array
                if (position < 0)
                {
                    // Alerting a user that string entered contains unsupported character
                    MessageBox.Show("String you entered contains unsupported character that can't be converted to Morse Code");
                    morseString = "";
                    break;
                }
                else
                {
                    // Constracting a Morse Code string
                    morseString += mCode[position] + " ";
                }
            }

            // Returning string of morse code
            return morseString;
        }

        // Creating a method to convert morse code to a string
        private string morsyString(string code)
        {
            // Initializing a string variable strin to hold converted morse code to string
            string strin = "";

            // Tokenizing elements from morse code string into array 
            string[] tokens = code.Split(null);

            // Going over each token of tokens array and determining index of that element in the mCode array
            for (int i = 0; i < tokens.Length; i++)
            {
                int position = Array.IndexOf(mCode, tokens[i]);

                // if position is out of range, aka if morse code is not in the array
                if (position < 0)
                {
                    // Alerting a user that string entered contains unsupported character
                    MessageBox.Show("String you entered contains unsupported character that can't be converted from Morse Code");
                    strin = "";
                    break;
                }
                else
                {
                    // Constructing a string from morse code
                    strin += characters[position];
                }
            }

            // Returning string
            return strin;
        }

        private void codeBtn_Click(object sender, EventArgs e)
        {
            // Getting a string from the user 
            string stringy = stringBox.Text;
            // Taking care of the case for letters
            string stringyLow = stringy.ToLower();

            // Calling a stringyMorse converter method and passing a lower cased string as an argument
            // Storing returned string in the morse variable
            string morse = stringyMorse(stringyLow);

            // Displaying morse code
            morseBox.Text = morse;
        }

        private void stringBtn_Click(object sender, EventArgs e)
        {
            // Getting amorse code from the user
            string code = codeBox.Text;
            // Trimming any white spaces
            string codeTrimmed = code.Trim();

            // Calling a morsyString method to convert morse code to a string
            // Storing returned string in the converted variable
            string converted = morsyString(codeTrimmed);

            // Displaying the string converted from morse code
            // Convert case to upper as on https://morsecode.world
            convertedBox.Text = converted.ToUpper();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
