namespace Views.Characters
{
    partial class LevelUpDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHitDice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMaxHP = new System.Windows.Forms.NumericUpDown();
            this.lblConMod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clase:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(78, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 17);
            this.lblClass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dados de golpe:";
            // 
            // lblHitDice
            // 
            this.lblHitDice.AutoSize = true;
            this.lblHitDice.Location = new System.Drawing.Point(130, 54);
            this.lblHitDice.Name = "lblHitDice";
            this.lblHitDice.Size = new System.Drawing.Size(16, 17);
            this.lblHitDice.TabIndex = 3;
            this.lblHitDice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nivel:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(324, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 17);
            this.lblLevel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Puntos de vida maximos";
            // 
            // nudMaxHP
            // 
            this.nudMaxHP.Location = new System.Drawing.Point(188, 135);
            this.nudMaxHP.Name = "nudMaxHP";
            this.nudMaxHP.Size = new System.Drawing.Size(120, 22);
            this.nudMaxHP.TabIndex = 7;
            // 
            // lblConMod
            // 
            this.lblConMod.AutoSize = true;
            this.lblConMod.Location = new System.Drawing.Point(367, 54);
            this.lblConMod.Name = "lblConMod";
            this.lblConMod.Size = new System.Drawing.Size(0, 17);
            this.lblConMod.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Constitucion:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(49, 184);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(386, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LevelUpDialog
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(524, 219);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblConMod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudMaxHP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHitDice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LevelUpDialog";
            this.Text = "Subir de Nivel";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHitDice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxHP;
        private System.Windows.Forms.Label lblConMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}