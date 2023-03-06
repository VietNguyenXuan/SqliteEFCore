using DemoSQLite.Models;
using DemoSQLite.Repositorys;
using DemoSQLite.Views;
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
      UpdateCb();
    }

    RepositoryLines _managersLine = new RepositoryLines();
    RepositoryMachines _managersMachine = new RepositoryMachines();
    RepositoryDevices _managersDevice = new RepositoryDevices();


    public void UpdateCb()
    {
      var dbIdMachine = _managersMachine.GetIdMachine();
      cbMachine.DataSource = dbIdMachine;
      CbIdMachine.DataSource = dbIdMachine;

      var dbIdLine = _managersLine.GetIdLine();
      cbLine.DataSource = dbIdLine;
      cbIdLine.DataSource = dbIdLine;

      var dbIdDevice = _managersDevice.GetIdDevice();
      cbIdDevice.DataSource = dbIdDevice;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      try
      {
        var dbLine = _managersLine.GetAll();
        dgvLine.DataSource = dbLine;
        
        var dbMachine = _managersMachine.GetAll();
        dgvMachine.DataSource = dbMachine;

        var dbDevice = _managersDevice.GetAll();
        dgvDevice.DataSource = dbDevice;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Thêm Line
    private void button1_Click_1(object sender, EventArgs e)
    {
      Line line = new Line();

      line.Name = txbLine.Text;
      line.DateCreate = DateTime.Now;

      _managersLine.Add(line);


      UpdateCb();
    }


    // Thêm Machine
    private void button1_Click(object sender, EventArgs e)
    {
      Machine machine = new Machine();

      machine.Name = txbMachine.Text;
      machine.DateCreate = DateTime.Now;
      machine.LineId = int.Parse(cbLine.SelectedItem.ToString());

      _managersMachine.Add(machine);


      UpdateCb();
    }


    // Thêm Device
    private void button2_Click(object sender, EventArgs e)
    {
      Device device = new Device();

      device.Name = txbDevice.Text;
      device.MachineId = int.Parse(cbMachine.SelectedItem.ToString());
      Random rd = new Random();
      device.Value = rd.Next(1, 100);
      device.DateCreate = DateTime.Now;

      _managersDevice.Add(device);

      UpdateCb();
    }

    private void btnDelLine_Click(object sender, EventArgs e)
    {
      _managersLine.Delete(int.Parse(cbIdLine.SelectedItem.ToString()));

      UpdateCb();
    }

    private void btnDelMachine_Click(object sender, EventArgs e)
    {
      _managersMachine.Delete(int.Parse(CbIdMachine.SelectedItem.ToString()));

      UpdateCb();
    }

    private void btnDelDevice_Click(object sender, EventArgs e)
    {
      _managersDevice.Delete(int.Parse(cbIdDevice.SelectedItem.ToString()));

      UpdateCb();
    }
  }
}
