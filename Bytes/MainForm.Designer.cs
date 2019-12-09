namespace Bytes
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxBit = new System.Windows.Forms.GroupBox();
			this.buttonCopyBitToClipboard = new System.Windows.Forms.Button();
			this.textBoxBit = new System.Windows.Forms.TextBox();
			this.groupBoxByte = new System.Windows.Forms.GroupBox();
			this.buttonCopyByteToClipboard = new System.Windows.Forms.Button();
			this.textBoxByte = new System.Windows.Forms.TextBox();
			this.groupBoxKilobyte = new System.Windows.Forms.GroupBox();
			this.buttonCopyKilobyteToClipboard = new System.Windows.Forms.Button();
			this.textBoxKilobyte = new System.Windows.Forms.TextBox();
			this.groupBoxTerabyte = new System.Windows.Forms.GroupBox();
			this.buttonCopyTerabyteToClipboard = new System.Windows.Forms.Button();
			this.textBoxTerabyte = new System.Windows.Forms.TextBox();
			this.groupBoxGigabyte = new System.Windows.Forms.GroupBox();
			this.buttonCopyGigabyteToClipboard = new System.Windows.Forms.Button();
			this.textBoxGigabyte = new System.Windows.Forms.TextBox();
			this.groupBoxMegabyte = new System.Windows.Forms.GroupBox();
			this.buttonCopyMegabyteToClipboard = new System.Windows.Forms.Button();
			this.textBoxMegabyte = new System.Windows.Forms.TextBox();
			this.checkBoxEnableBit = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableByte = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableKilobyte = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableMegabyte = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableGigabyte = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableTerabyte = new System.Windows.Forms.CheckBox();
			this.groupBoxBit.SuspendLayout();
			this.groupBoxByte.SuspendLayout();
			this.groupBoxKilobyte.SuspendLayout();
			this.groupBoxTerabyte.SuspendLayout();
			this.groupBoxGigabyte.SuspendLayout();
			this.groupBoxMegabyte.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxBit
			// 
			this.groupBoxBit.Controls.Add(this.checkBoxEnableBit);
			this.groupBoxBit.Controls.Add(this.buttonCopyBitToClipboard);
			this.groupBoxBit.Controls.Add(this.textBoxBit);
			this.groupBoxBit.Location = new System.Drawing.Point(12, 12);
			this.groupBoxBit.Name = "groupBoxBit";
			this.groupBoxBit.Size = new System.Drawing.Size(204, 55);
			this.groupBoxBit.TabIndex = 0;
			this.groupBoxBit.TabStop = false;
			this.groupBoxBit.Text = "&Bit";
			this.groupBoxBit.Enter += new System.EventHandler(this.GroupBoxBit_Enter);
			this.groupBoxBit.Leave += new System.EventHandler(this.GroupBoxBit_Leave);
			// 
			// buttonCopyBitToClipboard
			// 
			this.buttonCopyBitToClipboard.Location = new System.Drawing.Point(155, 17);
			this.buttonCopyBitToClipboard.Name = "buttonCopyBitToClipboard";
			this.buttonCopyBitToClipboard.Size = new System.Drawing.Size(40, 23);
			this.buttonCopyBitToClipboard.TabIndex = 1;
			this.buttonCopyBitToClipboard.Text = "Copy";
			this.buttonCopyBitToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyBitToClipboard.Click += new System.EventHandler(this.ButtonCopyBitToClipboard_Click);
			// 
			// textBoxBit
			// 
			this.textBoxBit.Location = new System.Drawing.Point(27, 19);
			this.textBoxBit.Name = "textBoxBit";
			this.textBoxBit.Size = new System.Drawing.Size(122, 20);
			this.textBoxBit.TabIndex = 0;
			this.textBoxBit.Text = "0";
			this.textBoxBit.TextChanged += new System.EventHandler(this.TextBoxBit_TextChanged);
			this.textBoxBit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBit_KeyPress);
			// 
			// groupBoxByte
			// 
			this.groupBoxByte.Controls.Add(this.checkBoxEnableByte);
			this.groupBoxByte.Controls.Add(this.buttonCopyByteToClipboard);
			this.groupBoxByte.Controls.Add(this.textBoxByte);
			this.groupBoxByte.Location = new System.Drawing.Point(222, 12);
			this.groupBoxByte.Name = "groupBoxByte";
			this.groupBoxByte.Size = new System.Drawing.Size(204, 55);
			this.groupBoxByte.TabIndex = 1;
			this.groupBoxByte.TabStop = false;
			this.groupBoxByte.Text = "B&yte";
			this.groupBoxByte.Enter += new System.EventHandler(this.GroupBoxByte_Enter);
			this.groupBoxByte.Leave += new System.EventHandler(this.GroupBoxByte_Leave);
			// 
			// buttonCopyByteToClipboard
			// 
			this.buttonCopyByteToClipboard.Location = new System.Drawing.Point(155, 18);
			this.buttonCopyByteToClipboard.Name = "buttonCopyByteToClipboard";
			this.buttonCopyByteToClipboard.Size = new System.Drawing.Size(40, 23);
			this.buttonCopyByteToClipboard.TabIndex = 1;
			this.buttonCopyByteToClipboard.Text = "Copy";
			this.buttonCopyByteToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyByteToClipboard.Click += new System.EventHandler(this.ButtonCopyByteToClipboard_Click);
			// 
			// textBoxByte
			// 
			this.textBoxByte.Location = new System.Drawing.Point(27, 20);
			this.textBoxByte.Name = "textBoxByte";
			this.textBoxByte.Size = new System.Drawing.Size(122, 20);
			this.textBoxByte.TabIndex = 0;
			this.textBoxByte.TextChanged += new System.EventHandler(this.TextBoxByte_TextChanged);
			this.textBoxByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxByte_KeyPress);
			// 
			// groupBoxKilobyte
			// 
			this.groupBoxKilobyte.Controls.Add(this.checkBoxEnableKilobyte);
			this.groupBoxKilobyte.Controls.Add(this.buttonCopyKilobyteToClipboard);
			this.groupBoxKilobyte.Controls.Add(this.textBoxKilobyte);
			this.groupBoxKilobyte.Location = new System.Drawing.Point(432, 12);
			this.groupBoxKilobyte.Name = "groupBoxKilobyte";
			this.groupBoxKilobyte.Size = new System.Drawing.Size(204, 55);
			this.groupBoxKilobyte.TabIndex = 2;
			this.groupBoxKilobyte.TabStop = false;
			this.groupBoxKilobyte.Text = "&Kilobyte";
			this.groupBoxKilobyte.Enter += new System.EventHandler(this.GroupBoxKilobyte_Enter);
			this.groupBoxKilobyte.Leave += new System.EventHandler(this.GroupBoxKilobyte_Leave);
			// 
			// buttonCopyKilobyteToClipboard
			// 
			this.buttonCopyKilobyteToClipboard.Location = new System.Drawing.Point(155, 19);
			this.buttonCopyKilobyteToClipboard.Name = "buttonCopyKilobyteToClipboard";
			this.buttonCopyKilobyteToClipboard.Size = new System.Drawing.Size(40, 23);
			this.buttonCopyKilobyteToClipboard.TabIndex = 1;
			this.buttonCopyKilobyteToClipboard.Text = "Copy";
			this.buttonCopyKilobyteToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyKilobyteToClipboard.Click += new System.EventHandler(this.ButtonCopyKilobyteToClipboard_Click);
			// 
			// textBoxKilobyte
			// 
			this.textBoxKilobyte.Location = new System.Drawing.Point(27, 21);
			this.textBoxKilobyte.Name = "textBoxKilobyte";
			this.textBoxKilobyte.Size = new System.Drawing.Size(122, 20);
			this.textBoxKilobyte.TabIndex = 0;
			this.textBoxKilobyte.TextChanged += new System.EventHandler(this.TextBoxKilobyte_TextChanged);
			this.textBoxKilobyte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKilobyte_KeyPress);
			// 
			// groupBoxTerabyte
			// 
			this.groupBoxTerabyte.Controls.Add(this.checkBoxEnableTerabyte);
			this.groupBoxTerabyte.Controls.Add(this.buttonCopyTerabyteToClipboard);
			this.groupBoxTerabyte.Controls.Add(this.textBoxTerabyte);
			this.groupBoxTerabyte.Location = new System.Drawing.Point(432, 73);
			this.groupBoxTerabyte.Name = "groupBoxTerabyte";
			this.groupBoxTerabyte.Size = new System.Drawing.Size(204, 55);
			this.groupBoxTerabyte.TabIndex = 5;
			this.groupBoxTerabyte.TabStop = false;
			this.groupBoxTerabyte.Text = "&Terabyte";
			this.groupBoxTerabyte.Enter += new System.EventHandler(this.GroupBoxTerabyte_Enter);
			this.groupBoxTerabyte.Leave += new System.EventHandler(this.GroupBoxTerabyte_Leave);
			// 
			// buttonCopyTerabyteToClipboard
			// 
			this.buttonCopyTerabyteToClipboard.Location = new System.Drawing.Point(155, 17);
			this.buttonCopyTerabyteToClipboard.Name = "buttonCopyTerabyteToClipboard";
			this.buttonCopyTerabyteToClipboard.Size = new System.Drawing.Size(40, 23);
			this.buttonCopyTerabyteToClipboard.TabIndex = 1;
			this.buttonCopyTerabyteToClipboard.Text = "Copy";
			this.buttonCopyTerabyteToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyTerabyteToClipboard.Click += new System.EventHandler(this.ButtonCopyTerabyteToClipboard_Click);
			// 
			// textBoxTerabyte
			// 
			this.textBoxTerabyte.Location = new System.Drawing.Point(27, 19);
			this.textBoxTerabyte.Name = "textBoxTerabyte";
			this.textBoxTerabyte.Size = new System.Drawing.Size(122, 20);
			this.textBoxTerabyte.TabIndex = 0;
			this.textBoxTerabyte.TextChanged += new System.EventHandler(this.TextBoxTerabyte_TextChanged);
			this.textBoxTerabyte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTerabyte_KeyPress);
			// 
			// groupBoxGigabyte
			// 
			this.groupBoxGigabyte.Controls.Add(this.checkBoxEnableGigabyte);
			this.groupBoxGigabyte.Controls.Add(this.buttonCopyGigabyteToClipboard);
			this.groupBoxGigabyte.Controls.Add(this.textBoxGigabyte);
			this.groupBoxGigabyte.Location = new System.Drawing.Point(222, 73);
			this.groupBoxGigabyte.Name = "groupBoxGigabyte";
			this.groupBoxGigabyte.Size = new System.Drawing.Size(204, 55);
			this.groupBoxGigabyte.TabIndex = 4;
			this.groupBoxGigabyte.TabStop = false;
			this.groupBoxGigabyte.Text = "&Gigabyte";
			this.groupBoxGigabyte.Enter += new System.EventHandler(this.GroupBoxGigabyte_Enter);
			this.groupBoxGigabyte.Leave += new System.EventHandler(this.GroupBoxGigabyte_Leave);
			// 
			// buttonCopyGigabyteToClipboard
			// 
			this.buttonCopyGigabyteToClipboard.Location = new System.Drawing.Point(155, 17);
			this.buttonCopyGigabyteToClipboard.Name = "buttonCopyGigabyteToClipboard";
			this.buttonCopyGigabyteToClipboard.Size = new System.Drawing.Size(40, 23);
			this.buttonCopyGigabyteToClipboard.TabIndex = 1;
			this.buttonCopyGigabyteToClipboard.Text = "Copy";
			this.buttonCopyGigabyteToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyGigabyteToClipboard.Click += new System.EventHandler(this.ButtonCopyGigabyteToClipboard_Click);
			// 
			// textBoxGigabyte
			// 
			this.textBoxGigabyte.Location = new System.Drawing.Point(27, 19);
			this.textBoxGigabyte.Name = "textBoxGigabyte";
			this.textBoxGigabyte.Size = new System.Drawing.Size(122, 20);
			this.textBoxGigabyte.TabIndex = 0;
			this.textBoxGigabyte.TextChanged += new System.EventHandler(this.TextBoxGigabyte_TextChanged);
			this.textBoxGigabyte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxGigabyte_KeyPress);
			// 
			// groupBoxMegabyte
			// 
			this.groupBoxMegabyte.Controls.Add(this.checkBoxEnableMegabyte);
			this.groupBoxMegabyte.Controls.Add(this.buttonCopyMegabyteToClipboard);
			this.groupBoxMegabyte.Controls.Add(this.textBoxMegabyte);
			this.groupBoxMegabyte.Location = new System.Drawing.Point(12, 73);
			this.groupBoxMegabyte.Name = "groupBoxMegabyte";
			this.groupBoxMegabyte.Size = new System.Drawing.Size(204, 55);
			this.groupBoxMegabyte.TabIndex = 3;
			this.groupBoxMegabyte.TabStop = false;
			this.groupBoxMegabyte.Text = "&Megabyte";
			this.groupBoxMegabyte.Enter += new System.EventHandler(this.GroupBoxMegabyte_Enter);
			this.groupBoxMegabyte.Leave += new System.EventHandler(this.GroupBoxMegabyte_Leave);
			// 
			// buttonCopyMegabyteToClipboard
			// 
			this.buttonCopyMegabyteToClipboard.Location = new System.Drawing.Point(155, 17);
			this.buttonCopyMegabyteToClipboard.Name = "buttonCopyMegabyteToClipboard";
			this.buttonCopyMegabyteToClipboard.Size = new System.Drawing.Size(40, 23);
			this.buttonCopyMegabyteToClipboard.TabIndex = 1;
			this.buttonCopyMegabyteToClipboard.Text = "Copy";
			this.buttonCopyMegabyteToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyMegabyteToClipboard.Click += new System.EventHandler(this.ButtonCopyMegabyteToClipboard_Click);
			// 
			// textBoxMegabyte
			// 
			this.textBoxMegabyte.Location = new System.Drawing.Point(27, 19);
			this.textBoxMegabyte.Name = "textBoxMegabyte";
			this.textBoxMegabyte.Size = new System.Drawing.Size(122, 20);
			this.textBoxMegabyte.TabIndex = 0;
			this.textBoxMegabyte.TextChanged += new System.EventHandler(this.TextBoxMegabyte_TextChanged);
			this.textBoxMegabyte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMegabyte_KeyPress);
			// 
			// checkBoxEnableBit
			// 
			this.checkBoxEnableBit.AutoSize = true;
			this.checkBoxEnableBit.Location = new System.Drawing.Point(6, 22);
			this.checkBoxEnableBit.Name = "checkBoxEnableBit";
			this.checkBoxEnableBit.Size = new System.Drawing.Size(15, 14);
			this.checkBoxEnableBit.TabIndex = 6;
			this.checkBoxEnableBit.UseVisualStyleBackColor = true;
			this.checkBoxEnableBit.CheckedChanged += new System.EventHandler(this.CheckBoxEnableBit_CheckedChanged);
			// 
			// checkBoxEnableByte
			// 
			this.checkBoxEnableByte.AutoSize = true;
			this.checkBoxEnableByte.Location = new System.Drawing.Point(6, 23);
			this.checkBoxEnableByte.Name = "checkBoxEnableByte";
			this.checkBoxEnableByte.Size = new System.Drawing.Size(15, 14);
			this.checkBoxEnableByte.TabIndex = 7;
			this.checkBoxEnableByte.UseVisualStyleBackColor = true;
			this.checkBoxEnableByte.CheckedChanged += new System.EventHandler(this.CheckBoxEnableByte_CheckedChanged);
			// 
			// checkBoxEnableKilobyte
			// 
			this.checkBoxEnableKilobyte.AutoSize = true;
			this.checkBoxEnableKilobyte.Location = new System.Drawing.Point(6, 24);
			this.checkBoxEnableKilobyte.Name = "checkBoxEnableKilobyte";
			this.checkBoxEnableKilobyte.Size = new System.Drawing.Size(15, 14);
			this.checkBoxEnableKilobyte.TabIndex = 7;
			this.checkBoxEnableKilobyte.UseVisualStyleBackColor = true;
			this.checkBoxEnableKilobyte.CheckedChanged += new System.EventHandler(this.CheckBoxEnableKilobyte_CheckedChanged);
			// 
			// checkBoxEnableMegabyte
			// 
			this.checkBoxEnableMegabyte.AutoSize = true;
			this.checkBoxEnableMegabyte.Location = new System.Drawing.Point(6, 22);
			this.checkBoxEnableMegabyte.Name = "checkBoxEnableMegabyte";
			this.checkBoxEnableMegabyte.Size = new System.Drawing.Size(15, 14);
			this.checkBoxEnableMegabyte.TabIndex = 7;
			this.checkBoxEnableMegabyte.UseVisualStyleBackColor = true;
			this.checkBoxEnableMegabyte.CheckedChanged += new System.EventHandler(this.CheckBoxEnableMegabyte_CheckedChanged);
			// 
			// checkBoxEnableGigabyte
			// 
			this.checkBoxEnableGigabyte.AutoSize = true;
			this.checkBoxEnableGigabyte.Location = new System.Drawing.Point(6, 22);
			this.checkBoxEnableGigabyte.Name = "checkBoxEnableGigabyte";
			this.checkBoxEnableGigabyte.Size = new System.Drawing.Size(15, 14);
			this.checkBoxEnableGigabyte.TabIndex = 7;
			this.checkBoxEnableGigabyte.UseVisualStyleBackColor = true;
			this.checkBoxEnableGigabyte.CheckedChanged += new System.EventHandler(this.CheckBoxEnableGigabyte_CheckedChanged);
			// 
			// checkBoxEnableTerabyte
			// 
			this.checkBoxEnableTerabyte.AutoSize = true;
			this.checkBoxEnableTerabyte.Location = new System.Drawing.Point(6, 22);
			this.checkBoxEnableTerabyte.Name = "checkBoxEnableTerabyte";
			this.checkBoxEnableTerabyte.Size = new System.Drawing.Size(15, 14);
			this.checkBoxEnableTerabyte.TabIndex = 7;
			this.checkBoxEnableTerabyte.UseVisualStyleBackColor = true;
			this.checkBoxEnableTerabyte.CheckedChanged += new System.EventHandler(this.CheckBoxEnableTerabyte_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 139);
			this.Controls.Add(this.groupBoxTerabyte);
			this.Controls.Add(this.groupBoxGigabyte);
			this.Controls.Add(this.groupBoxMegabyte);
			this.Controls.Add(this.groupBoxKilobyte);
			this.Controls.Add(this.groupBoxByte);
			this.Controls.Add(this.groupBoxBit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bytes";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBoxBit.ResumeLayout(false);
			this.groupBoxBit.PerformLayout();
			this.groupBoxByte.ResumeLayout(false);
			this.groupBoxByte.PerformLayout();
			this.groupBoxKilobyte.ResumeLayout(false);
			this.groupBoxKilobyte.PerformLayout();
			this.groupBoxTerabyte.ResumeLayout(false);
			this.groupBoxTerabyte.PerformLayout();
			this.groupBoxGigabyte.ResumeLayout(false);
			this.groupBoxGigabyte.PerformLayout();
			this.groupBoxMegabyte.ResumeLayout(false);
			this.groupBoxMegabyte.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxBit;
		private System.Windows.Forms.Button buttonCopyBitToClipboard;
		private System.Windows.Forms.TextBox textBoxBit;
		private System.Windows.Forms.GroupBox groupBoxByte;
		private System.Windows.Forms.Button buttonCopyByteToClipboard;
		private System.Windows.Forms.TextBox textBoxByte;
		private System.Windows.Forms.GroupBox groupBoxKilobyte;
		private System.Windows.Forms.Button buttonCopyKilobyteToClipboard;
		private System.Windows.Forms.TextBox textBoxKilobyte;
		private System.Windows.Forms.GroupBox groupBoxTerabyte;
		private System.Windows.Forms.Button buttonCopyTerabyteToClipboard;
		private System.Windows.Forms.TextBox textBoxTerabyte;
		private System.Windows.Forms.GroupBox groupBoxGigabyte;
		private System.Windows.Forms.Button buttonCopyGigabyteToClipboard;
		private System.Windows.Forms.TextBox textBoxGigabyte;
		private System.Windows.Forms.GroupBox groupBoxMegabyte;
		private System.Windows.Forms.Button buttonCopyMegabyteToClipboard;
		private System.Windows.Forms.TextBox textBoxMegabyte;
		private System.Windows.Forms.CheckBox checkBoxEnableBit;
		private System.Windows.Forms.CheckBox checkBoxEnableByte;
		private System.Windows.Forms.CheckBox checkBoxEnableKilobyte;
		private System.Windows.Forms.CheckBox checkBoxEnableMegabyte;
		private System.Windows.Forms.CheckBox checkBoxEnableTerabyte;
		private System.Windows.Forms.CheckBox checkBoxEnableGigabyte;
	}
}

