namespace StrategyModel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_num = new System.Windows.Forms.TextBox();
            this.calculate_method = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.goodsList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单　　价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数　　量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "计算方式";
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(71, 6);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(171, 21);
            this.text_price.TabIndex = 3;
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(71, 32);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(171, 21);
            this.text_num.TabIndex = 4;
            // 
            // calculate_method
            // 
            this.calculate_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculate_method.FormattingEnabled = true;
            this.calculate_method.Location = new System.Drawing.Point(71, 58);
            this.calculate_method.Name = "calculate_method";
            this.calculate_method.Size = new System.Drawing.Size(171, 20);
            this.calculate_method.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(248, 4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "确　　定";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(248, 30);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "重　　置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // goodsList
            // 
            this.goodsList.FormattingEnabled = true;
            this.goodsList.ItemHeight = 12;
            this.goodsList.Location = new System.Drawing.Point(12, 84);
            this.goodsList.Name = "goodsList";
            this.goodsList.Size = new System.Drawing.Size(311, 88);
            this.goodsList.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "总　　计";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("宋体", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result.Location = new System.Drawing.Point(71, 175);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 67);
            this.label_result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 241);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goodsList);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.calculate_method);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "商城收银软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.ComboBox calculate_method;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ListBox goodsList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_result;
    }
}

