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

            //int num;

            //Console.WriteLine("enter num");
            //num = Convert.ToInt16(Console.ReadLine());
            //int[] a = new int[num];
            //a = genraterand(num);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //Console.WriteLine("quick");
            //int[] a1 = new int[num];
            //a1 = quicksort(a, 0, 7);
            //for(int i=0;i<a1.Length;i++)
            //{
            //    Console.WriteLine(a1[i]);
            //}


            //Console.WriteLine("bubble sort");
            //int[] a1 = new int[num];
            //a1 = bubblsesort(a);
            //for(int i=0;i<a1.Length;i++)
            //{
            //    Console.WriteLine(a1[i]);
            //}

            //Console.WriteLine("selction ");
            //int[] a2 = new int[num];
            //a2 = selection(a);
            //for (int i = 0; i < a2.Length; i++)
            //{
            //    Console.WriteLine(a2[i]);
            //}
            //Console.WriteLine("insertion ");
            //int[] a3 = new int[num];
            //a3 = insertion(a);
            //for (int i = 0; i < a3.Length; i++)
            //{
            //    Console.WriteLine(a3[i]);
            //}

            //stack s = new stack(3);
            //s.push(3);
            //s.push(2);
            //s.pop();
            //Console.WriteLine();
            //s.display();


            queue q = new queue(3);
            q.insertfront(3);
            q.insertfront(4);
            q.delete();

            //list l = new list();
            //l.insert(43);
            //l.insert(24);
            //l.insert(35);
            //l.adddbegin(56);
            ////l.remove();

            //l.addsorted(43,53);
            //l.addsorted(100,99);
            //l.addsorted(2,22);
            //l.addsorted(12324,56);
            //l.search(2);
            /*  l.insertafter(43, 6)*//*;*/
                                      //l.print();



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
    class stack
    {
        int size;
        int top;
        int[] arr;

        public stack(int s)
        {
            size = s;
            arr = new int[size];
            top = -1;
        }

        public void push(int d)
        {
            top++;
            arr[top]=d;
            
            Console.WriteLine(arr[top]);
        }
        public void pop()
        {
            top--;
            int x = arr[top];
        }
        public void display()
        {
            for(int i=top;i>-1;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
    class queue
    {
        int front;
        int rear;
        int[] arr;
        int size;

        public queue(int s)
        {
            size = s;
            arr = new int[size];
            front = 0;
            rear = 0;

        }
        public void insertfront(int d)
        {
            arr[front]=d;
            
            Console.WriteLine(arr[front]);
            front++;
          
        }

        public void delete()
        {
            int x = arr[front];
            front--;
            Console.WriteLine("delete");
            Console.WriteLine(arr[front]);
        }
    }
    class node
    {
      public     node next;
      public  int data;

        public node(int i)
        {
            data = i;
            next = null;

        }
        public void insert(int data)
        {
            if(next==null)
            {
                next = new node(data);
            }
            else
            {
                next.insert(data);
            }
        }
        public void addsorted(int data,int bata)
        {
            if(next==null)
            {
                next = new node(data);
            }
            
            else if(data<next.data)
                {
                node temp=new node(data);

                temp.next = this.next;

                this.next = temp;
                }
            else
            {
                next.addsorted(data,bata);
            }
        }


        public void print()
        {
            Console.WriteLine("<" + data + ">");
            if(next!=null)
            {
                next.print();
            }
        }

    }
    class list
    {
        node head;
        public list()
        {
            head = null;
        }
        public void insert(int data)
        {
            if (head == null)
            {
                head= new node(data);
            }
            else
            {
                head.insert(data);
            }
        }
        public void adddbegin(int data)
        {
            if (head == null)
            {
                head= new node(data);

            }
            else
            {
                node temp = new node(data);
                temp.next = head;
                head = temp;
            }
        }
        public void addsorted(int data,int bata)
        {
            if (head == null)
            {
                head= new node(data);
            }
            else if (data < head.data)
            {


                adddbegin(data);
            }
            else
            {
                head.addsorted(data,bata);
            }
        }
        public node search(int data)
        {
            node x = head;
            while (x != null)
            {
                if (x.data == data)
                {
                    Console.WriteLine("the num is here");
                    return x;

                }
                x = x.next;
               
            }
            return null;
        }
        public void insertafter(int q,int e)
        {
            node x = search(2);

            while(x!=null)
            {
                node temp = new node(9);
                temp.next = x.next;
                x.next = temp;
                Console.WriteLine(temp);
                break;
            }
        }
        public void  remove()
        {
            node x = head;
            head = head.next;
            x = null;
        }
        public void print()
        {
            
            if (head != null)
            {
                head.print();
            }
        }

    }
}
