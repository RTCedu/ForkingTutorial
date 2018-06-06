using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForkingAssignment
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// FORKING ASSIGNMENT
        /// 
        /// PLEASE NOTE: SOME CODE STILL NEEDS ADDED FOR FULL FUNCTIONALITY
        /// 
        /// FORM OBJECT NAMES
        /// Buttons:
        ///     btnZero, btnOne, btnTwo, btnThree, btnFour, btnFive,
        ///     btnSix, btnSeven, btnEight, btnNine, btn Clear,
        ///     btnEquals, btnSubtract, btnAdd, btnMultipily, btnDivide
        /// TextBox
        ///     txtDisplay
        /// Global Variables:
        StringBuilder equation = new StringBuilder(); // used to compile input into one parsable string
        double answer; // holds the equation's solution upon calculation
        bool ANSWER_DISPLAYED; // True/False check for answer being displayed
        char OPERATOR; // +-*/ as input by user for equation
        /// ANSWER_DISPLAYED will be used to tell what is displayed in 
        /// txtDisplay, as to know if to erase and start fresh equation
        /// or to append current equation.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // After initilization, the form loads, during load 
            // the following lines of code are run. 
            // This sets up the application for a clean starting point
            // that the rest of the application can run from.
            ANSWER_DISPLAYED = true;
            OPERATOR = 'x';
            answer = 0;
            txtDisplay.Text = answer.ToString();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AnswerCheck();
            // concatinate 0 onto string
            equation.Append("0");
            // After appending a number to the string update the Display
            // so the user can see the full string as input.
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnOne_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 1 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 2 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnThree_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 3 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 4 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnFive_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 5 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnSix_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 6 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate 7 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            AnswerCheck();
            // concatinate 8 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            AnswerCheck();
            // concatinate 9 onto string
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate * onto string
            
            // Update OPERATOR variable to match chosen operator.
            OPERATOR = '*';
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate / onto string
            
            // Update OPERATOR
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            AnswerCheck();
            // concatinate - onto string
            
            // Update OPERATOR
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnswerCheck();
            // concatinate + onto string
            
            // Update OPERATOR
            
            UpdateEquationDisplay(equation.ToString());
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Parse string into equation and calculate result
            ANSWER_DISPLAYED = true;
            // The Parsing and calculation is handled by
            // the ParseCalcEquation() method. It requires a string
            // input to be passed to it.
            answer = ParseCalcEquation(equation.ToString());
            // Display the answer in txtDisplay
            txtDisplay.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear string of previous input and clear txtDisplay.
            // set ANSWER_DISPLAYED to true, and restart a the
            // stringbuilder to a fresh variable.
            ANSWER_DISPLAYED = true;
            answer = 0;
            equation = new StringBuilder();
            txtDisplay.Text = answer.ToString();
        }

        public void AnswerCheck()
        {
            // This checks if input requires clearing 
            // the equation that is already held.
            if (ANSWER_DISPLAYED)
            {
                ANSWER_DISPLAYED = false;
                equation = new StringBuilder();
            }
        }

        public void UpdateEquationDisplay(string e)
        {
            // This is an example method that takes a string,
            // returns nothing, and puts that string as the Text
            // for txtDisplay, thus displaying it to the user.
            // Though not necessary in this instance, it is often a good
            // idea to encapsulate repeated actions into a method. They
            // will often have more than one line of code. For this 
            // example, it was left as a one line, one action, method.
            txtDisplay.Text = e;
        }

        public double ParseCalcEquation(string e)
        {
            // instantiate variables to contain the two
            // integers from the equation. Set to -1, since 
            // inputing negative numbers is not implemented.
            int a = -1, b = -1;
            // Parse the string into two parts, separated by the 
            // four possible operator characters.
            string[] parts = e.Split('/', '-', '+', '*');
            // instantiate a check for each integer, initially set
            // to false. 
            bool checkA = false;
            bool checkB = false;
            // the rest of the code is encapsulated in an IF logic statement.
            // If two parts were not parsed out of the string, or if more were,
            // then skip the code and return -1 (effectively acting as our ERROR 
            // message to the user.
            if (parts.Count() == 2)
            {
                // First logic will attempt to parse the first piece of data
                // into an integer. If it cannot, it will exit the method and
                // return -1.
                if (!checkA) checkA = int.TryParse(parts[0], out a);
                else return -1;
                // If the first variable was successfully parsed into an integer,
                // the same is done for the second piece of data. If it fails,
                // the method exits, returning -1.
                if (!checkB) checkB = int.TryParse(parts[1], out b);
                else return -1;
                // This switch statement quickly determines which equation
                // to use based on the OPERATOR. The equation is executed,
                // the result being returned by the method.
                switch (OPERATOR)
                {
                    case '+':
                        return a + b;
                    case '-':
                        return a - b;
                    case '*':
                        return a * b;
                    case '/':
                        return a / b;
                    default:
                        return -1;
                }
            }
            else return -1;
        }
    }
}
