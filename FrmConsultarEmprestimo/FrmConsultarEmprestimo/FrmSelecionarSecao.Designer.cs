namespace FrmConsultarEmprestimo
{
	partial class FrmSelecionarSecao
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
			this.lblSecao = new System.Windows.Forms.Label();
			this.txtSecao = new System.Windows.Forms.TextBox();
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSecao
			// 
			this.lblSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSecao.AutoSize = true;
			this.lblSecao.Location = new System.Drawing.Point(13, 21);
			this.lblSecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSecao.Name = "lblSecao";
			this.lblSecao.Size = new System.Drawing.Size(47, 16);
			this.lblSecao.TabIndex = 26;
			this.lblSecao.Text = "Seção";
			// 
			// txtSecao
			// 
			this.txtSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtSecao.Location = new System.Drawing.Point(70, 15);
			this.txtSecao.Margin = new System.Windows.Forms.Padding(4);
			this.txtSecao.Name = "txtSecao";
			this.txtSecao.ReadOnly = true;
			this.txtSecao.Size = new System.Drawing.Size(464, 22);
			this.txtSecao.TabIndex = 25;
			this.txtSecao.TextChanged += new System.EventHandler(this.txtSecao_TextChanged);
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
            this.colSecao});
			this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridLayout.Location = new System.Drawing.Point(16, 58);
			this.gridLayout.Margin = new System.Windows.Forms.Padding(4);
			this.gridLayout.Name = "gridLayout";
			this.gridLayout.ReadOnly = true;
			this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridLayout.RowHeadersWidth = 51;
			this.gridLayout.Size = new System.Drawing.Size(519, 292);
			this.gridLayout.TabIndex = 24;
			this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
			this.gridLayout.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentDoubleClick);
			// 
			// colSecao
			// 
			this.colSecao.HeaderText = "Secao";
			this.colSecao.MinimumWidth = 6;
			this.colSecao.Name = "colSecao";
			this.colSecao.ReadOnly = true;
			// 
			// FrmSelecionarSecao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 364);
			this.Controls.Add(this.lblSecao);
			this.Controls.Add(this.txtSecao);
			this.Controls.Add(this.gridLayout);
			this.Name = "FrmSelecionarSecao";
			this.Text = "Selecionar Seção";
			this.Load += new System.EventHandler(this.FrmSelecionarSecao_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSecao;
		private System.Windows.Forms.TextBox txtSecao;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
	}
}