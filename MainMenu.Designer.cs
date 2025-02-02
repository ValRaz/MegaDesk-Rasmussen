namespace MegaDesk_Rasmussen
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addQuoteBtn = new Button();
            searchQuotesBtn = new Button();
            button2 = new Button();
            viewAllQuotesBtn = new Button();
            exitBtn = new Button();
            menuTitle = new Label();
            SuspendLayout();
            // 
            // addQuoteBtn
            // 
            addQuoteBtn.BackColor = Color.FromArgb(192, 255, 255);
            addQuoteBtn.FlatAppearance.BorderColor = Color.Black;
            addQuoteBtn.FlatAppearance.BorderSize = 2;
            addQuoteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            addQuoteBtn.FlatStyle = FlatStyle.Popup;
            addQuoteBtn.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addQuoteBtn.Location = new Point(92, 186);
            addQuoteBtn.Name = "addQuoteBtn";
            addQuoteBtn.Size = new Size(166, 92);
            addQuoteBtn.TabIndex = 0;
            addQuoteBtn.Text = "Add Quote";
            addQuoteBtn.UseVisualStyleBackColor = false;
            addQuoteBtn.Click += addQuoteBtn_Click;
            // 
            // searchQuotesBtn
            // 
            searchQuotesBtn.BackColor = Color.FromArgb(192, 255, 255);
            searchQuotesBtn.FlatAppearance.BorderColor = Color.Black;
            searchQuotesBtn.FlatAppearance.BorderSize = 2;
            searchQuotesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            searchQuotesBtn.FlatStyle = FlatStyle.Popup;
            searchQuotesBtn.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchQuotesBtn.Location = new Point(312, 186);
            searchQuotesBtn.Name = "searchQuotesBtn";
            searchQuotesBtn.Size = new Size(171, 92);
            searchQuotesBtn.TabIndex = 1;
            searchQuotesBtn.Text = "Search Quotes";
            searchQuotesBtn.UseVisualStyleBackColor = false;
            searchQuotesBtn.Click += searchQuotesBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 172);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // viewAllQuotesBtn
            // 
            viewAllQuotesBtn.BackColor = Color.FromArgb(192, 255, 255);
            viewAllQuotesBtn.FlatAppearance.BorderColor = Color.Black;
            viewAllQuotesBtn.FlatAppearance.BorderSize = 2;
            viewAllQuotesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            viewAllQuotesBtn.FlatStyle = FlatStyle.Popup;
            viewAllQuotesBtn.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAllQuotesBtn.Location = new Point(536, 186);
            viewAllQuotesBtn.Name = "viewAllQuotesBtn";
            viewAllQuotesBtn.Size = new Size(171, 92);
            viewAllQuotesBtn.TabIndex = 3;
            viewAllQuotesBtn.Text = "View All";
            viewAllQuotesBtn.UseVisualStyleBackColor = false;
            viewAllQuotesBtn.Click += viewAllQuotesBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 128, 128);
            exitBtn.FlatAppearance.BorderColor = Color.Black;
            exitBtn.FlatAppearance.BorderSize = 2;
            exitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(601, 360);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(161, 55);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // menuTitle
            // 
            menuTitle.AutoSize = true;
            menuTitle.BackColor = Color.White;
            menuTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuTitle.ForeColor = Color.FromArgb(0, 0, 192);
            menuTitle.Location = new Point(323, 43);
            menuTitle.Name = "menuTitle";
            menuTitle.Size = new Size(145, 60);
            menuTitle.TabIndex = 5;
            menuTitle.Text = "Menu";
            menuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuTitle);
            Controls.Add(exitBtn);
            Controls.Add(viewAllQuotesBtn);
            Controls.Add(button2);
            Controls.Add(searchQuotesBtn);
            Controls.Add(addQuoteBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addQuoteBtn;
        private Button searchQuotesBtn;
        private Button button2;
        private Button viewAllQuotesBtn;
        private Button exitBtn;
        private Label menuTitle;
    }
}
