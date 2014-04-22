namespace WindowsFormsPresentation
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControllerTabControl = new System.Windows.Forms.TabControl();
            this.Controller1TabPage = new System.Windows.Forms.TabPage();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Controller1LayoutComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Controller1PortComboBoxLabel = new System.Windows.Forms.Label();
            this.ButtonsPressedTextBox = new System.Windows.Forms.TextBox();
            this.Controller1PortComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenuStrip.SuspendLayout();
            this.ControllerTabControl.SuspendLayout();
            this.Controller1TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(504, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // commToolStripMenuItem
            // 
            this.commToolStripMenuItem.Name = "commToolStripMenuItem";
            this.commToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.commToolStripMenuItem.Text = "Comm";
            // 
            // ControllerTabControl
            // 
            this.ControllerTabControl.Controls.Add(this.Controller1TabPage);
            this.ControllerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControllerTabControl.Location = new System.Drawing.Point(0, 24);
            this.ControllerTabControl.MinimumSize = new System.Drawing.Size(272, 193);
            this.ControllerTabControl.Name = "ControllerTabControl";
            this.ControllerTabControl.SelectedIndex = 0;
            this.ControllerTabControl.Size = new System.Drawing.Size(504, 260);
            this.ControllerTabControl.TabIndex = 2;
            // 
            // Controller1TabPage
            // 
            this.Controller1TabPage.Controls.Add(this.ConnectButton);
            this.Controller1TabPage.Controls.Add(this.Controller1LayoutComboBox);
            this.Controller1TabPage.Controls.Add(this.label2);
            this.Controller1TabPage.Controls.Add(this.Controller1PortComboBoxLabel);
            this.Controller1TabPage.Controls.Add(this.ButtonsPressedTextBox);
            this.Controller1TabPage.Controls.Add(this.Controller1PortComboBox);
            this.Controller1TabPage.Location = new System.Drawing.Point(4, 22);
            this.Controller1TabPage.Name = "Controller1TabPage";
            this.Controller1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Controller1TabPage.Size = new System.Drawing.Size(496, 234);
            this.Controller1TabPage.TabIndex = 1;
            this.Controller1TabPage.Text = "Controller 1";
            this.Controller1TabPage.UseVisualStyleBackColor = true;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(135, 23);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Controller1LayoutComboBox
            // 
            this.Controller1LayoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controller1LayoutComboBox.FormattingEnabled = true;
            this.Controller1LayoutComboBox.Location = new System.Drawing.Point(8, 118);
            this.Controller1LayoutComboBox.Name = "Controller1LayoutComboBox";
            this.Controller1LayoutComboBox.Size = new System.Drawing.Size(121, 21);
            this.Controller1LayoutComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Controller Layout";
            // 
            // Controller1PortComboBoxLabel
            // 
            this.Controller1PortComboBoxLabel.AutoSize = true;
            this.Controller1PortComboBoxLabel.Location = new System.Drawing.Point(9, 7);
            this.Controller1PortComboBoxLabel.Name = "Controller1PortComboBoxLabel";
            this.Controller1PortComboBoxLabel.Size = new System.Drawing.Size(55, 13);
            this.Controller1PortComboBoxLabel.TabIndex = 2;
            this.Controller1PortComboBoxLabel.Text = "Serial Port";
            // 
            // ButtonsPressedTextBox
            // 
            this.ButtonsPressedTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonsPressedTextBox.Enabled = false;
            this.ButtonsPressedTextBox.Location = new System.Drawing.Point(250, 3);
            this.ButtonsPressedTextBox.Multiline = true;
            this.ButtonsPressedTextBox.Name = "ButtonsPressedTextBox";
            this.ButtonsPressedTextBox.Size = new System.Drawing.Size(243, 228);
            this.ButtonsPressedTextBox.TabIndex = 1;
            this.ButtonsPressedTextBox.Text = "a\r\nb\r\nc";
            // 
            // Controller1PortComboBox
            // 
            this.Controller1PortComboBox.DisplayMember = "Text";
            this.Controller1PortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controller1PortComboBox.FormattingEnabled = true;
            this.Controller1PortComboBox.Location = new System.Drawing.Point(8, 23);
            this.Controller1PortComboBox.Name = "Controller1PortComboBox";
            this.Controller1PortComboBox.Size = new System.Drawing.Size(121, 21);
            this.Controller1PortComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 284);
            this.Controls.Add(this.ControllerTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Controller Setup";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ControllerTabControl.ResumeLayout(false);
            this.Controller1TabPage.ResumeLayout(false);
            this.Controller1TabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commToolStripMenuItem;
        private System.Windows.Forms.TabControl ControllerTabControl;
        private System.Windows.Forms.TabPage Controller1TabPage;
        private System.Windows.Forms.ComboBox Controller1PortComboBox;
        private System.Windows.Forms.TextBox ButtonsPressedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Controller1PortComboBoxLabel;
        private System.Windows.Forms.ComboBox Controller1LayoutComboBox;
        private System.Windows.Forms.Button ConnectButton;
    }
}

