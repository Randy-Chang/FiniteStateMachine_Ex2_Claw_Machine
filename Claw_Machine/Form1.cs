using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claw_Machine
{
    public partial class Form1 : Form
    {
        public enum State1 { Idle, Start, Initialize, DetectTime, Move, Grab }
        public List<double> Object_X = new List<double>();
        public List<double> Object_Y = new List<double>();
        State1 s1;
        int s2 = 0;
        bool s3 = false;
        int PlayTimes = 0;
        bool bStart = false;
        bool bLeft = false, bRight = false, bDown = false;
        int TimeLimit = 10;
        int time_start;
        int StepAxis = 10;
        int condition = 10;

        int number;

        public Form1()
        {
            InitializeComponent();

            Object_X.Add(pbObject1.Location.X);
            Object_Y.Add(pbObject1.Location.Y);

            Object_X.Add(pbObject2.Location.X);
            Object_Y.Add(pbObject2.Location.Y);

        }

        void Run()
        {
            while (s3 == true)
            {
            }
        }

        private void MainState_Tick(object sender, EventArgs e)
        {
            
            switch (s1)
            {
                case State1.Idle:
                    SetLabel(lbTime, $"Time : {0}");
                    btnStart.Enabled = true;
                    if (bStart == true)
                    {
                        s1 = State1.Start;
                    }
                    break;

                case State1.Start:
                    PlayTimes++;
                    SetLabel(lbPlayTimes, $"PlayTimes : {PlayTimes}");
                    s1 = State1.Move;
                    break;

                case State1.Move:
                    SetLabel(lbTime, $"Time : {(Environment.TickCount - time_start) / 1000}");
                    s1 = State1.DetectTime;

                    if (bRight == true)
                        MoveXAxis(pbClaw, StepAxis);
                    else if (bLeft == true)
                        MoveXAxis(pbClaw, -1*StepAxis);
                    else if (bDown == true)
                        s1 = State1.Grab;

                    break;

                case State1.Grab:
                    switch (s2)
                    {
                        case 0:
                            if (pbClaw.Location.Y + StepAxis <= plGameZone.Size.Height - pbClaw.Size.Height - plBlackButton.Size.Height)
                            {
                                pbClaw.Top += StepAxis;
                                JudgeClawTouchObject(pbClaw, pbObject0, 0, ref number, ref s2);
                                JudgeClawTouchObject(pbClaw, pbObject1, condition, ref number, ref s2);
                                JudgeClawTouchObject(pbClaw, pbObject2, condition, ref number, ref s2);
                            }
                            else
                                s2 = 10;
                            break;

                        case 10:
                            if (pbClaw.Location.Y > 0)
                            {
                                pbClaw.Top += -1 * StepAxis;
                                GrabObject_Y(number, ref s2);
                            }
                                
                                
                            else
                                s2 = 20;
                            break;

                        case 20:
                            if (pbClaw.Location.X > 0)
                            {
                                pbClaw.Left += -1 * StepAxis;
                                GrabObject_X(number, ref s2);
                            }
                            else if (number == 0) // 沒夾到東西
                            {
                                s2 = 0;
                                bStart = false;
                                s1 = State1.Initialize;
                            }
                            else
                            {
                                GrabRelease(ref number);
                            }
                            break;
                    }
                    break;


                case State1.Initialize:
                    if (pbClaw.Location.X != 0 && pbClaw.Location.Y != 0)
                    {
                        pbClaw.Left += -StepAxis;
                        pbClaw.Top += -StepAxis;
                    }
                    s1 = State1.Idle;
                    number = 0;
                    break;

                case State1.DetectTime:
                    if(Environment.TickCount - time_start>= TimeLimit * 1000)
                        s1 = State1.Grab;
                    else
                        s1 = State1.Move;
                    break;
                    
            }

        }

        //--------------------------------------------
        void JudgeClawTouchObject(PictureBox pbClaw, PictureBox pbObject, int cdt, ref int number, ref int state)
        {
            double Claw_Width = pbClaw.Size.Width;
            double Claw_Height = pbClaw.Size.Height;
            double Claw_X = pbClaw.Location.X;
            double Claw_Y = pbClaw.Location.Y;

            double Object_Width = pbObject.Size.Width;
            double Object_Height = pbObject.Size.Height;
            double Object_X = pbObject.Location.X;
            double Object_Y = pbObject.Location.Y;

            double Claw_Fact_X = Claw_X + Claw_Width * 0.5;
            double Claw_Fact_Y = Claw_Y + Claw_Height;

            double Object_upper_X1 = Object_X;
            double Object_upper_X2 = Object_X + Object_Width;
            double Object_Fact_Y = Object_Y;

            if (Claw_Fact_X - cdt >= Object_upper_X1 & Claw_Fact_X + cdt <= Object_upper_X2 & Claw_Fact_Y >= Object_Fact_Y)
            {
                number = Convert.ToInt32( pbObject.Name.Substring(8,1) );
                state = 10;
                return;
            }
        }

        void GrabObject_Y(int number, ref int state)
        {
            if (number == 1)
                pbObject1.Top += -1 * StepAxis;
            else if (number == 2)
                pbObject2.Top += -1 * StepAxis;
        }

        void GrabObject_X(int number, ref int state)
        {
            if (number == 1)
                pbObject1.Left += -1 * StepAxis;
            else if (number == 2)
                pbObject2.Left += -1 * StepAxis;
        }

        void GrabRelease(ref int number)
        {
            if (number == 1)
            {
                if (pbObject1.Location.Y != Object_Y[number-1])
                    pbObject1.Top += StepAxis;
                else if (pbObject1.Location.Y == Object_Y[number-1])
                    number = 0;
            }
            else if (number == 2)
            {
                if (pbObject2.Location.Y != Object_Y[number - 1])
                    pbObject2.Top += StepAxis;
                else if (pbObject2.Location.Y == Object_Y[number - 1])
                    number = 0;
            }
        }

        void MoveXAxis(PictureBox pb,  int Speed)
        {
            if (pbClaw.Location.X + Speed >= 0 && pbClaw.Location.X + Speed <= plGameZone.Size.Width - pbClaw.Size.Width)
                pb.Left += Speed;
        }

        //--------- for 委派 -------------------------------------------------
        public delegate void SetLabelTextCallback(Label lb, string text);

        public void SetLabel(Label lb, string text)
        {
            if (lb.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabel);
                Invoke(d, new object[] { lb, text });
            }
            else
                lb.Text = text;
        }
        


        //---------- UI -------------------------------------------------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            bStart = true;
            s1 = State1.Start;
            time_start = Environment.TickCount;
            btnStart.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                bLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                bRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                bDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                bLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                bRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                bDown = false;
            }
        }
    }

    public class abc
    {
        void a(PictureBox pb)
        {
            pb.Left += 5;
        }
    }
}
