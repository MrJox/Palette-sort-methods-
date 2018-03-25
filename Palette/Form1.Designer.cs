namespace Palette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.delay1 = new System.Windows.Forms.RadioButton();
            this.delay0 = new System.Windows.Forms.RadioButton();
            this.delay10 = new System.Windows.Forms.RadioButton();
            this.delay100 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 105;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ((object)(resources.GetObject("comboBox1.Items"))),
            ((object)(resources.GetObject("comboBox1.Items1"))),
            ((object)(resources.GetObject("comboBox1.Items2"))),
            ((object)(resources.GetObject("comboBox1.Items3"))),
            ((object)(resources.GetObject("comboBox1.Items4"))),
            ((object)(resources.GetObject("comboBox1.Items5")))});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // delay1
            // 
            resources.ApplyResources(this.delay1, "delay1");
            this.delay1.Name = "delay1";
            this.delay1.UseVisualStyleBackColor = true;
            // 
            // delay0
            // 
            resources.ApplyResources(this.delay0, "delay0");
            this.delay0.Checked = true;
            this.delay0.Name = "delay0";
            this.delay0.TabStop = true;
            this.delay0.UseVisualStyleBackColor = true;
            this.delay0.CheckedChanged += new System.EventHandler(this.delay0_CheckedChanged);
            // 
            // delay10
            // 
            resources.ApplyResources(this.delay10, "delay10");
            this.delay10.Name = "delay10";
            this.delay10.UseVisualStyleBackColor = true;
            // 
            // delay100
            // 
            resources.ApplyResources(this.delay100, "delay100");
            this.delay100.Name = "delay100";
            this.delay100.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Name = "label2";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delay10);
            this.Controls.Add(this.delay100);
            this.Controls.Add(this.delay0);
            this.Controls.Add(this.delay1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton delay1;
        private System.Windows.Forms.RadioButton delay0;
        private System.Windows.Forms.RadioButton delay10;
        private System.Windows.Forms.RadioButton delay100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

