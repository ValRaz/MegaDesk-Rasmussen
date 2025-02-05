namespace MegaDesk_Rasmussen
{
    partial class ViewAllQuotes
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
            dataViewAll = new DataGridView();
            lblViewAll = new Label();
            btnLoadQuotes = new Button();
            btnBackToMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dataViewAll).BeginInit();
            SuspendLayout();
            // 
            // dataViewAll
            // 
            dataViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewAll.Location = new Point(78, 127);
            dataViewAll.Name = "dataViewAll";
            dataViewAll.RowHeadersWidth = 51;
            dataViewAll.Size = new Size(644, 276);
            dataViewAll.TabIndex = 0;
            // 
            // lblViewAll
            // 
            lblViewAll.AutoSize = true;
            lblViewAll.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAll.ForeColor = Color.Navy;
            lblViewAll.Location = new Point(308, 22);
            lblViewAll.Name = "lblViewAll";
            lblViewAll.Size = new Size(164, 48);
            lblViewAll.TabIndex = 1;
            lblViewAll.Text = "Quotes";
            // 
            // btnLoadQuotes
            // 
            btnLoadQuotes.BackColor = Color.FromArgb(192, 255, 255);
            btnLoadQuotes.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadQuotes.Location = new Point(78, 73);
            btnLoadQuotes.Name = "btnLoadQuotes";
            btnLoadQuotes.Size = new Size(108, 33);
            btnLoadQuotes.TabIndex = 2;
            btnLoadQuotes.Text = "Show All";
            btnLoadQuotes.UseVisualStyleBackColor = false;
            btnLoadQuotes.Click += btnLoadQuotes_Click;
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.FromArgb(255, 128, 128);
            btnBackToMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackToMain.ForeColor = Color.White;
            btnBackToMain.Location = new Point(620, 73);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(102, 33);
            btnBackToMain.TabIndex = 3;
            btnBackToMain.Text = "Main Menu";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackToMain);
            Controls.Add(btnLoadQuotes);
            Controls.Add(lblViewAll);
            Controls.Add(dataViewAll);
            Name = "ViewAllQuotes";
            Text = "ViewAllQuotes";
            Load += ViewAllQuotes_Load;
            ((System.ComponentModel.ISupportInitialize)dataViewAll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewAll;
        private Label lblViewAll;
        private Button btnLoadQuotes;
        private Button btnBackToMain;
    }
}