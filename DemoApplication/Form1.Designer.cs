
namespace DemoApplication
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.BarCodeFileName = new System.Windows.Forms.TextBox();
            this.txtStatusBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.countriesDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enviroment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1222, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.BarCodeFileName);
            this.tabPage1.Controls.Add(this.txtStatusBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.countriesDropdown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.enviroment);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1214, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Barcode Range Item Import";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(734, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BarCodeFileName
            // 
            this.BarCodeFileName.Location = new System.Drawing.Point(393, 237);
            this.BarCodeFileName.Name = "BarCodeFileName";
            this.BarCodeFileName.Size = new System.Drawing.Size(310, 22);
            this.BarCodeFileName.TabIndex = 8;
            // 
            // txtStatusBox
            // 
            this.txtStatusBox.Location = new System.Drawing.Point(148, 425);
            this.txtStatusBox.Name = "txtStatusBox";
            this.txtStatusBox.Size = new System.Drawing.Size(915, 122);
            this.txtStatusBox.TabIndex = 7;
            this.txtStatusBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.LightGray;
            this.btnImport.Location = new System.Drawing.Point(148, 339);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 35);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barcode Range Item Import File :";
            // 
            // countriesDropdown
            // 
            this.countriesDropdown.FormattingEnabled = true;
            this.countriesDropdown.Location = new System.Drawing.Point(393, 188);
            this.countriesDropdown.Name = "countriesDropdown";
            this.countriesDropdown.Size = new System.Drawing.Size(211, 24);
            this.countriesDropdown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country Code :";
            // 
            // enviroment
            // 
            this.enviroment.FormattingEnabled = true;
            this.enviroment.Items.AddRange(new object[] {
            "environments"});
            this.enviroment.Location = new System.Drawing.Point(393, 143);
            this.enviroment.Name = "enviroment";
            this.enviroment.Size = new System.Drawing.Size(211, 24);
            this.enviroment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviroment :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 640);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Online Support Client";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox enviroment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox countriesDropdown;
        private System.Windows.Forms.RichTextBox txtStatusBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox BarCodeFileName;
    }
}

