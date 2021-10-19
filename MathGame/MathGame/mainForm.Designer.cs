
namespace MathGame
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.agetxtbox = new System.Windows.Forms.TextBox();
            this.errorlbl = new System.Windows.Forms.Label();
            this.beginGamebtn = new System.Windows.Forms.Button();
            this.gameModeGroupBox = new System.Windows.Forms.GroupBox();
            this.divisionRadio = new System.Windows.Forms.RadioButton();
            this.multiplicationRadio = new System.Windows.Forms.RadioButton();
            this.subtractionRadio = new System.Windows.Forms.RadioButton();
            this.additionRadio = new System.Windows.Forms.RadioButton();
            this.gameModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(91, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(110, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(196, 153);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(189, 20);
            this.nametxtbox.TabIndex = 2;
            // 
            // agetxtbox
            // 
            this.agetxtbox.Location = new System.Drawing.Point(196, 187);
            this.agetxtbox.Name = "agetxtbox";
            this.agetxtbox.Size = new System.Drawing.Size(85, 20);
            this.agetxtbox.TabIndex = 3;
            // 
            // errorlbl
            // 
            this.errorlbl.AutoSize = true;
            this.errorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlbl.Location = new System.Drawing.Point(134, 111);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(0, 18);
            this.errorlbl.TabIndex = 4;
            // 
            // beginGamebtn
            // 
            this.beginGamebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.beginGamebtn.Location = new System.Drawing.Point(196, 364);
            this.beginGamebtn.Name = "beginGamebtn";
            this.beginGamebtn.Size = new System.Drawing.Size(146, 51);
            this.beginGamebtn.TabIndex = 5;
            this.beginGamebtn.Text = "BEGIN GAME";
            this.beginGamebtn.UseVisualStyleBackColor = false;
            this.beginGamebtn.Click += new System.EventHandler(this.beginGamebtn_Click);
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameModeGroupBox.Controls.Add(this.divisionRadio);
            this.gameModeGroupBox.Controls.Add(this.multiplicationRadio);
            this.gameModeGroupBox.Controls.Add(this.subtractionRadio);
            this.gameModeGroupBox.Controls.Add(this.additionRadio);
            this.gameModeGroupBox.Location = new System.Drawing.Point(196, 227);
            this.gameModeGroupBox.Name = "gameModeGroupBox";
            this.gameModeGroupBox.Size = new System.Drawing.Size(139, 121);
            this.gameModeGroupBox.TabIndex = 6;
            this.gameModeGroupBox.TabStop = false;
            this.gameModeGroupBox.Text = "Game Mode";
            // 
            // divisionRadio
            // 
            this.divisionRadio.AutoSize = true;
            this.divisionRadio.Location = new System.Drawing.Point(6, 87);
            this.divisionRadio.Name = "divisionRadio";
            this.divisionRadio.Size = new System.Drawing.Size(62, 17);
            this.divisionRadio.TabIndex = 3;
            this.divisionRadio.TabStop = true;
            this.divisionRadio.Tag = "4";
            this.divisionRadio.Text = "Division";
            this.divisionRadio.UseVisualStyleBackColor = true;
            // 
            // multiplicationRadio
            // 
            this.multiplicationRadio.AutoSize = true;
            this.multiplicationRadio.Location = new System.Drawing.Point(6, 64);
            this.multiplicationRadio.Name = "multiplicationRadio";
            this.multiplicationRadio.Size = new System.Drawing.Size(86, 17);
            this.multiplicationRadio.TabIndex = 2;
            this.multiplicationRadio.TabStop = true;
            this.multiplicationRadio.Tag = "3";
            this.multiplicationRadio.Text = "Multiplication";
            this.multiplicationRadio.UseVisualStyleBackColor = true;
            // 
            // subtractionRadio
            // 
            this.subtractionRadio.AutoSize = true;
            this.subtractionRadio.Location = new System.Drawing.Point(6, 41);
            this.subtractionRadio.Name = "subtractionRadio";
            this.subtractionRadio.Size = new System.Drawing.Size(79, 17);
            this.subtractionRadio.TabIndex = 1;
            this.subtractionRadio.TabStop = true;
            this.subtractionRadio.Tag = "2";
            this.subtractionRadio.Text = "Subtraction";
            this.subtractionRadio.UseVisualStyleBackColor = true;
            // 
            // additionRadio
            // 
            this.additionRadio.AutoSize = true;
            this.additionRadio.Location = new System.Drawing.Point(6, 18);
            this.additionRadio.Name = "additionRadio";
            this.additionRadio.Size = new System.Drawing.Size(63, 17);
            this.additionRadio.TabIndex = 0;
            this.additionRadio.TabStop = true;
            this.additionRadio.Tag = "1";
            this.additionRadio.Text = "Addition";
            this.additionRadio.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.gameModeGroupBox);
            this.Controls.Add(this.beginGamebtn);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.agetxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Math Game";
            this.gameModeGroupBox.ResumeLayout(false);
            this.gameModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox agetxtbox;
        private System.Windows.Forms.Label errorlbl;
        private System.Windows.Forms.Button beginGamebtn;
        private System.Windows.Forms.GroupBox gameModeGroupBox;
        private System.Windows.Forms.RadioButton divisionRadio;
        private System.Windows.Forms.RadioButton multiplicationRadio;
        private System.Windows.Forms.RadioButton subtractionRadio;
        private System.Windows.Forms.RadioButton additionRadio;
    }
}

