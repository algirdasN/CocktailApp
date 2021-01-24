
namespace CocktailApp.Forms
{
    partial class OverwritePrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverwritePrompt));
            this.YesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YesToAllButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.NoToAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesButton.Location = new System.Drawing.Point(37, 80);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 25);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cocktail \'\' already exists in the database.\r\n\r\nDo you want to replace it with the" +
    " one being imported?";
            // 
            // YesToAllButton
            // 
            this.YesToAllButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesToAllButton.Location = new System.Drawing.Point(123, 80);
            this.YesToAllButton.Name = "YesToAllButton";
            this.YesToAllButton.Size = new System.Drawing.Size(75, 25);
            this.YesToAllButton.TabIndex = 2;
            this.YesToAllButton.Text = "Yes to all";
            this.YesToAllButton.UseVisualStyleBackColor = true;
            this.YesToAllButton.Click += new System.EventHandler(this.YesToAllButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoButton.Location = new System.Drawing.Point(209, 80);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 25);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // NoToAllButton
            // 
            this.NoToAllButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoToAllButton.Location = new System.Drawing.Point(295, 80);
            this.NoToAllButton.Name = "NoToAllButton";
            this.NoToAllButton.Size = new System.Drawing.Size(75, 25);
            this.NoToAllButton.TabIndex = 4;
            this.NoToAllButton.Text = "No to all";
            this.NoToAllButton.UseVisualStyleBackColor = true;
            this.NoToAllButton.Click += new System.EventHandler(this.NoToAllButton_Click);
            // 
            // OverwritePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 116);
            this.ControlBox = false;
            this.Controls.Add(this.NoToAllButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesToAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 155);
            this.MinimumSize = new System.Drawing.Size(400, 155);
            this.Name = "OverwritePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cocktail import";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesToAllButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button NoToAllButton;
    }
}