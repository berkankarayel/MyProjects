namespace _1_AdonetCustomerProject
{
	partial class FrmMap
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
			this.btnOpenCityForm = new System.Windows.Forms.Button();
			this.btnCustomerOpenForm = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenCityForm
			// 
			this.btnOpenCityForm.Location = new System.Drawing.Point(103, 89);
			this.btnOpenCityForm.Name = "btnOpenCityForm";
			this.btnOpenCityForm.Size = new System.Drawing.Size(161, 48);
			this.btnOpenCityForm.TabIndex = 0;
			this.btnOpenCityForm.Text = "Şehir İşlemleri";
			this.btnOpenCityForm.UseVisualStyleBackColor = true;
			this.btnOpenCityForm.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCustomerOpenForm
			// 
			this.btnCustomerOpenForm.Location = new System.Drawing.Point(103, 157);
			this.btnCustomerOpenForm.Name = "btnCustomerOpenForm";
			this.btnCustomerOpenForm.Size = new System.Drawing.Size(161, 49);
			this.btnCustomerOpenForm.TabIndex = 1;
			this.btnCustomerOpenForm.Text = "Müşteri İşlemleri";
			this.btnCustomerOpenForm.UseVisualStyleBackColor = true;
			this.btnCustomerOpenForm.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(103, 224);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(161, 44);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Çıkış Yap";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.button3_Click);
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCustomerOpenForm);
			this.Controls.Add(this.btnOpenCityForm);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sayfalar";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpenCityForm;
		private System.Windows.Forms.Button btnCustomerOpenForm;
		private System.Windows.Forms.Button btnExit;
	}
}