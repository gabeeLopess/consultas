namespace FrmConsultarEmprestimo
{
	partial class FrmSelecionarItem
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
			this.txtNomeItem = new System.Windows.Forms.TextBox();
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNomeItem = new System.Windows.Forms.Label();
			this.lblCodigoItem = new System.Windows.Forms.Label();
			this.txtCodigoItem = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNomeItem
			// 
			this.txtNomeItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtNomeItem.Location = new System.Drawing.Point(70, 42);
			this.txtNomeItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtNomeItem.Name = "txtNomeItem";
			this.txtNomeItem.ReadOnly = true;
			this.txtNomeItem.Size = new System.Drawing.Size(464, 22);
			this.txtNomeItem.TabIndex = 19;
			this.txtNomeItem.TextChanged += new System.EventHandler(this.txtNomeItem_TextChanged);
			// 
			// gridLayout
			// 
			this.gridLayout.AllowUserToAddRows = false;
			this.gridLayout.AllowUserToDeleteRows = false;
			this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colNomeItem});
			this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridLayout.Location = new System.Drawing.Point(15, 89);
			this.gridLayout.Margin = new System.Windows.Forms.Padding(4);
			this.gridLayout.Name = "gridLayout";
			this.gridLayout.ReadOnly = true;
			this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridLayout.RowHeadersWidth = 51;
			this.gridLayout.Size = new System.Drawing.Size(519, 296);
			this.gridLayout.TabIndex = 18;
			this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
			this.gridLayout.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentDoubleClick);
			// 
			// colCodItem
			// 
			this.colCodItem.HeaderText = "Id";
			this.colCodItem.MinimumWidth = 6;
			this.colCodItem.Name = "colCodItem";
			this.colCodItem.ReadOnly = true;
			// 
			// colNomeItem
			// 
			this.colNomeItem.HeaderText = "Item";
			this.colNomeItem.MinimumWidth = 6;
			this.colNomeItem.Name = "colNomeItem";
			this.colNomeItem.ReadOnly = true;
			// 
			// lblNomeItem
			// 
			this.lblNomeItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNomeItem.AutoSize = true;
			this.lblNomeItem.Location = new System.Drawing.Point(13, 42);
			this.lblNomeItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNomeItem.Name = "lblNomeItem";
			this.lblNomeItem.Size = new System.Drawing.Size(32, 16);
			this.lblNomeItem.TabIndex = 20;
			this.lblNomeItem.Text = "Item";
			// 
			// lblCodigoItem
			// 
			this.lblCodigoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCodigoItem.AutoSize = true;
			this.lblCodigoItem.Location = new System.Drawing.Point(13, 12);
			this.lblCodigoItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigoItem.Name = "lblCodigoItem";
			this.lblCodigoItem.Size = new System.Drawing.Size(51, 16);
			this.lblCodigoItem.TabIndex = 22;
			this.lblCodigoItem.Text = "Código";
			this.lblCodigoItem.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtCodigoItem
			// 
			this.txtCodigoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCodigoItem.Location = new System.Drawing.Point(70, 12);
			this.txtCodigoItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigoItem.Name = "txtCodigoItem";
			this.txtCodigoItem.ReadOnly = true;
			this.txtCodigoItem.Size = new System.Drawing.Size(464, 22);
			this.txtCodigoItem.TabIndex = 21;
			this.txtCodigoItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// FrmSelecionarItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 399);
			this.Controls.Add(this.lblCodigoItem);
			this.Controls.Add(this.txtCodigoItem);
			this.Controls.Add(this.lblNomeItem);
			this.Controls.Add(this.txtNomeItem);
			this.Controls.Add(this.gridLayout);
			this.Name = "FrmSelecionarItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selecionar Item";
			this.Load += new System.EventHandler(this.FrmSelecionarItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNomeItem;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
		private System.Windows.Forms.Label lblNomeItem;
		private System.Windows.Forms.Label lblCodigoItem;
		private System.Windows.Forms.TextBox txtCodigoItem;
	}
}