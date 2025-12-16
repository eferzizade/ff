namespace newTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn0 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            lblTurn = new Label();
            lblScore1 = new Label();
            lblScore2 = new Label();
            panel1 = new Panel();
            btnReset = new Button();
            btnClose = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(57, 59);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 70);
            btn0.TabIndex = 0;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Btn_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(223, 59);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 70);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Btn_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(223, 147);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 70);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Btn_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(57, 147);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 70);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Btn_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(223, 322);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 70);
            btn7.TabIndex = 7;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Btn_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(57, 322);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 70);
            btn6.TabIndex = 6;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Btn_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(223, 234);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 70);
            btn5.TabIndex = 5;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Btn_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(57, 234);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 70);
            btn4.TabIndex = 4;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Btn_Click;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurn.ForeColor = Color.SaddleBrown;
            lblTurn.Location = new Point(529, 76);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(240, 33);
            lblTurn.TabIndex = 8;
            lblTurn.Text = "Növbə: Oyunçu 1";
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.Font = new Font("Consolas", 13.2000008F, FontStyle.Bold);
            lblScore1.ForeColor = Color.Purple;
            lblScore1.Location = new Point(466, 141);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(142, 27);
            lblScore1.TabIndex = 9;
            lblScore1.Text = "Oyunçu 1:0";
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.Font = new Font("Consolas", 13.2000008F, FontStyle.Bold);
            lblScore2.ForeColor = Color.MediumVioletRed;
            lblScore2.Location = new Point(674, 141);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(142, 27);
            lblScore2.TabIndex = 10;
            lblScore2.Text = "Oyunçu 2:0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Location = new Point(427, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 400);
            panel1.TabIndex = 11;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SteelBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(538, 217);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(218, 50);
            btnReset.TabIndex = 13;
            btnReset.Text = "Oyuna Başla";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(538, 293);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(218, 50);
            btnClose.TabIndex = 14;
            btnClose.Text = "Oyundan çıxış";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // timer1
            // 
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(882, 453);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(panel1);
            Controls.Add(lblScore2);
            Controls.Add(lblScore1);
            Controls.Add(lblTurn);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Memory Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Label lblTurn;
        private Label lblScore1;
        private Label lblScore2;
        private Panel panel1;
        private Button btnReset;
        private Button btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}
