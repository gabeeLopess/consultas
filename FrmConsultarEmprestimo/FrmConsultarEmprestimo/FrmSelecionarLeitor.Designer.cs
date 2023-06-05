namespace FrmConsultarEmprestimo
{
	partial class FrmSelecionarLeitor
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
			this.lblLeitor = new System.Windows.Forms.Label();
			this.txtLeitor = new System.Windows.Forms.TextBox();
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.colLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLeitor
			// 
			this.lblLeitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblLeitor.AutoSize = true;
			this.lblLeitor.Location = new System.Drawing.Point(13, 21);
			this.lblLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLeitor.Name = "lblLeitor";
			this.lblLeitor.Size = new System.Drawing.Size(40, 16);
			this.lblLeitor.TabIndex = 23;
			this.lblLeitor.Text = "Leitor";
			// 
			// txtLeitor
			// 
			this.txtLeitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtLeitor.Location = new System.Drawing.Point(70, 15);
			this.txtLeitor.Margin = new System.Windows.Forms.Padding(4);
			this.txtLeitor.Name = "txtLeitor";
			this.txtLeitor.ReadOnly = true;
			this.txtLeitor.Size = new System.Drawing.Size(464, 22);
			this.txtLeitor.TabIndex = 22;
			this.txtLeitor.TextChanged += new System.EventHandler(this.txtLeitor_TextChanged);
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
            this.colLeitor});
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
			// colLeitor
			// 
			this.colLeitor.HeaderText = "Leitor";
			this.colLeitor.MinimumWidth = 6;
			this.colLeitor.Name = "colLeitor";
			this.colLeitor.ReadOnly = true;
			// 
			// FrmSelecionarLeitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 364);
			this.Controls.Add(this.lblLeitor);
			this.Controls.Add(this.txtLeitor);
			this.Controls.Add(this.gridLayout);
			this.Name = "FrmSelecionarLeitor";
			this.Text = "Selecionar Leitor";
			this.Load += new System.EventHandler(this.FrmSelecionarLeitor_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLeitor;
		private System.Windows.Forms.TextBox txtLeitor;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLeitor;
	}
}