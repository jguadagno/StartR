using StartR.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StartR.Lib.Commands;

namespace StartR.MessageCreator
{
    public partial class Form1 : Form
    {
        private RabbitMQMessageSender _Queue;
        public Form1()
        {
            InitializeComponent();
            _Queue = new RabbitMQMessageSender();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            QualifyNewClientCommand q = new Lib.Commands.QualifyNewClientCommand();
            q.FirstName = "Keith";
            q.LastName = "Elder";
            q.State = "MS";
            q.Zip = "39401";
            q.City = "Hattiesburg";
            q.Address1 = "somwhere";
            q.Id = 1000;
            _Queue.Send<QualifyNewClientCommand>(q);
        }
    }
}
