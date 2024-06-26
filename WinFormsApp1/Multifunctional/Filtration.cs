﻿using HomeGarden.Core_Aplication;
using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Multifunctional
{
    public partial class Filtration : Form
    {
        public event EventHandler FilterApplied;
        public List<Plant> SearchResultList { get; set; }

        public Filtration()
        {
            InitializeComponent();
            SearchResultList = new List<Plant>(PlantService.Plants);
        }

        private void radioBtn_vegetable_Click(object sender, EventArgs e)
        {
            this.comboBox1_size.Enabled = true;
            this.textBox_color.Enabled = false;
            SearchResultList = PlantService.SearchPlantsByType(PlantService.Plants, "Vegetable");
        }

        private void radioBtn_flower_Click(object sender, EventArgs e)
        {
            this.comboBox1_size.Enabled = false;
            this.textBox_color.Enabled = true;
            SearchResultList = PlantService.SearchPlantsByType(PlantService.Plants, "Flower");
        }

        private void radioBtn_other_Click(object sender, EventArgs e)
        {
            this.comboBox1_size.Enabled = false;
            this.textBox_color.Enabled = false;
            SearchResultList = PlantService.SearchPlantsByType(PlantService.Plants, "Other");
        }

        private void radioButton_All_Click(object sender, EventArgs e)
        {
            this.comboBox1_size.Enabled = true;
            this.textBox_color.Enabled = true;
            SearchResultList = PlantService.Plants;
        }

        private void Cencel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the operation? Data will be lost.",
                "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            var filteredList = new List<Plant>(SearchResultList);

            if (checkBox_Id.Checked && !string.IsNullOrEmpty(textBox_Id.Text))
            {
                filteredList = PlantService.SearchPlantsById(filteredList, textBox_Id.Text);
            }

            if (checkBox_Name.Checked && !string.IsNullOrEmpty(textBox_name.Text))
            {
                filteredList = PlantService.SearchPlantsByName(filteredList, textBox_name.Text);
            }

            if (checkBox_Species.Checked && !string.IsNullOrEmpty(textBox_species.Text))
            {
                filteredList = PlantService.SearchPlantsBySpecies(filteredList, textBox_species.Text);
            }

            if (checkBox_Location.Checked && !string.IsNullOrEmpty(comboBox_location.Text))
            {
                filteredList = PlantService.SearchPlantsByLocation(filteredList, comboBox_location.Text);
            }

            if (checkBox_Level.Checked && !string.IsNullOrEmpty(comboBox1_Level.Text))
            {
                filteredList = PlantService.SearchPlantsByLevel(filteredList, comboBox1_Level.Text);
            }

            if (checkBox_Size.Checked && !string.IsNullOrEmpty(comboBox1_size.Text))
            {
                filteredList = PlantService.SearchPlantsBySize(filteredList, comboBox1_size.Text);
            }

            if (checkBox_Color.Checked && !string.IsNullOrEmpty(textBox_color.Text))
            {
                filteredList = PlantService.SearchPlantsByColor(filteredList, textBox_color.Text);
            }

            if (checkBox_Water.Checked && numericUpDown_Water.Value > 0)
            {
                filteredList = PlantService.SearchPlantsByWateringFrequency(filteredList, (int)numericUpDown_Water.Value);
            }

            MessageBox.Show($"Found {filteredList.Count} plants");

            SearchResultList = filteredList;

            FilterApplied?.Invoke(this, EventArgs.Empty);

            this.Hide();
        }

        private void Filtration_Load(object sender, EventArgs e)
        {
            if (MyApplication.UserMode == MyApplication.Mode.User)
            {
                splitContainer3.Visible = false;
            }
            else
            {
                splitContainer3.Visible = true;
            }
        }

    }
}
