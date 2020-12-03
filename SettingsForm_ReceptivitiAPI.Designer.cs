namespace ReceptivitiAPI
{
    partial class SettingsForm_ReceptivitiAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_ReceptivitiAPI));
            this.OKButton = new System.Windows.Forms.Button();
            this.secretkeytextbox = new System.Windows.Forms.TextBox();
            this.keytextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(276, 174);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // secretkeytextbox
            // 
            this.secretkeytextbox.Enabled = false;
            this.secretkeytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretkeytextbox.Location = new System.Drawing.Point(12, 112);
            this.secretkeytextbox.Name = "secretkeytextbox";
            this.secretkeytextbox.Size = new System.Drawing.Size(468, 21);
            this.secretkeytextbox.TabIndex = 7;
            // 
            // keytextbox
            // 
            this.keytextbox.Enabled = false;
            this.keytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keytextbox.Location = new System.Drawing.Point(12, 49);
            this.keytextbox.Name = "keytextbox";
            this.keytextbox.Size = new System.Drawing.Size(468, 21);
            this.keytextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "API Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "API Secret Key:";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileButton.Location = new System.Drawing.Point(105, 174);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(118, 40);
            this.LoadFileButton.TabIndex = 11;
            this.LoadFileButton.Text = "Open Key File";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // SettingsForm_ReceptivitiAPI
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 226);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keytextbox);
            this.Controls.Add(this.secretkeytextbox);
            this.Controls.Add(this.OKButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_ReceptivitiAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox secretkeytextbox;
        private System.Windows.Forms.TextBox keytextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadFileButton;
    }
}