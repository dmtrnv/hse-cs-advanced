
namespace WhoWantsToBeAMillionaire
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.btnHallHelp = new System.Windows.Forms.Button();
            this.btnCallFriend = new System.Windows.Forms.Button();
            this.btnCanFail = new System.Windows.Forms.Button();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.Location = new System.Drawing.Point(12, 12);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(160, 23);
            this.btnFiftyFifty.TabIndex = 0;
            this.btnFiftyFifty.Text = "50 на 50";
            this.btnFiftyFifty.UseVisualStyleBackColor = true;
            this.btnFiftyFifty.Click += new System.EventHandler(this.OnBtnFiftyFiftyClick);
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnswerA.Location = new System.Drawing.Point(200, 448);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(161, 23);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "btnAnswerA";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.OnBtnAnswerClick);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnswerB.Location = new System.Drawing.Point(488, 448);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(160, 23);
            this.btnAnswerB.TabIndex = 2;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "btnAnswerB";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.OnBtnAnswerClick);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnswerC.Location = new System.Drawing.Point(200, 522);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(160, 23);
            this.btnAnswerC.TabIndex = 3;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "btnAnswerC";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.OnBtnAnswerClick);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnswerD.Location = new System.Drawing.Point(487, 522);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(161, 23);
            this.btnAnswerD.TabIndex = 4;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "btnAnswerD";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.OnBtnAnswerClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(200, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(448, 280);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(197, 295);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(451, 141);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // lstLevel
            // 
            this.lstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 20;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
            this.lstLevel.Location = new System.Drawing.Point(653, 12);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(197, 424);
            this.lstLevel.TabIndex = 8;
            // 
            // btnHallHelp
            // 
            this.btnHallHelp.Enabled = false;
            this.btnHallHelp.Location = new System.Drawing.Point(12, 41);
            this.btnHallHelp.Name = "btnHallHelp";
            this.btnHallHelp.Size = new System.Drawing.Size(160, 23);
            this.btnHallHelp.TabIndex = 9;
            this.btnHallHelp.Text = "Помощь зала";
            this.btnHallHelp.UseVisualStyleBackColor = true;
            // 
            // btnCallFriend
            // 
            this.btnCallFriend.Enabled = false;
            this.btnCallFriend.Location = new System.Drawing.Point(12, 70);
            this.btnCallFriend.Name = "btnCallFriend";
            this.btnCallFriend.Size = new System.Drawing.Size(160, 23);
            this.btnCallFriend.TabIndex = 10;
            this.btnCallFriend.Text = "Звонок другу";
            this.btnCallFriend.UseVisualStyleBackColor = true;
            // 
            // btnCanFail
            // 
            this.btnCanFail.Enabled = false;
            this.btnCanFail.Location = new System.Drawing.Point(12, 99);
            this.btnCanFail.Name = "btnCanFail";
            this.btnCanFail.Size = new System.Drawing.Size(160, 23);
            this.btnCanFail.TabIndex = 11;
            this.btnCanFail.Text = "Право на ошибку";
            this.btnCanFail.UseVisualStyleBackColor = true;
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.Location = new System.Drawing.Point(12, 128);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(160, 23);
            this.btnChangeQuestion.TabIndex = 12;
            this.btnChangeQuestion.Text = "Замена вопроса";
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            this.btnChangeQuestion.Click += new System.EventHandler(this.OnBtnChangeQuestionClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 557);
            this.Controls.Add(this.btnChangeQuestion);
            this.Controls.Add(this.btnCanFail);
            this.Controls.Add(this.btnCallFriend);
            this.Controls.Add(this.btnHallHelp);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.btnFiftyFifty);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кто хочет стать миллионером?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Button btnHallHelp;
        private System.Windows.Forms.Button btnCallFriend;
        private System.Windows.Forms.Button btnCanFail;
        private System.Windows.Forms.Button btnChangeQuestion;
    }
}

