namespace MegaDesk_Rasmussen
{
    partial class SearchQuotes
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
            Label Title;
            lblMaterialSearch = new Label();
            cmbMaterialSearch = new ComboBox();
            btnMaterialSearch = new Button();
            listViewMaterialSearchResults = new ListView();
            customerName = new ColumnHeader();
            quoteDate = new ColumnHeader();
            material = new ColumnHeader();
            price = new ColumnHeader();
            lblMatrialSearchResults = new Label();
            btnBackToMain = new Button();
            Title = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Navy;
            Title.Location = new Point(316, 43);
            Title.Name = "Title";
            Title.Size = new Size(157, 48);
            Title.TabIndex = 0;
            Title.Text = "Search";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaterialSearch
            // 
            lblMaterialSearch.AutoSize = true;
            lblMaterialSearch.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterialSearch.ForeColor = Color.FromArgb(64, 0, 64);
            lblMaterialSearch.Location = new Point(147, 161);
            lblMaterialSearch.Name = "lblMaterialSearch";
            lblMaterialSearch.Size = new Size(149, 34);
            lblMaterialSearch.TabIndex = 1;
            lblMaterialSearch.Text = "Material: ";
            lblMaterialSearch.Click += label1_Click;
            // 
            // cmbMaterialSearch
            // 
            cmbMaterialSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMaterialSearch.FormattingEnabled = true;
            cmbMaterialSearch.Location = new Point(504, 165);
            cmbMaterialSearch.Name = "cmbMaterialSearch";
            cmbMaterialSearch.Size = new Size(151, 32);
            cmbMaterialSearch.TabIndex = 2;
            cmbMaterialSearch.SelectedIndexChanged += cmbMaterialSearch_SelectedIndexChanged;
            // 
            // btnMaterialSearch
            // 
            btnMaterialSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnMaterialSearch.FlatAppearance.BorderColor = Color.Black;
            btnMaterialSearch.FlatAppearance.BorderSize = 2;
            btnMaterialSearch.FlatStyle = FlatStyle.Popup;
            btnMaterialSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaterialSearch.ForeColor = Color.Black;
            btnMaterialSearch.Location = new Point(335, 258);
            btnMaterialSearch.Name = "btnMaterialSearch";
            btnMaterialSearch.Size = new Size(124, 29);
            btnMaterialSearch.TabIndex = 3;
            btnMaterialSearch.Text = "Get Quotes";
            btnMaterialSearch.UseVisualStyleBackColor = false;
            btnMaterialSearch.Click += btnMaterialSearch_Click;
            // 
            // listViewMaterialSearchResults
            // 
            listViewMaterialSearchResults.Columns.AddRange(new ColumnHeader[] { customerName, quoteDate, material, price });
            listViewMaterialSearchResults.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewMaterialSearchResults.ForeColor = Color.FromArgb(0, 64, 64);
            listViewMaterialSearchResults.Location = new Point(147, 401);
            listViewMaterialSearchResults.Name = "listViewMaterialSearchResults";
            listViewMaterialSearchResults.Size = new Size(508, 147);
            listViewMaterialSearchResults.TabIndex = 4;
            listViewMaterialSearchResults.UseCompatibleStateImageBehavior = false;
            // 
            // customerName
            // 
            customerName.Text = "Customer Name";
            // 
            // quoteDate
            // 
            quoteDate.Text = "QuoteDate";
            // 
            // material
            // 
            material.Text = "Material";
            // 
            // price
            // 
            price.Text = "Total Price";
            // 
            // lblMatrialSearchResults
            // 
            lblMatrialSearchResults.AutoSize = true;
            lblMatrialSearchResults.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatrialSearchResults.ForeColor = Color.Navy;
            lblMatrialSearchResults.Location = new Point(356, 352);
            lblMatrialSearchResults.Name = "lblMatrialSearchResults";
            lblMatrialSearchResults.Size = new Size(81, 24);
            lblMatrialSearchResults.TabIndex = 5;
            lblMatrialSearchResults.Text = "Results:";
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.FromArgb(255, 128, 128);
            btnBackToMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackToMain.ForeColor = Color.White;
            btnBackToMain.Location = new Point(32, 589);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(122, 41);
            btnBackToMain.TabIndex = 6;
            btnBackToMain.Text = "Main Menu";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(btnBackToMain);
            Controls.Add(lblMatrialSearchResults);
            Controls.Add(listViewMaterialSearchResults);
            Controls.Add(btnMaterialSearch);
            Controls.Add(cmbMaterialSearch);
            Controls.Add(lblMaterialSearch);
            Controls.Add(Title);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchQuotes";
            Text = "SearchQuotes";
            Load += SearchQuotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lblMaterialSearch;
        private ComboBox cmbMaterialSearch;
        private Button btnMaterialSearch;
        private ListView listViewMaterialSearchResults;
        private Label lblMatrialSearchResults;
        private ColumnHeader customerName;
        private ColumnHeader quoteDate;
        private ColumnHeader material;
        private ColumnHeader price;
        private Button btnBackToMain;
    }
}