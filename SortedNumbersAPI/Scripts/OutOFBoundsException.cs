using System;
/*
 * Custom exception that is called when there are numbers that are not in 1-10 interval
 */

namespace SortedNumbersAPI.Scripts
{
    [Serializable]
    public class OutOFBoundsException : Exception
    {

        public OutOFBoundsException()
        {

        }

        public OutOFBoundsException(int num)
            : base(String.Format("Number is not in range of 1-10: {0}", num))
        {

        }

    }
}
