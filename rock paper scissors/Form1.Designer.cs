namespace rock_paper_scissors {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_Winner = new System.Windows.Forms.Label();
			this.lbl_cChoice = new System.Windows.Forms.Label();
			this.lbl_pChoice = new System.Windows.Forms.Label();
			this.btn_Paper = new System.Windows.Forms.Button();
			this.btn_Scissors = new System.Windows.Forms.Button();
			this.btn_Rock = new System.Windows.Forms.Button();
			this.btn_Reset = new System.Windows.Forms.Button();
			this.tbx_Result = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lbl_Winner);
			this.groupBox1.Controls.Add(this.lbl_cChoice);
			this.groupBox1.Controls.Add(this.lbl_pChoice);
			this.groupBox1.Controls.Add(this.btn_Paper);
			this.groupBox1.Controls.Add(this.btn_Scissors);
			this.groupBox1.Controls.Add(this.btn_Rock);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(356, 129);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rock Paper Scissors";
			// 
			// lbl_Winner
			// 
			this.lbl_Winner.AutoSize = true;
			this.lbl_Winner.Location = new System.Drawing.Point(6, 110);
			this.lbl_Winner.Name = "lbl_Winner";
			this.lbl_Winner.Size = new System.Drawing.Size(35, 13);
			this.lbl_Winner.TabIndex = 5;
			this.lbl_Winner.Text = "label1";
			// 
			// lbl_cChoice
			// 
			this.lbl_cChoice.AutoSize = true;
			this.lbl_cChoice.Location = new System.Drawing.Point(6, 84);
			this.lbl_cChoice.Name = "lbl_cChoice";
			this.lbl_cChoice.Size = new System.Drawing.Size(35, 13);
			this.lbl_cChoice.TabIndex = 4;
			this.lbl_cChoice.Text = "label1";
			// 
			// lbl_pChoice
			// 
			this.lbl_pChoice.AutoSize = true;
			this.lbl_pChoice.Location = new System.Drawing.Point(6, 59);
			this.lbl_pChoice.Name = "lbl_pChoice";
			this.lbl_pChoice.Size = new System.Drawing.Size(35, 13);
			this.lbl_pChoice.TabIndex = 3;
			this.lbl_pChoice.Text = "label1";
			// 
			// btn_Paper
			// 
			this.btn_Paper.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_Paper.Location = new System.Drawing.Point(122, 19);
			this.btn_Paper.Name = "btn_Paper";
			this.btn_Paper.Size = new System.Drawing.Size(110, 37);
			this.btn_Paper.TabIndex = 2;
			this.btn_Paper.Text = "Paper";
			this.btn_Paper.UseVisualStyleBackColor = true;
			this.btn_Paper.Click += new System.EventHandler(this.btn_Paper_Click);
			// 
			// btn_Scissors
			// 
			this.btn_Scissors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Scissors.Location = new System.Drawing.Point(240, 19);
			this.btn_Scissors.Name = "btn_Scissors";
			this.btn_Scissors.Size = new System.Drawing.Size(110, 37);
			this.btn_Scissors.TabIndex = 1;
			this.btn_Scissors.Text = "Scissors";
			this.btn_Scissors.UseVisualStyleBackColor = true;
			this.btn_Scissors.Click += new System.EventHandler(this.btn_Scissors_Click);
			// 
			// btn_Rock
			// 
			this.btn_Rock.Location = new System.Drawing.Point(6, 19);
			this.btn_Rock.Name = "btn_Rock";
			this.btn_Rock.Size = new System.Drawing.Size(110, 37);
			this.btn_Rock.TabIndex = 0;
			this.btn_Rock.Text = "Rock";
			this.btn_Rock.UseVisualStyleBackColor = true;
			this.btn_Rock.Click += new System.EventHandler(this.btn_Rock_Click);
			// 
			// btn_Reset
			// 
			this.btn_Reset.Location = new System.Drawing.Point(6, 19);
			this.btn_Reset.Name = "btn_Reset";
			this.btn_Reset.Size = new System.Drawing.Size(175, 23);
			this.btn_Reset.TabIndex = 1;
			this.btn_Reset.Text = "Reset";
			this.btn_Reset.UseVisualStyleBackColor = true;
			this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
			// 
			// tbx_Result
			// 
			this.tbx_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbx_Result.Location = new System.Drawing.Point(6, 48);
			this.tbx_Result.Multiline = true;
			this.tbx_Result.Name = "tbx_Result";
			this.tbx_Result.ReadOnly = true;
			this.tbx_Result.Size = new System.Drawing.Size(175, 75);
			this.tbx_Result.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.tbx_Result);
			this.groupBox2.Controls.Add(this.btn_Reset);
			this.groupBox2.Location = new System.Drawing.Point(374, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(187, 129);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Result";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 149);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(589, 188);
			this.MinimumSize = new System.Drawing.Size(589, 188);
			this.Name = "Form1";
			this.Text = "Rock Paper Scissors";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_Paper;
		private System.Windows.Forms.Button btn_Scissors;
		private System.Windows.Forms.Button btn_Rock;
		private System.Windows.Forms.Button btn_Reset;
		private System.Windows.Forms.TextBox tbx_Result;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_Winner;
		private System.Windows.Forms.Label lbl_cChoice;
		private System.Windows.Forms.Label lbl_pChoice;
	}
}

