using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using MySql.Data.MySqlClient;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        const string CONSTR = " Server = localhost; Database = rfiddatabaselizagagan; Uid = student; Pwd = secret;";

        Random rnd = new Random();

        private InterfaceKit ifkit;
        int numQuestions = 0;
        int qid = 0;
        int corrAns = 0;
        int mode = 0;
        int player = 0;
        int scoreOne = 0;
        int scoreTwo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ifkit = new InterfaceKit();
            ifkit.Attach += Ifkit_Attach;
            ifkit.Detach += Ifkit_Detach;
            ifkit.Error += Ifkit_Error;
            ifkit.InputChange += Ifkit_InputChange;
            
            ifkit.open();
            numQuestions = GetQuestionCount();
        }

        private void Ifkit_InputChange(object sender, InputChangeEventArgs e)
        {
            if (e.Value)
            {
                if (mode ==0) // find player
                {
                    player = e.Index / 4;
                    label2.Text = player.ToString();
                    mode = 1;
                }
                else //find answer
                {
                    int choice = e.Index % 4;
                    label3.Text = choice.ToString();

                    if (choice == corrAns)
                    {
                        ifkit.outputs[7] = true;
                        if (player == 0)
                        {
                            scoreOne++;
                            plScore1.Text = scoreOne.ToString();
                        }
                        if (player == 1)
                        {
                            scoreTwo++;
                            plScore2.Text = scoreTwo.ToString();
                        }
                    }
                    else{
                        ifkit.outputs[6] = true;
                    }
                    
                    mode = 3;
                    timer.Start();
                    
                }
            }
            
        }

        private void Ifkit_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
            ifkit.close();
            this.Close();
        }

        private void Ifkit_Detach(object sender, DetachEventArgs e)
        {
            chkRFID.Checked = false;
        }

        private void Ifkit_Attach(object sender, AttachEventArgs e)
        {
            
            chkRFID.Checked = true;
            qid = rnd.Next(numQuestions) + 1;
            GetQuestion(qid);
            GetAnswers(qid);
        }

        private int GetQuestionCount()
        {
            Int64 count = 0;
            using (MySqlConnection conn = new MySqlConnection(CONSTR))
            {
                conn.Open();
                string query = "Select count(qId) from questions";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    count = (Int64)cmd.ExecuteScalar();
                }
                conn.Close();
            }
            return (int)count;
        }

        private void GetQuestion(int qid)
        {
            //conn  opn cmd  datareader
            using (MySqlConnection conn = new MySqlConnection(CONSTR))
            {
                conn.Open();
                string query = "Select qText, corrAns from questions where qId=@QID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("QID", qid);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
     
                            txtQuestion.Text = rdr.GetString(0);
                            corrAns = rdr.GetInt32(1);
                            label1.Text = corrAns.ToString();
                        }
                    }
                }
                conn.Close();
            }
            
        }

        private void GetAnswers(int qid)
        {

            //conn  opn cmd  datareader
            using (MySqlConnection conn = new MySqlConnection(CONSTR))
            {
                conn.Open();
                string query = "SELECT ansText, ansOption FROM answers WHERE qId = @QID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("QID", qid);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                           
                            int aId = rdr.GetInt32(1);
                            if (aId == 0) ansA.Text = rdr.GetString(0);
                            if (aId == 1) ansB.Text = rdr.GetString(0);
                            if (aId == 2) ansC.Text = rdr.GetString(0);
                            if (aId == 3) ansD.Text = rdr.GetString(0);

                        }
                    }
                }
                conn.Close();
            }
            
        }
        /*private string GetAnswers()
        {
            string answer = null;
            using (MySqlConnection conn = new MySqlConnection(CONSTR))
            {
                conn.Open();
                string query = "Select qText from questions where qId=7 ";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("qText", answer);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            answer = rdr.GetString(0);
                            txtQuestion.Text = answer;
                        }
                    }
                }
                conn.Close();
            }
            return answer;

        }
        }*/


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                ifkit.Attach -= new AttachEventHandler(Ifkit_Attach);
                ifkit.Detach -= new DetachEventHandler(Ifkit_Detach);
                ifkit.Error -= new ErrorEventHandler(Ifkit_Error);

                ifkit.close();
                ifkit = null;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ifkit.outputs[7] = false;
            ifkit.outputs[6] = false;
            qid = rnd.Next(numQuestions) + 1;
            GetQuestion(qid);
            GetAnswers(qid);
            mode = 0;
        }

        
    }
}
