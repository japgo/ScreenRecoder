namespace ScreenRecoderTest
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRecordStart = new System.Windows.Forms.Button();
			this.btnRecordStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnRecordStart
			// 
			this.btnRecordStart.Location = new System.Drawing.Point(42, 53);
			this.btnRecordStart.Name = "btnRecordStart";
			this.btnRecordStart.Size = new System.Drawing.Size(75, 50);
			this.btnRecordStart.TabIndex = 0;
			this.btnRecordStart.Text = "Record Start";
			this.btnRecordStart.UseVisualStyleBackColor = true;
			this.btnRecordStart.Click += new System.EventHandler(this.btnRecordStart_Click);
			// 
			// btnRecordStop
			// 
			this.btnRecordStop.Location = new System.Drawing.Point(160, 53);
			this.btnRecordStop.Name = "btnRecordStop";
			this.btnRecordStop.Size = new System.Drawing.Size(75, 50);
			this.btnRecordStop.TabIndex = 1;
			this.btnRecordStop.Text = "Record Stop";
			this.btnRecordStop.UseVisualStyleBackColor = true;
			this.btnRecordStop.Click += new System.EventHandler(this.btnRecordStop_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnRecordStop);
			this.Controls.Add(this.btnRecordStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRecordStart;
		private System.Windows.Forms.Button btnRecordStop;
	}
}

