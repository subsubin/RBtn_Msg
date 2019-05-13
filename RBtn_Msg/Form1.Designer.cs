namespace RBtn_Msg
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.Ok = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbInfomation = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gpOption1 = new System.Windows.Forms.GroupBox();
            this.gpOption2 = new System.Windows.Forms.GroupBox();
            this.gpOption1.SuspendLayout();
            this.gpOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(6, 27);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(38, 16);
            this.rbOk.TabIndex = 2;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "Ok";
            this.rbOk.UseVisualStyleBackColor = true;
            this.rbOk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Ok
            // 
            this.Ok.AutoSize = true;
            this.Ok.Location = new System.Drawing.Point(6, 49);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(78, 16);
            this.Ok.TabIndex = 3;
            this.Ok.TabStop = true;
            this.Ok.Text = "OkCancle";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(6, 71);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(61, 16);
            this.rbYesNo.TabIndex = 4;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(6, 27);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(50, 16);
            this.rbError.TabIndex = 5;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            this.rbError.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbInfomation
            // 
            this.rbInfomation.AutoSize = true;
            this.rbInfomation.Location = new System.Drawing.Point(6, 49);
            this.rbInfomation.Name = "rbInfomation";
            this.rbInfomation.Size = new System.Drawing.Size(85, 16);
            this.rbInfomation.TabIndex = 6;
            this.rbInfomation.TabStop = true;
            this.rbInfomation.Text = "Information";
            this.rbInfomation.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Location = new System.Drawing.Point(6, 71);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(73, 16);
            this.rbQuestion.TabIndex = 7;
            this.rbQuestion.TabStop = true;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(14, 106);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(220, 43);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // gpOption1
            // 
            this.gpOption1.Controls.Add(this.Ok);
            this.gpOption1.Controls.Add(this.rbOk);
            this.gpOption1.Controls.Add(this.rbYesNo);
            this.gpOption1.Location = new System.Drawing.Point(14, 9);
            this.gpOption1.Name = "gpOption1";
            this.gpOption1.Size = new System.Drawing.Size(111, 91);
            this.gpOption1.TabIndex = 9;
            this.gpOption1.TabStop = false;
            this.gpOption1.Text = "Type";
            // 
            // gpOption2
            // 
            this.gpOption2.Controls.Add(this.rbInfomation);
            this.gpOption2.Controls.Add(this.rbQuestion);
            this.gpOption2.Controls.Add(this.rbError);
            this.gpOption2.Location = new System.Drawing.Point(132, 9);
            this.gpOption2.Name = "gpOption2";
            this.gpOption2.Size = new System.Drawing.Size(102, 91);
            this.gpOption2.TabIndex = 10;
            this.gpOption2.TabStop = false;
            this.gpOption2.Text = "Icon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 159);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpOption1);
            this.Controls.Add(this.gpOption2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메세지 박스 보기";
            this.gpOption1.ResumeLayout(false);
            this.gpOption1.PerformLayout();
            this.gpOption2.ResumeLayout(false);
            this.gpOption2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.RadioButton Ok;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbInfomation;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gpOption1;
        private System.Windows.Forms.GroupBox gpOption2;
    }
}

