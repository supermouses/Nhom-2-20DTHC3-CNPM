using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace THCongNghePhanMem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //#region 
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.title = this.title.Substring(1, title.Length - 1) + this.title.Substring(0, 1);
        //    this.Text = this.title;
        //}
        //string title = "Phan mem quan ly sinh vien o tro";
        //#endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OTro ot = new OTro();
            ot.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NhaTro nt = new NhaTro();
            nt.ShowDialog();
        }
    }
}