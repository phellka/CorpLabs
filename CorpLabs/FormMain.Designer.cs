
namespace CorpLabs
{
    partial class FormMain
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
            this.madyshevListBox = new MadyshevVisualComponents.MadyshevListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGetSelected = new System.Windows.Forms.Button();
            this.buttonSetSelected = new System.Windows.Forms.Button();
            this.textBoxSelectedItem = new System.Windows.Forms.TextBox();
            this.madyshevTextBox = new MadyshevVisualComponents.MadyshevTextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.madyshevDataGridView = new MadyshevVisualComponents.MadyshevDataGridView();
            this.buttonClearGrid = new System.Windows.Forms.Button();
            this.buttonGriSelectedObjectGrid = new System.Windows.Forms.Button();
            this.buttonSetSelectedIndexGrid = new System.Windows.Forms.Button();
            this.buttonGetSelectedIndexGrid = new System.Windows.Forms.Button();
            this.numericUpDownSelectedIndexGrid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedIndexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // madyshevListBox
            // 
            this.madyshevListBox.ListBoxValue = "";
            this.madyshevListBox.Location = new System.Drawing.Point(12, 12);
            this.madyshevListBox.Name = "madyshevListBox";
            this.madyshevListBox.Size = new System.Drawing.Size(188, 72);
            this.madyshevListBox.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 90);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonGetSelected
            // 
            this.buttonGetSelected.Location = new System.Drawing.Point(114, 90);
            this.buttonGetSelected.Name = "buttonGetSelected";
            this.buttonGetSelected.Size = new System.Drawing.Size(86, 23);
            this.buttonGetSelected.TabIndex = 2;
            this.buttonGetSelected.Text = "Get Selected";
            this.buttonGetSelected.UseVisualStyleBackColor = true;
            this.buttonGetSelected.Click += new System.EventHandler(this.buttonGetSelected_Click);
            // 
            // buttonSetSelected
            // 
            this.buttonSetSelected.Location = new System.Drawing.Point(114, 133);
            this.buttonSetSelected.Name = "buttonSetSelected";
            this.buttonSetSelected.Size = new System.Drawing.Size(86, 23);
            this.buttonSetSelected.TabIndex = 4;
            this.buttonSetSelected.Text = "Set Selected";
            this.buttonSetSelected.UseVisualStyleBackColor = true;
            this.buttonSetSelected.Click += new System.EventHandler(this.buttonSetSelected_Click);
            // 
            // textBoxSelectedItem
            // 
            this.textBoxSelectedItem.Location = new System.Drawing.Point(12, 134);
            this.textBoxSelectedItem.Name = "textBoxSelectedItem";
            this.textBoxSelectedItem.Size = new System.Drawing.Size(75, 23);
            this.textBoxSelectedItem.TabIndex = 5;
            // 
            // madyshevTextBox
            // 
            this.madyshevTextBox.Location = new System.Drawing.Point(263, 12);
            this.madyshevTextBox.Name = "madyshevTextBox";
            this.madyshevTextBox.Size = new System.Drawing.Size(150, 44);
            this.madyshevTextBox.TabIndex = 6;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(287, 61);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(86, 23);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // madyshevDataGridView
            // 
            this.madyshevDataGridView.DataGridSelectedRow = -1;
            this.madyshevDataGridView.Location = new System.Drawing.Point(451, 12);
            this.madyshevDataGridView.Name = "madyshevDataGridView";
            this.madyshevDataGridView.Size = new System.Drawing.Size(337, 225);
            this.madyshevDataGridView.TabIndex = 8;
            // 
            // buttonClearGrid
            // 
            this.buttonClearGrid.Location = new System.Drawing.Point(451, 258);
            this.buttonClearGrid.Name = "buttonClearGrid";
            this.buttonClearGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonClearGrid.TabIndex = 9;
            this.buttonClearGrid.Text = "Clear";
            this.buttonClearGrid.UseVisualStyleBackColor = true;
            this.buttonClearGrid.Click += new System.EventHandler(this.buttonClearGrid_Click);
            // 
            // buttonGriSelectedObjectGrid
            // 
            this.buttonGriSelectedObjectGrid.Location = new System.Drawing.Point(653, 258);
            this.buttonGriSelectedObjectGrid.Name = "buttonGriSelectedObjectGrid";
            this.buttonGriSelectedObjectGrid.Size = new System.Drawing.Size(135, 23);
            this.buttonGriSelectedObjectGrid.TabIndex = 10;
            this.buttonGriSelectedObjectGrid.Text = "Get Selected Object";
            this.buttonGriSelectedObjectGrid.UseVisualStyleBackColor = true;
            this.buttonGriSelectedObjectGrid.Click += new System.EventHandler(this.buttonGriSelectedObjectGrid_Click);
            // 
            // buttonSetSelectedIndexGrid
            // 
            this.buttonSetSelectedIndexGrid.Location = new System.Drawing.Point(542, 299);
            this.buttonSetSelectedIndexGrid.Name = "buttonSetSelectedIndexGrid";
            this.buttonSetSelectedIndexGrid.Size = new System.Drawing.Size(96, 23);
            this.buttonSetSelectedIndexGrid.TabIndex = 11;
            this.buttonSetSelectedIndexGrid.Text = "Set Selected";
            this.buttonSetSelectedIndexGrid.UseVisualStyleBackColor = true;
            this.buttonSetSelectedIndexGrid.Click += new System.EventHandler(this.buttonSetSelectedIndexGrid_Click);
            // 
            // buttonGetSelectedIndexGrid
            // 
            this.buttonGetSelectedIndexGrid.Location = new System.Drawing.Point(542, 258);
            this.buttonGetSelectedIndexGrid.Name = "buttonGetSelectedIndexGrid";
            this.buttonGetSelectedIndexGrid.Size = new System.Drawing.Size(96, 23);
            this.buttonGetSelectedIndexGrid.TabIndex = 12;
            this.buttonGetSelectedIndexGrid.Text = "Get Selected";
            this.buttonGetSelectedIndexGrid.UseVisualStyleBackColor = true;
            this.buttonGetSelectedIndexGrid.Click += new System.EventHandler(this.buttonGetSelectedIndexGrid_Click);
            // 
            // numericUpDownSelectedIndexGrid
            // 
            this.numericUpDownSelectedIndexGrid.Location = new System.Drawing.Point(451, 298);
            this.numericUpDownSelectedIndexGrid.Name = "numericUpDownSelectedIndexGrid";
            this.numericUpDownSelectedIndexGrid.Size = new System.Drawing.Size(75, 23);
            this.numericUpDownSelectedIndexGrid.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownSelectedIndexGrid);
            this.Controls.Add(this.buttonGetSelectedIndexGrid);
            this.Controls.Add(this.buttonSetSelectedIndexGrid);
            this.Controls.Add(this.buttonGriSelectedObjectGrid);
            this.Controls.Add(this.buttonClearGrid);
            this.Controls.Add(this.madyshevDataGridView);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.madyshevTextBox);
            this.Controls.Add(this.textBoxSelectedItem);
            this.Controls.Add(this.buttonSetSelected);
            this.Controls.Add(this.buttonGetSelected);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.madyshevListBox);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedIndexGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MadyshevVisualComponents.MadyshevListBox madyshevListBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGetSelected;
        private System.Windows.Forms.Button buttonSetSelected;
        private System.Windows.Forms.TextBox textBoxSelectedItem;
        private MadyshevVisualComponents.MadyshevTextBox madyshevTextBox;
        private System.Windows.Forms.Button buttonEnter;
        private MadyshevVisualComponents.MadyshevDataGridView madyshevDataGridView;
        private System.Windows.Forms.Button buttonClearGrid;
        private System.Windows.Forms.Button buttonGriSelectedObjectGrid;
        private System.Windows.Forms.Button buttonSetSelectedIndexGrid;
        private System.Windows.Forms.Button buttonGetSelectedIndexGrid;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedIndexGrid;
    }
}

