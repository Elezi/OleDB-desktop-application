using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosqueCommunity.Data.Enums;

namespace MosqueCommunity
{
    public partial class StudentsForm : Form
    {
        CitiesDictionary cd;
        public StudentsForm()
        {
            InitializeComponent();
            cd = new CitiesDictionary();
            //cmb2Occupation.DataSource = Enum.GetValues(typeof(Occupation));
            //cmb2MaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            //cmb2HealthStatus.DataSource = Enum.GetValues(typeof(HealthStatus));
            comboBox2.DataSource = cd.CityNamesList;
            comboBox3.DataSource = cd.MunicipalitiesList;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ContactInfoPanel.Visible = !ContactInfoPanel.Visible;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ContactInfoPanel.Visible = checkBox1.Checked;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var studentRegistrationForm = new StudentRegistration();
            studentRegistrationForm.Show();

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedCity = comboBox2.SelectedItem;
            //var cd = new CitiesDictionary();
            var list = cd.MunicipalitiesDictionary.Where(v => v.Value == (string)selectedCity).Select(v => v.Key).ToList();
           if(list.Any())
           { 
                comboBox3.DataSource = list;
                comboBox3.SelectedItem = list.First();
           }else
           {
               comboBox3.DataSource = new List<string>();
               comboBox3.ResetText();
           }
        }
    }
}
