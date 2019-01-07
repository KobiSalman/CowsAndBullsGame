using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CowsAndBullsGameDisplay
{
    public enum eColors
    {
        Purple = 1,
        Red = 2,
        Green = 3,
        Azure = 4,
        Blue = 5,
        Yellow = 6,
        Brown = 7,
        White = 8,
        Black = 9
    }

    public partial class PickAColor : Form
    {
        public static Color m_CurrentColor;
        public static eColors em_Colors;

        public PickAColor()
        {
            InitializeComponent();
        }

        public eColors Colors
        {
            get { return em_Colors; }
            set { em_Colors = value; }
        }

        public static Color ConvertEnumToColor(eColors i_EnumCurrentColor)
        {
            Color backColor = Color.Black;
            switch ((int)i_EnumCurrentColor)
            {
                case 1:
                    {
                        backColor = Color.Purple;
                        break;
                    }

                case 2:
                    {
                        backColor = Color.Red;
                        break;
                    }

                case 3:
                    {
                        backColor = Color.Green;
                        break;
                    }

                case 4:
                    {
                        backColor = Color.Azure;
                        break;
                    }

                case 5:
                    {
                        backColor = Color.Blue;
                        break;
                    }

                case 6:
                    {
                        backColor = Color.Yellow;
                        break;
                    }

                case 7:
                    {
                        backColor = Color.Brown;
                        break;
                    }

                case 8:
                    {
                        backColor = Color.White;
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

            return backColor;
        }

        private void PickAColor_Load(object sender, EventArgs e)
        {
        }

        private void PurpleButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Purple;
            this.Close();
        }

        // $G$ DSN-001 (-5) Code duplication - Single event could be used for all buttons instead. You could for example have used an inherited control with color or button/color dictionary.
        private void RedButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Red;
            this.Close();
        }

        private void GreenButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Green;
            this.Close();
        }

        private void AzureButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Azure;
            this.Close();
        }

        private void BlueButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Blue;
            this.Close();
        }

        private void YellowButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Yellow;
            this.Close();
        }

        private void BrownButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.Brown;
            this.Close();
        }

        private void WhiteButton_MouseClick(object sender, MouseEventArgs e)
        {
            m_CurrentColor = Color.White;
            this.Close();
        }
    }
}
