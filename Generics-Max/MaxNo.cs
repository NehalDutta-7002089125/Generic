﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Generics_Max
{
    internal class MaxNo
    {
        public static int Max(int FirstNo, int SecondNo, int ThiredNo)
        {
            if (FirstNo.CompareTo(SecondNo) >0 && FirstNo.CompareTo(ThiredNo) >0)
            {
                return FirstNo;
            }
            if (SecondNo.CompareTo(FirstNo) >0 && SecondNo.CompareTo(ThiredNo) >0)
            {
                return SecondNo;
            }
            if(ThiredNo.CompareTo(FirstNo)>0 && ThiredNo.CompareTo(SecondNo) >0)
            {
                return ThiredNo;
            }
            throw new Exception(" FirstNo,SecondNo,L is same");
        }
        
      
            
    }
}