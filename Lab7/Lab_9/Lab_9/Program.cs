using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    //Варіант 14.Двоспрямований список.Спосіб додавання - включення до початку.Операції зі списком:знайти кількість елементів менших за середнє значення.Видалити елементи,які розташовані до максимального елементу
    public class DoublyNode<Double>
    {
        public double Data { get; set; }
        public DoublyNode<Double> Previous { get; set; }
        public DoublyNode<Double> Next { get; set; }
    
        public DoublyNode(double data)
        {
            Data = data;
            
        }
    }
    public class DoublyLinkedList<Double> : IEnumerable<double>
    {
        DoublyNode<Double> head;
        DoublyNode<Double> tail;
        int count;//count elements in list
        //add element
        public void Add(double data)
        {
            DoublyNode<Double> node = new DoublyNode<Double>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(double data)
        {
            DoublyNode<Double> node = new DoublyNode<Double>(data);
            DoublyNode<Double> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(double data)
        {
            DoublyNode<Double> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public bool Remove(double data)
        {
            DoublyNode<Double> current = head;
            //to search deleting node
            while (current != null)
            {
                if (current.Data.Equals(data))
                    break;
                current = current.Next;
            }
            if (current!=null)
            {
                //if node is not last
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }
                //if node is not first
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        public void deleteElementsBeforeMax()
        {
            DoublyNode<Double> max = FindMaxNode();
            DoublyNode<Double> current = head;
            while (current != null)
            {
                if (current.Data != max.Data)
                    Remove(current.Data);
                else
                    break;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<double> IEnumerable<double>.GetEnumerator()
        {
            DoublyNode<Double> current = head;
            while (current != null)
            {
                 yield return current.Data;
                current = current.Next;
            }
        }
        public IEnumerable<double> BackEnumerator()
        {
            DoublyNode<Double> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
        public double CalcSum()
        {
            DoublyNode<Double> current = head;
            double sum = 0d;
            while (current!=null)
            {
                
                    sum += Convert.ToDouble(current.Data);
                current = current.Next;
            }
            return sum;
        }
        public double CalcNumOfLessThanAvLetters()
        {
            DoublyNode<Double> current = head;
            int counter = 0;
            double data = 0d;
            double sum = CalcSum();
            while (current != null)
            {
                
                    data = Convert.ToDouble(current.Data);
               
                if (data.CompareTo(sum / Count) < 0) counter++;
                current = current.Next;
            }
            return counter;
        }
        public DoublyNode<Double> FindMaxNode()
        {
            DoublyNode<Double> current = head;
            DoublyNode<Double> max = current;
            while (current != null)
            {

                //find last max
                if ( max.Data<=current.Data)
                
                    max = current;

                current = current.Next;
            }
            return max;
        }
        

    }
        class Program
        {
        static void Main(string[] args)
        {
            DoublyLinkedList<double> linkedList = new DoublyLinkedList<double>();
            linkedList.Add(5);
            linkedList.Add(23);
            linkedList.Add(100);
            linkedList.Add(56);
            linkedList.Add(5);
            linkedList.Add(10);
            linkedList.Add(68);
            Console.WriteLine($"Average:{linkedList.CalcSum() / linkedList.Count}");
            Console.WriteLine($"Sum:{linkedList.CalcSum()}");
            Console.WriteLine($"counter:{linkedList.CalcNumOfLessThanAvLetters()}");
            Console.WriteLine($"max:{linkedList.FindMaxNode().Data}");
            linkedList.deleteElementsBeforeMax();
            foreach (var l in linkedList)
            {
                Console.WriteLine(l);
            }
          
        }
    }
}
