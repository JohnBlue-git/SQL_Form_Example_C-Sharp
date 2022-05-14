namespace SQL_Form_Example
{
    partial class Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(48, 43);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 35;
            this.DataGrid.Size = new System.Drawing.Size(486, 168);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Click += new System.EventHandler(this.Touch_Grid);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("新細明體", 18F);
            this.button.Location = new System.Drawing.Point(201, 321);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(189, 61);
            this.button.TabIndex = 1;
            this.button.Text = "ADD";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox.Location = new System.Drawing.Point(48, 242);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(486, 58);
            this.textBox.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 394);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox;
    }
}

