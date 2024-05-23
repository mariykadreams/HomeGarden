﻿using HomeGarden.Core_Aplication;
using HomeGarden.Models;
using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserPages
{
    public partial class UserPlantInfo : Form
    {
        private Plant plant;
        private bool hideWateringControls;
        private Dictionary<string, UserPlantPreferences> userPreferences;

        public UserPlantInfo(Plant plant, bool hideWateringControls = false)
        {
            InitializeComponent();
            this.plant = plant;
            this.hideWateringControls = hideWateringControls;
            this.userPreferences = UserWateringService.LoadPreferences();
        }

        private void PlantInfo_Load(object sender, EventArgs e)
        {
            if (MyApplication.UserMode == MyApplication.Mode.User)
            {
                SetControlsForUser();
            }
           

            if (hideWateringControls)
            {
                this.checkBox1.Visible = false;
                this.label10.Visible = false;
                this.time_whenWaterr.Visible = false;
            }

            LoadPlantInfo();
            UpdateWateringTime();
        }

        private void SetControlsForUser()
        {
           
            this.checkBox1.Visible = true;
            this.label10.Visible = true;
            this.time_whenWaterr.Visible = true;

            this.textBox_name.ReadOnly = true;
            this.textBox_species.ReadOnly = true;
            this.textBox_desciption.ReadOnly = true;
            this.comboBox1_Level.Enabled = false;
            this.numericUpDown_Water.Enabled = false;
            this.comboBox_location.Enabled = false;

            if (this.textBox_color.Visible)
            {
                this.textBox_color.ReadOnly = true;
            }

            if (this.comboBox1_size.Visible)
            {
                this.comboBox1_size.Enabled = false;
            }
        }

       

        private void LoadPlantInfo()
        {
            this.Input_type.Text = plant.Type;
            this.textBox_name.Text = plant.Name;
            this.textBox_species.Text = plant.Species;
            this.textBox_desciption.Text = plant.ShortDesciption;
            this.comboBox1_Level.Text = plant.Level;
            this.numericUpDown_Water.Value = plant.WateringFrequency;
            this.comboBox_location.Text = plant.Location;

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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            plant.Name = this.textBox_name.Text;
            plant.Species = this.textBox_species.Text;
            plant.ShortDesciption = this.textBox_desciption.Text;
            plant.Level = this.comboBox1_Level.Text;
            plant.WateringFrequency = Convert.ToInt32(this.numericUpDown_Water.Value);
            plant.Location = this.comboBox_location.Text;

            if (plant is Flower flower)
            {
                flower.Color = this.textBox_color.Text;
            }
            else if (plant is Vegetable vegetable)
            {
                vegetable.Size = this.comboBox1_size.Text;
            }

            PlantService.UpdatePlant(plant);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the operation?",
               "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void time_whenWaterr_Click(object sender, EventArgs e)
        {

        }

        private void SaveUserPreferences()
        {
            userPreferences[plant.Id.ToString()] = new UserPlantPreferences
            {
                PlantId = plant.Id.ToString(),
                IsWateringChecked = checkBox1.Checked
            };

            UserWateringService.SavePreferences(userPreferences);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWateringTime();
            SaveUserPreferences();
        }

        private void UpdateWateringTime()
        {
            if (checkBox1.Checked)
            {
                DateTime wateringTime = DateTime.Today.AddHours(10);
                time_whenWaterr.Text = wateringTime.ToString("HH:mm");
            }
            else
            {
                time_whenWaterr.Text = "You need to water now!";
            }
        }
    }
}

