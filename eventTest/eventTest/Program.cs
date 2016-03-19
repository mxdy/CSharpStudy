using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EventTest e = new EventTest(18);
            e.setValue(10);

            e.eventHandler += new EventTest.eventDelegateHandler(Print);
            e.setValue(200);
            Console.ReadLine();
        }

        public static void Print()
        {
            Console.WriteLine("event is call_back");
        }
    }

    class EventTest
    {
        int value;
        public delegate void eventDelegateHandler();
        public event eventDelegateHandler eventHandler;

        public EventTest(int v)
        {
            setValue(v);
        }

        public virtual void OnValueChanged()
        {
            if (eventHandler != null)
            {
                eventHandler();
            }
            else
            {
                Console.WriteLine("event fired!");
            }
        }

        public void setValue(int v)
        {
            if (value != v)
            {
                value = v;
                OnValueChanged();
            }
        }
    }
}
