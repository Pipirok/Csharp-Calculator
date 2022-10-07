﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {


        public Calculator()
        {
            InitializeComponent();
        }

        private string CurrentNumber = "0";

        private string OperationNumber = "0";

        private bool IsCurrentNumberShown = true;

        // 0 - nothing/equals, 1 - add, 2 - subtract, 3 - multiply, 4 - divide,
        // 5 - power, 6 - modulo
        private int CurrentOperation = 0;
        private void EnterNumber(string ValueToAdd)
        {
            if (IsCurrentNumberShown)
            {
                if (CurrentNumber == "0")
                {
                    CurrentNumber = ValueToAdd;
                }
                else
                {
                    CurrentNumber += ValueToAdd;
                }
                TextDisplay.Text = CurrentNumber;
            }
            else
            {
                if (OperationNumber == "0")
                {
                    OperationNumber = ValueToAdd;
                }
                else
                {
                    OperationNumber += ValueToAdd;
                }
                TextDisplay.Text = OperationNumber;
            }
        }

        private void NumberOperation(int NextOperation)
        {
            IsCurrentNumberShown = false;
            if (CurrentOperation != 0)
            {
                switch (CurrentOperation)
                {
                    case 1:
                        CurrentNumber = "" + (double.Parse(CurrentNumber) + double.Parse(OperationNumber));                     
                        break;
                    case 2:
                        CurrentNumber = "" + (double.Parse(CurrentNumber) - double.Parse(OperationNumber));
                        break;
                    case 3:
                        CurrentNumber = "" + (double.Parse(CurrentNumber) * double.Parse(OperationNumber));
                        break;
                    case 4:
                        if (OperationNumber == "0")
                        {
                            MessageBox.Show("Can't divide by 0! Enter another number", "Computation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        CurrentNumber = "" + (double.Parse(CurrentNumber) / double.Parse(OperationNumber));
                        break;
                    case 5:
                        CurrentNumber = "" + Math.Pow(double.Parse(CurrentNumber), double.Parse(OperationNumber));
                        break;
                    case 6:
                        CurrentNumber = "" + (double.Parse(CurrentNumber) % double.Parse(OperationNumber));
                        break;
                }
            }

            OperationNumber = "0";
            CurrentOperation = NextOperation;
            if(NextOperation == 0)
            {
                IsCurrentNumberShown = true;
                TextDisplay.Text = CurrentNumber;
                labelOperationalNum.Text = "";
                return;
            }
            TextDisplay.Text = OperationNumber;
            labelOperationalNum.Text = CurrentNumber;

        }

        

        private void ButtonNum1_Click(object sender, EventArgs e)
        {
            EnterNumber("1");
        }

        private void ButtonNum2_Click(object sender, EventArgs e)
        {
            EnterNumber("2");
        }

        private void ButtonNum3_Click(object sender, EventArgs e)
        {
            EnterNumber("3");
        }

        private void ButtonNum4_Click(object sender, EventArgs e)
        {
            EnterNumber("4");
        }

        private void ButtonNum5_Click(object sender, EventArgs e)
        {
            EnterNumber("5");
        }

        private void ButtonNum6_Click(object sender, EventArgs e)
        {
            EnterNumber("6");
        }

        private void ButtonNum7_Click(object sender, EventArgs e)
        {
            EnterNumber("7");
        }

        private void ButtonNum8_Click(object sender, EventArgs e)
        {
            EnterNumber("8");
        }

        private void ButtonNum9_Click(object sender, EventArgs e)
        {
            EnterNumber("9");
        }

        private void ButtonNumZero_Click(object sender, EventArgs e)
        {
            if (IsCurrentNumberShown)
            {
                if (CurrentNumber == "0")
                {
                    return;
                }
                CurrentNumber += "0";
                TextDisplay.Text = CurrentNumber;
            }
            else
            {
                if (OperationNumber == "0")
                {
                    return;
                }
                OperationNumber += "0";
                TextDisplay.Text = OperationNumber;
            }
        }
        private void ButtonPeriod_Click(object sender, EventArgs e)
        {
            if (IsCurrentNumberShown)
            {
                if (!CurrentNumber.Contains("."))
                {
                    CurrentNumber += ".";
                }
                
                TextDisplay.Text = CurrentNumber;
            }
            else
            {
                if (!OperationNumber.Contains("."))
                {
                    OperationNumber += ".";
                }
                
                TextDisplay.Text = OperationNumber;
            }
        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            CurrentNumber = "0";
            OperationNumber = "0";
            CurrentOperation = 0;
            IsCurrentNumberShown = true;
            TextDisplay.Text = CurrentNumber;
            labelOperationalNum.Text = "";
        }

        private void ButtonModulo_Click(object sender, EventArgs e)
        {
            NumberOperation(6);
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            NumberOperation(5);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (IsCurrentNumberShown)
            {
                if (CurrentNumber.Length == 1)
                {
                    CurrentNumber = "0";
                } else
                {
                    CurrentNumber = CurrentNumber.Substring(0, CurrentNumber.Length - 1);
                }
                TextDisplay.Text = CurrentNumber;
            }
            else
            {
                if (OperationNumber.Length == 1)
                {
                    OperationNumber = "0";
                } else
                {
                    OperationNumber = OperationNumber.Substring(0, OperationNumber.Length - 1);
                }
                TextDisplay.Text = OperationNumber;
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            NumberOperation(4);
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            NumberOperation(3);
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            NumberOperation(2);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            NumberOperation(1);
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            NumberOperation(0);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


