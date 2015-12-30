﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFME_LAUNCHER
{

    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void Play_MouseHover(object sender, EventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayHover;
        }

        private void Play_MouseClick(object sender, MouseEventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayClicked;
            //this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayHover;
        }

        private void Play_MouseEnter(object sender, EventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayHover;
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.Play;
        }

        

      

    

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quitClicked;
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.minClicked;
            this.WindowState = FormWindowState.Minimized;
        }
        private bool drag = false;
        //private Point _offset;
        private Point startPoint = new Point(0, 0);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {

            this.startPoint = e.Location;
            
            this.drag = true;

            

        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);

                Point p2 = this.PointToScreen(p1);

                Point p3 = new Point(p2.X - this.startPoint.X,

                                     p2.Y - this.startPoint.Y);

                this.Location = p3;

            }
            

        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void SelectBFME1_Click(object sender, EventArgs e)
        {
            SelectBFME1.Visible = false;
            SelectBFME2.Visible = true;
            SelectROTWK.Visible = true;
            SelectBFME2.BringToFront();
            SelectROTWK.BringToFront();
            BFME1Pb.BringToFront();
            this.BFME1Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Active;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
        }

        private void SelectBFME2_Click(object sender, EventArgs e)
        {
            //this.BFME1Pb.Parent = this.BFME2Pb;
            SelectBFME2.Visible = false;
            SelectBFME1.Visible = true;
            SelectROTWK.Visible = true;
            SelectBFME1.BringToFront();
            SelectROTWK.BringToFront();
            BFME2Pb.BringToFront();
            this.BFME1Pb.BackgroundImage = null;
            this.BFME2Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme2Active;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme2Background;
        }

        private void SelectROTWK_Click(object sender, EventArgs e)
        {
            SelectROTWK.Visible = false;
            SelectBFME1.Visible = true;
            SelectBFME2.Visible = true;
            SelectBFME1.BringToFront();
            SelectBFME2.BringToFront();
            ROTWKPb.BringToFront() ;
            this.BFME1Pb.BackgroundImage = null;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeRotwkActive;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeRotwkBackground;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            SelectBFME1.Visible = false;
            SelectBFME2.Visible = true;
            SelectROTWK.Visible = true;
            BFME1Pb.BringToFront();
            SelectBFME2.BringToFront();
            SelectROTWK.BringToFront();
            this.BFME1Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Active;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
        }

       
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quitHover;

        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quit;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.minHover;

        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.min;
        }

        private void MainLogo_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;

            this.drag = true;

        }

        private void MainLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);

                Point p2 = this.PointToScreen(p1);

                Point p3 = new Point(p2.X - this.startPoint.X,

                                     p2.Y - this.startPoint.Y);

                this.Location = p3;
            }

        }

        private void MainLogo_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void Info_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;

            this.drag = true;

        }

        private void Info_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);

                Point p2 = this.PointToScreen(p1);

                Point p3 = new Point(p2.X - this.startPoint.X,

                                     p2.Y - this.startPoint.Y);

                this.Location = p3;
            }

        }

        private void Info_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void T3A_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://forums.revora.net/");
        }

        private void BFMETeam_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://www.facebook.com/thebfme/");
        }

        private void EALogo_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "https://help.ea.com/en/contact-us/new/");
        }

        private void Play_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                i++;
                this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayClicked;
            } while (i != 100);
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayHover;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ROTWKPb_Click(object sender, EventArgs e)
        {

        }
    }
}
