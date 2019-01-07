using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CowsAndBullsGameDisplay
{
    // $G$ DSN-002 (-10) User guesses/feedbacks belong in the game logic. The UI should only reflect the game's state to the user.
    public partial class MainGameBoard : Form
    {
        // $G$ CSS-004 (-5) Bad static readonly variable name (should be in the form of sr_PascalCased)
        public static readonly List<Button> m_ComputerSequenceButtonsList = new List<Button>();
        public static readonly List<GuessLine> m_GuessLinesList = new List<GuessLine>();
        public static Color[] m_ComputerActualSequenceColor = new Color[4];
        PickAColor Color = new PickAColor();

        int index;

        public MainGameBoard()
        {
            InitializeComponents();
            GameLogic.SetComputerSequence();
        }

        public static void ColorDisplayResultButton(int ResualtLineIndex, int numberOfBull, int numberOfPgia)
        {
            int i = 0;
            for (; i < numberOfBull; i++)
            {
                m_GuessLinesList[ResualtLineIndex].m_UserGuessesResultButtonsList[i].BackColor = System.Drawing.Color.Black;
            }

            for (; i < numberOfPgia + numberOfBull; i++)
            {
                m_GuessLinesList[ResualtLineIndex].m_UserGuessesResultButtonsList[i].BackColor = System.Drawing.Color.Yellow;
            }
        }

        public static void DisableButtonsAfterWin(int i_Index)
        {
            if (i_Index != m_GuessLinesList.Count)
            {
                for (int i = 0; i < NumberOfChances.m_NumberOfOptionsToGuess; i++)
                {
                    // $G$ SFN-008 (-5) The game crashes here when the player wins in last round.
                    m_GuessLinesList[i_Index + 1].m_UserSequenceButtonsList[i].Enabled = false;
                }
            }

            m_GuessLinesList[i_Index].m_ChoiceButton.Enabled = false;
        }

        public static bool ChecksIfUserChoseAColor(List<Button> m_UserSequenceButtonsList)
        {
            bool userChoseAColor = true;

            foreach (Button UserSequenceButtonsList in m_UserSequenceButtonsList)
            {
                if (UserSequenceButtonsList.BackColor == System.Drawing.SystemColors.Control)
                {
                    userChoseAColor = false;
                    break;
                }
            }

            return userChoseAColor;
        }

        public void DisabledUserSequenceButtonsList()
        {
            for (int i = 1; i < CowsAndBullsGameDisplay.NumberOfChances.m_NumberOfGuesses; i++)
            {
                for (int j = 0; j < CowsAndBullsGameDisplay.NumberOfChances.m_NumberOfOptionsToGuess; j++)
                {
                    m_GuessLinesList[i].m_UserSequenceButtonsList[j].Enabled = false;
                }
            }
        }

        private void MainGameBoard_Load(object sender, EventArgs e)
        {
        }

        private void UserSequenceButton1_MouseClick(object sender, MouseEventArgs e)
        {
            index = ((sender as Button).Top - (20 + m_HeightDifferenceBetweenGuessLines)) / m_HeightDifferenceBetweenGuessLines;
            Color.ShowDialog();
            m_GuessLinesList[index].m_UserSequenceButtonsList[0].BackColor = PickAColor.m_CurrentColor;

            if (ChecksIfUserChoseAColor(m_GuessLinesList[index].m_UserSequenceButtonsList) == true)
            {
                m_GuessLinesList[index].m_ChoiceButton.Enabled = true;
            }
        }

        private void UserSequenceButton2_MouseClick(object sender, MouseEventArgs e)
        {
            index = ((sender as Button).Top - (20 + m_HeightDifferenceBetweenGuessLines)) / m_HeightDifferenceBetweenGuessLines;
            Color.ShowDialog();
            m_GuessLinesList[index].m_UserSequenceButtonsList[1].BackColor = PickAColor.m_CurrentColor;

            if (ChecksIfUserChoseAColor(m_GuessLinesList[index].m_UserSequenceButtonsList) == true)
            {
                m_GuessLinesList[index].m_ChoiceButton.Enabled = true;
            }
        }

        // $G$ DSN-004 (-5) Code duplication. You could have used a collection of buttons instead.
        private void UserSequenceButton3_MouseClick(object sender, MouseEventArgs e)
        {
            index = ((sender as Button).Top - (20 + m_HeightDifferenceBetweenGuessLines)) / m_HeightDifferenceBetweenGuessLines;
            Color.ShowDialog();
            m_GuessLinesList[index].m_UserSequenceButtonsList[2].BackColor = PickAColor.m_CurrentColor;

            if (ChecksIfUserChoseAColor(m_GuessLinesList[index].m_UserSequenceButtonsList) == true)
            {
                m_GuessLinesList[index].m_ChoiceButton.Enabled = true;
            }
        }

        private void UserSequenceButton4_MouseClick(object sender, MouseEventArgs e)
        {
            index = ((sender as Button).Top - (20 + m_HeightDifferenceBetweenGuessLines)) / m_HeightDifferenceBetweenGuessLines;
            Color.ShowDialog();
            m_GuessLinesList[index].m_UserSequenceButtonsList[3].BackColor = PickAColor.m_CurrentColor;
            if (ChecksIfUserChoseAColor(m_GuessLinesList[index].m_UserSequenceButtonsList) == true)
            {
                m_GuessLinesList[index].m_ChoiceButton.Enabled = true;
            }
        }

        private void ChoiceButton_MouseClick(object sender, MouseEventArgs e)
        {
            index = ((sender as Button).Top - (20 + m_HeightDifferenceBetweenGuessLines)) / m_HeightDifferenceBetweenGuessLines;
            if (index != m_GuessLinesList.Count - 1)
            {
                for (int i = 0; i < NumberOfChances.m_NumberOfOptionsToGuess; i++)
                {
                    m_GuessLinesList[index + 1].m_UserSequenceButtonsList[i].Enabled = true;
                    m_GuessLinesList[index].m_UserSequenceButtonsList[i].Enabled = false;
                    m_GuessLinesList[index].m_ChoiceButton.Enabled = false;
                }
            }
            else
            {
                m_GuessLinesList[m_GuessLinesList.Count - 1].m_ChoiceButton.Enabled = false;
                for (int i = 0; i < NumberOfChances.m_NumberOfOptionsToGuess; i++)
                {
                    m_GuessLinesList[m_GuessLinesList.Count - 1].m_UserSequenceButtonsList[i].Enabled = false;
                }
            }

            GameLogic.ColorTheHitsInTheGuess(index);
        }
    }

    public class GuessLine
    {
        public readonly List<Button> m_UserSequenceButtonsList = new List<Button>();
        public readonly List<Button> m_UserGuessesResultButtonsList = new List<Button>();
        public Button m_ChoiceButton = new Button();
    }
}
