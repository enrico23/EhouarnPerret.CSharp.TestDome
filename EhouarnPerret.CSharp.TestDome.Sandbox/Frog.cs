    //
// Frog.cs
//
// Author:
//       Ehouarn Perret <ehouarn.perret@outlook.com>
//
// Copyright (c) 2016 Ehouarn Perret
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace EhouarnPerret.CSharp.TestDome.Sandbox
{

    public class Frog
    {

//        public static Int32 NumberOfWays(Int32 n)
//        {
//            if (n <= 2)
//            {
//                return n;
//            }
//            else
//            {
//                var n2 = 1;
//                var n1 = 2;
//
//                for (var i = 2; i < n; i++)
//                {
//                    
//                }
//            }
//        }

        public static Int32 NaiveRecursiveNumberOfWays(Int32 n)
        {
            if (n <= 2)
            {
                return n;
            }
            else
            {
                return Frog.NaiveRecursiveNumberOfWays(n - 1) + Frog.NaiveRecursiveNumberOfWays(n - 2);
            }
        }

        private static Int32[] Memoization { get; set; }

        public static void Main(params String[] args)
        {
            Console.WriteLine(Frog.NumberOfWays(3));
        }
    }

}
