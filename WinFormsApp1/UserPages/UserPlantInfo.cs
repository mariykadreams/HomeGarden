using HomeGarden.Core_Aplication;
using HomeGarden.Models;
using HomeGarden.Plants;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI.UserPages
{
    public partial class UserPlantInfo : Form
    {
        private Plant plant;

        public UserPlantInfo(Plant plant, bool hideWateringControls = false)
        {
            InitializeComponent();
            this.plant = plant;
            LoadPlantInfo();
        }

        private void LoadPlantInfo()
        {
            if (plant == null) return;

            this.Input_type.Text = plant.Type;
            this.textBox_name.Text = plant.Name;
            this.textBox_species.Text = plant.Species;
            this.textBox_desciption.Text = plant.ShortDesciption;
            this.comboBox1_Level.Text = plant.Level;
            this.numericUpDown_Water.Value = plant.WateringFrequency;
            this.comboBox_location.Text = plant.Location;
            this.textBox1.Text = plant.Status;

            if (plant is Flower flower)
            {
                this.textBox_color.Text = flower.Color;
                this.textBox_color.Visible = true;
                this.label6.Visible = true;
            }
            else
            {
                this.textBox_color.Visible = false;
                this.label6.Visible = false;
            }

            if (plant is Vegetable vegetable)
            {
                this.comboBox1_size.Text = vegetable.Size;
                this.label5.Visible = true;
                this.comboBox1_size.Visible = true;
            }
            else
            {
                this.comboBox1_size.Visible = false;
                this.label5.Visible = false;
            }

            var wateringHistory = UserWateringService.GetWateringInfoByPlant(plant.Id.ToString());
            if (wateringHistory != null && wateringHistory.Any())
            {
                time_whenWaterr.Text = "Last watered by you: " + (wateringHistory.FirstOrDefault(w => w.UserId == MyApplication.CurrentUserId)?.LastWatered.ToString() ?? "Never");
            }
            else
            {
                time_whenWaterr.Text = "Not watered yet.";
            }

            CalculateNextWateringTime(wateringHistory);
        }

        private void CalculateNextWateringTime(List<UserWateringService> wateringHistory)
        {
            if (wateringHistory != null && wateringHistory.Any())
            {
                var lastWatering = wateringHistory.OrderByDescending(w => w.LastWatered).FirstOrDefault();
                if (lastWatering != null)
                {
                    var nextWatering = lastWatering.LastWatered.AddDays(plant.WateringFrequency);
                    if (nextWatering <= DateTime.Now)
                    {
                        plant.Status = "Bad Health";
                        MessageBox.Show("You need to water your plant now!", "Watering Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        water_next.Text = "You need to water your plant now!";
                    }
                    else
                    {
                        water_next.Text = "Next watering: " + nextWatering.ToString();
                    }
                }
                else
                {
                    plant.Status = "Bad Health";
                    water_next.Text = "You need to water your plant now!";
                }
            }
            else
            {
                plant.Status = "Bad Health";
                water_next.Text = "You need to water your plant now!";
            }

            this.textBox1.Text = plant.Status;
        }


        private void UserPlantInfo_Load(object sender, EventArgs e)
        {
            LoadPlantInfo();
        }

        private void button_Iwatered_Click(object sender, EventArgs e)
        {
            var wateringService = new UserWateringService
            {
                UserId = MyApplication.CurrentUserId,
                PlantId = plant.Id.ToString(),
                OperationId = Guid.NewGuid().ToString(),
                LastWatered = DateTime.Now

            };
            plant.Status = "Healthy";
            UserWateringService.SaveWateringInfo(wateringService);
            LoadPlantInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
              "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void water_next_Click(object sender, EventArgs e)
        {
        }
    }
}
