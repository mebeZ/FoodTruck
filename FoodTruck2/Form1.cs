using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'foodTruckDataSet.Truck' table. You can move, or remove it, as needed.
            this.truckTableAdapter.Fill(this.foodTruckDataSet.Truck);
            // TODO: This line of code loads data into the 'foodTruckDataSet.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.foodTruckDataSet.Food);

            FillFood();
            FillDrink();

        }

        public void FillDrink()
        {
            Dictionary<String, Decimal> values = new Dictionary<String, Decimal>();
            String connString = @"Data Source=localhost;Initial Catalog=FoodTruck;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            String q = "SELECT * FROM Food";
            SqlCommand cmd = new SqlCommand(q, conn);

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr.GetInt32(0).Equals(truckComboBox.SelectedValue) && dr.GetString(1).Equals("Drink"))
                        {

                            values.Add(dr.GetString(2), dr.GetDecimal(3));
                        }

                    }
                    dr.Close();
                }
            }
            finally { conn.Close(); }

            drinkComboBox.DataSource = new BindingSource(values, null);
            drinkComboBox.DisplayMember = "Key";
            drinkComboBox.ValueMember = "Value";

        }

        public void FillFood()
        {
            Dictionary<String, Decimal> values = new Dictionary<String, Decimal>();
            String connString = @"Data Source=localhost;Initial Catalog=FoodTruck;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            String q = "SELECT * FROM Food";
            SqlCommand cmd = new SqlCommand(q, conn);

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr.GetInt32(0).Equals(truckComboBox.SelectedValue) && dr.GetString(1).Equals("Food"))
                        {

                            values.Add(dr.GetString(2), dr.GetDecimal(3));
                        }

                    }
                    dr.Close();
                }
            }
            finally { conn.Close(); }

            foodComboBox.DataSource = new BindingSource(values, null);
            foodComboBox.DisplayMember = "Key";
            foodComboBox.ValueMember = "Value";

        }

        public void UpdateDrinkCost()
        {
            try
            {
                drinkCost.Text = "Cost: " + (Decimal.Parse(drinkComboBox.SelectedValue.ToString()) * Int32.Parse(numericUpDown1.Value.ToString()));
                totalCost.Text = "Cost: " + (Decimal.Parse(drinkComboBox.SelectedValue.ToString()) * Int32.Parse(numericUpDown1.Value.ToString()) + Decimal.Parse(foodComboBox.SelectedValue.ToString()) * Int32.Parse(numericUpDown2.Value.ToString()));
            }
            catch(System.Exception)
            {

            }
            

        }

      
        public void UpdateFoodCost()
        {
            try
            {
                foodCost.Text = "Cost: " + (Decimal.Parse(foodComboBox.SelectedValue.ToString()) * Int32.Parse(numericUpDown2.Value.ToString()));
                totalCost.Text = "Cost: " + (Decimal.Parse(drinkComboBox.SelectedValue.ToString()) * Int32.Parse(numericUpDown1.Value.ToString()) + Decimal.Parse(foodComboBox.SelectedValue.ToString()) * Int32.Parse(numericUpDown2.Value.ToString()));
            }
            catch (System.Exception)
            {

            }
        } 

        private void TruckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDrink();
            FillFood();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDrinkCost();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateFoodCost();
        }

        private void DrinkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrinkCost();
        }

        private void FoodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFoodCost();
        }
    }
}
 