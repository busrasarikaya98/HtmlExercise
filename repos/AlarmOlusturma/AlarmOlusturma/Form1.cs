﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamaniGoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; //butona bastıgımızda harekete gecsin //ozlliklerde false kayıtlı
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString(); //label1 saattir dönüşümü
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Second.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Enabled = false; //butona basmayı engelleyebiliriz
        }
    }
}
