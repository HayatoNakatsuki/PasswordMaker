namespace PassWord_Maker
{
	partial class PasswordMaker
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.PassWordMake_Button = new System.Windows.Forms.Button();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.PassLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.fileSaveButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxService = new System.Windows.Forms.TextBox();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.buttonRegistration = new System.Windows.Forms.Button();
			this.buttonSavePass = new System.Windows.Forms.Button();
			this.checkTextBoxControl = new System.Windows.Forms.CheckBox();
			this.dataGridPass = new System.Windows.Forms.DataGridView();
			this.checkPassVisible = new System.Windows.Forms.CheckBox();
			this.labelPassList = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnClearBox = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPass)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// PassWordMake_Button
			// 
			this.PassWordMake_Button.AutoSize = true;
			this.PassWordMake_Button.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.PassWordMake_Button.Location = new System.Drawing.Point(120, 189);
			this.PassWordMake_Button.Name = "PassWordMake_Button";
			this.PassWordMake_Button.Size = new System.Drawing.Size(149, 42);
			this.PassWordMake_Button.TabIndex = 4;
			this.PassWordMake_Button.Text = "パスワード生成";
			this.PassWordMake_Button.UseVisualStyleBackColor = true;
			this.PassWordMake_Button.Click += new System.EventHandler(this.PassWordMake_Button_Click);
			// 
			// textBoxPass
			// 
			this.textBoxPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBoxPass.Location = new System.Drawing.Point(1, 258);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.ReadOnly = true;
			this.textBoxPass.Size = new System.Drawing.Size(403, 19);
			this.textBoxPass.TabIndex = 5;
			this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
			// 
			// PassLabel
			// 
			this.PassLabel.AutoSize = true;
			this.PassLabel.BackColor = System.Drawing.SystemColors.Control;
			this.PassLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.PassLabel.Location = new System.Drawing.Point(1, 239);
			this.PassLabel.Name = "PassLabel";
			this.PassLabel.Size = new System.Drawing.Size(194, 16);
			this.PassLabel.TabIndex = 2;
			this.PassLabel.Text = "・ここにパスワードを表示します";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(1, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "■パスワードの文字数";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(67, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "文字";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numericUpDown1.Location = new System.Drawing.Point(6, 197);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(55, 26);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// fileSaveButton
			// 
			this.fileSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.fileSaveButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.fileSaveButton.Location = new System.Drawing.Point(89, 372);
			this.fileSaveButton.Name = "fileSaveButton";
			this.fileSaveButton.Size = new System.Drawing.Size(205, 43);
			this.fileSaveButton.TabIndex = 7;
			this.fileSaveButton.Text = "ファイル出力";
			this.fileSaveButton.UseVisualStyleBackColor = true;
			this.fileSaveButton.Click += new System.EventHandler(this.fileSaveButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(1, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "■サービス名";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(1, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "■ユーザ名";
			// 
			// textBoxService
			// 
			this.textBoxService.Location = new System.Drawing.Point(1, 49);
			this.textBoxService.Name = "textBoxService";
			this.textBoxService.Size = new System.Drawing.Size(376, 19);
			this.textBoxService.TabIndex = 1;
			// 
			// textBoxUser
			// 
			this.textBoxUser.Location = new System.Drawing.Point(1, 126);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(376, 19);
			this.textBoxUser.TabIndex = 2;
			// 
			// buttonRegistration
			// 
			this.buttonRegistration.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonRegistration.Location = new System.Drawing.Point(336, 283);
			this.buttonRegistration.Name = "buttonRegistration";
			this.buttonRegistration.Size = new System.Drawing.Size(68, 35);
			this.buttonRegistration.TabIndex = 6;
			this.buttonRegistration.Text = "登録";
			this.buttonRegistration.UseVisualStyleBackColor = true;
			this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
			// 
			// buttonSavePass
			// 
			this.buttonSavePass.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonSavePass.Location = new System.Drawing.Point(336, 324);
			this.buttonSavePass.Name = "buttonSavePass";
			this.buttonSavePass.Size = new System.Drawing.Size(68, 35);
			this.buttonSavePass.TabIndex = 7;
			this.buttonSavePass.Text = "保存";
			this.buttonSavePass.UseVisualStyleBackColor = true;
			this.buttonSavePass.Click += new System.EventHandler(this.buttonSavePass_Click);
			// 
			// checkTextBoxControl
			// 
			this.checkTextBoxControl.AutoSize = true;
			this.checkTextBoxControl.Location = new System.Drawing.Point(343, 239);
			this.checkTextBoxControl.Name = "checkTextBoxControl";
			this.checkTextBoxControl.Size = new System.Drawing.Size(60, 16);
			this.checkTextBoxControl.TabIndex = 10;
			this.checkTextBoxControl.Text = "操作可";
			this.checkTextBoxControl.UseVisualStyleBackColor = true;
			this.checkTextBoxControl.CheckedChanged += new System.EventHandler(this.checkTextBoxControl_CheckedChanged);
			// 
			// dataGridPass
			// 
			this.dataGridPass.AllowUserToAddRows = false;
			this.dataGridPass.AllowUserToDeleteRows = false;
			this.dataGridPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridPass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridPass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dataGridPass.Location = new System.Drawing.Point(13, 30);
			this.dataGridPass.Name = "dataGridPass";
			this.dataGridPass.ReadOnly = true;
			this.dataGridPass.RowTemplate.Height = 21;
			this.dataGridPass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridPass.Size = new System.Drawing.Size(450, 336);
			this.dataGridPass.TabIndex = 0;
			this.dataGridPass.TabStop = false;
			this.dataGridPass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPass_CellDoubleClick);
			// 
			// checkPassVisible
			// 
			this.checkPassVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkPassVisible.AutoSize = true;
			this.checkPassVisible.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkPassVisible.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.checkPassVisible.Location = new System.Drawing.Point(13, 372);
			this.checkPassVisible.Name = "checkPassVisible";
			this.checkPassVisible.Size = new System.Drawing.Size(148, 19);
			this.checkPassVisible.TabIndex = 8;
			this.checkPassVisible.Text = "パスワードを表示する";
			this.checkPassVisible.UseVisualStyleBackColor = true;
			this.checkPassVisible.CheckedChanged += new System.EventHandler(this.checkPassVisible_CheckedChanged);
			// 
			// labelPassList
			// 
			this.labelPassList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelPassList.AutoSize = true;
			this.labelPassList.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelPassList.Location = new System.Drawing.Point(10, 5);
			this.labelPassList.Name = "labelPassList";
			this.labelPassList.Size = new System.Drawing.Size(151, 16);
			this.labelPassList.TabIndex = 9;
			this.labelPassList.Text = "◆パスワード一覧表";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelete.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonDelete.Location = new System.Drawing.Point(405, 379);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(68, 35);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "削除";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Controls.Add(this.labelPassList);
			this.panel1.Controls.Add(this.checkPassVisible);
			this.panel1.Controls.Add(this.dataGridPass);
			this.panel1.Location = new System.Drawing.Point(16, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 426);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.checkTextBoxControl);
			this.panel2.Controls.Add(this.btnClearBox);
			this.panel2.Controls.Add(this.buttonSavePass);
			this.panel2.Controls.Add(this.buttonRegistration);
			this.panel2.Controls.Add(this.textBoxUser);
			this.panel2.Controls.Add(this.textBoxService);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.fileSaveButton);
			this.panel2.Controls.Add(this.numericUpDown1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.PassLabel);
			this.panel2.Controls.Add(this.textBoxPass);
			this.panel2.Controls.Add(this.PassWordMake_Button);
			this.panel2.Location = new System.Drawing.Point(498, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(409, 426);
			this.panel2.TabIndex = 11;
			// 
			// btnClearBox
			// 
			this.btnClearBox.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnClearBox.Location = new System.Drawing.Point(7, 324);
			this.btnClearBox.Name = "btnClearBox";
			this.btnClearBox.Size = new System.Drawing.Size(107, 35);
			this.btnClearBox.TabIndex = 7;
			this.btnClearBox.Text = "入力クリア";
			this.btnClearBox.UseVisualStyleBackColor = true;
			this.btnClearBox.Click += new System.EventHandler(this.btnClearBox_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPass)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button PassWordMake_Button;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.Label PassLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button fileSaveButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxService;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Button buttonRegistration;
		private System.Windows.Forms.Button buttonSavePass;
		private System.Windows.Forms.CheckBox checkTextBoxControl;
		private System.Windows.Forms.DataGridView dataGridPass;
		private System.Windows.Forms.CheckBox checkPassVisible;
		private System.Windows.Forms.Label labelPassList;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnClearBox;
	}
}

