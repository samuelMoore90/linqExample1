using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1ExamSample
{
    public partial class Form1 : Form
    {
        List<Vehicle> VehicleList;
        List<VehicleService> VehicleServiceList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VehicleList = new List<Vehicle>
            {
                new Vehicle { VehicleID = 1, VehicleType = "Sherman", RegistrationYear = 2008, ServiceID = 100 },
                new Vehicle { VehicleID = 2, VehicleType = "K2 Black Panther", RegistrationYear = 2015, ServiceID = 101 },
                new Vehicle { VehicleID = 3, VehicleType = "Armata", RegistrationYear = 2014, ServiceID = 102},
                new Vehicle { VehicleID = 4, VehicleType = "Panzer", RegistrationYear = 2007, ServiceID = 103},
                new Vehicle { VehicleID = 5, VehicleType = "Churchill", RegistrationYear = 2009, ServiceID = 104}
            };

            VehicleServiceList = new List<VehicleService>
            {
                new VehicleService { ServiceID = 100, Mileage = 93123, MLS = 2007, RFA = 9},
                new VehicleService { ServiceID = 101, Mileage = 7591, MLS = 308, RFA = 0},
                new VehicleService { ServiceID = 102, Mileage = 27010, MLS = 10598, RFA = 25},
                new VehicleService { ServiceID = 103, Mileage = 103412, MLS = 1933, RFA = 7},
                new VehicleService { ServiceID = 104, Mileage = 10112, MLS = 10010, RFA = 2}
            };

            var vehicleInfo = (from vehicleElem in VehicleList
                               join vehicleServiceElem in VehicleServiceList on vehicleElem.ServiceID equals vehicleServiceElem.ServiceID
                               select new
                               {
                                   vehicleElem.VehicleID,
                                   vehicleElem.VehicleType,
                                   vehicleElem.RegistrationYear,
                                   vehicleServiceElem.Mileage,
                                   vehicleServiceElem.MLS,
                                   vehicleServiceElem.RFA
                               }).ToList(); // Do not forget the ToList() to force immediate execution & have data to show on the dgv

            dgvVehicles.DataSource = vehicleInfo;
        }

        private void rbRegistrationYr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRegistrationYr.Checked)
            {
                var vehicleInfo = (from vehicleElem in VehicleList
                                   join vehicleServiceElem in VehicleServiceList on
                                    vehicleElem.ServiceID equals vehicleServiceElem.ServiceID
                                   orderby vehicleElem.RegistrationYear
                                   select new
                                   {
                                       vehicleElem.VehicleID,
                                       vehicleElem.VehicleType,
                                       vehicleElem.RegistrationYear,
                                       vehicleServiceElem.Mileage,
                                       vehicleServiceElem.MLS,
                                       vehicleServiceElem.RFA
                                   }).ToList();

                dgvVehicles.DataSource = vehicleInfo;
            }
        }

        private void rbMileage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMechanicalReport_Click(object sender, EventArgs e)
        {
            List<Vehicle> RTM = (from vehicleElem in VehicleList
                                 join vehicleServiceElem in VehicleServiceList
                                 on vehicleElem.ServiceID equals vehicleServiceElem.ServiceID
                                 let VehicleAge = DateTime.Now.Year - vehicleElem.RegistrationYear
                                 where vehicleServiceElem.Mileage < 95000 
                                        && vehicleServiceElem.RFA >= 8 && VehicleAge <= 5
                                 select vehicleElem).ToList();

            List<Vehicle> diagnosticService = (from vehicleElem in VehicleList
                                               join vehicleServiceElem in VehicleServiceList
                                               on vehicleElem.ServiceID equals vehicleServiceElem.ServiceID
                                               let VehicleAge = DateTime.Now.Year - vehicleElem.RegistrationYear
                                               where vehicleServiceElem.Mileage < 95000 &&
                                               vehicleServiceElem.MLS < 10000 &&
                                               ((vehicleServiceElem.RFA > 5 && vehicleServiceElem.RFA < 8 && VehicleAge <= 4) ||
                                                (vehicleServiceElem.RFA >= 3 && vehicleServiceElem.RFA <= 5 && VehicleAge <= 2))
                                               select vehicleElem).ToList();

            using (MechanicalReport frmMechanicalReport = new MechanicalReport(diagnosticService, RTM))
            {
                frmMechanicalReport.ShowDialog();
            }
        }

        private void btnTotalRFA_Click(object sender, EventArgs e)
        {
            int TotalRFA = (from vehicleElem in VehicleList
                            join vehicleServiceElem in VehicleServiceList
                                on vehicleElem.ServiceID equals vehicleServiceElem.ServiceID
                            where vehicleElem.RegistrationYear >= 2009
                            select vehicleServiceElem.RFA).Sum();

            MessageBox.Show($"Total RFA for all vehicles registered on or after 2009 is {TotalRFA}");
        }
    }
}
