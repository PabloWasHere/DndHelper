namespace Views.Characters
{
    partial class ShortRestDialog
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
            this.lblClassHitDice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHitDiceTotal = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tomar un descanso corto recuperara una cantidad de puntos de vida igual a los dad" +
    "os de golpe de su clase usados";
            // 
            // lblClassHitDice
            // 
            this.lblClassHitDice.AutoSize = true;
            this.lblClassHitDice.Location = new System.Drawing.Point(98, 115);
            this.lblClassHitDice.Name = "lblClassHitDice";
            this.lblClassHitDice.Size = new System.Drawing.Size(47, 17);
            this.lblClassHitDice.TabIndex = 1;
            this.lblClassHitDice.Text = "Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // lblHitDiceTotal
            // 
            this.lblHitDiceTotal.AutoSize = true;
            this.lblHitDiceTotal.Location = new System.Drawing.Point(428, 115);
            this.lblHitDiceTotal.Name = "lblHitDiceTotal";
            this.lblHitDiceTotal.Size = new System.Drawing.Size(16, 17);
            this.lblHitDiceTotal.TabIndex = 3;
            this.lblHitDiceTotal.Text = "1";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(228, 179);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 22);
            this.nudAmount.TabIndex = 4;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(101, 240);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ShortRestDialog
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(604, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblHitDiceTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClassHitDice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShortRestDialog";
            this.Text = "Tomar un descanso corto";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClassHitDice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHitDiceTotal;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}