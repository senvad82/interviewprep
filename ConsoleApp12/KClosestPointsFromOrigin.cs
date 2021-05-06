using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{

    public class KCLosestPointFromOrigin
    {
        public int[][] KClosest(int[][] points, int k)
        {

            PriorityQueue<Point> pq = new PriorityQueue<Point>();
            var n = points.Length;
            for (int i = 0; i < n; i++)
            {
                Point pt = new Point(points[i][0], points[i][1]);
                pq.Enqueue(pt);
            }
            var result = new int[k][];
            for (int i = 0; i < k; i++)
            {
                var pt = pq.Dequeue();
                Console.WriteLine(pt.x);
                Console.WriteLine(pt.y);
                result[i] = new int[2] { pt.x, pt.y };
            }

            return result;

        }


    }

    public class Point : IComparable<Point>
    {
        public int x;
        public int y;
        public double distanceFromOrigin;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.distanceFromOrigin = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public int CompareTo(Point other)
        {
            if (this.distanceFromOrigin < other.distanceFromOrigin) return -1;
            else if (this.distanceFromOrigin > other.distanceFromOrigin) return 1;
            else return 0;
        }
    } // Employee

    // ===================================================================

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1;
            while (ci > 0)
            {
                int pi = (ci - 1) / 2;
                if (data[ci].CompareTo(data[pi]) >= 0) break;
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {

            int li = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[li];
            data.RemoveAt(li);

            --li;
            int pi = 0;
            while (true)
            {
                int ci = pi * 2 + 1;
                if (ci > li) break;
                int rc = ci + 1;
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0)
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break;
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; // swap parent and child
                pi = ci;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }

        public bool IsConsistent()
        {

            if (data.Count == 0) return true;
            int li = data.Count - 1; // last index
            for (int pi = 0; pi < data.Count; ++pi) // each parent index
            {
                int lci = 2 * pi + 1; // left child index
                int rci = 2 * pi + 2; // right child index

                if (lci <= li && data[pi].CompareTo(data[lci]) > 0) return false; // if lc exists and it's greater than parent then bad.
                if (rci <= li && data[pi].CompareTo(data[rci]) > 0) return false; // check the right child too.
            }
            return true; // passed all checks
        } // IsConsistent
    } // PriorityQueue


}
