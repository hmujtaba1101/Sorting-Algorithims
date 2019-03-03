using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("enter num");
            num = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[num];
            a = genraterand(num);
            for (int i = 0; i < a.Length; i++)
            {
               Console.WriteLine(a[i]);
            }

            Console.WriteLine("quick");
            int[] a1 = new int[num];
            a1 = quicksort(a, 0, 7);
            for(int i=0;i<a1.Length;i++)
            {
                Console.WriteLine(a1[i]);
            }


            Console.WriteLine("bubble sort");
            int[] a1 = new int[num];
            a1 = bubblsesort(a);
            for(int i=0;i<a1.Length;i++)
            {
                Console.WriteLine(a1[i]);
            }

            Console.WriteLine("selction ");
            int[] a2 = new int[num];
            a2 = selection(a);
            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine(a2[i]);
            }
            Console.WriteLine("insertion ");
            int[] a3 = new int[num];
            a3 = insertion(a);
            for (int i = 0; i < a3.Length; i++)
           {
                Console.WriteLine(a3[i]);
            }

           


          



            Console.ReadLine();

        }

        public  static int []genraterand(int num)
        {

            int[] arr = new int[num];
            Random rand = new Random();
            for(int i=0;i<arr.Length;i++)
            {
               arr[i]=rand.Next(1, num);

            }
            return arr;
        }

        public static int []bubblsesort(int []arr)
        {
            int temp;
            for(int j=0;j<arr.Length;j++)
            {
                for(int i=0;i<arr.Length-j-1;i++)
                {
                    if(arr[i]>arr[i+1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static int []selection(int []arr)
        {
            int temp;
            for(int i=1;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if(arr[i]<arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
        public static int [ ]insertion(int []arr)
        {
            int temp;
            for(int outer=1;outer<arr.Length;outer++)
            {
                temp = arr[outer];
                int inner = outer - 1;

                while(inner>0&&arr[inner]>temp)
                {
                    arr[inner] = arr[inner + 1];
                    inner = inner - 1;
                }
                arr[inner + 1] = temp;
            }
            return arr;
        }

        public static int  partial(int []a,int start,int end)
        {
            int pivot = a[end];
            int pindex = start;
            for(int i=start;i<end;i++)
            {
                if(a[i]<=pivot)
                {
                    int temp = a[i];
                    a[i] = a[pindex];
                    a[pindex] = temp;
                    pindex++;
                }
            }
            int h = a[pindex];
            a[pindex] = a[end];
            a[end] = h;

            return pindex;


        }
        public static int [] quicksort(int []a,int start,int end)
        {
            if (start < end)
            {
                int pindex = partial(a, start, end);
                quicksort(a, start, pindex - 1);
                quicksort(a, pindex + 1, end);
            }
            return a;
        }
    }
  
}
