namespace NativeHelper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Build = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Debug = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Release = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Arm64 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.x64 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Linux = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Windows = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Build
            // 
            this.Build.BorderRadius = 8;
            this.Build.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Build.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Build.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Build.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Build.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Build.ForeColor = System.Drawing.Color.White;
            this.Build.Location = new System.Drawing.Point(12, 177);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(118, 39);
            this.Build.TabIndex = 16;
            this.Build.Text = "Compile it to Native";
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 4;
            this.guna2GroupBox2.Controls.Add(this.Debug);
            this.guna2GroupBox2.Controls.Add(this.Release);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 124);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(238, 47);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Folder";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -9);
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.BackColor = System.Drawing.Color.Transparent;
            this.Debug.Checked = true;
            this.Debug.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Debug.CheckedState.BorderThickness = 0;
            this.Debug.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Debug.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Debug.CheckedState.InnerOffset = -4;
            this.Debug.Location = new System.Drawing.Point(124, 24);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(60, 17);
            this.Debug.TabIndex = 5;
            this.Debug.TabStop = true;
            this.Debug.Text = "Debug";
            this.Debug.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Debug.UncheckedState.BorderThickness = 2;
            this.Debug.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Debug.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Debug.UseVisualStyleBackColor = false;
            // 
            // Release
            // 
            this.Release.AutoSize = true;
            this.Release.BackColor = System.Drawing.Color.Transparent;
            this.Release.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Release.CheckedState.BorderThickness = 0;
            this.Release.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Release.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Release.CheckedState.InnerOffset = -4;
            this.Release.Location = new System.Drawing.Point(54, 24);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(64, 17);
            this.Release.TabIndex = 4;
            this.Release.Text = "Release";
            this.Release.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Release.UncheckedState.BorderThickness = 2;
            this.Release.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Release.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Release.UseVisualStyleBackColor = false;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 4;
            this.guna2GroupBox4.Controls.Add(this.Arm64);
            this.guna2GroupBox4.Controls.Add(this.x64);
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(12, 71);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(238, 47);
            this.guna2GroupBox4.TabIndex = 2;
            this.guna2GroupBox4.Text = "Architecture";
            this.guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox4.TextOffset = new System.Drawing.Point(0, -9);
            // 
            // Arm64
            // 
            this.Arm64.AutoSize = true;
            this.Arm64.BackColor = System.Drawing.Color.Transparent;
            this.Arm64.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Arm64.CheckedState.BorderThickness = 0;
            this.Arm64.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Arm64.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Arm64.CheckedState.InnerOffset = -4;
            this.Arm64.Location = new System.Drawing.Point(115, 24);
            this.Arm64.Name = "Arm64";
            this.Arm64.Size = new System.Drawing.Size(57, 17);
            this.Arm64.TabIndex = 4;
            this.Arm64.Text = "Arm64";
            this.Arm64.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Arm64.UncheckedState.BorderThickness = 2;
            this.Arm64.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Arm64.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Arm64.UseVisualStyleBackColor = false;
            // 
            // x64
            // 
            this.x64.AutoSize = true;
            this.x64.BackColor = System.Drawing.Color.Transparent;
            this.x64.Checked = true;
            this.x64.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.x64.CheckedState.BorderThickness = 0;
            this.x64.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.x64.CheckedState.InnerColor = System.Drawing.Color.White;
            this.x64.CheckedState.InnerOffset = -4;
            this.x64.Location = new System.Drawing.Point(67, 24);
            this.x64.Name = "x64";
            this.x64.Size = new System.Drawing.Size(42, 17);
            this.x64.TabIndex = 3;
            this.x64.TabStop = true;
            this.x64.Text = "x64";
            this.x64.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.x64.UncheckedState.BorderThickness = 2;
            this.x64.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.x64.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.x64.UseVisualStyleBackColor = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 4;
            this.guna2GroupBox1.Controls.Add(this.Linux);
            this.guna2GroupBox1.Controls.Add(this.Windows);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 18);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(238, 47);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Platform";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -9);
            // 
            // Linux
            // 
            this.Linux.AutoSize = true;
            this.Linux.BackColor = System.Drawing.Color.Transparent;
            this.Linux.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Linux.CheckedState.BorderThickness = 0;
            this.Linux.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Linux.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Linux.CheckedState.InnerOffset = -4;
            this.Linux.Location = new System.Drawing.Point(133, 25);
            this.Linux.Name = "Linux";
            this.Linux.Size = new System.Drawing.Size(52, 17);
            this.Linux.TabIndex = 7;
            this.Linux.Text = "Linux";
            this.Linux.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Linux.UncheckedState.BorderThickness = 2;
            this.Linux.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Linux.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Linux.UseVisualStyleBackColor = false;
            // 
            // Windows
            // 
            this.Windows.AutoSize = true;
            this.Windows.BackColor = System.Drawing.Color.Transparent;
            this.Windows.Checked = true;
            this.Windows.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Windows.CheckedState.BorderThickness = 0;
            this.Windows.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Windows.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Windows.CheckedState.InnerOffset = -4;
            this.Windows.Location = new System.Drawing.Point(53, 25);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(74, 17);
            this.Windows.TabIndex = 6;
            this.Windows.TabStop = true;
            this.Windows.Text = "Windows";
            this.Windows.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Windows.UncheckedState.BorderThickness = 2;
            this.Windows.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Windows.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Windows.UseVisualStyleBackColor = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(243, -3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "By Vestige";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(132, 175);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 39);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Check Dotnet Version";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 234);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NativeHelper";
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2RadioButton Debug;
        private Guna.UI2.WinForms.Guna2RadioButton Release;
        private Guna.UI2.WinForms.Guna2RadioButton Arm64;
        private Guna.UI2.WinForms.Guna2RadioButton x64;
        private Guna.UI2.WinForms.Guna2RadioButton Linux;
        private Guna.UI2.WinForms.Guna2RadioButton Windows;
        private Guna.UI2.WinForms.Guna2Button Build;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

