namespace FrmConsultarEmprestimo
{
	partial class FrmSelecionarLocal
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
			this.txtLocal = new System.Windows.Forms.TextBox();
			this.lblNomeLocal = new System.Windows.Forms.Label();
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLocal
			// 
			this.txtLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtLocal.Location = new System.Drawing.Point(69, 15);
			this.txtLocal.Margin = new System.Windows.Forms.Padding(4);
			this.txtLocal.Name = "txtLocal";
			this.txtLocal.Size = new System.Drawing.Size(464, 22);
			this.txtLocal.TabIndex = 23;
			this.txtLocal.TextChanged += new System.EventHandler(this.txtLocal_TextChanged);
			// 
			// lblNomeLocal
			// 
			this.lblNomeLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblNomeLocal.AutoSize = true;
			this.lblNomeLocal.Location = new System.Drawing.Point(13, 23);
			this.lblNomeLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNomeLocal.Name = "lblNomeLocal";
			this.lblNomeLocal.Size = new System.Drawing.Size(40, 16);
			this.lblNomeLocal.TabIndex = 22;
			this.lblNomeLocal.Text = "Local";
			this.lblNomeLocal.Click += new System.EventHandler(this.lblNomeLocal_Click);
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
            this.colNomeLocal});
			this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridLayout.Location = new System.Drawing.Point(16, 58);
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
			// colNomeLocal
			// 
			this.colNomeLocal.HeaderText = "Local";
			this.colNomeLocal.MinimumWidth = 6;
			this.colNomeLocal.Name = "colNomeLocal";
			this.colNomeLocal.ReadOnly = true;
			// 
			// FrmSelecionarLocal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 364);
			this.Controls.Add(this.txtLocal);
			this.Controls.Add(this.lblNomeLocal);
			this.Controls.Add(this.gridLayout);
			this.Name = "FrmSelecionarLocal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selecionar Local";
			this.Load += new System.EventHandler(this.FrmSelecionarLocal_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLocal;
		private System.Windows.Forms.Label lblNomeLocal;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
	}
}