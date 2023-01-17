namespace Расчёт_ступени_ЦВД_паровой_турбины_2
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.z1 = new ZedGraph.ZedGraphControl();
            this.table = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.z2 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.z4 = new ZedGraph.ZedGraphControl();
            this.z3 = new ZedGraph.ZedGraphControl();
            this.table2 = new System.Windows.Forms.DataGridView();
            this.out2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.out1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.out3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            this.SuspendLayout();
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(924, -7);
            this.z1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new System.Drawing.Size(909, 706);
            this.z1.TabIndex = 0;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(1, 733);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(929, 203);
            this.table.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1837, 734);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.z2);
            this.tabPage1.Controls.Add(this.z1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1829, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Графики d, v0";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(-4, -7);
            this.z2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z2.Name = "z2";
            this.z2.ScrollGrace = 0D;
            this.z2.ScrollMaxX = 0D;
            this.z2.ScrollMaxY = 0D;
            this.z2.ScrollMaxY2 = 0D;
            this.z2.ScrollMinX = 0D;
            this.z2.ScrollMinY = 0D;
            this.z2.ScrollMinY2 = 0D;
            this.z2.Size = new System.Drawing.Size(929, 706);
            this.z2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.z4);
            this.tabPage2.Controls.Add(this.z3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1829, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графики H0_ , H0";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // z4
            // 
            this.z4.Location = new System.Drawing.Point(924, -7);
            this.z4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z4.Name = "z4";
            this.z4.ScrollGrace = 0D;
            this.z4.ScrollMaxX = 0D;
            this.z4.ScrollMaxY = 0D;
            this.z4.ScrollMaxY2 = 0D;
            this.z4.ScrollMinX = 0D;
            this.z4.ScrollMinY = 0D;
            this.z4.ScrollMinY2 = 0D;
            this.z4.Size = new System.Drawing.Size(909, 706);
            this.z4.TabIndex = 3;
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(-4, -7);
            this.z3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z3.Name = "z3";
            this.z3.ScrollGrace = 0D;
            this.z3.ScrollMaxX = 0D;
            this.z3.ScrollMaxY = 0D;
            this.z3.ScrollMaxY2 = 0D;
            this.z3.ScrollMinX = 0D;
            this.z3.ScrollMinY = 0D;
            this.z3.ScrollMinY2 = 0D;
            this.z3.Size = new System.Drawing.Size(929, 706);
            this.z3.TabIndex = 2;
            // 
            // table2
            // 
            this.table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2.Location = new System.Drawing.Point(929, 733);
            this.table2.Name = "table2";
            this.table2.RowTemplate.Height = 24;
            this.table2.Size = new System.Drawing.Size(905, 172);
            this.table2.TabIndex = 3;
            // 
            // out2
            // 
            this.out2.Location = new System.Drawing.Point(1329, 911);
            this.out2.Name = "out2";
            this.out2.ReadOnly = true;
            this.out2.Size = new System.Drawing.Size(100, 22);
            this.out2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1294, 914);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "∆ =";
            // 
            // out1
            // 
            this.out1.Location = new System.Drawing.Point(1143, 911);
            this.out1.Name = "out1";
            this.out1.ReadOnly = true;
            this.out1.Size = new System.Drawing.Size(100, 22);
            this.out1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 914);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сумма H0 (располагаемый) =";
            // 
            // out3
            // 
            this.out3.Location = new System.Drawing.Point(1550, 911);
            this.out3.Name = "out3";
            this.out3.ReadOnly = true;
            this.out3.Size = new System.Drawing.Size(100, 22);
            this.out3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1495, 914);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "∆ / 5 =";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 937);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.out3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.out1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.out2);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1858, 984);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики и таблица";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl z4;
        private ZedGraph.ZedGraphControl z3;
        private ZedGraph.ZedGraphControl z2;
        private System.Windows.Forms.DataGridView table2;
        private System.Windows.Forms.TextBox out2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox out1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox out3;
        private System.Windows.Forms.Label label3;
    }
}