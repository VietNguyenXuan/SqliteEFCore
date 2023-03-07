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
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.dgvMachine = new System.Windows.Forms.DataGridView();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMachine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.dgvLine = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(-1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Machine";
            // 
            // txtMachine
            // 
            this.txtMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMachine.Location = new System.Drawing.Point(156, 28);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(154, 38);
            this.txtMachine.TabIndex = 2;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMachine.Location = new System.Drawing.Point(316, 26);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(84, 40);
            this.btnAddMachine.TabIndex = 3;
            this.btnAddMachine.Text = "Add";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // dgvMachine
            // 
            this.dgvMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachine.Location = new System.Drawing.Point(15, 119);
            this.dgvMachine.Name = "dgvMachine";
            this.dgvMachine.RowHeadersVisible = false;
            this.dgvMachine.RowHeadersWidth = 51;
            this.dgvMachine.RowTemplate.Height = 29;
            this.dgvMachine.Size = new System.Drawing.Size(385, 322);
            this.dgvMachine.TabIndex = 4;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Location = new System.Drawing.Point(440, 119);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.RowTemplate.Height = 29;
            this.dgvDevice.Size = new System.Drawing.Size(405, 322);
            this.dgvDevice.TabIndex = 8;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDevice.Location = new System.Drawing.Point(767, 21);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(78, 38);
            this.btnAddDevice.TabIndex = 7;
            this.btnAddDevice.Text = "Add";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // txtDevice
            // 
            this.txtDevice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDevice.Location = new System.Drawing.Point(577, 12);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(172, 38);
            this.txtDevice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(440, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Device";
            // 
            // txtIdMachine
            // 
            this.txtIdMachine.Location = new System.Drawing.Point(577, 69);
            this.txtIdMachine.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMachine.Name = "txtIdMachine";
            this.txtIdMachine.Size = new System.Drawing.Size(172, 27);
            this.txtIdMachine.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(851, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Line";
            // 
            // txtLine
            // 
            this.txtLine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLine.Location = new System.Drawing.Point(962, 25);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(200, 38);
            this.txtLine.TabIndex = 2;
            // 
            // btnAddLine
            // 
            this.btnAddLine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddLine.Location = new System.Drawing.Point(1168, 23);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(84, 40);
            this.btnAddLine.TabIndex = 3;
            this.btnAddLine.Text = "Add";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // dgvLine
            // 
            this.dgvLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLine.Location = new System.Drawing.Point(867, 119);
            this.dgvLine.Name = "dgvLine";
            this.dgvLine.RowHeadersVisible = false;
            this.dgvLine.RowHeadersWidth = 51;
            this.dgvLine.RowTemplate.Height = 29;
            this.dgvLine.Size = new System.Drawing.Size(385, 319);
            this.dgvLine.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(440, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Machine";
            // 
            // txtIdLine
            // 
            this.txtIdLine.Location = new System.Drawing.Point(158, 73);
            this.txtIdLine.Name = "txtIdLine";
            this.txtIdLine.Size = new System.Drawing.Size(152, 27);
            this.txtIdLine.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(-1, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "IDLine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 585);
            this.Controls.Add(this.txtIdLine);
            this.Controls.Add(this.txtIdMachine);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLine);
            this.Controls.Add(this.dgvMachine);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
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
    private System.Windows.Forms.TextBox txtMachine;
    private System.Windows.Forms.Button btnAddMachine;
    private System.Windows.Forms.DataGridView dgvMachine;
    private System.Windows.Forms.DataGridView dgvDevice;
    private System.Windows.Forms.Button btnAddDevice;
    private System.Windows.Forms.TextBox txtDevice;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtIdMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.DataGridView dgvLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdLine;
        private System.Windows.Forms.Label label5;
    }
}
