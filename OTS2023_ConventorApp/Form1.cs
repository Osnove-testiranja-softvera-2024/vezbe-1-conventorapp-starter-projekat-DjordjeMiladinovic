﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OTS2023_ConventorApp.LenghtConverter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true){
                label1.Text = "Pounds";
                label2.Text = "Kilograms";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                label1.Text = "Feet";
                label2.Text = "Meters";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MassConverter converter = new MassConverter();
                textBox2.Text = converter.Convert(Convert.ToInt64(textBox1.Text)).ToString();

            }
            else if (radioButton2.Checked == true)
            {
                LengthConverter converter = new LengthConverter();
                textBox2.Text = converter.Convert(Convert.ToInt64(textBox1.Text)).ToString();
            }
        }
    }


    

}

