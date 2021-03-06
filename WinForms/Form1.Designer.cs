﻿namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelectInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelectWhere = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateEntityState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 46);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnSelectInsert
            // 
            this.btnSelectInsert.Location = new System.Drawing.Point(666, 12);
            this.btnSelectInsert.Name = "btnSelectInsert";
            this.btnSelectInsert.Size = new System.Drawing.Size(120, 46);
            this.btnSelectInsert.TabIndex = 1;
            this.btnSelectInsert.Text = "Select + insert";
            this.btnSelectInsert.UseVisualStyleBackColor = true;
            this.btnSelectInsert.Click += new System.EventHandler(this.BtnSelectInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(539, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(121, 46);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Loja do Produto";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnSelectWhere
            // 
            this.btnSelectWhere.Location = new System.Drawing.Point(12, 64);
            this.btnSelectWhere.Name = "btnSelectWhere";
            this.btnSelectWhere.Size = new System.Drawing.Size(136, 42);
            this.btnSelectWhere.TabIndex = 3;
            this.btnSelectWhere.Text = "Select com cláusula Where";
            this.btnSelectWhere.UseVisualStyleBackColor = true;
            this.btnSelectWhere.Click += new System.EventHandler(this.BtnSelectWhere_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(539, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 41);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(666, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdateEntityState
            // 
            this.btnUpdateEntityState.Location = new System.Drawing.Point(347, 132);
            this.btnUpdateEntityState.Name = "btnUpdateEntityState";
            this.btnUpdateEntityState.Size = new System.Drawing.Size(121, 48);
            this.btnUpdateEntityState.TabIndex = 6;
            this.btnUpdateEntityState.Text = "Update via EntityState";
            this.btnUpdateEntityState.UseVisualStyleBackColor = true;
            this.btnUpdateEntityState.Click += new System.EventHandler(this.BtnUpdateEntityState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateEntityState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectWhere);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSelectInsert);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelectInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSelectWhere;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateEntityState;
    }
}

