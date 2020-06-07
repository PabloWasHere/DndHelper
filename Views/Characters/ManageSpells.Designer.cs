namespace Views.Characters
{
    partial class ManageSpells
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
            this.dgvAddSpells = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPreparedSpells = new System.Windows.Forms.DataGridView();
            this.dgvSpellbook = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.asId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparedSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpellbook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddSpells
            // 
            this.dgvAddSpells.AllowUserToAddRows = false;
            this.dgvAddSpells.AllowUserToDeleteRows = false;
            this.dgvAddSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asId,
            this.asLevel,
            this.asName,
            this.asAction});
            this.dgvAddSpells.Location = new System.Drawing.Point(12, 41);
            this.dgvAddSpells.MultiSelect = false;
            this.dgvAddSpells.Name = "dgvAddSpells";
            this.dgvAddSpells.RowHeadersWidth = 51;
            this.dgvAddSpells.RowTemplate.Height = 24;
            this.dgvAddSpells.Size = new System.Drawing.Size(321, 442);
            this.dgvAddSpells.TabIndex = 0;
            this.dgvAddSpells.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddSpells_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar hechizos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hechizos preparados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libro de hechizos";
            // 
            // dgvPreparedSpells
            // 
            this.dgvPreparedSpells.AllowUserToAddRows = false;
            this.dgvPreparedSpells.AllowUserToDeleteRows = false;
            this.dgvPreparedSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreparedSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.psId,
            this.psNivel,
            this.psNombre,
            this.psAction});
            this.dgvPreparedSpells.Location = new System.Drawing.Point(368, 41);
            this.dgvPreparedSpells.MultiSelect = false;
            this.dgvPreparedSpells.Name = "dgvPreparedSpells";
            this.dgvPreparedSpells.RowHeadersWidth = 51;
            this.dgvPreparedSpells.RowTemplate.Height = 24;
            this.dgvPreparedSpells.Size = new System.Drawing.Size(321, 442);
            this.dgvPreparedSpells.TabIndex = 6;
            this.dgvPreparedSpells.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreparedSpells_CellClick);
            // 
            // dgvSpellbook
            // 
            this.dgvSpellbook.AllowUserToAddRows = false;
            this.dgvSpellbook.AllowUserToDeleteRows = false;
            this.dgvSpellbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpellbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn2});
            this.dgvSpellbook.Location = new System.Drawing.Point(724, 41);
            this.dgvSpellbook.MultiSelect = false;
            this.dgvSpellbook.Name = "dgvSpellbook";
            this.dgvSpellbook.RowHeadersWidth = 51;
            this.dgvSpellbook.RowTemplate.Height = 24;
            this.dgvSpellbook.Size = new System.Drawing.Size(321, 442);
            this.dgvSpellbook.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Accion";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 125;
            // 
            // asId
            // 
            this.asId.HeaderText = "Id";
            this.asId.MinimumWidth = 6;
            this.asId.Name = "asId";
            this.asId.ReadOnly = true;
            this.asId.Visible = false;
            this.asId.Width = 125;
            // 
            // asLevel
            // 
            this.asLevel.HeaderText = "Nivel";
            this.asLevel.MinimumWidth = 6;
            this.asLevel.Name = "asLevel";
            this.asLevel.ReadOnly = true;
            this.asLevel.Width = 125;
            // 
            // asName
            // 
            this.asName.HeaderText = "Nombre";
            this.asName.MinimumWidth = 6;
            this.asName.Name = "asName";
            this.asName.ReadOnly = true;
            this.asName.Width = 125;
            // 
            // asAction
            // 
            this.asAction.HeaderText = "Accion";
            this.asAction.MinimumWidth = 6;
            this.asAction.Name = "asAction";
            this.asAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.asAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asAction.Width = 125;
            // 
            // psId
            // 
            this.psId.HeaderText = "Id";
            this.psId.MinimumWidth = 6;
            this.psId.Name = "psId";
            this.psId.ReadOnly = true;
            this.psId.Visible = false;
            this.psId.Width = 125;
            // 
            // psNivel
            // 
            this.psNivel.HeaderText = "Nivel";
            this.psNivel.MinimumWidth = 6;
            this.psNivel.Name = "psNivel";
            this.psNivel.ReadOnly = true;
            this.psNivel.Width = 125;
            // 
            // psNombre
            // 
            this.psNombre.HeaderText = "Nombre";
            this.psNombre.MinimumWidth = 6;
            this.psNombre.Name = "psNombre";
            this.psNombre.ReadOnly = true;
            this.psNombre.Width = 125;
            // 
            // psAction
            // 
            this.psAction.HeaderText = "Accion";
            this.psAction.MinimumWidth = 6;
            this.psAction.Name = "psAction";
            this.psAction.Width = 125;
            // 
            // ManageSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 495);
            this.Controls.Add(this.dgvSpellbook);
            this.Controls.Add(this.dgvPreparedSpells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddSpells);
            this.Name = "ManageSpells";
            this.Text = "ManageSpells";
            this.Load += new System.EventHandler(this.ManageSpells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSpells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparedSpells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpellbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddSpells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPreparedSpells;
        private System.Windows.Forms.DataGridView dgvSpellbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asId;
        private System.Windows.Forms.DataGridViewTextBoxColumn asLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn asName;
        private System.Windows.Forms.DataGridViewTextBoxColumn asAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn psId;
        private System.Windows.Forms.DataGridViewTextBoxColumn psNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn psNombre;
        private System.Windows.Forms.DataGridViewButtonColumn psAction;
    }
}