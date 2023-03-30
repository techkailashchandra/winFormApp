using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> environments = new Dictionary<string, string>
        {
            {"Prod", "orion-api-discovery-svc.ups.com"},
            {"SnP", "orion-api-discovery-svc.ams1907.com"},
            {"Dev4", "svrt00009280.tus.ams1907.com"},
            {"QA02", "svrt0000af1e.tus.ams1907.com"},
            {"QA03", "svrt0000af1f.tus.ams1907.com"},
            {"QA04", "svrt0000af1d.tus.ams1907.com"},
            {"QA05", "svrt0000a2bb.tus.ams1907.com"},
            {"QA07", "svrt00009290.tus.ams1907.com"},
            {"QA09", "svrt0000a2bc.tus.ams1907.com"},
            {"QA10", "svrt0000b556.tus.ams1907.com"},
            {"QA11", "svrt0000b558.tus.ams1907.com"},
            {"QA12", "svrt0000b55a.tus.ams1907.com"},
            {"QA13", "svrt0000b55c.tus.ams1907.com"},
            {"QA14", "svrt0000b55e.tus.ams1907.com"},
            {"QA15", "svrt0000b561.tus.ams1907.com"},
            {"QA16", "svrt0000b563.tus.ams1907.com"}
        };

        private Dictionary<string, string> countries = new Dictionary<string, string>
        {
            {"US", "US"},
            {"AUS", "AUS"},
            {"CAN", "CAN"}
        };

        public Form1()
        {

            InitializeComponent();
            enviroment.DataSource = new BindingSource(environments, null);
            enviroment.DisplayMember = "Value";
            enviroment.ValueMember = "Key";
            enviroment.SelectedItem = null;

            countriesDropdown.DataSource= new BindingSource(countries, null);
            countriesDropdown.DisplayMember = "Value";
            countriesDropdown.ValueMember = "Key";
            countriesDropdown.SelectedItem = null;

            BarCodeFileName.Text = "BarcodeRangeUS.xml";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var selectEnv = enviroment.SelectedItem;
            var selectedCountry = countriesDropdown.SelectedItem;
            var barcodeFile = BarCodeFileName.Text;


            txtStatusBox.Text = "success";
        }
    }
}
