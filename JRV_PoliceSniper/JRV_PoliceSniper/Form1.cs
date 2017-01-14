using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace JRV_PoliceSniper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "JRV_PoliceSniper";

            Image badguy1 = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
            Image badguy2 = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
            Image badguy3 = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
            Image badguy4 = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
            Image badguy5 = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
            Image badguy6 = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
            Image badguy7 = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
            Image badguy8 = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;

            Image goodguy1 = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
            Image goodguy2 = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
            Image goodguy3 = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
            Image goodguy4 = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
            Image goodguy5 = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
            Image goodguy6 = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
            Image goodguy7 = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
            Image goodguy8 = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
            Image goodguy9 = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;

        }

        int action;
        bool appear = false;
        bool disappear = false;
        int window;
        int personToAppear;
        int score = 0;
        Random rnd1 = new Random();

        bool window1badguy = false;
        bool window2badguy = false;
        bool window3badguy = false;
        bool window4badguy = false;
        bool window5badguy = false;
        bool window6badguy = false;
        bool window7badguy = false;
        bool window8badguy = false;
        bool window9badguy = false;
        bool window10badguy = false;
        bool window11badguy = false;
        bool window12badguy = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void badGuyClick()
        {
            score++;
            if (timer1.Interval > 1) { timer1.Interval = timer1.Interval--; }
        }

        private void goodGuyClick()
        {
            timer1.Stop();
            window1.Visible = false;
            window2.Visible = false;
            window3.Visible = false;
            window4.Visible = false;
            window5.Visible = false;
            window6.Visible = false;
            window7.Visible = false;
            window8.Visible = false;
            window9.Visible = false;
            window10.Visible = false;
            window11.Visible = false;
            window12.Visible = false;

            gameOver.Visible = true;
            restartButton.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreBox.Text = score.ToString();

            action = rnd1.Next(0, 4);
            if (action == 1)
            {
                appear = true;
            }
            else if (action == 2)
            {
                disappear = true;
            }

            if (disappear)
            {
                disappear = false;
                window = rnd1.Next(1, 13); // there are 12 windows, numbered 1 thru 12
                switch (window)
                {
                    case 1:
                        window1.Visible = false;
                        break;
                    case 2:
                        window2.Visible = false;
                        break;
                    case 3:
                        window3.Visible = false;
                        break;
                    case 4:
                        window4.Visible = false;
                        break;
                    case 5:
                        window5.Visible = false;
                        break;
                    case 6:
                        window6.Visible = false;
                        break;
                    case 7:
                        window7.Visible = false;
                        break;
                    case 8:
                        window8.Visible = false;
                        break;
                    case 9:
                        window9.Visible = false;
                        break;
                    case 10:
                        window10.Visible = false;
                        break;
                    case 11:
                        window11.Visible = false;
                        break;
                    case 12:
                        window12.Visible = false;
                        break;

                    default:
                        break;
                }
            }

            if (appear)
            {

                appear = false;
                window = rnd1.Next(1, 13); // there are 12 windows, numbered 1 thru 12


                if (window == 1)
                {
                    if (window1.Visible == false)
                    {
                        window1.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window1badguy = true; }
                        else
                        { window1badguy = false; }


                        switch (personToAppear)
                        {
                            case 1:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window1.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment


                if (window == 2)
                {
                    if (window2.Visible == false)
                    {
                        window2.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window2badguy = true; }
                        else
                        { window2badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window2.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment


                if (window == 3)
                {
                    if (window3.Visible == false)
                    {
                        window3.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window3badguy = true; }
                        else
                        { window3badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window3.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment



                if (window == 4)
                {
                    if (window4.Visible == false)
                    {
                        window4.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window4badguy = true; }
                        else
                        { window4badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window4.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment





                if (window == 5)
                {
                    if (window5.Visible == false)
                    {
                        window5.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window5badguy = true; }
                        else
                        { window5badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window5.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment

                if (window == 6)
                {
                    if (window6.Visible == false)
                    {
                        window6.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window6badguy = true; }
                        else
                        { window6badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window6.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment


                if (window == 7)
                {
                    if (window7.Visible == false)
                    {
                        window7.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window7badguy = true; }
                        else
                        { window7badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window7.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment


                if (window == 8)
                {
                    if (window8.Visible == false)
                    {
                        window8.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window8badguy = true; }
                        else
                        { window8badguy = false; }

                        switch (personToAppear)
                        {
                            case 1:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                                break;
                            case 2:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                                break;
                            case 3:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                                break;
                            case 4:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                                break;
                            case 5:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                                break;
                            case 6:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                                break;
                            case 7:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                                break;
                            case 8:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                                break;
                            case 9:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                                break;
                            case 10:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                                break;
                            case 11:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                                break;
                            case 12:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                                break;
                            case 13:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                                break;
                            case 14:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                                break;
                            case 15:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                                break;
                            case 16:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                                break;
                            case 17:
                                window8.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                                break;
                            default:
                                break;
                        }
                    }
                } // End window segment


                if (window == 9)
                {
                    if (window9.Visible == false)
                    {
                        window9.Visible = true;
                        personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                        if (personToAppear < 9)
                        { window9badguy = true; }
                        else
                        { window9badguy = false; }

                        window9.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                    }
                    switch (personToAppear)
                    {
                        case 1:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                            break;
                        case 2:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                            break;
                        case 3:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                            break;
                        case 4:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                            break;
                        case 5:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                            break;
                        case 6:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                            break;
                        case 7:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                            break;
                        case 8:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                            break;
                        case 9:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                            break;
                        case 10:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                            break;
                        case 11:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                            break;
                        case 12:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                            break;
                        case 13:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                            break;
                        case 14:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                            break;
                        case 15:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                            break;
                        case 16:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                            break;
                        case 17:
                            window9.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                            break;
                        default:
                            break;
                    }
                }
            } // End window segment


            if (window == 10)
            {
                if (window10.Visible == false)
                {
                    window10.Visible = true;
                    personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                    if (personToAppear < 9)
                    { window10badguy = true; }
                    else
                    { window10badguy = false; }

                    switch (personToAppear)
                    {
                        case 1:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                            break;
                        case 2:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                            break;
                        case 3:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                            break;
                        case 4:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                            break;
                        case 5:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                            break;
                        case 6:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                            break;
                        case 7:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                            break;
                        case 8:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                            break;
                        case 9:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                            break;
                        case 10:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                            break;
                        case 11:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                            break;
                        case 12:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                            break;
                        case 13:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                            break;
                        case 14:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                            break;
                        case 15:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                            break;
                        case 16:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                            break;
                        case 17:
                            window10.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                            break;
                        default:
                            break;
                    }
                }
            } // End window segment




            if (window == 11)
            {
                if (window11.Visible == false)
                {
                    window11.Visible = true;
                    personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear


                    if (personToAppear < 9)
                    { window11badguy = true; }
                    else
                    { window11badguy = false; }

                    switch (personToAppear)
                    {
                        case 1:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                            break;
                        case 2:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                            break;
                        case 3:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                            break;
                        case 4:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                            break;
                        case 5:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                            break;
                        case 6:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                            break;
                        case 7:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                            break;
                        case 8:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                            break;
                        case 9:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                            break;
                        case 10:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                            break;
                        case 11:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                            break;
                        case 12:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                            break;
                        case 13:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                            break;
                        case 14:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                            break;
                        case 15:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                            break;
                        case 16:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                            break;
                        case 17:
                            window11.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                            break;
                        default:
                            break;
                    }
                }
            } // End window segment



            if (window == 12)
            {
                if (window12.Visible == false)
                {
                    window12.Visible = true;
                    personToAppear = rnd1.Next(0, 18); // there are 17 people who might appear

                    if (personToAppear < 9)
                    { window12badguy = true; }
                    else
                    { window12badguy = false; }

                    switch (personToAppear)
                    {
                        case 1:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle1;
                            break;
                        case 2:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle2;
                            break;
                        case 3:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.BadGuyRifle3;
                            break;
                        case 4:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.BadGuyStriped2;
                            break;
                        case 5:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Green;
                            break;
                        case 6:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Purple;
                            break;
                        case 7:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Red_Green;
                            break;
                        case 8:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Bad_Guy_Striped;
                            break;
                        case 9:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl1;
                            break;
                        case 10:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl2;
                            break;
                        case 11:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.GoodGirl3;
                            break;
                        case 12:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat2;
                            break;
                        case 13:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.GoodGuyCat3;
                            break;
                        case 14:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Black___White;
                            break;
                        case 15:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Cat1;
                            break;
                        case 16:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Green;
                            break;
                        case 17:
                            window12.Image = JRV_PoliceSniper.Properties.Resources.Good_Guy_Striped;
                            break;
                        default:
                            break;
                    }
                }
            } // End window segment

        }


        private void window1_Click(object sender, EventArgs e)
        {
            window1.Visible = false;
            if (window1badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window2_Click_1(object sender, EventArgs e)
        {
            window2.Visible = false;
            if (window2badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window3_Click_1(object sender, EventArgs e)
        {
            window3.Visible = false;
            if (window3badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window4_Click_1(object sender, EventArgs e)
        {
            window4.Visible = false;
            if (window4badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window5_Click_1(object sender, EventArgs e)
        {
            window5.Visible = false;
            if (window5badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window6_Click_1(object sender, EventArgs e)
        {
            window6.Visible = false;
            if (window6badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window7_Click_1(object sender, EventArgs e)
        {
            window7.Visible = false;
            if (window7badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window8_Click_1(object sender, EventArgs e)
        {
            window8.Visible = false;
            if (window8badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window9_Click_1(object sender, EventArgs e)
        {
            window9.Visible = false;
            if (window9badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window10_Click_1(object sender, EventArgs e)
        {
            window10.Visible = false;
            if (window10badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window11_Click_1(object sender, EventArgs e)
        {
            window11.Visible = false;
            if (window11badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void window12_Click_1(object sender, EventArgs e)
        {
            window12.Visible = false;
            if (window12badguy)
            {
                badGuyClick();
            }
            else
            {
                goodGuyClick();
            }
        } // end window

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            score = 0;
            gameOver.Visible = false;
            timer1.Interval = 100;
            timer1.Start();
            restartButton.Visible = false;
        }
    }
}
