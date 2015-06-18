using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Threads.commands;

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LinearProcess lp = new LinearProcess();

            TimeSpan ts = lp.process(10);

            lblLinear.Text = string.Format("Total MilliSeconds: {0}", ts.TotalMilliseconds);

            Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            ThreadedProcess tp = new ThreadedProcess();

            TimeSpan ts = tp.process(1);

            lblOneThread.Text = string.Format("Total MilliSeconds: {0}", ts.TotalMilliseconds);

            Cursor = Cursors.Default;
        }

        private void btnMoreThreads_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            ThreadedProcess tp = new ThreadedProcess();

            TimeSpan ts = tp.process(16);

            lblMoreThreads.Text = string.Format("Total MilliSeconds: {0}", ts.TotalMilliseconds);

            Cursor = Cursors.Default;
        }

        private void btnLinear2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LinearProcess lp = new LinearProcess();

            TimeSpan ts = lp.process(0);

            lblLinear2.Text = string.Format("Total MilliSeconds: {0}", ts.TotalMilliseconds);

            Cursor = Cursors.Default;
        }

        private void btnLinqOne_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LinqThreaded lt = new LinqThreaded();

            TimeSpan ts = lt.process(1);

            lblLinqOne.Text = string.Format("Total MilliSeconds: {0}", ts.TotalMilliseconds);

            Cursor = Cursors.Default;
        }

        private void btnLinqMulti_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LinqThreaded lt = new LinqThreaded();

            TimeSpan ts = lt.process(16);

            lblLinqMulti.Text = string.Format("Total MilliSeconds: {0}", ts.TotalMilliseconds);

            Cursor = Cursors.Default;
        }
    }
}
