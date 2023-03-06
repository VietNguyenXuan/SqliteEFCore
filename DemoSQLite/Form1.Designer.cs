namespace DemoSQLite
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.txbMachine = new System.Windows.Forms.TextBox();
      this.btnMachine = new System.Windows.Forms.Button();
      this.dgvMachine = new System.Windows.Forms.DataGridView();
      this.dgvDevice = new System.Windows.Forms.DataGridView();
      this.btnDevice = new System.Windows.Forms.Button();
      this.txbDevice = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.dgvLine = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.txbLine = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.cbMachine = new System.Windows.Forms.ComboBox();
      this.cbLine = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.CbIdMachine = new System.Windows.Forms.ComboBox();
      this.btnDelMachine = new System.Windows.Forms.Button();
      this.btnDelLine = new System.Windows.Forms.Button();
      this.cbIdLine = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnDelDevice = new System.Windows.Forms.Button();
      this.cbIdDevice = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 3000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(417, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(151, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "Add Machine";
      // 
      // txbMachine
      // 
      this.txbMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txbMachine.Location = new System.Drawing.Point(567, 11);
      this.txbMachine.Name = "txbMachine";
      this.txbMachine.Size = new System.Drawing.Size(261, 38);
      this.txbMachine.TabIndex = 2;
      // 
      // btnMachine
      // 
      this.btnMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnMachine.Location = new System.Drawing.Point(725, 61);
      this.btnMachine.Name = "btnMachine";
      this.btnMachine.Size = new System.Drawing.Size(103, 35);
      this.btnMachine.TabIndex = 3;
      this.btnMachine.Text = "Add";
      this.btnMachine.UseVisualStyleBackColor = true;
      this.btnMachine.Click += new System.EventHandler(this.button1_Click);
      // 
      // dgvMachine
      // 
      this.dgvMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMachine.Location = new System.Drawing.Point(417, 185);
      this.dgvMachine.Name = "dgvMachine";
      this.dgvMachine.RowHeadersVisible = false;
      this.dgvMachine.RowHeadersWidth = 51;
      this.dgvMachine.RowTemplate.Height = 29;
      this.dgvMachine.Size = new System.Drawing.Size(411, 278);
      this.dgvMachine.TabIndex = 4;
      // 
      // dgvDevice
      // 
      this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDevice.Location = new System.Drawing.Point(850, 185);
      this.dgvDevice.Name = "dgvDevice";
      this.dgvDevice.RowHeadersVisible = false;
      this.dgvDevice.RowHeadersWidth = 51;
      this.dgvDevice.RowTemplate.Height = 29;
      this.dgvDevice.Size = new System.Drawing.Size(455, 278);
      this.dgvDevice.TabIndex = 8;
      // 
      // btnDevice
      // 
      this.btnDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnDevice.Location = new System.Drawing.Point(1171, 62);
      this.btnDevice.Name = "btnDevice";
      this.btnDevice.Size = new System.Drawing.Size(134, 38);
      this.btnDevice.TabIndex = 7;
      this.btnDevice.Text = "Add";
      this.btnDevice.UseVisualStyleBackColor = true;
      this.btnDevice.Click += new System.EventHandler(this.button2_Click);
      // 
      // txbDevice
      // 
      this.txbDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txbDevice.Location = new System.Drawing.Point(987, 11);
      this.txbDevice.Name = "txbDevice";
      this.txbDevice.Size = new System.Drawing.Size(318, 38);
      this.txbDevice.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(850, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(131, 31);
      this.label2.TabIndex = 5;
      this.label2.Text = "Add Device";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(850, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(128, 31);
      this.label3.TabIndex = 10;
      this.label3.Text = "Id Machine";
      // 
      // dgvLine
      // 
      this.dgvLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLine.Location = new System.Drawing.Point(14, 185);
      this.dgvLine.Name = "dgvLine";
      this.dgvLine.RowHeadersVisible = false;
      this.dgvLine.RowHeadersWidth = 51;
      this.dgvLine.RowTemplate.Height = 29;
      this.dgvLine.Size = new System.Drawing.Size(377, 278);
      this.dgvLine.TabIndex = 14;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.Location = new System.Drawing.Point(14, 58);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(377, 38);
      this.button1.TabIndex = 13;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // txbLine
      // 
      this.txbLine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txbLine.Location = new System.Drawing.Point(125, 11);
      this.txbLine.Name = "txbLine";
      this.txbLine.Size = new System.Drawing.Size(266, 38);
      this.txbLine.TabIndex = 12;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(14, 13);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(105, 31);
      this.label4.TabIndex = 11;
      this.label4.Text = "Add Line";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(417, 62);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 31);
      this.label5.TabIndex = 16;
      this.label5.Text = "Id Line";
      // 
      // cbMachine
      // 
      this.cbMachine.FormattingEnabled = true;
      this.cbMachine.Location = new System.Drawing.Point(987, 68);
      this.cbMachine.Name = "cbMachine";
      this.cbMachine.Size = new System.Drawing.Size(178, 28);
      this.cbMachine.TabIndex = 20;
      // 
      // cbLine
      // 
      this.cbLine.FormattingEnabled = true;
      this.cbLine.Location = new System.Drawing.Point(550, 65);
      this.cbLine.Name = "cbLine";
      this.cbLine.Size = new System.Drawing.Size(169, 28);
      this.cbLine.TabIndex = 21;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.Location = new System.Drawing.Point(417, 130);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(127, 31);
      this.label6.TabIndex = 22;
      this.label6.Text = "Id machine";
      // 
      // CbIdMachine
      // 
      this.CbIdMachine.FormattingEnabled = true;
      this.CbIdMachine.Location = new System.Drawing.Point(550, 132);
      this.CbIdMachine.Name = "CbIdMachine";
      this.CbIdMachine.Size = new System.Drawing.Size(169, 28);
      this.CbIdMachine.TabIndex = 23;
      // 
      // btnDelMachine
      // 
      this.btnDelMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnDelMachine.Location = new System.Drawing.Point(725, 126);
      this.btnDelMachine.Name = "btnDelMachine";
      this.btnDelMachine.Size = new System.Drawing.Size(103, 36);
      this.btnDelMachine.TabIndex = 24;
      this.btnDelMachine.Text = "Delete";
      this.btnDelMachine.UseVisualStyleBackColor = true;
      this.btnDelMachine.Click += new System.EventHandler(this.btnDelMachine_Click);
      // 
      // btnDelLine
      // 
      this.btnDelLine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnDelLine.Location = new System.Drawing.Point(288, 130);
      this.btnDelLine.Name = "btnDelLine";
      this.btnDelLine.Size = new System.Drawing.Size(103, 36);
      this.btnDelLine.TabIndex = 27;
      this.btnDelLine.Text = "Delete";
      this.btnDelLine.UseVisualStyleBackColor = true;
      this.btnDelLine.Click += new System.EventHandler(this.btnDelLine_Click);
      // 
      // cbIdLine
      // 
      this.cbIdLine.FormattingEnabled = true;
      this.cbIdLine.Location = new System.Drawing.Point(97, 136);
      this.cbIdLine.Name = "cbIdLine";
      this.cbIdLine.Size = new System.Drawing.Size(174, 28);
      this.cbIdLine.TabIndex = 26;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label7.Location = new System.Drawing.Point(14, 132);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(77, 31);
      this.label7.TabIndex = 25;
      this.label7.Text = "Id line";
      // 
      // btnDelDevice
      // 
      this.btnDelDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnDelDevice.Location = new System.Drawing.Point(1171, 125);
      this.btnDelDevice.Name = "btnDelDevice";
      this.btnDelDevice.Size = new System.Drawing.Size(133, 36);
      this.btnDelDevice.TabIndex = 30;
      this.btnDelDevice.Text = "Delete";
      this.btnDelDevice.UseVisualStyleBackColor = true;
      this.btnDelDevice.Click += new System.EventHandler(this.btnDelDevice_Click);
      // 
      // cbIdDevice
      // 
      this.cbIdDevice.FormattingEnabled = true;
      this.cbIdDevice.Location = new System.Drawing.Point(987, 132);
      this.cbIdDevice.Name = "cbIdDevice";
      this.cbIdDevice.Size = new System.Drawing.Size(178, 28);
      this.cbIdDevice.TabIndex = 29;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label8.Location = new System.Drawing.Point(854, 130);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(106, 31);
      this.label8.TabIndex = 28;
      this.label8.Text = "Id device";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1316, 481);
      this.Controls.Add(this.btnDelDevice);
      this.Controls.Add(this.cbIdDevice);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.btnDelLine);
      this.Controls.Add(this.cbIdLine);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.btnDelMachine);
      this.Controls.Add(this.CbIdMachine);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.cbLine);
      this.Controls.Add(this.cbMachine);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.dgvLine);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txbLine);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dgvDevice);
      this.Controls.Add(this.btnDevice);
      this.Controls.Add(this.txbDevice);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dgvMachine);
      this.Controls.Add(this.btnMachine);
      this.Controls.Add(this.txbMachine);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txbMachine;
    private System.Windows.Forms.Button btnMachine;
    private System.Windows.Forms.DataGridView dgvMachine;
    private System.Windows.Forms.DataGridView dgvDevice;
    private System.Windows.Forms.Button btnDevice;
    private System.Windows.Forms.TextBox txbDevice;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dgvLine;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txbLine;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cbMachine;
    private System.Windows.Forms.ComboBox cbLine;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox CbIdMachine;
    private System.Windows.Forms.Button btnDelMachine;
    private System.Windows.Forms.Button btnDelLine;
    private System.Windows.Forms.ComboBox cbIdLine;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnDelDevice;
    private System.Windows.Forms.ComboBox cbIdDevice;
    private System.Windows.Forms.Label label8;
  }
}
