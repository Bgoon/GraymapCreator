namespace GraymapCreator {
	partial class MainForm {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.ImageView = new System.Windows.Forms.PictureBox();
			this.TopBar = new System.Windows.Forms.Panel();
			this.RedrawBtn = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Panel();
			this.GenerateBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
			this.TopBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ImageView
			// 
			this.ImageView.Location = new System.Drawing.Point(0, 20);
			this.ImageView.Name = "ImageView";
			this.ImageView.Size = new System.Drawing.Size(112, 112);
			this.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImageView.TabIndex = 0;
			this.ImageView.TabStop = false;
			// 
			// TopBar
			// 
			this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.TopBar.Controls.Add(this.ExitBtn);
			this.TopBar.Location = new System.Drawing.Point(0, 0);
			this.TopBar.Name = "TopBar";
			this.TopBar.Size = new System.Drawing.Size(112, 20);
			this.TopBar.TabIndex = 1;
			// 
			// RedrawBtn
			// 
			this.RedrawBtn.BackColor = System.Drawing.SystemColors.GrayText;
			this.RedrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RedrawBtn.Font = new System.Drawing.Font("굴림", 9F);
			this.RedrawBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.RedrawBtn.Location = new System.Drawing.Point(-1, 158);
			this.RedrawBtn.Name = "RedrawBtn";
			this.RedrawBtn.Size = new System.Drawing.Size(114, 29);
			this.RedrawBtn.TabIndex = 2;
			this.RedrawBtn.Text = "다시 그리기";
			this.RedrawBtn.UseVisualStyleBackColor = false;
			// 
			// ExitBtn
			// 
			this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ExitBtn.Location = new System.Drawing.Point(92, 0);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(21, 20);
			this.ExitBtn.TabIndex = 2;
			// 
			// GenerateBtn
			// 
			this.GenerateBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.GenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GenerateBtn.Font = new System.Drawing.Font("굴림", 9F);
			this.GenerateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.GenerateBtn.Location = new System.Drawing.Point(-1, 130);
			this.GenerateBtn.Name = "GenerateBtn";
			this.GenerateBtn.Size = new System.Drawing.Size(114, 29);
			this.GenerateBtn.TabIndex = 3;
			this.GenerateBtn.Text = "제네레이트";
			this.GenerateBtn.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(112, 184);
			this.Controls.Add(this.GenerateBtn);
			this.Controls.Add(this.RedrawBtn);
			this.Controls.Add(this.TopBar);
			this.Controls.Add(this.ImageView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "GraymapCreator";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
			this.TopBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ImageView;
		private System.Windows.Forms.Panel TopBar;
		private System.Windows.Forms.Button RedrawBtn;
		private System.Windows.Forms.Panel ExitBtn;
		private System.Windows.Forms.Button GenerateBtn;
	}
}

