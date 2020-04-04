namespace Views.Spells
{
    partial class SpellList
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
            this.dgvSpells = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpells
            // 
            this.dgvSpells.AllowUserToAddRows = false;
            this.dgvSpells.AllowUserToDeleteRows = false;
            this.dgvSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.level,
            this.charClass,
            this.name,
            this.materials});
            this.dgvSpells.Location = new System.Drawing.Point(12, 112);
            this.dgvSpells.MultiSelect = false;
            this.dgvSpells.Name = "dgvSpells";
            this.dgvSpells.ReadOnly = true;
            this.dgvSpells.RowHeadersWidth = 51;
            this.dgvSpells.RowTemplate.Height = 24;
            this.dgvSpells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpells.Size = new System.Drawing.Size(1000, 417);
            this.dgvSpells.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // level
            // 
            this.level.HeaderText = "Nivel";
            this.level.MinimumWidth = 6;
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Width = 125;
            // 
            // charClass
            // 
            this.charClass.HeaderText = "Clase";
            this.charClass.MinimumWidth = 6;
            this.charClass.Name = "charClass";
            this.charClass.ReadOnly = true;
            this.charClass.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // materials
            // 
            this.materials.HeaderText = "Componentes";
            this.materials.MinimumWidth = 6;
            this.materials.Name = "materials";
            this.materials.ReadOnly = true;
            this.materials.Width = 125;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(127, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SpellList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 541);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvSpells);
            this.Name = "SpellList";
            this.Text = "SpellList";
            this.Load += new System.EventHandler(this.SpellList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpells;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn charClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn materials;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
    }
}