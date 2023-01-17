using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Generics_Max
{
    public class MaxNo<T> where T: IComparable
        
    {
        T firstNo,secondNo, thirdNo;
        public MaxNo(T FirstNo, T secondNo, T thirdNo) 
        {
            this.firstNo = FirstNo;
            this.secondNo = secondNo;
            this.thirdNo = thirdNo;
        }


        public static T Max  (T FirstNo, T SecondNo, T ThiredNo) 
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
            throw new Exception(" FirstNo,SecondNo,ThiredNo is same");
        }
        
      public T check ()
        {
            T max = MaxNo<T>.Max(this.firstNo, this.secondNo, this.thirdNo);
                return max;
        }
            
    }
}
