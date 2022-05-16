namespace Assessment.Algo
{
    public class MergeSort
    {

        /// <summary>
        /// Reference -  mycodeschool -  https://www.youtube.com/watch?v=TzeBrDU-JaY&list=PL2_aWCzGMAwKedT2KfDMB9YA5DgASZb3U&index=5
        /// Merge sort is asked 98 % of time . Most efficient sorting algorithm .
        /// </summary>
        /// <param name="unSortedArr"></param>
        /// <returns></returns>
        public  int[] MergeSort_Array_Alog(int[] unSortedArr)
        {
            int unSortedArrLength = unSortedArr.Length;

            if (unSortedArrLength < 2)
                return unSortedArr;

            int mid = unSortedArrLength / 2;

            int[] leftArr = new int[mid];
            int[] rightArr = new int[unSortedArrLength - mid];

            // Make left  array 
            for (int i = 0; i < mid; i++)
            {
                leftArr[i] = unSortedArr[i];
            }

            // Make right sorted array 
            for (int i = mid; i < unSortedArrLength; i++)
            {
                rightArr[i-mid] = unSortedArr[i];
            }

            // Further break down left array untill only one index left 
            MergeSort_Array_Alog(leftArr);

            // Further break down left array untill only one index left 
            MergeSort_Array_Alog(rightArr);

            // Finally sort the array 
            Merge(leftArr, rightArr, unSortedArr);

            // return sorted Array
            return unSortedArr;

        }

        public void Merge(int[] leftArr, int[] rightArr, int[] unSortedArr)
        {
            int i = 0; int j = 0; int k = 0;

            // It will compare two left and right array index by index and update main array 
            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    unSortedArr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    unSortedArr[k] = rightArr[j];
                    j++;
                }

                k++;
            }

            // left array index which is not replcaed in main array 

            while (i < leftArr.Length)
            {
                unSortedArr[k] = leftArr[i];
                i++;
                k++;
            }

            // Right  array index which is not replcaed in main array 

            while (j < rightArr.Length)
            {
                unSortedArr[k] = rightArr[j];
                j++;
                k++;
            }
        }


    }
}
