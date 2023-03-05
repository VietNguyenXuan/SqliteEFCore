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
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 2000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(15, 24);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(181, 38);
      this.label1.TabIndex = 0;
      this.label1.Text = "Add Machine";
      // 
      // txbMachine
      // 
      this.txbMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txbMachine.Location = new System.Drawing.Point(202, 20);
      this.txbMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txbMachine.Name = "txbMachine";
      this.txbMachine.Size = new System.Drawing.Size(200, 44);
      this.txbMachine.TabIndex = 2;
      // 
      // btnMachine
      // 
      this.btnMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnMachine.Location = new System.Drawing.Point(411, 19);
      this.btnMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnMachine.Name = "btnMachine";
      this.btnMachine.Size = new System.Drawing.Size(118, 48);
      this.btnMachine.TabIndex = 3;
      this.btnMachine.Text = "Add";
      this.btnMachine.UseVisualStyleBackColor = true;
      this.btnMachine.Click += new System.EventHandler(this.button1_Click);
      // 
      // dgvMachine
      // 
      this.dgvMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMachine.Location = new System.Drawing.Point(15, 99);
      this.dgvMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvMachine.Name = "dgvMachine";
      this.dgvMachine.RowHeadersVisible = false;
      this.dgvMachine.RowHeadersWidth = 51;
      this.dgvMachine.RowTemplate.Height = 29;
      this.dgvMachine.Size = new System.Drawing.Size(514, 241);
      this.dgvMachine.TabIndex = 4;
      // 
      // dgvDevice
      // 
      this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDevice.Location = new System.Drawing.Point(584, 99);
      this.dgvDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvDevice.Name = "dgvDevice";
      this.dgvDevice.RowHeadersVisible = false;
      this.dgvDevice.RowHeadersWidth = 51;
      this.dgvDevice.RowTemplate.Height = 29;
      this.dgvDevice.Size = new System.Drawing.Size(654, 241);
      this.dgvDevice.TabIndex = 8;
      // 
      // btnDevice
      // 
      this.btnDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnDevice.Location = new System.Drawing.Point(1120, 20);
      this.btnDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnDevice.Name = "btnDevice";
      this.btnDevice.Size = new System.Drawing.Size(118, 48);
      this.btnDevice.TabIndex = 7;
      this.btnDevice.Text = "Add";
      this.btnDevice.UseVisualStyleBackColor = true;
      this.btnDevice.Click += new System.EventHandler(this.button2_Click);
      // 
      // txbDevice
      // 
      this.txbDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txbDevice.Location = new System.Drawing.Point(755, 20);
      this.txbDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txbDevice.Name = "txbDevice";
      this.txbDevice.Size = new System.Drawing.Size(356, 44);
      this.txbDevice.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(584, 24);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(158, 38);
      this.label2.TabIndex = 5;
      this.label2.Text = "Add Device";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(584, 65);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(150, 31);
      this.textBox1.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1256, 731);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.dgvDevice);
      this.Controls.Add(this.btnDevice);
      this.Controls.Add(this.txbDevice);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dgvMachine);
      this.Controls.Add(this.btnMachine);
      this.Controls.Add(this.txbMachine);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
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
    private System.Windows.Forms.TextBox textBox1;
  }
}
