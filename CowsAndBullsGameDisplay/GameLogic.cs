using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CowsAndBullsGameDisplay
{
    public class GameLogic
    {
        public static void ColorTheHitsInTheGuess(int i_Index)
        {
            int sizeOfSequence = NumberOfChances.m_NumberOfOptionsToGuess;
            int hitCounter = sizeOfSequence;
            int userSequenceIndex = 0, computerSequenceIndex = 0;
            int counterV = 0, counterX = 0;

            for (userSequenceIndex = 0; userSequenceIndex < sizeOfSequence; userSequenceIndex++)
            {
                for (computerSequenceIndex = 0; computerSequenceIndex < sizeOfSequence && hitCounter > 0; computerSequenceIndex++)
                {
                    // $G$ DSN-002 (-10) No UI separation - game logic should not be coupled to UI classes.
                    if (MainGameBoard.m_GuessLinesList[i_Index].m_UserSequenceButtonsList[userSequenceIndex].BackColor ==
                        MainGameBoard.m_ComputerActualSequenceColor[computerSequenceIndex])
                    {
                        if (userSequenceIndex == computerSequenceIndex)
                        {
                            counterV++;
                        }
                        else
                        {
                            counterX++;
                        }

                        hitCounter--;
                        break;
                    }
                }
            }

            MainGameBoard.ColorDisplayResultButton(i_Index, counterV, counterX);
            if (counterV == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    MainGameBoard.m_ComputerSequenceButtonsList[i].BackColor = MainGameBoard.m_ComputerActualSequenceColor[i];
                }

                MainGameBoard.DisableButtonsAfterWin(i_Index);
            }
        }

        public static void SetComputerSequence()
        {
            int sizeOfArray = 4;
            int j;
            Random randomLetter = new Random();
            int[] arrayOfRandonNumbersInRange = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                int randomL = randomLetter.Next(1, 9);
                for (j = 0; j < i; j++)
                {
                    if (randomL == arrayOfRandonNumbersInRange[j])
                    {
                        i--;
                        break;
                    }
                }

                arrayOfRandonNumbersInRange[j] = randomL;
            }

            Color eCol;
            for (j = 0; j < sizeOfArray; j++)
            {
                eCol = PickAColor.ConvertEnumToColor((CowsAndBullsGameDisplay.eColors)arrayOfRandonNumbersInRange[j]);
                CowsAndBullsGameDisplay.MainGameBoard.m_ComputerActualSequenceColor[j] = eCol;
            }
        }
    }
}