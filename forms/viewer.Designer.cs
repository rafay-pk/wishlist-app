namespace wishlist_app.forms
{
    partial class viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txt_url = new System.Windows.Forms.ToolStripTextBox();
            this.btn_add_from_url = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_url,
            this.btn_add_from_url});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txt_url
            // 
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(100, 25);
            // 
            // btn_add_from_url
            // 
            this.btn_add_from_url.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_add_from_url.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_from_url.Image")));
            this.btn_add_from_url.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add_from_url.Name = "btn_add_from_url";
            this.btn_add_from_url.Size = new System.Drawing.Size(33, 22);
            this.btn_add_from_url.Text = "Add";
            this.btn_add_from_url.Click += new System.EventHandler(this.btn_add_from_url_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.table);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 2;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.name});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowTemplate.Height = 150;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(800, 425);
            this.table.TabIndex = 1;
            // 
            // image
            // 
            this.image.HeaderText = "Product Image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "viewer";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripTextBox txt_url;
        private ToolStripButton btn_add_from_url;
        private Panel panel1;
        private DataGridView table;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn name;
    }
}