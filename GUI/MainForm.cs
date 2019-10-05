using System;
using System.Windows.Forms;
using PCInfo;

namespace GUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        ComputerInfo computerInfo = new ComputerInfo();

        private void Timer_Tick( object sender , EventArgs e ) {
            cpuBox.Text = computerInfo.CpuLoad.ToString();
            ramBox.Text = computerInfo.RamLoad.ToString();
            computerInfo.UpdateComputerInfo();
        }

        private void MainForm_Load( object sender , EventArgs e ) {
            nameBox.Text = computerInfo.Name;
            manufacturerBox.Text = computerInfo.Manufacturer;

            foreach( string user in computerInfo.ListOfUsers ) {
                usersList.Items.Add( user );
            }
        }
    }
}
