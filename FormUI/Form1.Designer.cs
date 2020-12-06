namespace FormUI
{
    partial class Form1
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
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Subcategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProductLine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.labelmax = new System.Windows.Forms.Label();
            this.labmin = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdventureWorks2016 = new System.Windows.Forms.Label();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(660, 31);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(90, 21);
            this.textBoxProduct.TabIndex = 1;
            this.textBoxProduct.TextChanged += new System.EventHandler(this.textBoxProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(15, 57);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(109, 23);
            this.comboBoxCategoria.TabIndex = 4;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(15, 99);
            this.comboBoxSubCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(109, 23);
            this.comboBoxSubCategory.TabIndex = 5;
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategory_SelectedIndexChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(9, 37);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(149, 24);
            this.comboBoxSize.TabIndex = 6;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria";
            // 
            // Subcategoria
            // 
            this.Subcategoria.AutoSize = true;
            this.Subcategoria.Location = new System.Drawing.Point(11, 82);
            this.Subcategoria.Name = "Subcategoria";
            this.Subcategoria.Size = new System.Drawing.Size(80, 15);
            this.Subcategoria.TabIndex = 8;
            this.Subcategoria.Text = "Subcategoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size";
            // 
            // listViewProduct
            // 
            this.listViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(195, 57);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(682, 445);
            this.listViewProduct.TabIndex = 10;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.List;
            this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.listViewProduct_SelectedIndexChanged);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "EN",
            "FR"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(801, 511);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(76, 23);
            this.comboBoxLanguage.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Language";
            // 
            // comboBoxProductLine
            // 
            this.comboBoxProductLine.FormattingEnabled = true;
            this.comboBoxProductLine.Location = new System.Drawing.Point(9, 82);
            this.comboBoxProductLine.Name = "comboBoxProductLine";
            this.comboBoxProductLine.Size = new System.Drawing.Size(149, 24);
            this.comboBoxProductLine.TabIndex = 13;
            this.comboBoxProductLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductLine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ProductLine";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxFilter.Controls.Add(this.labelmax);
            this.groupBoxFilter.Controls.Add(this.labmin);
            this.groupBoxFilter.Controls.Add(this.max);
            this.groupBoxFilter.Controls.Add(this.min);
            this.groupBoxFilter.Controls.Add(this.label7);
            this.groupBoxFilter.Controls.Add(this.labelClass);
            this.groupBoxFilter.Controls.Add(this.comboBoxStyle);
            this.groupBoxFilter.Controls.Add(this.comboBoxClass);
            this.groupBoxFilter.Controls.Add(this.label6);
            this.groupBoxFilter.Controls.Add(this.comboBoxProductLine);
            this.groupBoxFilter.Controls.Add(this.label5);
            this.groupBoxFilter.Controls.Add(this.comboBoxSize);
            this.groupBoxFilter.Controls.Add(this.label3);
            this.groupBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxFilter.Location = new System.Drawing.Point(11, 127);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxFilter.Size = new System.Drawing.Size(178, 380);
            this.groupBoxFilter.TabIndex = 15;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filters";
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelmax.Location = new System.Drawing.Point(26, 257);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(32, 13);
            this.labelmax.TabIndex = 23;
            this.labelmax.Text = "MAX";
            // 
            // labmin
            // 
            this.labmin.AutoSize = true;
            this.labmin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labmin.Location = new System.Drawing.Point(26, 231);
            this.labmin.Name = "labmin";
            this.labmin.Size = new System.Drawing.Size(29, 13);
            this.labmin.TabIndex = 22;
            this.labmin.Text = "MIN";
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(58, 252);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(100, 23);
            this.max.TabIndex = 21;
            this.max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_KeyPress);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(58, 226);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(100, 23);
            this.min.TabIndex = 20;
            this.min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.min_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "ListPrice";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(6, 155);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(41, 16);
            this.labelClass.TabIndex = 18;
            this.labelClass.Text = "Style";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(9, 174);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(149, 24);
            this.comboBoxStyle.TabIndex = 17;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(9, 128);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(149, 24);
            this.comboBoxClass.TabIndex = 16;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Class";
            // 
            // AdventureWorks2016
            // 
            this.AdventureWorks2016.AutoSize = true;
            this.AdventureWorks2016.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AdventureWorks2016.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdventureWorks2016.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AdventureWorks2016.Location = new System.Drawing.Point(6, 9);
            this.AdventureWorks2016.Name = "AdventureWorks2016";
            this.AdventureWorks2016.Size = new System.Drawing.Size(220, 26);
            this.AdventureWorks2016.TabIndex = 16;
            this.AdventureWorks2016.Text = "AdventureWorks2016";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(889, 535);
            this.Controls.Add(this.AdventureWorks2016);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.Subcategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Subcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProductLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label AdventureWorks2016;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labmin;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelmax;
    }
}

