using System.Windows.Forms;

namespace Parser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartIndexNumber = new System.Windows.Forms.NumericUpDown();
            this.StartEndNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartIndexNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartEndNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 18;
            this.ListBox.Location = new System.Drawing.Point(13, 13);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(582, 418);
            this.ListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(625, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Index";
            // 
            // StartIndexNumber
            // 
            this.StartIndexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartIndexNumber.Location = new System.Drawing.Point(630, 58);
            this.StartIndexNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartIndexNumber.Name = "StartIndexNumber";
            this.StartIndexNumber.Size = new System.Drawing.Size(132, 24);
            this.StartIndexNumber.TabIndex = 2;
            this.StartIndexNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartIndexNumber.ValueChanged += new System.EventHandler(this.StartIndexNumber_ValueChanged);
            // 
            // StartEndNumber
            // 
            this.StartEndNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartEndNumber.Location = new System.Drawing.Point(630, 130);
            this.StartEndNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.StartEndNumber.Name = "StartEndNumber";
            this.StartEndNumber.Size = new System.Drawing.Size(132, 24);
            this.StartEndNumber.TabIndex = 4;
            this.StartEndNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.StartEndNumber.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(625, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Index";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(630, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Parsing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(630, 203);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(132, 22);
            this.link.TabIndex = 6;
            this.link.Text = "https://habr.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(626, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(626, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(630, 261);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(132, 22);
            this.Class.TabIndex = 8;
            this.Class.Text = "post__title_link";
            this.Class.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartEndNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartIndexNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UltraParser3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyEventHandler);
            ((System.ComponentModel.ISupportInitialize)(this.StartIndexNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartEndNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StartIndexNumber;
        private System.Windows.Forms.NumericUpDown StartEndNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Class;
    }
}

