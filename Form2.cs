using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace UHFReader288Demo
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer tmr;
        public static string picture = "";
        public Form2()
        {
            InitializeComponent();
            label1.Text = Form1.fullname;
            label3.Text = Form1.position;
            label4.Text = Form1.industry;
            picture = Form1.pic;
            
            switch (picture)
            {
                case "UHFReader288Demo.Properties.Resources._0":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._0;
                    break;
                case "UHFReader288Demo.Properties.Resources._1":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._1;
                    break;
                case "UHFReader288Demo.Properties.Resources._2":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._2;
                    break;
                case "UHFReader288Demo.Properties.Resources._3":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._3;
                    break;
                case "UHFReader288Demo.Properties.Resources._4":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._4;
                    break;
                case "UHFReader288Demo.Properties.Resources._5":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._5;
                    break;
                case "UHFReader288Demo.Properties.Resources._6":
                    pictureBox1.Image = UHFReader288Demo.Properties.Resources._6;
                    break;
                default:
                    //Console.WriteLine("Default case");
                    break;
            }
            pictureBox1.Visible = true;

            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(0.09).TotalMilliseconds;
            tmr.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
