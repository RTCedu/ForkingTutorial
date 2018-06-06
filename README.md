# Lesson 03 - Forking Tutorial and Assignment

((CURRENTLY PROOF OF CONCEPT PROJECT))

Renton Technical College - Computer Science Department

Included in this repository
* Lesson 03 Forked Assignment.pptx
* Solution: ForkingTutorial
* README.md
* .gitignore

The Power Point presentation is provided as a walkthrough, with images, to complete this tutorial and assignment. RTC students in the CS programs will be lead through this lesson by their instructor.

# Lesson Guide
1. Fork this repository to your GitHub profile.
2. Clone the repository from your profile to your local environment (example uses GitKraken).
3. Follow the assignment instructions found in Summary in ...\ForkingTutorial\Form1.cs
  - Presented below as well.
4. Finalize changes and push to GitHub repository on your profile.
5. Submit link to your forked version of the repository on Canvas.

# Assignment
Full notation on these examples are presented in solution.

Create a simple calculator capable of parsing out numbers, operation
Deliverables:
* Fork Assignment to own profile
* work on assignment, creating commits and pushing code to forked repository.
** Important Note: Success in the code is not the point of this assignment. Being able to Fork, update, and turn in is.
** The forked repository should be updated at least once, minimum of 10 lines edited.
* Turn in link to forked repository

GUI Setup
* Add a TextBox to display output, mark it as editable false. (Already Added)
* Add Buttons for numbers 0-9, addition, subtraction, multiplication, division, equals, and clear. (Already Added)
* Set Form's text to relevant title (your choice).

Form.cs
* Add methods to parse input and calculate equations
* Add code to buttons
* Add Form Load.

Object Naming Convention
* Buttons | btn... | btnEquals, btnZero, btnOne, ..., btnNine, btnSubtract, btnMultiply, btnDivide, btnAdd
* TextBox | txt... | txtDisplay

Objectives of code:
* Input two numbers separated by an operation
* Parse input to determine equation
* Calculate correct answers for ab, a+b, a-b, a/b

Approximately 30 minutes will be given for this assignment, with instructor aid, helping each other is permitted. Example code can be found below and in the Power Point presentation: Lesson 03 Forking Assignment.

#Examples and Used Code
Global variables utilized in code:
       * StringBuilder equation = new StringBuilder(); // used to compile input into one parsable string
       * double answer; // holds the equation's solution upon calculation
       * bool ANSWER_DISPLAYED; // True/False check for answer being displayed
       * char OPERATOR; // +-*/ as input by user for equation

Example code for button to add input from user to equation.
      private void btnZero_Click(object sender, EventArgs e)
      {
          AnswerCheck();
          equation.Append("0");
          UpdateEquationDisplay(equation.ToString());
      }
     
Example method to parse string input into two variables, conduct appropriate calculation, and return of answer as a double.
        public double ParseCalcEquation(string e)
        {
            int a = -1, b = -1;
            string[] parts = e.Split('/', '-', '+', '*');
            bool checkA = false;
            bool checkB = false;
            if (parts.Count() == 2)
            {
                if (!checkA) checkA = int.TryParse(parts[0], out a);
                else return -1;
                if (!checkB) checkB = int.TryParse(parts[1], out b);
                else return -1;
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
