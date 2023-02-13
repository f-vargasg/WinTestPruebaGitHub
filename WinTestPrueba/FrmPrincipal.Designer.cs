
namespace WinTestPrueba
{
    partial class FrmPrincProceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.testCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueCombo = new System.Windows.Forms.TextBox();
            this.setSelectedValueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 118);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // testCmb
            // 
            this.testCmb.FormattingEnabled = true;
            this.testCmb.Location = new System.Drawing.Point(220, 644);
            this.testCmb.Name = "testCmb";
            this.testCmb.Size = new System.Drawing.Size(476, 28);
            this.testCmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // valueCombo
            // 
            this.valueCombo.Location = new System.Drawing.Point(232, 533);
            this.valueCombo.Name = "valueCombo";
            this.valueCombo.Size = new System.Drawing.Size(430, 26);
            this.valueCombo.TabIndex = 4;
            // 
            // setSelectedValueBtn
            // 
            this.setSelectedValueBtn.Location = new System.Drawing.Point(696, 533);
            this.setSelectedValueBtn.Name = "setSelectedValueBtn";
            this.setSelectedValueBtn.Size = new System.Drawing.Size(119, 26);
            this.setSelectedValueBtn.TabIndex = 5;
            this.setSelectedValueBtn.Text = "Set Value";
            this.setSelectedValueBtn.UseVisualStyleBackColor = true;
            this.setSelectedValueBtn.Click += new System.EventHandler(this.SetSelectedValueBtn_Click);
            // 
            // FrmPrincProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 952);
            this.Controls.Add(this.setSelectedValueBtn);
            this.Controls.Add(this.valueCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testCmb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincProceso";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox testCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueCombo;
        private System.Windows.Forms.Button setSelectedValueBtn;
    }
}

