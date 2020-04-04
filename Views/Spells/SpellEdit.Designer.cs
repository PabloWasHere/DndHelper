namespace Views.Spells
{
    partial class SpellEdit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbCastingTime = new System.Windows.Forms.TextBox();
            this.tbMaterials = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbComponents = new System.Windows.Forms.TextBox();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbFamily
            // 
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(141, 274);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(236, 24);
            this.cbFamily.TabIndex = 43;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(510, 29);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(236, 24);
            this.cbClass.TabIndex = 42;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(141, 90);
            this.nudLevel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(236, 22);
            this.nudLevel.TabIndex = 41;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(28, 332);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(718, 102);
            this.tbDescription.TabIndex = 40;
            // 
            // tbCastingTime
            // 
            this.tbCastingTime.Location = new System.Drawing.Point(510, 92);
            this.tbCastingTime.Name = "tbCastingTime";
            this.tbCastingTime.Size = new System.Drawing.Size(236, 22);
            this.tbCastingTime.TabIndex = 39;
            // 
            // tbMaterials
            // 
            this.tbMaterials.Location = new System.Drawing.Point(510, 213);
            this.tbMaterials.Name = "tbMaterials";
            this.tbMaterials.Size = new System.Drawing.Size(236, 22);
            this.tbMaterials.TabIndex = 38;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(510, 148);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(236, 22);
            this.tbDuration.TabIndex = 37;
            // 
            // tbComponents
            // 
            this.tbComponents.Location = new System.Drawing.Point(141, 213);
            this.tbComponents.Name = "tbComponents";
            this.tbComponents.Size = new System.Drawing.Size(236, 22);
            this.tbComponents.TabIndex = 36;
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(141, 145);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(236, 22);
            this.tbRange.TabIndex = 35;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(236, 22);
            this.tbName.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Nivel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Familia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Materiales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rango";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Componentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tiempo de lanzamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // SpellEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbCastingTime);
            this.Controls.Add(this.tbMaterials);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbComponents);
            this.Controls.Add(this.tbRange);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpellEdit";
            this.Text = "SpellEdit";
            this.Load += new System.EventHandler(this.SpellEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbCastingTime;
        private System.Windows.Forms.TextBox tbMaterials;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbComponents;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}