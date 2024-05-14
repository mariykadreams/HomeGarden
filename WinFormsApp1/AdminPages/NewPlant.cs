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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox_name.Text == String.Empty || this.textBox_species.Text == String.Empty
                || this.comboBox_location.Text == String.Empty || textBox_desciption.Text == String.Empty || this.comboBox1_Level.Text == String.Empty)
            {
                MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (typeOfPlant == "vegetable")
            {
                if (comboBox1_size.Text == String.Empty)
                {
                    MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PlantService.AddPlant(new Vegetable(this.textBox_name.Text, this.textBox_species.Text,
                this.comboBox_location.Text, textBox_desciption.Text, comboBox1_size.Text, comboBox1_Level.Text));
                MessageBox.Show($"A new vegetable has been added to the database.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PlantAdded = true;
            }

            this.Close();
        }

        private void textBox_desciption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
