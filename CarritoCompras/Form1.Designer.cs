namespace CarritoCompras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCarritoDeCompras = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listCarritoDeCompras
            // 
            this.listCarritoDeCompras.FormattingEnabled = true;
            this.listCarritoDeCompras.ItemHeight = 15;
            this.listCarritoDeCompras.Location = new System.Drawing.Point(21, 12);
            this.listCarritoDeCompras.Name = "listCarritoDeCompras";
            this.listCarritoDeCompras.Size = new System.Drawing.Size(215, 304);
            this.listCarritoDeCompras.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(407, 134);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(128, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular Precio Final";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // cboxProducto
            // 
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(316, 74);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(121, 23);
            this.cboxProducto.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 428);
            this.Controls.Add(this.cboxProducto);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listCarritoDeCompras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listCarritoDeCompras;
        private Button btnAdd;
        private Button btnCalc;
        private ComboBox cboxProducto;
    }
}