using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Stack_Queue
{
    public partial class Form1 : Form
    {
        bool onStack = false;
        bool onQueue=false ;
        public static Stack<int> s = new Stack<int>();
        Queue q = new Queue();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void piuStack()
        {
            int n = 0;
            onStack = true;
            while (onStack)
            {
                s.Push(n);


                Thread.Sleep(1000);
                n++;
            }
        }

        public void piuQueue()
        {
            int n = 0;
            onQueue = true;
            while (onQueue)
            {
                q.Enqueue(n);


                Thread.Sleep(1000);
                n++;
            }
        }




        //Thread p = new Thread(piu);


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(this.piuStack);
            t.Start();
            while (s.Count > 0)
            {
                listBox1.Items.Add(s.Pop());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onStack = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            onQueue = false;
            while (q.Count > 0)
            {
                listBox2.Items.Add(q.Dequeue());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(piuQueue);
            a.Start();

        }
    }
}
