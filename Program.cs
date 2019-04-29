using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sequence1 = new List <int>(); 
            for (int i = 0; i < sequence.Count-1; i++)
            {
                sequence1.Add(sequence[i]);
            }
          
            var br = 0;
            var FirstIndex =sequence[sequence.Count - 1];
            sequence.RemoveAt(sequence.Count - 1); 
            for (int i = 0; i < sequence.Count; i++)
            {
                sequence[i] -= 1; 
                
            } 
                if (sequence[FirstIndex]==0)
                {
                    Console.Write(string.Join(" ",sequence));
                    Console.WriteLine();
                    Console.WriteLine(br); return;
                }
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i]==0)
                {
                    sequence[i] += br;
                }

            }
            
            var index = int.Parse(Console.ReadLine());

            while (true)
            {
                br++;
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i] -= 1;

                }
                if (sequence[index] == 0)
                {
                    Console.Write(string.Join(" ", sequence));
                    Console.WriteLine();
                    Console.WriteLine(br); return;
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == 0)
                    {
                        sequence[i] = sequence1[i];
                    }

                }
                
                index = int.Parse(Console.ReadLine());
            }
            
            
        }
    }
}

