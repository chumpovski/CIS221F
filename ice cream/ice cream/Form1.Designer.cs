namespace ice_cream
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
            this.lBoxFlavors = new System.Windows.Forms.ListBox();
            this.rdo1scoop = new System.Windows.Forms.RadioButton();
            this.rdo2scoop = new System.Windows.Forms.RadioButton();
            this.rdo3scoop = new System.Windows.Forms.RadioButton();
            this.chBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.chBoxOreos = new System.Windows.Forms.CheckBox();
            this.chBoxChocChips = new System.Windows.Forms.CheckBox();
            this.ChBoxCherSyrp = new System.Windows.Forms.CheckBox();
            this.ChBoxGumWrm = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlScoops = new System.Windows.Forms.Panel();
            this.pnlToppings = new System.Windows.Forms.Panel();
            this.lblFlavors = new System.Windows.Forms.Label();
            this.lblScoopa = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlScoops.SuspendLayout();
            this.pnlToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxFlavors
            // 
            this.lBoxFlavors.FormattingEnabled = true;
            this.lBoxFlavors.Items.AddRange(new object[] {
            "Chocolate",
            "Vanilla",
            "Cookie dough",
            "Strawberry",
            "Mint chip",
            "Mocha",
            "Cookies n cream"});
            this.lBoxFlavors.Location = new System.Drawing.Point(54, 52);
            this.lBoxFlavors.Name = "lBoxFlavors";
            this.lBoxFlavors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxFlavors.Size = new System.Drawing.Size(200, 199);
            this.lBoxFlavors.TabIndex = 0;
            this.lBoxFlavors.SelectedIndexChanged += new System.EventHandler(this.lBoxFlavors_SelectedIndexChanged);
            // 
            // rdo1scoop
            // 
            this.rdo1scoop.AutoSize = true;
            this.rdo1scoop.Location = new System.Drawing.Point(3, 49);
            this.rdo1scoop.Name = "rdo1scoop";
            this.rdo1scoop.Size = new System.Drawing.Size(63, 17);
            this.rdo1scoop.TabIndex = 0;
            this.rdo1scoop.TabStop = true;
            this.rdo1scoop.Text = "1 scoop";
            this.rdo1scoop.UseVisualStyleBackColor = true;
            this.rdo1scoop.CheckedChanged += new System.EventHandler(this.rdo1scoop_CheckedChanged);
            this.rdo1scoop.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // rdo2scoop
            // 
            this.rdo2scoop.AutoSize = true;
            this.rdo2scoop.Location = new System.Drawing.Point(3, 86);
            this.rdo2scoop.Name = "rdo2scoop";
            this.rdo2scoop.Size = new System.Drawing.Size(68, 17);
            this.rdo2scoop.TabIndex = 1;
            this.rdo2scoop.TabStop = true;
            this.rdo2scoop.Text = "2 scoops";
            this.rdo2scoop.UseVisualStyleBackColor = true;
            this.rdo2scoop.CheckedChanged += new System.EventHandler(this.rdo2scoop_CheckedChanged);
            this.rdo2scoop.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // rdo3scoop
            // 
            this.rdo3scoop.AutoSize = true;
            this.rdo3scoop.Location = new System.Drawing.Point(3, 123);
            this.rdo3scoop.Name = "rdo3scoop";
            this.rdo3scoop.Size = new System.Drawing.Size(68, 17);
            this.rdo3scoop.TabIndex = 2;
            this.rdo3scoop.TabStop = true;
            this.rdo3scoop.Text = "3 scoops";
            this.rdo3scoop.UseVisualStyleBackColor = true;
            this.rdo3scoop.CheckedChanged += new System.EventHandler(this.rdo3scoop_CheckedChanged);
            this.rdo3scoop.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // chBoxSprinkles
            // 
            this.chBoxSprinkles.AutoSize = true;
            this.chBoxSprinkles.Location = new System.Drawing.Point(53, 13);
            this.chBoxSprinkles.Name = "chBoxSprinkles";
            this.chBoxSprinkles.Size = new System.Drawing.Size(69, 17);
            this.chBoxSprinkles.TabIndex = 4;
            this.chBoxSprinkles.Text = "Sprinkles";
            this.chBoxSprinkles.UseVisualStyleBackColor = true;
            this.chBoxSprinkles.CheckedChanged += new System.EventHandler(this.chBoxSprinkles_CheckedChanged);
            this.chBoxSprinkles.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // chBoxOreos
            // 
            this.chBoxOreos.AutoSize = true;
            this.chBoxOreos.Location = new System.Drawing.Point(53, 49);
            this.chBoxOreos.Name = "chBoxOreos";
            this.chBoxOreos.Size = new System.Drawing.Size(54, 17);
            this.chBoxOreos.TabIndex = 5;
            this.chBoxOreos.Text = "Oreos";
            this.chBoxOreos.UseVisualStyleBackColor = true;
            this.chBoxOreos.CheckedChanged += new System.EventHandler(this.chBoxOreos_CheckedChanged);
            this.chBoxOreos.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // chBoxChocChips
            // 
            this.chBoxChocChips.AutoSize = true;
            this.chBoxChocChips.Location = new System.Drawing.Point(53, 85);
            this.chBoxChocChips.Name = "chBoxChocChips";
            this.chBoxChocChips.Size = new System.Drawing.Size(103, 17);
            this.chBoxChocChips.TabIndex = 6;
            this.chBoxChocChips.Text = "Chocolate Chips";
            this.chBoxChocChips.UseVisualStyleBackColor = true;
            this.chBoxChocChips.CheckedChanged += new System.EventHandler(this.chBoxChocChips_CheckedChanged);
            this.chBoxChocChips.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // ChBoxCherSyrp
            // 
            this.ChBoxCherSyrp.AutoSize = true;
            this.ChBoxCherSyrp.Location = new System.Drawing.Point(53, 121);
            this.ChBoxCherSyrp.Name = "ChBoxCherSyrp";
            this.ChBoxCherSyrp.Size = new System.Drawing.Size(86, 17);
            this.ChBoxCherSyrp.TabIndex = 7;
            this.ChBoxCherSyrp.Text = "Cherry Syrup";
            this.ChBoxCherSyrp.UseVisualStyleBackColor = true;
            this.ChBoxCherSyrp.CheckedChanged += new System.EventHandler(this.ChBoxCherSyrp_CheckedChanged);
            this.ChBoxCherSyrp.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // ChBoxGumWrm
            // 
            this.ChBoxGumWrm.AutoSize = true;
            this.ChBoxGumWrm.Location = new System.Drawing.Point(53, 157);
            this.ChBoxGumWrm.Name = "ChBoxGumWrm";
            this.ChBoxGumWrm.Size = new System.Drawing.Size(97, 17);
            this.ChBoxGumWrm.TabIndex = 8;
            this.ChBoxGumWrm.Text = "Gummy Worms";
            this.ChBoxGumWrm.UseVisualStyleBackColor = true;
            this.ChBoxGumWrm.CheckedChanged += new System.EventHandler(this.ChBoxGumWrm_CheckedChanged);
            this.ChBoxGumWrm.Click += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(542, 304);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(293, 365);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print Order";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(542, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(667, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlScoops
            // 
            this.pnlScoops.Controls.Add(this.rdo1scoop);
            this.pnlScoops.Controls.Add(this.rdo2scoop);
            this.pnlScoops.Controls.Add(this.rdo3scoop);
            this.pnlScoops.Location = new System.Drawing.Point(303, 52);
            this.pnlScoops.Name = "pnlScoops";
            this.pnlScoops.Size = new System.Drawing.Size(200, 199);
            this.pnlScoops.TabIndex = 1;
            // 
            // pnlToppings
            // 
            this.pnlToppings.Controls.Add(this.chBoxSprinkles);
            this.pnlToppings.Controls.Add(this.chBoxOreos);
            this.pnlToppings.Controls.Add(this.chBoxChocChips);
            this.pnlToppings.Controls.Add(this.ChBoxCherSyrp);
            this.pnlToppings.Controls.Add(this.ChBoxGumWrm);
            this.pnlToppings.Location = new System.Drawing.Point(542, 52);
            this.pnlToppings.Name = "pnlToppings";
            this.pnlToppings.Size = new System.Drawing.Size(200, 199);
            this.pnlToppings.TabIndex = 2;
            // 
            // lblFlavors
            // 
            this.lblFlavors.AutoSize = true;
            this.lblFlavors.Location = new System.Drawing.Point(51, 23);
            this.lblFlavors.Name = "lblFlavors";
            this.lblFlavors.Size = new System.Drawing.Size(44, 13);
            this.lblFlavors.TabIndex = 15;
            this.lblFlavors.Text = "Flavors:";
            // 
            // lblScoopa
            // 
            this.lblScoopa.AutoSize = true;
            this.lblScoopa.Location = new System.Drawing.Point(300, 23);
            this.lblScoopa.Name = "lblScoopa";
            this.lblScoopa.Size = new System.Drawing.Size(46, 13);
            this.lblScoopa.TabIndex = 16;
            this.lblScoopa.Text = "Scoops:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(539, 23);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(51, 13);
            this.lblToppings.TabIndex = 17;
            this.lblToppings.Text = "Toppings";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(300, 254);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(68, 13);
            this.lblDollar.TabIndex = 18;
            this.lblDollar.Text = "$1.00/scoop";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Location = new System.Drawing.Point(539, 254);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(68, 13);
            this.lblTopping.TabIndex = 19;
            this.lblTopping.Text = "$.50/topping";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(469, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblScoopa);
            this.Controls.Add(this.lblFlavors);
            this.Controls.Add(this.pnlToppings);
            this.Controls.Add(this.pnlScoops);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lBoxFlavors);
            this.Name = "Form1";
            this.Text = "1";
            this.pnlScoops.ResumeLayout(false);
            this.pnlScoops.PerformLayout();
            this.pnlToppings.ResumeLayout(false);
            this.pnlToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxFlavors;
        private System.Windows.Forms.RadioButton rdo1scoop;
        private System.Windows.Forms.RadioButton rdo2scoop;
        private System.Windows.Forms.RadioButton rdo3scoop;
        private System.Windows.Forms.CheckBox chBoxSprinkles;
        private System.Windows.Forms.CheckBox chBoxOreos;
        private System.Windows.Forms.CheckBox chBoxChocChips;
        private System.Windows.Forms.CheckBox ChBoxCherSyrp;
        private System.Windows.Forms.CheckBox ChBoxGumWrm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlScoops;
        private System.Windows.Forms.Panel pnlToppings;
        private System.Windows.Forms.Label lblFlavors;
        private System.Windows.Forms.Label lblScoopa;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblTotal;
    }
}

