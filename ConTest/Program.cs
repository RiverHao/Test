using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConTest
{
    class Program
    {
        static void Main(string[] args)
        {



            //B b = new B();
            //b.say();

            //int[] array = { 49, 38, 65, 97, 76, 13, 27 };
            //sort(array, 0, array.Length - 1);
            //Console.ReadLine();

            //IList<int> lists = new List<int>();
            //IList<int> list = new List<int> { 1, 1, 2, 3, 3, 4 };
            //lists=list.Distinct().ToList();
        }
        #region//快速排序
        public static void sort(int[] array, int low, int high)
        {
            if (low >= high)
                return;
            /*完成一次单元排序*/
            int index = sortUnit(array, low, high);
            /*对左边单元进行排序*/
            sort(array, low, index - 1);
            /*对右边单元进行排序*/
            sort(array, index + 1, high);
        }
        private static int sortUnit(int[] array, int low, int high)
        {
            int key = array[low];
            while (low < high)
            {
                /*从后向前搜索比key小的值*/
                while (array[high] >= key && high > low)
                    --high;
                /*比key小的放左边*/
                array[low] = array[high];
                /*从前向后搜索比key大的值，比key大的放右边*/
                while (array[low] <= key && high > low)
                    ++low;
                /*比key大的放右边*/
                array[high] = array[low];
            }
            /*左边都比key小，右边都比key大。//将key放在游标当前位置。//此时low等于high */
            array[low] = key;
            foreach (int i in array)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
            return high;
        }

        public class A
        {
            public A() { say(); }
            public virtual void say() { }
        }

        public class B : A
        {
            int x = 1, y = 0;
            public B()
            {
                y = 6; say();
            }
            public override void say()
            {
                Console.WriteLine("x:{0},y{1}", x, y);
            }
        }
        #endregion

        //int askCount = AskList.GetAskListCount();
        //        SlFile.Write("E:\\SouFun\\ask.test.soufun.com\\interface\\Config\\GetAskCount" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", string.Format("个数:{0} 时间:{1}", askCount, DateTime.Now));

    }

     
}
