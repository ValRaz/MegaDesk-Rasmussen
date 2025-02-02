namespace MegaDesk_Rasmussen
{
    partial class AddQuote
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
            components = new System.ComponentModel.Container();
            lblWidth = new Label();
            lblDepth = new Label();
            numNumDrawers = new NumericUpDown();
            cmbMaterial = new ComboBox();
            btnGetQuote = new Button();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblRushOrder = new Label();
            lblMaterial = new Label();
            lblnumDrawers = new Label();
            errorProvider1 = new ErrorProvider(components);
            backToMainMenu = new Button();
            numWidth = new NumericUpDown();
            numDepth = new NumericUpDown();
            numRushOrder = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numNumDrawers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRushOrder).BeginInit();
            SuspendLayout();
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblWidth.ForeColor = Color.Navy;
            lblWidth.Location = new Point(133, 249);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(119, 21);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Desk Width :";
            // 
            // lblDepth
            // 
            lblDepth.AutoSize = true;
            lblDepth.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblDepth.ForeColor = Color.Navy;
            lblDepth.Location = new Point(133, 295);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(125, 21);
            lblDepth.TabIndex = 1;
            lblDepth.Text = "Desk Depth : ";
            // 
            // numNumDrawers
            // 
            numNumDrawers.Location = new Point(633, 192);
            numNumDrawers.Name = "numNumDrawers";
            numNumDrawers.Size = new Size(41, 27);
            numNumDrawers.TabIndex = 2;
            // 
            // cmbMaterial
            // 
            cmbMaterial.FormattingEnabled = true;
            cmbMaterial.Location = new Point(523, 144);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(151, 28);
            cmbMaterial.TabIndex = 3;
            // 
            // btnGetQuote
            // 
            btnGetQuote.BackColor = Color.FromArgb(192, 255, 255);
            btnGetQuote.FlatAppearance.BorderColor = Color.Black;
            btnGetQuote.FlatAppearance.BorderSize = 2;
            btnGetQuote.FlatStyle = FlatStyle.Popup;
            btnGetQuote.Font = new Font("Tahoma", 12F);
            btnGetQuote.Location = new Point(325, 373);
            btnGetQuote.Name = "btnGetQuote";
            btnGetQuote.Size = new Size(143, 35);
            btnGetQuote.TabIndex = 5;
            btnGetQuote.Text = "Get Quote";
            btnGetQuote.UseVisualStyleBackColor = false;
            btnGetQuote.Click += btnGetQuote_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.Navy;
            lblCustomerName.Location = new Point(95, 58);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(157, 21);
            lblCustomerName.TabIndex = 6;
            lblCustomerName.Text = "Customer Name :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(523, 52);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(151, 27);
            txtCustomerName.TabIndex = 7;
            // 
            // lblRushOrder
            // 
            lblRushOrder.AutoSize = true;
            lblRushOrder.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblRushOrder.ForeColor = Color.Navy;
            lblRushOrder.Location = new Point(135, 106);
            lblRushOrder.Name = "lblRushOrder";
            lblRushOrder.Size = new Size(117, 21);
            lblRushOrder.TabIndex = 8;
            lblRushOrder.Text = "Rush Order :";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblMaterial.ForeColor = Color.Navy;
            lblMaterial.Location = new Point(162, 151);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(90, 21);
            lblMaterial.TabIndex = 9;
            lblMaterial.Text = "Material :";
            // 
            // lblnumDrawers
            // 
            lblnumDrawers.AutoSize = true;
            lblnumDrawers.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblnumDrawers.ForeColor = Color.Navy;
            lblnumDrawers.Location = new Point(64, 198);
            lblnumDrawers.Name = "lblnumDrawers";
            lblnumDrawers.Size = new Size(188, 21);
            lblnumDrawers.TabIndex = 10;
            lblnumDrawers.Text = "Number of Drawers :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // backToMainMenu
            // 
            backToMainMenu.BackColor = Color.FromArgb(255, 128, 128);
            backToMainMenu.FlatAppearance.BorderColor = Color.Black;
            backToMainMenu.FlatAppearance.BorderSize = 2;
            backToMainMenu.FlatStyle = FlatStyle.Popup;
            backToMainMenu.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToMainMenu.ForeColor = Color.White;
            backToMainMenu.Location = new Point(682, 409);
            backToMainMenu.Name = "backToMainMenu";
            backToMainMenu.Size = new Size(106, 29);
            backToMainMenu.TabIndex = 13;
            backToMainMenu.Text = "Main Menu";
            backToMainMenu.UseVisualStyleBackColor = false;
            backToMainMenu.Click += backToMainMenu_Click;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(601, 243);
            numWidth.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            numWidth.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(73, 27);
            numWidth.TabIndex = 14;
            numWidth.Value = new decimal(new int[] { 24, 0, 0, 0 });
            numWidth.Validating += numWidth_Validating;
            // 
            // numDepth
            // 
            numDepth.Location = new Point(601, 289);
            numDepth.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            numDepth.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            numDepth.Name = "numDepth";
            numDepth.Size = new Size(72, 27);
            numDepth.TabIndex = 15;
            numDepth.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numDepth.KeyPress += numDepth_KeyPress;
            // 
            // numRushOrder
            // 
            numRushOrder.Location = new Point(601, 100);
            numRushOrder.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numRushOrder.Name = "numRushOrder";
            numRushOrder.Size = new Size(73, 27);
            numRushOrder.TabIndex = 16;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numRushOrder);
            Controls.Add(numDepth);
            Controls.Add(numWidth);
            Controls.Add(backToMainMenu);
            Controls.Add(lblnumDrawers);
            Controls.Add(lblMaterial);
            Controls.Add(lblRushOrder);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(btnGetQuote);
            Controls.Add(cmbMaterial);
            Controls.Add(numNumDrawers);
            Controls.Add(lblDepth);
            Controls.Add(lblWidth);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddQuote";
            Text = "Add Quote";
            Load += AddQuote_Load;
            ((System.ComponentModel.ISupportInitialize)numNumDrawers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRushOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWidth;
        private Label lblDepth;
        private NumericUpDown numNumDrawers;
        private ComboBox cmbMaterial;
        private ComboBox cmbRushOrder;
        private Button btnGetQuote;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblRushOrder;
        private Label lblMaterial;
        private Label lblnumDrawers;
        private ErrorProvider errorProvider1;
        private Button backToMainMenu;
        private NumericUpDown numWidth;
        private NumericUpDown numRushOrder;
        private NumericUpDown numDepth;
    }
}