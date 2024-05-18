using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DKSystem
{
    public partial class frmPOS : Form
    {
        private string connString = "Server=sql12.freesqldatabase.com;database=sql12707321;user=sql12707321;password=pIZ472it8X";
        private List<Guna.UI2.WinForms.Guna2CheckBox> foods = new List<Guna.UI2.WinForms.Guna2CheckBox>();
        private Dictionary<Guna.UI2.WinForms.Guna2CheckBox, Panel> checkBoxPanelMap = new Dictionary<Guna.UI2.WinForms.Guna2CheckBox, Panel>();
        private Form1 receipt = new Form1();
        public frmPOS()
        {
            InitializeComponent();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                orderPanel.Controls.Clear();
                menuContentPanel.Controls.Clear();
                MySqlConnection con = new MySqlConnection(connString);
                con.Open();
                string qry = "SELECT * FROM `foods`";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Guna.UI2.WinForms.Guna2Panel foodPanel = new Guna.UI2.WinForms.Guna2Panel
                    {
                        BackColor = System.Drawing.Color.White,
                        Location = new System.Drawing.Point(3, 3),
                        Name = "foodPanel",
                        Size = new System.Drawing.Size(535, 100),
                        TabIndex = 0
                    };

                    Guna.UI2.WinForms.Guna2CheckBox foodCheck = new Guna.UI2.WinForms.Guna2CheckBox
                    {
                        CheckedState = { BorderColor = System.Drawing.Color.FromArgb(94, 148, 255), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(94, 148, 255) },
                        Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0),
                        Location = new System.Drawing.Point(34, 11),
                        Name = "foodCheck",
                        Size = new System.Drawing.Size(248, 75),
                        TabIndex = 0,
                        Text = reader.GetString("name"),
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        UncheckedState = { BorderColor = System.Drawing.Color.FromArgb(125, 137, 149), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(125, 137, 149) }
                    };

                    Label priceLbl = new Label
                    {
                        AutoSize = true,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        Location = new System.Drawing.Point(358, 40),
                        Name = "priceLbl",
                        Size = new System.Drawing.Size(45, 16),
                        TabIndex = 1,
                        Text = "Price: ₱" + reader.GetDouble("price")
                    };

                    foodCheck.CheckedChanged += new System.EventHandler(foodCheck_CheckChanged);

                    menuContentPanel.Controls.Add(foodPanel);
                    foodPanel.Controls.Add(foodCheck);
                    foodPanel.Controls.Add(priceLbl);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }

        private void btnHam_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodCheck_CheckChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CheckBox checkbox = sender as Guna.UI2.WinForms.Guna2CheckBox;
            Panel parentPanel = (Panel)checkbox.Parent;
            string[] priceLblSplit = parentPanel.Controls["priceLbl"].Text.Split('₱');
            double price = Convert.ToDouble(priceLblSplit[1]);
            if (checkbox != null)
            {
                if (checkbox.Checked)
                {
                    if (!checkBoxPanelMap.ContainsKey(checkbox))
                    {
                        Panel panel = new Panel
                        {
                            AutoScroll = true,
                            BackColor = System.Drawing.Color.White,
                            Location = new System.Drawing.Point(3, 3),
                            Name = "panel" + checkbox.Name,
                            Size = new System.Drawing.Size(275, 145),
                            TabIndex = 0
                        };
                        
                        Label name = new Label()
                        {
                            AutoSize = true,
                            Location = new System.Drawing.Point(17, 9),
                            Name = "labelName",
                            Size = new System.Drawing.Size(118, 30),
                            TabIndex = 0,
                            Text = checkbox.Text
                        };

                        Label priceLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(18, 107),
                            Name = "priceLabel",
                            Size = new System.Drawing.Size(54, 21),
                            TabIndex = 2,
                            Text = "Price: ₱"
                        };

                        Label priceNum = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(78, 108),
                            Name = "priceNum",
                            Size = new System.Drawing.Size(50, 20),
                            TabIndex = 4,
                            Text = Convert.ToString(price)
                        };

                        Label quanLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(18, 59),
                            Name = "quanLbl",
                            Size = new System.Drawing.Size(80, 21),
                            TabIndex = 1,
                            Text = "Quantity: "
                        };

                        Guna.UI2.WinForms.Guna2NumericUpDown quanNum = new Guna.UI2.WinForms.Guna2NumericUpDown
                        {
                            BackColor = System.Drawing.Color.Transparent,
                            Cursor = System.Windows.Forms.Cursors.IBeam,
                            Font = new System.Drawing.Font("Segoe UI", 9F),
                            Location = new System.Drawing.Point(94, 56),
                            Name = "quanNum",
                            Size = new System.Drawing.Size(98, 29),
                            TabIndex = 3,
                            Value = new decimal(new int[] {
                        1,
                        0,
                        0,
                        0})
                        };
                        quanNum.ValueChanged += (s, ev) => UpdatePrice();

                        orderPanel.Controls.Add(panel);
                        panel.Controls.Add(name);
                        panel.Controls.Add(priceLbl);
                        panel.Controls.Add(priceNum);
                        panel.Controls.Add(quanLbl);
                        panel.Controls.Add(quanNum);
                        checkBoxPanelMap[checkbox] = panel;
                    }
                }
                else
                {
                    if (checkBoxPanelMap.ContainsKey(checkbox))
                    {
                        Panel panel = checkBoxPanelMap[checkbox];
                        orderPanel.Controls.Remove(panel);
                        checkBoxPanelMap.Remove(checkbox);
                    }
                }
                UpdatePrice();
            }
        }

        private void UpdatePrice()
        {
            double total = 0;
            foreach(Panel panel in orderPanel.Controls)
            {
                string foodName = panel.Controls["labelName"].Text;
                Guna.UI2.WinForms.Guna2NumericUpDown quantitynum = (Guna.UI2.WinForms.Guna2NumericUpDown)panel.Controls["quanNum"];
                double priceFood;

                if (double.TryParse(panel.Controls["priceNum"].Text, out priceFood))
                {
                    total += Convert.ToDouble(quantitynum.Value) * priceFood;
                    
                }
            }
            totalPriceLbl.Text = Convert.ToString(total.ToString("0.00"));
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            orderPanel.Controls.Clear();
            
            foreach(Control cont in menuContentPanel.Controls)
            {
                if (cont is Guna.UI2.WinForms.Guna2Panel foodPanel)
                {
                    foreach (Control control in foodPanel.Controls)
                    {
                        if (control is Guna.UI2.WinForms.Guna2CheckBox check)
                        {
                            check.Checked = false;
                        }
                    }
                }
            }
        }

        private int orderNumber = 87482;

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            DateTime datenow = DateTime.Now;
            string dateonly = Convert.ToString(datenow);
            string[] today = dateonly.Split(' ');
            receipt.date.Text = today[0];
            receipt.orderNum.Text = Convert.ToString(orderNumber);
            foreach(Control cont in orderPanel.Controls)
            {
                if (cont is Panel panel)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is Guna.UI2.WinForms.Guna2NumericUpDown quanNumber)
                        {
                            receipt.productInfo.Rows.Add(panel.Controls["labelName"].Text, quanNumber.Value, panel.Controls["priceNum"].Text);
                        }
                    }
                }
            }
            receipt.totalPriceLbl.Text = totalPriceLbl.Text;

            receipt.Show();
            orderNumber++;
        }
    }
}
