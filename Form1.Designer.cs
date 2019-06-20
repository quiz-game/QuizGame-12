namespace QuizGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.chkRFID = new System.Windows.Forms.CheckBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.ansA = new System.Windows.Forms.TextBox();
            this.ansB = new System.Windows.Forms.TextBox();
            this.ansC = new System.Windows.Forms.TextBox();
            this.ansD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plScore1 = new System.Windows.Forms.Label();
            this.plScore2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(123, 117);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 33);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(123, 156);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 33);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(123, 195);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 33);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseCompatibleTextRendering = true;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(123, 234);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 33);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // chkRFID
            // 
            this.chkRFID.AutoSize = true;
            this.chkRFID.Enabled = false;
            this.chkRFID.Location = new System.Drawing.Point(77, 43);
            this.chkRFID.Name = "chkRFID";
            this.chkRFID.Size = new System.Drawing.Size(99, 17);
            this.chkRFID.TabIndex = 4;
            this.chkRFID.Text = "IfKit Connected";
            this.chkRFID.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Location = new System.Drawing.Point(123, 81);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(410, 20);
            this.txtQuestion.TabIndex = 5;
            // 
            // ansA
            // 
            this.ansA.Location = new System.Drawing.Point(204, 124);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(329, 20);
            this.ansA.TabIndex = 6;
            // 
            // ansB
            // 
            this.ansB.Location = new System.Drawing.Point(204, 163);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(329, 20);
            this.ansB.TabIndex = 7;
            // 
            // ansC
            // 
            this.ansC.Location = new System.Drawing.Point(204, 202);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(329, 20);
            this.ansC.TabIndex = 8;
            // 
            // ansD
            // 
            this.ansD.Location = new System.Drawing.Point(204, 241);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(329, 20);
            this.ansD.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player 1 score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Player 2 score:";
            // 
            // plScore1
            // 
            this.plScore1.AutoSize = true;
            this.plScore1.Location = new System.Drawing.Point(201, 329);
            this.plScore1.Name = "plScore1";
            this.plScore1.Size = new System.Drawing.Size(13, 13);
            this.plScore1.TabIndex = 15;
            this.plScore1.Text = "0";
            // 
            // plScore2
            // 
            this.plScore2.AutoSize = true;
            this.plScore2.Location = new System.Drawing.Point(540, 329);
            this.plScore2.Name = "plScore2";
            this.plScore2.Size = new System.Drawing.Size(13, 13);
            this.plScore2.TabIndex = 16;
            this.plScore2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plScore2);
            this.Controls.Add(this.plScore1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ansD);
            this.Controls.Add(this.ansC);
            this.Controls.Add(this.ansB);
            this.Controls.Add(this.ansA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.chkRFID);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.CheckBox chkRFID;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox ansA;
        private System.Windows.Forms.TextBox ansB;
        private System.Windows.Forms.TextBox ansC;
        private System.Windows.Forms.TextBox ansD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label plScore1;
        private System.Windows.Forms.Label plScore2;
    }
}

