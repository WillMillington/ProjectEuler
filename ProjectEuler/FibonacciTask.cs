﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class FibonacciTask
    {
        public static int Fibonacci(int max)
        {
            var sequence = new List<int>();
            int num1 = 1;
            int num2 = 1;
            int num3;

            sequence.Add(num1);
            //if (max == 1) return sequence;

            sequence.Add(num2);
            //if (max == 2) return sequence;

            var evenSequence = new List<int>();
            int evenSequenceSum = 0;
            Console.Write($"{num1} ");
            Console.Write($"{num2} ");
            for (int i = 2; i < max; i++)
            {
                num3 = num1 + num2;
                if (num3 < 4000000)
                {
                    sequence.Add(num3);
                    if (num3 % 2 == 0) evenSequence.Add(num3);
                    Console.Write($"{num3} ");
                    num1 = num2;
                    num2 = num3;
                }
            }
            foreach (int i in evenSequence)
            {
                evenSequenceSum += i;
            }
            return evenSequenceSum;
            //return 0;
            //return sequence;

        }
    }
}

