using PG5_DP_Observer.KeyReceivers.Observers;
using PG5_DP_Observer.KeyReceivers.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG5_DP_Observer
{
    public partial class Form1 : Form
    {
        private Subject _subject = new Subject();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubscribeToSubject();
        }

        private void SubscribeToSubject()
        {
            new Observer("observer1").Subscribed(this._subject);
            new Observer("observer2").Subscribed(this._subject);
            new Observer("observer3").Subscribed(this._subject);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                int number = e.KeyChar - 48; // Made Ascii value as a number
                this._subject.ChangeNumber(number);
            }
            else // out of boundary
            {
                MessageBox.Show($"Please enter the number between 1 and 9.");
            }
        }
    }
}
