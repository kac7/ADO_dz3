namespace Ado_dz3
{
    partial class Form1
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
            this.btnShowProduct = new System.Windows.Forms.Button();
            this.btnShowSeller = new System.Windows.Forms.Button();
            this.btnShowBuyer = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnTakeCheck = new System.Windows.Forms.Button();
            this.SelectBuyer = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelOnly = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowProduct
            // 
            this.btnShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowProduct.Location = new System.Drawing.Point(681, 13);
            this.btnShowProduct.Name = "btnShowProduct";
            this.btnShowProduct.Size = new System.Drawing.Size(274, 44);
            this.btnShowProduct.TabIndex = 2;
            this.btnShowProduct.Text = "Таблица товаров";
            this.btnShowProduct.UseVisualStyleBackColor = true;
            // 
            // btnShowSeller
            // 
            this.btnShowSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowSeller.Location = new System.Drawing.Point(681, 63);
            this.btnShowSeller.Name = "btnShowSeller";
            this.btnShowSeller.Size = new System.Drawing.Size(274, 44);
            this.btnShowSeller.TabIndex = 3;
            this.btnShowSeller.Text = "Таблица продавцов";
            this.btnShowSeller.UseVisualStyleBackColor = true;
            // 
            // btnShowBuyer
            // 
            this.btnShowBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowBuyer.Location = new System.Drawing.Point(681, 114);
            this.btnShowBuyer.Name = "btnShowBuyer";
            this.btnShowBuyer.Size = new System.Drawing.Size(274, 44);
            this.btnShowBuyer.TabIndex = 4;
            this.btnShowBuyer.Text = "Таблица покупателей";
            this.btnShowBuyer.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Green;
            this.btnBuy.Enabled = false;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(681, 373);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(274, 44);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnTakeCheck
            // 
            this.btnTakeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeCheck.Location = new System.Drawing.Point(681, 423);
            this.btnTakeCheck.Name = "btnTakeCheck";
            this.btnTakeCheck.Size = new System.Drawing.Size(274, 44);
            this.btnTakeCheck.TabIndex = 6;
            this.btnTakeCheck.Text = "Таблица чеков";
            this.btnTakeCheck.UseVisualStyleBackColor = true;
            // 
            // SelectBuyer
            // 
            this.SelectBuyer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SelectBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectBuyer.FormattingEnabled = true;
            this.SelectBuyer.ItemHeight = 20;
            this.SelectBuyer.Location = new System.Drawing.Point(681, 333);
            this.SelectBuyer.Name = "SelectBuyer";
            this.SelectBuyer.Size = new System.Drawing.Size(273, 28);
            this.SelectBuyer.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 456);
            this.dataGridView1.TabIndex = 8;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.ForeColor = System.Drawing.Color.Green;
            this.labelSelect.Location = new System.Drawing.Point(731, 293);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(177, 20);
            this.labelSelect.TabIndex = 9;
            this.labelSelect.Text = "Выберите покупателя";
            // 
            // labelOnly
            // 
            this.labelOnly.AutoSize = true;
            this.labelOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOnly.ForeColor = System.Drawing.Color.Red;
            this.labelOnly.Location = new System.Drawing.Point(698, 215);
            this.labelOnly.Name = "labelOnly";
            this.labelOnly.Size = new System.Drawing.Size(239, 40);
            this.labelOnly.TabIndex = 11;
            this.labelOnly.Text = "Для покупки товара \r\nвыберите таблицу с товарами";
            this.labelOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOnly.UseMnemonic = false;
            this.labelOnly.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 483);
            this.Controls.Add(this.labelOnly);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectBuyer);
            this.Controls.Add(this.btnTakeCheck);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnShowBuyer);
            this.Controls.Add(this.btnShowSeller);
            this.Controls.Add(this.btnShowProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Refrigerators";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowProduct;
        private System.Windows.Forms.Button btnShowSeller;
        private System.Windows.Forms.Button btnShowBuyer;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnTakeCheck;
        private System.Windows.Forms.ComboBox SelectBuyer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelOnly;
    }
}

