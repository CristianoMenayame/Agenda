namespace Agenda
{
    partial class Ad_Edit
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
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.tx_Numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Location = new System.Drawing.Point(201, 162);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(92, 23);
            this.bt_Guardar.TabIndex = 11;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(100, 162);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(95, 23);
            this.bt_Cancelar.TabIndex = 10;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_Numero
            // 
            this.tx_Numero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Numero.Location = new System.Drawing.Point(15, 86);
            this.tx_Numero.MaxLength = 20;
            this.tx_Numero.Name = "tx_Numero";
            this.tx_Numero.Size = new System.Drawing.Size(180, 23);
            this.tx_Numero.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tx_Nome
            // 
            this.tx_Nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Nome.Location = new System.Drawing.Point(15, 42);
            this.tx_Nome.MaxLength = 50;
            this.tx_Nome.Name = "tx_Nome";
            this.tx_Nome.Size = new System.Drawing.Size(276, 23);
            this.tx_Nome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Ad_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 199);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.tx_Numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_Nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ad_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar e Editar";
            this.Load += new System.EventHandler(this.Ad_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.TextBox tx_Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Nome;
        private System.Windows.Forms.Label label1;
    }
}