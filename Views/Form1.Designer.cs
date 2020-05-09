namespace Views
{
    partial class Form1
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCharacters = new System.Windows.Forms.Button();
            this.btnSpells = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(107, 80);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(100, 28);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCharacters
            // 
            this.btnCharacters.Location = new System.Drawing.Point(295, 80);
            this.btnCharacters.Name = "btnCharacters";
            this.btnCharacters.Size = new System.Drawing.Size(109, 28);
            this.btnCharacters.TabIndex = 1;
            this.btnCharacters.Text = "Personajes";
            this.btnCharacters.UseVisualStyleBackColor = true;
            this.btnCharacters.Click += new System.EventHandler(this.btnCharacters_Click);
            // 
            // btnSpells
            // 
            this.btnSpells.Location = new System.Drawing.Point(505, 80);
            this.btnSpells.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpells.Name = "btnSpells";
            this.btnSpells.Size = new System.Drawing.Size(100, 28);
            this.btnSpells.TabIndex = 2;
            this.btnSpells.Text = "Hechizos";
            this.btnSpells.UseVisualStyleBackColor = true;
            this.btnSpells.Click += new System.EventHandler(this.btnSpells_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hechizos manage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSpells);
            this.Controls.Add(this.btnCharacters);
            this.Controls.Add(this.btnUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCharacters;
        private System.Windows.Forms.Button btnSpells;
        private System.Windows.Forms.Button button1;
    }
}

