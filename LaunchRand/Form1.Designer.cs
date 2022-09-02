namespace LaunchRand
{
    partial class Form1
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
            this.btnRand = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listbInput = new System.Windows.Forms.ListBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(584, 357);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(99, 33);
            this.btnRand.TabIndex = 0;
            this.btnRand.Text = "Rand";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(453, 164);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(230, 172);
            this.listBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listbInput.FormattingEnabled = true;
            this.listbInput.ItemHeight = 12;
            this.listbInput.Location = new System.Drawing.Point(153, 164);
            this.listbInput.Name = "listBox1";
            this.listbInput.Size = new System.Drawing.Size(207, 172);
            this.listbInput.TabIndex = 2;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(259, 121);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(101, 22);
            this.tbAdd.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(388, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.listbInput);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnRand);
            this.Name = "Form1";
            this.Text = "午餐";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listbInput;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

