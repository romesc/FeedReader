namespace RSS_1
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdthrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemlidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemlinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemconteudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(177, 426);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemtituloDataGridViewTextBoxColumn,
            this.itemdthrDataGridViewTextBoxColumn,
            this.itemlidoDataGridViewTextBoxColumn,
            this.itemlinkDataGridViewTextBoxColumn,
            this.itemconteudoDataGridViewTextBoxColumn,
            this.feedcodigoDataGridViewTextBoxColumn,
            this.feedDataGridViewTextBoxColumn,
            this.itemcodigoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(177, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(623, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(RSS_1.Item);
            // 
            // itemtituloDataGridViewTextBoxColumn
            // 
            this.itemtituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemtituloDataGridViewTextBoxColumn.DataPropertyName = "item_titulo";
            this.itemtituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.itemtituloDataGridViewTextBoxColumn.Name = "itemtituloDataGridViewTextBoxColumn";
            this.itemtituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemdthrDataGridViewTextBoxColumn
            // 
            this.itemdthrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemdthrDataGridViewTextBoxColumn.DataPropertyName = "item_dthr";
            this.itemdthrDataGridViewTextBoxColumn.HeaderText = "Postagem";
            this.itemdthrDataGridViewTextBoxColumn.Name = "itemdthrDataGridViewTextBoxColumn";
            this.itemdthrDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemdthrDataGridViewTextBoxColumn.Width = 79;
            // 
            // itemlidoDataGridViewTextBoxColumn
            // 
            this.itemlidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemlidoDataGridViewTextBoxColumn.DataPropertyName = "item_lido";
            this.itemlidoDataGridViewTextBoxColumn.HeaderText = "Lido?";
            this.itemlidoDataGridViewTextBoxColumn.Name = "itemlidoDataGridViewTextBoxColumn";
            this.itemlidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemlidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemlidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemlidoDataGridViewTextBoxColumn.Width = 58;
            // 
            // itemlinkDataGridViewTextBoxColumn
            // 
            this.itemlinkDataGridViewTextBoxColumn.DataPropertyName = "item_link";
            this.itemlinkDataGridViewTextBoxColumn.HeaderText = "item_link";
            this.itemlinkDataGridViewTextBoxColumn.Name = "itemlinkDataGridViewTextBoxColumn";
            this.itemlinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemlinkDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemconteudoDataGridViewTextBoxColumn
            // 
            this.itemconteudoDataGridViewTextBoxColumn.DataPropertyName = "item_conteudo";
            this.itemconteudoDataGridViewTextBoxColumn.HeaderText = "item_conteudo";
            this.itemconteudoDataGridViewTextBoxColumn.Name = "itemconteudoDataGridViewTextBoxColumn";
            this.itemconteudoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemconteudoDataGridViewTextBoxColumn.Visible = false;
            // 
            // feedcodigoDataGridViewTextBoxColumn
            // 
            this.feedcodigoDataGridViewTextBoxColumn.DataPropertyName = "feed_codigo";
            this.feedcodigoDataGridViewTextBoxColumn.HeaderText = "feed_codigo";
            this.feedcodigoDataGridViewTextBoxColumn.Name = "feedcodigoDataGridViewTextBoxColumn";
            this.feedcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedcodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // feedDataGridViewTextBoxColumn
            // 
            this.feedDataGridViewTextBoxColumn.DataPropertyName = "Feed";
            this.feedDataGridViewTextBoxColumn.HeaderText = "Feed";
            this.feedDataGridViewTextBoxColumn.Name = "feedDataGridViewTextBoxColumn";
            this.feedDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemcodigoDataGridViewTextBoxColumn
            // 
            this.itemcodigoDataGridViewTextBoxColumn.DataPropertyName = "item_codigo";
            this.itemcodigoDataGridViewTextBoxColumn.HeaderText = "item_codigo";
            this.itemcodigoDataGridViewTextBoxColumn.Name = "itemcodigoDataGridViewTextBoxColumn";
            this.itemcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdthrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemlidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemlinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemconteudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}

