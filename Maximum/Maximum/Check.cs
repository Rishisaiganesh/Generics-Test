﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    public class Check
    {
        public int FindIntMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
                return thirdNumber;
        }
        public float FindFloatMax(float firstNumber, float secondNumber, float thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
                return thirdNumber;
        }
        
        
    }
}
