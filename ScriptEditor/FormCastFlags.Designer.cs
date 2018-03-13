﻿namespace ScriptEditor
{
    partial class FormCastFlags
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
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.chkCastFlag1 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag2 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag4 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag8 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag16 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag32 = new System.Windows.Forms.CheckBox();
            this.txtScriptId = new System.Windows.Forms.TextBox();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.grpFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.chkCastFlag32);
            this.grpFlags.Controls.Add(this.chkCastFlag16);
            this.grpFlags.Controls.Add(this.chkCastFlag8);
            this.grpFlags.Controls.Add(this.chkCastFlag4);
            this.grpFlags.Controls.Add(this.chkCastFlag2);
            this.grpFlags.Controls.Add(this.chkCastFlag1);
            this.grpFlags.Location = new System.Drawing.Point(12, 12);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Size = new System.Drawing.Size(268, 106);
            this.grpFlags.TabIndex = 0;
            this.grpFlags.TabStop = false;
            this.grpFlags.Text = "Cast Flags";
            // 
            // chkCastFlag1
            // 
            this.chkCastFlag1.AutoSize = true;
            this.chkCastFlag1.Location = new System.Drawing.Point(6, 28);
            this.chkCastFlag1.Name = "chkCastFlag1";
            this.chkCastFlag1.Size = new System.Drawing.Size(109, 17);
            this.chkCastFlag1.TabIndex = 0;
            this.chkCastFlag1.Text = "Interrupt Previous";
            this.chkCastFlag1.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag2
            // 
            this.chkCastFlag2.AutoSize = true;
            this.chkCastFlag2.Location = new System.Drawing.Point(154, 28);
            this.chkCastFlag2.Name = "chkCastFlag2";
            this.chkCastFlag2.Size = new System.Drawing.Size(71, 17);
            this.chkCastFlag2.TabIndex = 1;
            this.chkCastFlag2.Text = "Triggered";
            this.chkCastFlag2.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag4
            // 
            this.chkCastFlag4.AutoSize = true;
            this.chkCastFlag4.Location = new System.Drawing.Point(154, 51);
            this.chkCastFlag4.Name = "chkCastFlag4";
            this.chkCastFlag4.Size = new System.Drawing.Size(77, 17);
            this.chkCastFlag4.TabIndex = 2;
            this.chkCastFlag4.Text = "Force Cast";
            this.chkCastFlag4.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag8
            // 
            this.chkCastFlag8.AutoSize = true;
            this.chkCastFlag8.Location = new System.Drawing.Point(6, 51);
            this.chkCastFlag8.Name = "chkCastFlag8";
            this.chkCastFlag8.Size = new System.Drawing.Size(116, 17);
            this.chkCastFlag8.TabIndex = 3;
            this.chkCastFlag8.Text = "Main Ranged Spell";
            this.chkCastFlag8.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag16
            // 
            this.chkCastFlag16.AutoSize = true;
            this.chkCastFlag16.Location = new System.Drawing.Point(6, 74);
            this.chkCastFlag16.Name = "chkCastFlag16";
            this.chkCastFlag16.Size = new System.Drawing.Size(124, 17);
            this.chkCastFlag16.TabIndex = 4;
            this.chkCastFlag16.Text = "Target Casts On Self";
            this.chkCastFlag16.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag32
            // 
            this.chkCastFlag32.AutoSize = true;
            this.chkCastFlag32.Location = new System.Drawing.Point(154, 74);
            this.chkCastFlag32.Name = "chkCastFlag32";
            this.chkCastFlag32.Size = new System.Drawing.Size(107, 17);
            this.chkCastFlag32.TabIndex = 5;
            this.chkCastFlag32.Text = "Aura Not Present";
            this.chkCastFlag32.UseVisualStyleBackColor = true;
            // 
            // txtScriptId
            // 
            this.txtScriptId.Location = new System.Drawing.Point(70, 124);
            this.txtScriptId.MinimumSize = new System.Drawing.Size(0, 23);
            this.txtScriptId.Name = "txtScriptId";
            this.txtScriptId.Size = new System.Drawing.Size(136, 23);
            this.txtScriptId.TabIndex = 1;
            // 
            // btnEditScript
            // 
            this.btnEditScript.Location = new System.Drawing.Point(212, 124);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(68, 23);
            this.btnEditScript.TabIndex = 2;
            this.btnEditScript.Text = "Edit";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // lblScriptId
            // 
            this.lblScriptId.AutoSize = true;
            this.lblScriptId.Location = new System.Drawing.Point(17, 129);
            this.lblScriptId.Name = "lblScriptId";
            this.lblScriptId.Size = new System.Drawing.Size(49, 13);
            this.lblScriptId.TabIndex = 3;
            this.lblScriptId.Text = "Script Id:";
            // 
            // FormCastFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 155);
            this.Controls.Add(this.lblScriptId);
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.txtScriptId);
            this.Controls.Add(this.grpFlags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCastFlags";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Additional Settings";
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.CheckBox chkCastFlag32;
        private System.Windows.Forms.CheckBox chkCastFlag16;
        private System.Windows.Forms.CheckBox chkCastFlag8;
        private System.Windows.Forms.CheckBox chkCastFlag4;
        private System.Windows.Forms.CheckBox chkCastFlag2;
        private System.Windows.Forms.CheckBox chkCastFlag1;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.Button btnEditScript;
        private System.Windows.Forms.Label lblScriptId;
    }
}