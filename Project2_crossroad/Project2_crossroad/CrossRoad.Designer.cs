namespace Project2_crossroad
{
    partial class CrossRoad
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.timerCarro1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(767, 326);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(686, 346);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(767, 367);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(848, 346);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // timerCarro1
            // 
            this.timerCarro1.Enabled = true;
            this.timerCarro1.Interval = 500;
            this.timerCarro1.Tick += new System.EventHandler(this.timerCarro1_Tick);
            // 
            // CrossRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 556);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Name = "CrossRoad";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Timer timerCarro1;



    }
}

