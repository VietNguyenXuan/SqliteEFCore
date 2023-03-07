using DemoSQLite.Models;
using DemoSQLite.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLite
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      timer1.Start();
            
    }



    private async void timer1_Tick(object sender, EventArgs e)
    {
      try
      {
         
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
        Line line = new Line();
        Machine machine = new Machine();
        Device device = new Device();

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            LineRepository lineRepositoy = new LineRepository();
            
            line.Name = txtLine.Text;
            line.DateCreate = DateTime.Now;
            lineRepositoy.Add(line);
            var data1 = lineRepositoy.GetAll();
            dgvLine.DataSource = data1;
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            MachineRepository machineRepository= new MachineRepository();
            
            machine.Name = txtMachine.Text;
            machine.DateCreate = DateTime.Now;
            machine.LineId=int.Parse(txtIdLine.Text);
            machineRepository.Add(machine);
            var data2 = machineRepository.GetAll();
            dgvMachine.DataSource = data2;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            DeviceRepository deviceRepository = new DeviceRepository(); 
            
            device.Name = txtDevice.Text;
            device.DateCreate = DateTime.Now;
            device.MachineId = int.Parse(txtIdMachine.Text);  
            deviceRepository.Add(device);
            var data3 = deviceRepository.GetAll();
            dgvDevice.DataSource = data3;
        }
    }
}
