using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectGas
{
    public partial class FormGas : Form
    {
        MoveBall moveBall;
        public FormGas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormGas_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Ball ball = new Ball(e.X, e.Y, this);
            }

            else
            {
                moveBall = new MoveBall(e.X, e.Y, this);
            }
        }

        private void FormGas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            moveBall.Move();
            moveBall.Show();
        }
    }
}
