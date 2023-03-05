using DemoSQLite.Controls;
using DemoSQLite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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



    private void timer1_Tick(object sender, EventArgs e)
    {
      try
      {
        var dbMachine = _managersMachine.GetAll();
        dgvMachine.DataSource = dbMachine;

        var dbDevice = _managersDevice.GetAllData();
        dgvDevice.DataSource = dbDevice;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    ControllersDbMachine _managersMachine = new ControllersDbMachine();
    private void button1_Click(object sender, EventArgs e)
    {
      Machine machine = new Machine();
      machine.Name = txbMachine.Text;
      machine.DateCreate = DateTime.Now;
      machine.LineId = null;
      machine.Line = null;
      _managersMachine.Add(machine);
    }




    ControllersDbDevice _managersDevice = new ControllersDbDevice();
    private void button2_Click(object sender, EventArgs e)
    {
      Device device = new Device();
      device.Name = txbDevice.Text;
      device.MachineId = int.Parse(textBox1.Text);
      Random rd = new Random();
      device.Value = rd.Next(1, 100);
      //device.Value = 100;

      device.DateCreate = DateTime.Now;

      device.MachineId = 1;

      _managersDevice.AddData(device);
    }
  }
}
