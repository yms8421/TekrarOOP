namespace BilgeAdam.WordMemory
{
    partial class frmGame
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
            this.lblPicker = new System.Windows.Forms.Label();
            this.tmrPicker = new System.Windows.Forms.Timer(this.components);
            this.grbLetters = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grbLetters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPicker
            // 
            this.lblPicker.AutoSize = true;
            this.lblPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPicker.Location = new System.Drawing.Point(362, 26);
            this.lblPicker.Name = "lblPicker";
            this.lblPicker.Size = new System.Drawing.Size(54, 73);
            this.lblPicker.TabIndex = 0;
            this.lblPicker.Text = "-";
            // 
            // tmrPicker
            // 
            this.tmrPicker.Interval = 50;
            this.tmrPicker.Tick += new System.EventHandler(this.tmrPicker_Tick);
            // 
            // grbLetters
            // 
            this.grbLetters.Controls.Add(this.label8);
            this.grbLetters.Controls.Add(this.label4);
            this.grbLetters.Controls.Add(this.label7);
            this.grbLetters.Controls.Add(this.label3);
            this.grbLetters.Controls.Add(this.label6);
            this.grbLetters.Controls.Add(this.label2);
            this.grbLetters.Controls.Add(this.label5);
            this.grbLetters.Controls.Add(this.label1);
            this.grbLetters.Location = new System.Drawing.Point(12, 329);
            this.grbLetters.Name = "grbLetters";
            this.grbLetters.Size = new System.Drawing.Size(776, 100);
            this.grbLetters.TabIndex = 1;
            this.grbLetters.TabStop = false;
            this.grbLetters.Text = "Kullanılacak Harfler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(714, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 55);
            this.label8.TabIndex = 1;
            this.label8.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(306, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 55);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(614, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 55);
            this.label7.TabIndex = 1;
            this.label7.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(201, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(507, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 55);
            this.label6.TabIndex = 1;
            this.label6.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(404, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(343, 121);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 59);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grbLetters);
            this.Controls.Add(this.lblPicker);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "Kelime Oyunu";
            this.grbLetters.ResumeLayout(false);
            this.grbLetters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPicker;
        private System.Windows.Forms.Timer tmrPicker;
        private System.Windows.Forms.GroupBox grbLetters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

