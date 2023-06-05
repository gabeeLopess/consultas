namespace FrmConsultarEmprestimo
{
	partial class FrmConsultarEmprestimo
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
			this.lblDataFim = new System.Windows.Forms.Label();
			this.lblDataInicio = new System.Windows.Forms.Label();
			this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
			this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblCodigoItem = new System.Windows.Forms.Label();
			this.txtCodigoItem = new System.Windows.Forms.TextBox();
			this.btnSelecionarAutor = new System.Windows.Forms.Button();
			this.btnSelecionarLeitor = new System.Windows.Forms.Button();
			this.btnSelecionarSecao = new System.Windows.Forms.Button();
			this.txtSecao = new System.Windows.Forms.TextBox();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.lblSecao = new System.Windows.Forms.Label();
			this.lblAutor = new System.Windows.Forms.Label();
			this.txtLeitor = new System.Windows.Forms.TextBox();
			this.btnSelecionarLocal = new System.Windows.Forms.Button();
			this.btnSelecionarItem = new System.Windows.Forms.Button();
			this.cmbTipoItem = new System.Windows.Forms.ComboBox();
			this.lblItem = new System.Windows.Forms.Label();
			this.lblLeitor = new System.Windows.Forms.Label();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.lblTipoItem = new System.Windows.Forms.Label();
			this.lblSituacao = new System.Windows.Forms.Label();
			this.txtLocal = new System.Windows.Forms.TextBox();
			this.cmbSituacao = new System.Windows.Forms.ComboBox();
			this.lblLocal = new System.Windows.Forms.Label();
			this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDataFim
			// 
			this.lblDataFim.AutoSize = true;
			this.lblDataFim.Location = new System.Drawing.Point(423, 167);
			this.lblDataFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDataFim.Name = "lblDataFim";
			this.lblDataFim.Size = new System.Drawing.Size(61, 16);
			this.lblDataFim.TabIndex = 37;
			this.lblDataFim.Text = "Data Fim";
			// 
			// lblDataInicio
			// 
			this.lblDataInicio.AutoSize = true;
			this.lblDataInicio.Location = new System.Drawing.Point(8, 166);
			this.lblDataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDataInicio.Name = "lblDataInicio";
			this.lblDataInicio.Size = new System.Drawing.Size(70, 16);
			this.lblDataInicio.TabIndex = 36;
			this.lblDataInicio.Text = "Data Inicio";
			// 
			// dtpDataFim
			// 
			this.dtpDataFim.Location = new System.Drawing.Point(507, 162);
			this.dtpDataFim.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDataFim.Name = "dtpDataFim";
			this.dtpDataFim.Size = new System.Drawing.Size(328, 22);
			this.dtpDataFim.TabIndex = 35;
			// 
			// dtpDataInicio
			// 
			this.dtpDataInicio.Location = new System.Drawing.Point(80, 161);
			this.dtpDataInicio.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDataInicio.Name = "dtpDataInicio";
			this.dtpDataInicio.Size = new System.Drawing.Size(328, 22);
			this.dtpDataInicio.TabIndex = 34;
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
            this.colIdItem,
            this.colItem,
            this.colAutor,
            this.colSituacao,
            this.colDataReserva,
            this.colDataRetorno,
            this.colLocal,
            this.colLeitor,
            this.colTipoItem,
            this.colSecao});
			this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridLayout.Location = new System.Drawing.Point(4, 225);
			this.gridLayout.Margin = new System.Windows.Forms.Padding(4);
			this.gridLayout.Name = "gridLayout";
			this.gridLayout.ReadOnly = true;
			this.gridLayout.RowHeadersWidth = 51;
			this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridLayout.Size = new System.Drawing.Size(819, 366);
			this.gridLayout.TabIndex = 31;
			this.gridLayout.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentDoubleClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(586, 203);
			this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(100, 25);
			this.btnConsultar.TabIndex = 19;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(710, 203);
			this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(100, 25);
			this.btnLimpar.TabIndex = 20;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.Controls.Add(this.lblCodigoItem);
			this.groupBox2.Controls.Add(this.txtCodigoItem);
			this.groupBox2.Controls.Add(this.btnConsultar);
			this.groupBox2.Controls.Add(this.btnSelecionarAutor);
			this.groupBox2.Controls.Add(this.btnLimpar);
			this.groupBox2.Controls.Add(this.lblDataFim);
			this.groupBox2.Controls.Add(this.dtpDataFim);
			this.groupBox2.Controls.Add(this.btnSelecionarLeitor);
			this.groupBox2.Controls.Add(this.btnSelecionarSecao);
			this.groupBox2.Controls.Add(this.lblDataInicio);
			this.groupBox2.Controls.Add(this.dtpDataInicio);
			this.groupBox2.Controls.Add(this.txtSecao);
			this.groupBox2.Controls.Add(this.txtAutor);
			this.groupBox2.Controls.Add(this.lblSecao);
			this.groupBox2.Controls.Add(this.lblAutor);
			this.groupBox2.Controls.Add(this.txtLeitor);
			this.groupBox2.Controls.Add(this.btnSelecionarLocal);
			this.groupBox2.Controls.Add(this.btnSelecionarItem);
			this.groupBox2.Controls.Add(this.cmbTipoItem);
			this.groupBox2.Controls.Add(this.lblItem);
			this.groupBox2.Controls.Add(this.lblLeitor);
			this.groupBox2.Controls.Add(this.txtItem);
			this.groupBox2.Controls.Add(this.lblTipoItem);
			this.groupBox2.Controls.Add(this.lblSituacao);
			this.groupBox2.Controls.Add(this.txtLocal);
			this.groupBox2.Controls.Add(this.cmbSituacao);
			this.groupBox2.Controls.Add(this.lblLocal);
			this.groupBox2.Location = new System.Drawing.Point(-7, -11);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(840, 286);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// lblCodigoItem
			// 
			this.lblCodigoItem.AutoSize = true;
			this.lblCodigoItem.Location = new System.Drawing.Point(8, 20);
			this.lblCodigoItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigoItem.Name = "lblCodigoItem";
			this.lblCodigoItem.Size = new System.Drawing.Size(79, 16);
			this.lblCodigoItem.TabIndex = 38;
			this.lblCodigoItem.Text = "Codigo Item";
			// 
			// txtCodigoItem
			// 
			this.txtCodigoItem.Location = new System.Drawing.Point(80, 17);
			this.txtCodigoItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigoItem.Name = "txtCodigoItem";
			this.txtCodigoItem.ReadOnly = true;
			this.txtCodigoItem.Size = new System.Drawing.Size(328, 22);
			this.txtCodigoItem.TabIndex = 39;
			// 
			// btnSelecionarAutor
			// 
			this.btnSelecionarAutor.Location = new System.Drawing.Point(357, 122);
			this.btnSelecionarAutor.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarAutor.Name = "btnSelecionarAutor";
			this.btnSelecionarAutor.Size = new System.Drawing.Size(51, 25);
			this.btnSelecionarAutor.TabIndex = 25;
			this.btnSelecionarAutor.UseVisualStyleBackColor = true;
			this.btnSelecionarAutor.Click += new System.EventHandler(this.btnSelecionarAutor_Click);
			// 
			// btnSelecionarLeitor
			// 
			this.btnSelecionarLeitor.Location = new System.Drawing.Point(781, 50);
			this.btnSelecionarLeitor.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarLeitor.Name = "btnSelecionarLeitor";
			this.btnSelecionarLeitor.Size = new System.Drawing.Size(51, 26);
			this.btnSelecionarLeitor.TabIndex = 28;
			this.btnSelecionarLeitor.UseVisualStyleBackColor = true;
			this.btnSelecionarLeitor.Click += new System.EventHandler(this.btnSelecionarLeitor_Click);
			// 
			// btnSelecionarSecao
			// 
			this.btnSelecionarSecao.Location = new System.Drawing.Point(781, 82);
			this.btnSelecionarSecao.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarSecao.Name = "btnSelecionarSecao";
			this.btnSelecionarSecao.Size = new System.Drawing.Size(51, 25);
			this.btnSelecionarSecao.TabIndex = 24;
			this.btnSelecionarSecao.UseVisualStyleBackColor = true;
			this.btnSelecionarSecao.Click += new System.EventHandler(this.btnSelecionarSecao_Click);
			// 
			// txtSecao
			// 
			this.txtSecao.Location = new System.Drawing.Point(507, 83);
			this.txtSecao.Margin = new System.Windows.Forms.Padding(4);
			this.txtSecao.Name = "txtSecao";
			this.txtSecao.ReadOnly = true;
			this.txtSecao.Size = new System.Drawing.Size(269, 22);
			this.txtSecao.TabIndex = 8;
			// 
			// txtAutor
			// 
			this.txtAutor.Location = new System.Drawing.Point(80, 123);
			this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.ReadOnly = true;
			this.txtAutor.Size = new System.Drawing.Size(269, 22);
			this.txtAutor.TabIndex = 10;
			// 
			// lblSecao
			// 
			this.lblSecao.AutoSize = true;
			this.lblSecao.Location = new System.Drawing.Point(429, 86);
			this.lblSecao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSecao.Name = "lblSecao";
			this.lblSecao.Size = new System.Drawing.Size(47, 16);
			this.lblSecao.TabIndex = 9;
			this.lblSecao.Text = "Seção";
			// 
			// lblAutor
			// 
			this.lblAutor.AutoSize = true;
			this.lblAutor.Location = new System.Drawing.Point(12, 126);
			this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAutor.Name = "lblAutor";
			this.lblAutor.Size = new System.Drawing.Size(38, 16);
			this.lblAutor.TabIndex = 4;
			this.lblAutor.Text = "Autor";
			// 
			// txtLeitor
			// 
			this.txtLeitor.Location = new System.Drawing.Point(507, 49);
			this.txtLeitor.Margin = new System.Windows.Forms.Padding(4);
			this.txtLeitor.Name = "txtLeitor";
			this.txtLeitor.ReadOnly = true;
			this.txtLeitor.Size = new System.Drawing.Size(269, 22);
			this.txtLeitor.TabIndex = 11;
			// 
			// btnSelecionarLocal
			// 
			this.btnSelecionarLocal.Location = new System.Drawing.Point(357, 85);
			this.btnSelecionarLocal.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarLocal.Name = "btnSelecionarLocal";
			this.btnSelecionarLocal.Size = new System.Drawing.Size(51, 25);
			this.btnSelecionarLocal.TabIndex = 22;
			this.btnSelecionarLocal.UseVisualStyleBackColor = true;
			this.btnSelecionarLocal.Click += new System.EventHandler(this.btnSelecionarLocal_Click);
			// 
			// btnSelecionarItem
			// 
			this.btnSelecionarItem.Location = new System.Drawing.Point(357, 49);
			this.btnSelecionarItem.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarItem.Name = "btnSelecionarItem";
			this.btnSelecionarItem.Size = new System.Drawing.Size(51, 22);
			this.btnSelecionarItem.TabIndex = 21;
			this.btnSelecionarItem.UseVisualStyleBackColor = true;
			this.btnSelecionarItem.Click += new System.EventHandler(this.button5_Click);
			// 
			// cmbTipoItem
			// 
			this.cmbTipoItem.FormattingEnabled = true;
			this.cmbTipoItem.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
			this.cmbTipoItem.Location = new System.Drawing.Point(506, 17);
			this.cmbTipoItem.Margin = new System.Windows.Forms.Padding(4);
			this.cmbTipoItem.Name = "cmbTipoItem";
			this.cmbTipoItem.Size = new System.Drawing.Size(324, 24);
			this.cmbTipoItem.TabIndex = 6;
			// 
			// lblItem
			// 
			this.lblItem.AutoSize = true;
			this.lblItem.Location = new System.Drawing.Point(8, 52);
			this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(32, 16);
			this.lblItem.TabIndex = 0;
			this.lblItem.Text = "Item";
			// 
			// lblLeitor
			// 
			this.lblLeitor.AutoSize = true;
			this.lblLeitor.Location = new System.Drawing.Point(429, 55);
			this.lblLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLeitor.Name = "lblLeitor";
			this.lblLeitor.Size = new System.Drawing.Size(40, 16);
			this.lblLeitor.TabIndex = 2;
			this.lblLeitor.Text = "Leitor";
			// 
			// txtItem
			// 
			this.txtItem.Location = new System.Drawing.Point(80, 49);
			this.txtItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtItem.Name = "txtItem";
			this.txtItem.ReadOnly = true;
			this.txtItem.Size = new System.Drawing.Size(269, 22);
			this.txtItem.TabIndex = 5;
			// 
			// lblTipoItem
			// 
			this.lblTipoItem.AutoSize = true;
			this.lblTipoItem.Location = new System.Drawing.Point(416, 25);
			this.lblTipoItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTipoItem.Name = "lblTipoItem";
			this.lblTipoItem.Size = new System.Drawing.Size(63, 16);
			this.lblTipoItem.TabIndex = 1;
			this.lblTipoItem.Text = "Tipo Item";
			// 
			// lblSituacao
			// 
			this.lblSituacao.AutoSize = true;
			this.lblSituacao.Location = new System.Drawing.Point(423, 126);
			this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(60, 16);
			this.lblSituacao.TabIndex = 17;
			this.lblSituacao.Text = "Situação";
			// 
			// txtLocal
			// 
			this.txtLocal.Location = new System.Drawing.Point(80, 86);
			this.txtLocal.Margin = new System.Windows.Forms.Padding(4);
			this.txtLocal.Name = "txtLocal";
			this.txtLocal.ReadOnly = true;
			this.txtLocal.Size = new System.Drawing.Size(269, 22);
			this.txtLocal.TabIndex = 7;
			// 
			// cmbSituacao
			// 
			this.cmbSituacao.FormattingEnabled = true;
			this.cmbSituacao.Items.AddRange(new object[] {
            "Reservado",
            "Emprestado",
            "Disponível"});
			this.cmbSituacao.Location = new System.Drawing.Point(507, 121);
			this.cmbSituacao.Margin = new System.Windows.Forms.Padding(4);
			this.cmbSituacao.Name = "cmbSituacao";
			this.cmbSituacao.Size = new System.Drawing.Size(323, 24);
			this.cmbSituacao.TabIndex = 18;
			// 
			// lblLocal
			// 
			this.lblLocal.AutoSize = true;
			this.lblLocal.Location = new System.Drawing.Point(10, 86);
			this.lblLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLocal.Name = "lblLocal";
			this.lblLocal.Size = new System.Drawing.Size(40, 16);
			this.lblLocal.TabIndex = 3;
			this.lblLocal.Text = "Local";
			// 
			// colIdItem
			// 
			this.colIdItem.HeaderText = "Id Item";
			this.colIdItem.MinimumWidth = 6;
			this.colIdItem.Name = "colIdItem";
			this.colIdItem.ReadOnly = true;
			// 
			// colItem
			// 
			this.colItem.HeaderText = "Item da Biblioteca";
			this.colItem.MinimumWidth = 6;
			this.colItem.Name = "colItem";
			this.colItem.ReadOnly = true;
			// 
			// colAutor
			// 
			this.colAutor.HeaderText = "Autor";
			this.colAutor.MinimumWidth = 6;
			this.colAutor.Name = "colAutor";
			this.colAutor.ReadOnly = true;
			// 
			// colSituacao
			// 
			this.colSituacao.HeaderText = "Situação";
			this.colSituacao.MinimumWidth = 6;
			this.colSituacao.Name = "colSituacao";
			this.colSituacao.ReadOnly = true;
			// 
			// colDataReserva
			// 
			this.colDataReserva.HeaderText = "Data Reserva";
			this.colDataReserva.MinimumWidth = 6;
			this.colDataReserva.Name = "colDataReserva";
			this.colDataReserva.ReadOnly = true;
			// 
			// colDataRetorno
			// 
			this.colDataRetorno.HeaderText = "Data Retorno";
			this.colDataRetorno.MinimumWidth = 6;
			this.colDataRetorno.Name = "colDataRetorno";
			this.colDataRetorno.ReadOnly = true;
			// 
			// colLocal
			// 
			this.colLocal.HeaderText = "Local";
			this.colLocal.MinimumWidth = 6;
			this.colLocal.Name = "colLocal";
			this.colLocal.ReadOnly = true;
			this.colLocal.Visible = false;
			// 
			// colLeitor
			// 
			this.colLeitor.HeaderText = "Leitor";
			this.colLeitor.MinimumWidth = 6;
			this.colLeitor.Name = "colLeitor";
			this.colLeitor.ReadOnly = true;
			this.colLeitor.Visible = false;
			// 
			// colTipoItem
			// 
			this.colTipoItem.HeaderText = "TipoItem";
			this.colTipoItem.MinimumWidth = 6;
			this.colTipoItem.Name = "colTipoItem";
			this.colTipoItem.ReadOnly = true;
			this.colTipoItem.Visible = false;
			// 
			// colSecao
			// 
			this.colSecao.HeaderText = "Seção";
			this.colSecao.MinimumWidth = 6;
			this.colSecao.Name = "colSecao";
			this.colSecao.ReadOnly = true;
			this.colSecao.Visible = false;
			// 
			// FrmConsultarEmprestimo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 592);
			this.Controls.Add(this.gridLayout);
			this.Controls.Add(this.groupBox2);
			this.Name = "FrmConsultarEmprestimo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultar Emprestimo";
			this.Load += new System.EventHandler(this.FrmConsultarEmprestimo_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblDataFim;
		private System.Windows.Forms.Label lblDataInicio;
		private System.Windows.Forms.DateTimePicker dtpDataFim;
		private System.Windows.Forms.DateTimePicker dtpDataInicio;
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSelecionarAutor;
		private System.Windows.Forms.Button btnSelecionarLeitor;
		private System.Windows.Forms.Button btnSelecionarSecao;
		private System.Windows.Forms.TextBox txtSecao;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.Label lblSecao;
		private System.Windows.Forms.Label lblAutor;
		private System.Windows.Forms.TextBox txtLeitor;
		private System.Windows.Forms.Button btnSelecionarLocal;
		private System.Windows.Forms.Button btnSelecionarItem;
		private System.Windows.Forms.ComboBox cmbTipoItem;
		private System.Windows.Forms.Label lblItem;
		private System.Windows.Forms.Label lblLeitor;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.Label lblTipoItem;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.TextBox txtLocal;
		private System.Windows.Forms.ComboBox cmbSituacao;
		private System.Windows.Forms.Label lblLocal;
		private System.Windows.Forms.Label lblCodigoItem;
		private System.Windows.Forms.TextBox txtCodigoItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataReserva;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataRetorno;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLeitor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
	}
}

