using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadSpy
{
    class DrawingRunnable
    {
        private TextBox tb;
        private char c;
        private int n;

        public DrawingRunnable(TextBox tb, char c, int n)
        {
            this.tb = tb;
            this.c = c;
            this.n = n;
        }

        /// <summary>
        /// The method to be executed by the new thread
        /// It will print 20 times the character c into TextBox tb
        /// </summary>
        public void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(300);
                TextBoxHelper.AddChar(tb, c, n);
             }
        }
    }
}