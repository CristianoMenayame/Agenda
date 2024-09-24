 namespace Agenda
{
    partial class fr_Apresentar
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
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.gr_Resultados = new System.Windows.Forms.DataGridView();
            this.lb_Quantidade = new System.Windows.Forms.Label();
            this.bt_Apagar = new System.Windows.Forms.Button();
            this.bt_Editar = new System.Windows.Forms.Button();
            this.bt_Ver_Tudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gr_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Location = new System.Drawing.Point(516, 328);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(99, 32);
            this.bt_Fechar.TabIndex = 0;
            this.bt_Fechar.Text = "Fechar";
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // gr_Resultados
            // 
            this.gr_Resultados.AllowUserToAddRows = false;
            this.gr_Resultados.AllowUserToDeleteRows = false;
            this.gr_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr_Resultados.Location = new System.Drawing.Point(12, 28);
            this.gr_Resultados.MultiSelect = false;
            this.gr_Resultados.Name = "gr_Resultados";
            this.gr_Resultados.ReadOnly = true;
            this.gr_Resultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gr_Resultados.RowHeadersVisible = false;
            this.gr_Resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gr_Resultados.Size = new System.Drawing.Size(603, 280);
            this.gr_Resultados.TabIndex = 1;
            this.gr_Resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_Resultados_CellClick);
            // 
            // lb_Quantidade
            // 
            this.lb_Quantidade.AutoSize = true;
            this.lb_Quantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quantidade.Location = new System.Drawing.Point(13, 328);
            this.lb_Quantidade.Name = "lb_Quantidade";
            this.lb_Quantidade.Size = new System.Drawing.Size(47, 17);
            this.lb_Quantidade.TabIndex = 2;
            this.lb_Quantidade.Text = "label1";
            // 
            // bt_Apagar
            // 
            this.bt_Apagar.Location = new System.Drawing.Point(411, 328);
            this.bt_Apagar.Name = "bt_Apagar";
            this.bt_Apagar.Size = new System.Drawing.Size(99, 32);
            this.bt_Apagar.TabIndex = 3;
            this.bt_Apagar.Text = "Apagar";
            this.bt_Apagar.UseVisualStyleBackColor = true;
            this.bt_Apagar.Click += new System.EventHandler(this.bt_Apagar_Click);
            // 
            // bt_Editar
            // 
            this.bt_Editar.Location = new System.Drawing.Point(306, 328);
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Size = new System.Drawing.Size(99, 32);
            this.bt_Editar.TabIndex = 4;
            this.bt_Editar.Text = "Editar";
            this.bt_Editar.UseVisualStyleBackColor = true;
            this.bt_Editar.Click += new System.EventHandler(this.bt_Editar_Click);
            // 
            // bt_Ver_Tudo
            // 
            this.bt_Ver_Tudo.Location = new System.Drawing.Point(201, 328);
            this.bt_Ver_Tudo.Name = "bt_Ver_Tudo";
            this.bt_Ver_Tudo.Size = new System.Drawing.Size(99, 32);
            this.bt_Ver_Tudo.TabIndex = 5;
            this.bt_Ver_Tudo.Text = "Ver Tudo";
            this.bt_Ver_Tudo.UseVisualStyleBackColor = true;
            this.bt_Ver_Tudo.Click += new System.EventHandler(this.bt_Ver_Tudo_Click);
            // 
            // fr_Apresentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 372);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Ver_Tudo);
            this.Controls.Add(this.bt_Editar);
            this.Controls.Add(this.bt_Apagar);
            this.Controls.Add(this.lb_Quantidade);
            this.Controls.Add(this.gr_Resultados);
            this.Controls.Add(this.bt_Fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Apresentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.fr_Apresentar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gr_Resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.DataGridView gr_Resultados;
        private System.Windows.Forms.Label lb_Quantidade;
        private System.Windows.Forms.Button bt_Apagar;
        private System.Windows.Forms.Button bt_Editar;
        private System.Windows.Forms.Button bt_Ver_Tudo;
    }
}