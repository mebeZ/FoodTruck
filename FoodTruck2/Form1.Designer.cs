namespace FoodTruck2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.truckLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.truckComboBox = new System.Windows.Forms.ComboBox();
            this.truckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTruckDataSet = new FoodTruck2.FoodTruckDataSet();
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinkComboBox = new System.Windows.Forms.ComboBox();
            this.drinkQuantity = new System.Windows.Forms.Label();
            this.foodQuantity = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.drinkCost = new System.Windows.Forms.Label();
            this.foodCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.foodTableAdapter = new FoodTruck2.FoodTruckDataSetTableAdapters.FoodTableAdapter();
            this.truckTableAdapter = new FoodTruck2.FoodTruckDataSetTableAdapters.TruckTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTruckDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // truckLabel
            // 
            this.truckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckLabel.Location = new System.Drawing.Point(60, 64);
            this.truckLabel.Name = "truckLabel";
            this.truckLabel.Size = new System.Drawing.Size(51, 22);
            this.truckLabel.TabIndex = 0;
            this.truckLabel.Text = "Truck";
            // 
            // drinkLabel
            // 
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(60, 133);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(51, 22);
            this.drinkLabel.TabIndex = 1;
            this.drinkLabel.Text = "Drink";
            // 
            // foodLabel
            // 
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(60, 200);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(51, 22);
            this.foodLabel.TabIndex = 2;
            this.foodLabel.Text = "Food";
            // 
            // truckComboBox
            // 
            this.truckComboBox.DataSource = this.truckBindingSource;
            this.truckComboBox.DisplayMember = "TruckName";
            this.truckComboBox.FormattingEnabled = true;
            this.truckComboBox.Location = new System.Drawing.Point(127, 64);
            this.truckComboBox.Name = "truckComboBox";
            this.truckComboBox.Size = new System.Drawing.Size(121, 21);
            this.truckComboBox.TabIndex = 3;
            this.truckComboBox.ValueMember = "TruckID";
            this.truckComboBox.SelectedIndexChanged += new System.EventHandler(this.TruckComboBox_SelectedIndexChanged);
            // 
            // truckBindingSource
            // 
            this.truckBindingSource.DataMember = "Truck";
            this.truckBindingSource.DataSource = this.foodTruckDataSet;
            // 
            // foodTruckDataSet
            // 
            this.foodTruckDataSet.DataSetName = "FoodTruckDataSet";
            this.foodTruckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodComboBox
            // 
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Location = new System.Drawing.Point(127, 200);
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(121, 21);
            this.foodComboBox.TabIndex = 4;
            this.foodComboBox.SelectedIndexChanged += new System.EventHandler(this.FoodComboBox_SelectedIndexChanged);
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.foodTruckDataSet;
            // 
            // drinkComboBox
            // 
            this.drinkComboBox.FormattingEnabled = true;
            this.drinkComboBox.Location = new System.Drawing.Point(127, 133);
            this.drinkComboBox.Name = "drinkComboBox";
            this.drinkComboBox.Size = new System.Drawing.Size(121, 21);
            this.drinkComboBox.TabIndex = 5;
            this.drinkComboBox.SelectedIndexChanged += new System.EventHandler(this.DrinkComboBox_SelectedIndexChanged);
            // 
            // drinkQuantity
            // 
            this.drinkQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkQuantity.Location = new System.Drawing.Point(313, 133);
            this.drinkQuantity.Name = "drinkQuantity";
            this.drinkQuantity.Size = new System.Drawing.Size(70, 22);
            this.drinkQuantity.TabIndex = 6;
            this.drinkQuantity.Text = "Quantity";
            // 
            // foodQuantity
            // 
            this.foodQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodQuantity.Location = new System.Drawing.Point(313, 200);
            this.foodQuantity.Name = "foodQuantity";
            this.foodQuantity.Size = new System.Drawing.Size(70, 22);
            this.foodQuantity.TabIndex = 7;
            this.foodQuantity.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(389, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(389, 203);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // drinkCost
            // 
            this.drinkCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCost.Location = new System.Drawing.Point(500, 136);
            this.drinkCost.Name = "drinkCost";
            this.drinkCost.Size = new System.Drawing.Size(102, 22);
            this.drinkCost.TabIndex = 10;
            this.drinkCost.Text = "Cost: $0.0";
            // 
            // foodCost
            // 
            this.foodCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCost.Location = new System.Drawing.Point(500, 203);
            this.foodCost.Name = "foodCost";
            this.foodCost.Size = new System.Drawing.Size(102, 22);
            this.foodCost.TabIndex = 11;
            this.foodCost.Text = "Cost: $0.0";
            // 
            // totalCost
            // 
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(430, 273);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(157, 31);
            this.totalCost.TabIndex = 12;
            this.totalCost.Text = "Total Cost: $0.0";
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // truckTableAdapter
            // 
            this.truckTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.foodCost);
            this.Controls.Add(this.drinkCost);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.foodQuantity);
            this.Controls.Add(this.drinkQuantity);
            this.Controls.Add(this.drinkComboBox);
            this.Controls.Add(this.foodComboBox);
            this.Controls.Add(this.truckComboBox);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.truckLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTruckDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label truckLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.ComboBox truckComboBox;
        private System.Windows.Forms.ComboBox foodComboBox;
        private System.Windows.Forms.ComboBox drinkComboBox;
        private System.Windows.Forms.Label drinkQuantity;
        private System.Windows.Forms.Label foodQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label drinkCost;
        private System.Windows.Forms.Label foodCost;
        private System.Windows.Forms.Label totalCost;
        private FoodTruckDataSet foodTruckDataSet;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private FoodTruckDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.BindingSource truckBindingSource;
        private FoodTruckDataSetTableAdapters.TruckTableAdapter truckTableAdapter;
    }
}

