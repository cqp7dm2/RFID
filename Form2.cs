﻿using System;
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
        public Form2(string epc)
        {
            InitializeComponent();

            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);

            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(0.05).TotalMilliseconds;
            tmr.Start();

            switch (epc)
            {
                case "2020":
                    ulabel.Text = "Lim Wern Wei";
                    break;

                case "2021":
                    ulabel.Text = "Nicholas Tan Ooi Kiat";
                    break;

                case "2022":
                    ulabel.Text = " Lim Chin Eng";
                    break;

                case "2023":
                    ulabel.Text = "Tan Kian Guan";
                    break;
                default:
                    ulabel.Text = "";
                    ulabel.Visible = false;
                    break;
            }
            //ulabel.Text = epc;
        }
    }
}
