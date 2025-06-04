namespace TeamSignUpModule
{
    partial class SignUpForm
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
            this.getAdBtn = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.checkAvBtn = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.imgLoad = new System.Windows.Forms.Button();
            this.imgDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.team = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idCheckLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // getAdBtn
            // 
            this.getAdBtn.Location = new System.Drawing.Point(257, 366);
            this.getAdBtn.Name = "getAdBtn";
            this.getAdBtn.Size = new System.Drawing.Size(75, 23);
            this.getAdBtn.TabIndex = 0;
            this.getAdBtn.Text = "주소 찾기";
            this.getAdBtn.UseVisualStyleBackColor = true;
            this.getAdBtn.Click += new System.EventHandler(this.getAdBtn_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(53, 366);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(198, 45);
            this.address.TabIndex = 1;
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imgBox.Location = new System.Drawing.Point(120, 33);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(80, 80);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(164, 426);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(76, 23);
            this.signUpBtn.TabIndex = 3;
            this.signUpBtn.Text = " 회원가입";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // checkAvBtn
            // 
            this.checkAvBtn.Location = new System.Drawing.Point(257, 182);
            this.checkAvBtn.Name = "checkAvBtn";
            this.checkAvBtn.Size = new System.Drawing.Size(75, 23);
            this.checkAvBtn.TabIndex = 4;
            this.checkAvBtn.Text = "중복확인";
            this.checkAvBtn.UseVisualStyleBackColor = true;
            this.checkAvBtn.Click += new System.EventHandler(this.checkAvBtn_Click);
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(202, 136);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(130, 21);
            this.nickname.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(53, 184);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(198, 21);
            this.id.TabIndex = 7;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(53, 230);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(279, 21);
            this.pw.TabIndex = 8;
            // 
            // imgLoad
            // 
            this.imgLoad.Location = new System.Drawing.Point(206, 48);
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.Size = new System.Drawing.Size(75, 23);
            this.imgLoad.TabIndex = 9;
            this.imgLoad.Text = "불러오기";
            this.imgLoad.UseVisualStyleBackColor = true;
            this.imgLoad.Click += new System.EventHandler(this.imgLoad_Click);
            // 
            // imgDel
            // 
            this.imgDel.Location = new System.Drawing.Point(206, 77);
            this.imgDel.Name = "imgDel";
            this.imgDel.Size = new System.Drawing.Size(75, 23);
            this.imgDel.TabIndex = 10;
            this.imgDel.Text = "삭제하기";
            this.imgDel.UseVisualStyleBackColor = true;
            this.imgDel.Click += new System.EventHandler(this.imgDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "별명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "아이디";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "비밀번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "팀";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "주소";
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(53, 277);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(279, 20);
            this.department.TabIndex = 18;
            this.department.SelectedIndexChanged += new System.EventHandler(this.department_SelectedIndexChanged);
            // 
            // team
            // 
            this.team.FormattingEnabled = true;
            this.team.Location = new System.Drawing.Point(53, 321);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(279, 20);
            this.team.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "프로필 사진";
            // 
            // idCheckLabel
            // 
            this.idCheckLabel.AutoSize = true;
            this.idCheckLabel.Location = new System.Drawing.Point(98, 169);
            this.idCheckLabel.Name = "idCheckLabel";
            this.idCheckLabel.Size = new System.Drawing.Size(81, 12);
            this.idCheckLabel.TabIndex = 21;
            this.idCheckLabel.Text = "중복확인 필요";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(53, 136);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(130, 21);
            this.name.TabIndex = 22;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.name);
            this.Controls.Add(this.idCheckLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.team);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgDel);
            this.Controls.Add(this.imgLoad);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.checkAvBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.getAdBtn);
            this.Name = "SignUpForm";
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getAdBtn;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button checkAvBtn;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Button imgLoad;
        private System.Windows.Forms.Button imgDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.ComboBox team;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idCheckLabel;
        private System.Windows.Forms.TextBox name;
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

