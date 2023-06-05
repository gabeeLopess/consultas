namespace FrmConsultarEmprestimo
{
	partial class FrmSelecionarAutor
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
			this.txtNomeAutor = new System.Windows.Forms.TextBox();
			this.lblNomeAutor = new System.Windows.Forms.Label();
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNomeAutor
			// 
			this.txtNomeAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtNomeAutor.Location = new System.Drawing.Point(68, 15);
			this.txtNomeAutor.Margin = new System.Windows.Forms.Padding(4);
			this.txtNomeAutor.Name = "txtNomeAutor";
			this.txtNomeAutor.Size = new System.Drawing.Size(464, 22);
			this.txtNomeAutor.TabIndex = 23;
			this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
			// 
			// lblNomeAutor
			// 
			this.lblNomeAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNomeAutor.AutoSize = true;
			this.lblNomeAutor.Location = new System.Drawing.Point(15, 18);
			this.lblNomeAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNomeAutor.Name = "lblNomeAutor";
			this.lblNomeAutor.Size = new System.Drawing.Size(38, 16);
			this.lblNomeAutor.TabIndex = 22;
			this.lblNomeAutor.Text = "Autor";
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
            this.colNomeAutor});
			this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridLayout.Location = new System.Drawing.Point(15, 58);
			this.gridLayout.Margin = new System.Windows.Forms.Padding(4);
			this.gridLayout.Name = "gridLayout";
			this.gridLayout.ReadOnly = true;
			this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridLayout.RowHeadersWidth = 51;
			this.gridLayout.Size = new System.Drawing.Size(519, 292);
			this.gridLayout.TabIndex = 21;
			this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
			this.gridLayout.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentDoubleClick);
			// 
			// colNomeAutor
			// 
			this.colNomeAutor.HeaderText = "Autor";
			this.colNomeAutor.MinimumWidth = 6;
			this.colNomeAutor.Name = "colNomeAutor";
			this.colNomeAutor.ReadOnly = true;
			// 
			// FrmSelecionarAutor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 364);
			this.Controls.Add(this.txtNomeAutor);
			this.Controls.Add(this.lblNomeAutor);
			this.Controls.Add(this.gridLayout);
			this.Name = "FrmSelecionarAutor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selecionar Autor";
			this.Load += new System.EventHandler(this.FrmSelecionarAutor_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNomeAutor;
		private System.Windows.Forms.Label lblNomeAutor;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
	}
}