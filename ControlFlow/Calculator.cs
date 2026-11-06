using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow
{
    public class Calculator
    {
        public double Calculate(double nr1, double nr2, char op)
        {
            double result;
            switch (op)
            {
                case '+':
                    {
                        result = nr1 + nr2;
                        return result;
                    }
                case '-':
                    {
                        result = nr1 - nr2;
                        return result;
                    }
                case '*':
                    {
                        result = nr1 * nr2;
                        return result;
                    }
                case '/':
                    if (nr2 != 0)
                    {
                        result = nr1 / nr2;
                        return result;
                    }
                    else
                    {
                        throw new Exception("Eroare: Impartire la zero!");
                    }
                default:
                    throw new Exception("Eroare: Operatie invalida!");
            }
        }
    }
}
