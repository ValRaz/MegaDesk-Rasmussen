﻿namespace MegaDesk_Rasmussen
{
    partial class DisplayQuote
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
            lblQuoteDate = new Label();
            lblCustomerName = new Label();
            lblWidth = new Label();
            lblMaterial = new Label();
            lblRushOrder = new Label();
            lblTotal = new Label();
            btnClose = new Button();
            lblDepth = new Label();
            lblDrawers = new Label();
            SuspendLayout();
            // 
            // lblQuoteDate
            // 
            lblQuoteDate.AutoSize = true;
            lblQuoteDate.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuoteDate.ForeColor = Color.Navy;
            lblQuoteDate.Location = new Point(287, 40);
            lblQuoteDate.Name = "lblQuoteDate";
            lblQuoteDate.Size = new Size(145, 28);
            lblQuoteDate.TabIndex = 0;
            lblQuoteDate.Text = "Quote Date";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Navy;
            lblCustomerName.Location = new Point(232, 85);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(247, 28);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer: First Last";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWidth.Location = new Point(123, 162);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(75, 24);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width: ";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterial.Location = new Point(503, 162);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(95, 24);
            lblMaterial.TabIndex = 3;
            lblMaterial.Text = "Material: ";
            // 
            // lblRushOrder
            // 
            lblRushOrder.AutoSize = true;
            lblRushOrder.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRushOrder.Location = new Point(503, 211);
            lblRushOrder.Name = "lblRushOrder";
            lblRushOrder.Size = new Size(122, 24);
            lblRushOrder.TabIndex = 4;
            lblRushOrder.Text = "Rush Order: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Purple;
            lblTotal.Location = new Point(355, 351);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 34);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: ";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(694, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblDepth
            // 
            lblDepth.AutoSize = true;
            lblDepth.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepth.Location = new Point(123, 211);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(77, 24);
            lblDepth.TabIndex = 7;
            lblDepth.Text = "Depth: ";
            // 
            // lblDrawers
            // 
            lblDrawers.AutoSize = true;
            lblDrawers.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDrawers.Location = new Point(296, 246);
            lblDrawers.Name = "lblDrawers";
            lblDrawers.Size = new Size(91, 24);
            lblDrawers.TabIndex = 8;
            lblDrawers.Text = "Drawers:";
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDrawers);
            Controls.Add(lblDepth);
            Controls.Add(btnClose);
            Controls.Add(lblTotal);
            Controls.Add(lblRushOrder);
            Controls.Add(lblMaterial);
            Controls.Add(lblWidth);
            Controls.Add(lblCustomerName);
            Controls.Add(lblQuoteDate);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayQuote";
            Text = "DisplayQuote";
            Load += DisplayQuote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuoteDate;
        private Label lblCustomerName;
        private Label lblWidth;
        private Label lblMaterial;
        private Label lblRushOrder;
        private Label lblTotal;
        private Button btnClose;
        private Label lblDepth;
        private Label lblDrawers;
    }
}