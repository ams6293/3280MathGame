
namespace MathGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.numOnelbl = new System.Windows.Forms.Label();
            this.signlbl = new System.Windows.Forms.Label();
            this.numTwolbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answertxtbox = new System.Windows.Forms.TextBox();
            this.submitAnswerbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Correctlbl = new System.Windows.Forms.Label();
            this.incorrectlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOnelbl
            // 
            this.numOnelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numOnelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOnelbl.Location = new System.Drawing.Point(43, 189);
            this.numOnelbl.Name = "numOnelbl";
            this.numOnelbl.Size = new System.Drawing.Size(80, 63);
            this.numOnelbl.TabIndex = 0;
            this.numOnelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signlbl
            // 
            this.signlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signlbl.Location = new System.Drawing.Point(146, 189);
            this.signlbl.Name = "signlbl";
            this.signlbl.Size = new System.Drawing.Size(82, 63);
            this.signlbl.TabIndex = 1;
            this.signlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTwolbl
            // 
            this.numTwolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numTwolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTwolbl.Location = new System.Drawing.Point(246, 189);
            this.numTwolbl.Name = "numTwolbl";
            this.numTwolbl.Size = new System.Drawing.Size(72, 63);
            this.numTwolbl.TabIndex = 2;
            this.numTwolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 63);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answertxtbox
            // 
            this.answertxtbox.Enabled = false;
            this.answertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answertxtbox.Location = new System.Drawing.Point(450, 205);
            this.answertxtbox.Name = "answertxtbox";
            this.answertxtbox.Size = new System.Drawing.Size(78, 31);
            this.answertxtbox.TabIndex = 4;
            this.answertxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitAnswerbtn
            // 
            this.submitAnswerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.submitAnswerbtn.Enabled = false;
            this.submitAnswerbtn.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnswerbtn.Location = new System.Drawing.Point(427, 246);
            this.submitAnswerbtn.Name = "submitAnswerbtn";
            this.submitAnswerbtn.Size = new System.Drawing.Size(123, 52);
            this.submitAnswerbtn.TabIndex = 5;
            this.submitAnswerbtn.Text = "Submit";
            this.submitAnswerbtn.UseVisualStyleBackColor = false;
            this.submitAnswerbtn.Click += new System.EventHandler(this.submitAnswerbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startbtn.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(136, 330);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(222, 52);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "Start Game";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerlbl
            // 
            this.timerlbl.AutoSize = true;
            this.timerlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.timerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlbl.Location = new System.Drawing.Point(26, 53);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(40, 42);
            this.timerlbl.TabIndex = 7;
            this.timerlbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "TIMER";
            // 
            // Correctlbl
            // 
            this.Correctlbl.AutoSize = true;
            this.Correctlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correctlbl.ForeColor = System.Drawing.Color.Green;
            this.Correctlbl.Location = new System.Drawing.Point(447, 182);
            this.Correctlbl.Name = "Correctlbl";
            this.Correctlbl.Size = new System.Drawing.Size(68, 20);
            this.Correctlbl.TabIndex = 9;
            this.Correctlbl.Text = "Correct";
            this.Correctlbl.Visible = false;
            // 
            // incorrectlbl
            // 
            this.incorrectlbl.AutoSize = true;
            this.incorrectlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectlbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.incorrectlbl.Location = new System.Drawing.Point(446, 182);
            this.incorrectlbl.Name = "incorrectlbl";
            this.incorrectlbl.Size = new System.Drawing.Size(81, 20);
            this.incorrectlbl.TabIndex = 10;
            this.incorrectlbl.Text = "Incorrect";
            this.incorrectlbl.Visible = false;
            // 
            // GameForm
            // 
            this.AcceptButton = this.submitAnswerbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.incorrectlbl);
            this.Controls.Add(this.Correctlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerlbl);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.submitAnswerbtn);
            this.Controls.Add(this.answertxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTwolbl);
            this.Controls.Add(this.signlbl);
            this.Controls.Add(this.numOnelbl);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOnelbl;
        private System.Windows.Forms.Label signlbl;
        private System.Windows.Forms.Label numTwolbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox answertxtbox;
        private System.Windows.Forms.Button submitAnswerbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Correctlbl;
        private System.Windows.Forms.Label incorrectlbl;
    }
}