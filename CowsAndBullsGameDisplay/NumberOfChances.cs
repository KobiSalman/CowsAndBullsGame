using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CowsAndBullsGameDisplay
{
    // $G$ CSS-016 (-3) Bad class name - The name of classes derived from Form should end with Form.
    public partial class NumberOfChances : Form
    {
        // $G$ CSS-003 (-5) Bad constant variable name (should be in the form of k_PascalCased)
        // $G$ NTT-004 (-5) You should use properties, not public/internal members.
        public const int m_NumberOfOptionsToGuess = 4;
        public const int m_MinNumberOfGuesses = 4;
        public const int m_MaxNumberOfGuesses = 10;
        public static int m_NumberOfGuesses = m_MinNumberOfGuesses;

        public NumberOfChances()
        {
            InitializeComponent();
        }

        public int NumberOfGuesses
        {
            get { return m_NumberOfGuesses; }
            set { m_NumberOfGuesses = value; }
        }

        private void ButtonNumberOfChances_MouseClick(object sender, MouseEventArgs e)
        {
            if (NumberOfGuesses >= m_MinNumberOfGuesses && NumberOfGuesses < m_MaxNumberOfGuesses)
            {
                this.ButtonNumberOfChances.Text = "Number of chances: " + ++NumberOfGuesses;
            }
        }

        private void ButtonStart(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            // $G$ DSN-999 (-10) The game settings form and the game form should not be tightly coupled. (Board game settings form is a class that might be reused by other winform board games)
            MainGameBoard MainGameBoard = new MainGameBoard();
            GameLogic gameLogic = new GameLogic();
            MainGameBoard.ShowDialog(); 
        }

        private void NumberOfChances_Load(object sender, EventArgs e)
        {
        }
    }
}
