
namespace ExcelToCsvUtf8Converter
{
    partial class MainForm
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
            this.buttonStartConvert = new System.Windows.Forms.Button();
            this.textBoxFileDirector = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartConvert
            // 
            this.buttonStartConvert.Location = new System.Drawing.Point(396, 48);
            this.buttonStartConvert.Name = "buttonStartConvert";
            this.buttonStartConvert.Size = new System.Drawing.Size(106, 29);
            this.buttonStartConvert.TabIndex = 0;
            this.buttonStartConvert.Text = "轉換";
            this.buttonStartConvert.UseVisualStyleBackColor = true;
            this.buttonStartConvert.Click += new System.EventHandler(this.buttonStartConvert_Click);
            // 
            // textBoxFileDirector
            // 
            this.textBoxFileDirector.Location = new System.Drawing.Point(13, 13);
            this.textBoxFileDirector.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileDirector.Name = "textBoxFileDirector";
            this.textBoxFileDirector.Size = new System.Drawing.Size(376, 25);
            this.textBoxFileDirector.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(396, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(106, 29);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "開啟";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 89);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFileDirector);
            this.Controls.Add(this.buttonStartConvert);
            this.Name = "MainForm";
            this.Text = "ExcelToCsvUtf8Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartConvert;
        private System.Windows.Forms.TextBox textBoxFileDirector;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}

