using Lab_1_2;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Item> items = new List<Item>();

        private void generateItemsButton_Click(object sender, EventArgs e)
        {
            Random random = new Random(int.Parse(seedBox.Text));

            double val = 0, weigh = 0;
            int numberOfItems = int.Parse(itemsTextBox.Text);

            for (int i = 0; i < numberOfItems; i++)
            {
                val = random.Next(1, 11);
                weigh = random.Next(1, 11);
                items.Add(new Item(i, val, weigh));
            }
            foreach (Item it in items)
            {
                generatedItemsTextBox.Text += it.ToString();
                generatedItemsTextBox.Text += Environment.NewLine;
            }
        }
        private void packItemsButton_Click(object sender, EventArgs e)
        {
            items = Solve.solve(items, int.Parse(capacityTextBox.Text));
            foreach (Item it in items)
            {
                packedItemstextBox.Text += it.ToString();
                packedItemstextBox.Text += Environment.NewLine;
            }
            double val = 0, weigh = 0;
            foreach (Item it in items)
            {
                val += it.value;
                weigh += it.weight;
            }
            totalValueLabel.Text = val.ToString();
            totalWeightLabel.Text = weigh.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
