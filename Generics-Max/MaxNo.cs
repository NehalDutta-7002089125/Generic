using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Generics_Max
{
    public class MaxNo<T> where T: IComparable
        
    {
        T firstNo,secondNo, thirdNo, forthNo;
        public MaxNo(T FirstNo, T secondNo, T thirdNo, T ForthNo) 
        {
            this.firstNo = FirstNo;
            this.secondNo = secondNo;
            this.thirdNo = thirdNo;
            this.forthNo = ForthNo;
        }


        public static T Max  (T FirstNo, T SecondNo, T ThiredNo, T ForthNo) 
        {
            if (FirstNo.CompareTo(SecondNo) > 0 && FirstNo.CompareTo(ThiredNo) > 0 && FirstNo.CompareTo(ForthNo) > 0)
            {
                return FirstNo;
            }
            if (SecondNo.CompareTo(FirstNo) > 0 && SecondNo.CompareTo(ThiredNo) > 0 && SecondNo.CompareTo(ForthNo) > 0)
            {
                return SecondNo;
            }
            if (ThiredNo.CompareTo(FirstNo) > 0 && ThiredNo.CompareTo(SecondNo) > 0 && ThiredNo.CompareTo(ForthNo) > 0)
            {
                return ThiredNo;
            }
            if (ForthNo.CompareTo(FirstNo) > 0 && ForthNo.CompareTo(SecondNo) > 0 && ForthNo.CompareTo(ThiredNo) > 0)
            {
                return ForthNo;
            }
            throw new Exception(" FirstNo,SecondNo,ThiredNo, ForthNo is same");
        }
        
      public T check ()
        {
            T max = MaxNo<T>.Max(this.firstNo, this.secondNo, this.thirdNo, this.forthNo);
                return max;
        }
            
    }
}
