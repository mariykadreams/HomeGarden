﻿using HomeGarden.Plants;
using System;
using System.Windows.Forms;
using HomeGarden.Core_Aplication;

namespace UI.Multifunctional
{
    public partial class PlantInfo : Form
    {
        private Plant plant;

        public PlantInfo(Plant plant)
        {
            InitializeComponent();
            this.plant = plant;
        }

        private void PlantInfo_Load(object sender, EventArgs e)
        {
            if (MyApplication.UserMode == MyApplication.Mode.User)
            {

                this.btnSave.Visible = false;
                this.btnCancel.Visible = false;
            }
            else
            {

                this.btnSave.Visible = true;
                this.btnCancel.Visible = true;
            }


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
    }
}