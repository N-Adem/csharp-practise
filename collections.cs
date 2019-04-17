using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CollectionsProj
{
    class CollectionsOne
    {   //  ******************************************* First Draft *****************************************
        // Task Check which collection type return a value faster with the same operations
        // Collection types will be List, Enumerable, Dictionary, stack and Queue. 
        // Run all of the methods asynchronously get the time back from that. 
        /* 
         * I'm going to make several methods which return the total elapsed time after the algorithm has finished processing. 
         * The fastest time will be 
         one will be printed.                   
        */ 
        public static Stopwatch watch = new Stopwatch();
       
        public static double ReturnListTime(int value)
        {   
            int[] numList = Enumerable.Range(1,value).ToArray();
            List<int> evenContainer = new List<int>();
            List<int> oddContainer = new List<int>();
            watch.Start();
            for(int i = 1; i <= numList.Length; i++)
            {   
                if((i % 2) == 0)   
                {        
                    evenContainer.Add(i);
                }else if((i % 2) != 0 )
                {oddContainer.Add(i);}    
            }
            foreach(var i in evenContainer)
            {
                Console.WriteLine($"List even container = {i}");
            }
            watch.Stop();
            double endTime = watch.ElapsedMilliseconds;
            Console.WriteLine(endTime);
            return endTime;
        }

        public static double ReturnStackTime(int value)
        {
            int[] numList = Enumerable.Range(1,value).ToArray();
            Stack<int> evenContainer = new Stack<int>();
            Stack<int> oddContainer = new Stack<int>();
             watch.Start();
            for(int i = 1; i <= numList.Length; i++)
            {       
                   // Console.WriteLine($"This stack item is in the even container {i}");  
                    evenContainer.Push(i);
                 if((i % 2) != 0 )
                {
                    oddContainer.Push(evenContainer.Pop());
                 //   Console.WriteLine($"This stack item is in the odd container {i}");
                }    
            } 
            foreach(var i in evenContainer)
            {
                Console.WriteLine("Stack even container =" + i);
            }
            watch.Stop();
            double endTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time = " + endTime);
            // output the elapsed time and return
            return watch.ElapsedMilliseconds;
        }

        public static double ReturnQueueTime(int value)
        {
            int[] numList = Enumerable.Range(1,value).ToArray();
            Queue<int> evenContainer = new Queue<int>();
            Queue<int> oddContainer = new Queue<int>();
             watch.Start();
            for(int i = 1; i <= numList.Length; i++)
            {  
                if((i % 2) == 0 )
                {
                    //Console.WriteLine($"This stack item is in the even container {i}");  
                    evenContainer.Enqueue(i);
                }                
                else if((i % 2) != 0)
                    {
                        oddContainer.Enqueue(i);
                        //Console.WriteLine($"This stack item is in the odd container {i}");
                    }    
            } 
            foreach(var i in evenContainer)
            {
                Console.WriteLine($"Queue even container = {i}");
            }        
            watch.Stop();
            double endTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time = " + endTime);
            // output the elapsed time and return
            return endTime;
        }

        public static double ReturnDictTime(int value)
        {
            int[] numList = Enumerable.Range(1,value).ToArray();
            Dictionary<int,int> evenDict = new Dictionary<int, int>();
            int key = 1;
            watch.Start();
            for(int i = 1 ; i < numList.Length; i ++ )
            {
                if((i % 2) == 0)
                {
                    evenDict.Add(key ++,i);
                }
            }
            foreach(var i in evenDict)
            {
                Console.WriteLine("Dictionary Even Output = "+ i);
            }
            watch.Stop();
            double endTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed time = " + endTime);
            return endTime;
        }

    } 

    // ***************************************** Second Draft ****************************************
    // Create a simple way to test 
    class CollectionsTwo
    {
        
    }

}// End of NameSpace Collectionsproj  