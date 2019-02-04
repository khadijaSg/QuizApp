namespace QuizApp
{
    partial class EnterQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterQuiz));
            this.enterPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryList = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // enterPictureBox
            // 
            this.enterPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterPictureBox.BackgroundImage")));
            this.enterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enterPictureBox.Location = new System.Drawing.Point(229, 24);
            this.enterPictureBox.Name = "enterPictureBox";
            this.enterPictureBox.Size = new System.Drawing.Size(403, 302);
            this.enterPictureBox.TabIndex = 0;
            this.enterPictureBox.TabStop = false;
            // 
            // CategoryList
            // 
            this.CategoryList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryList.BackColor = System.Drawing.Color.Black;
            this.CategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(444, 346);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(176, 32);
            this.CategoryList.TabIndex = 1;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategory.Location = new System.Drawing.Point(251, 348);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(175, 25);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Choose category";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(316, 417);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSurname.Location = new System.Drawing.Point(328, 465);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(98, 25);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUserName.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxUserName.Location = new System.Drawing.Point(444, 417);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(176, 29);
            this.tbxUserName.TabIndex = 5;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSurname.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxSurname.Location = new System.Drawing.Point(444, 465);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(176, 29);
            this.tbxSurname.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(530, 514);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Enter";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // EnterQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(841, 643);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.enterPictureBox);
            this.Name = "EnterQuiz";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.EnterQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enterPictureBox;
        private System.Windows.Forms.ComboBox CategoryList;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Button btnLogin;
    }
}

