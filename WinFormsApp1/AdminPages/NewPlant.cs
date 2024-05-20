using System;
using System.Windows.Forms;
using HomeGarden.Plants;

namespace UI.AdminPages
{
    public partial class NewPlant : Form
    {
        string typeOfPlant;
        public bool PlantAdded { get; private set; }

        public NewPlant()
        {
            InitializeComponent();
        }

        private void Vegetable_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeOfPlant = "vegetable";
            this.comboBox1_size.Enabled = true;
            this.textBox_color.Enabled = false;
        }

        private void Flower_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeOfPlant = "flower";
            this.comboBox1_size.Enabled = false;
            this.textBox_color.Enabled = true;
        }

        private void Other_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeOfPlant = "other";
            this.comboBox1_size.Enabled = false;
            this.textBox_color.Enabled = false;
        }

        private void NewPlant_Load(object sender, EventArgs e)
        {
            numericUpDown_Water.Minimum = 1;
            numericUpDown_Water.Maximum = 365;
            numericUpDown_Water.Value = 1; // default value
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox_name.Text == String.Empty || this.textBox_species.Text == String.Empty
                || this.comboBox_location.Text == String.Empty || textBox_desciption.Text == String.Empty || this.comboBox1_Level.Text == String.Empty)
            {
                MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int wateringFrequency = (int)numericUpDown_Water.Value;

            if (typeOfPlant == "vegetable")
            {
                if (comboBox1_size.Text == String.Empty)
                {
                    MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PlantService.AddPlant(new Vegetable(this.textBox_name.Text, this.comboBox1_size.Text, this.textBox_species.Text,
                this.comboBox_location.Text, textBox_desciption.Text, comboBox1_Level.Text, wateringFrequency));
                MessageBox.Show($"A new vegetable has been added to the database.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PlantAdded = true;
            }
            else if (typeOfPlant == "flower")
            {
                if (textBox_color.Text == String.Empty)
                {
                    MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PlantService.AddPlant(new Flower(this.textBox_name.Text, this.textBox_color.Text, this.textBox_species.Text,
                this.comboBox_location.Text, textBox_desciption.Text, comboBox1_Level.Text, wateringFrequency));
                MessageBox.Show($"A new flower has been added to the database.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PlantAdded = true;
            }
            else if (typeOfPlant == "other")
            {
                PlantService.AddPlant(new Other(this.textBox_name.Text, this.textBox_species.Text,
                this.comboBox_location.Text, textBox_desciption.Text, comboBox1_Level.Text, wateringFrequency));
                MessageBox.Show($"A new plant has been added to the database.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PlantAdded = true;
            }

            this.Close();
        }

        private void Cencel_button_Click(object sender, EventArgs e)
        {

        }

        private void Type_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
