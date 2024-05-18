
namespace DKSystem
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.titleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.generateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.menuContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.orderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.titleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuContentPanel.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.White;
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.btnHam);
            this.titleBar.Location = new System.Drawing.Point(12, 12);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1093, 57);
            this.titleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DUKE FOOD TRUCK";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(253, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "MENU";
            // 
            // generateBtn
            // 
            this.generateBtn.BorderRadius = 10;
            this.generateBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.generateBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.generateBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.generateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateBtn.FillColor = System.Drawing.Color.Aqua;
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.Black;
            this.generateBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.generateBtn.Location = new System.Drawing.Point(804, 597);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(301, 45);
            this.generateBtn.TabIndex = 14;
            this.generateBtn.Text = "GENERATE RECEIPT";
            this.generateBtn.Click += new System.EventHandler(this.guna2Button11_Click);
            // 
            // menuContentPanel
            // 
            this.menuContentPanel.AutoScroll = true;
            this.menuContentPanel.Controls.Add(this.guna2Panel3);
            this.menuContentPanel.Controls.Add(this.guna2Panel4);
            this.menuContentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuContentPanel.Location = new System.Drawing.Point(253, 135);
            this.menuContentPanel.Name = "menuContentPanel";
            this.menuContentPanel.Size = new System.Drawing.Size(541, 506);
            this.menuContentPanel.TabIndex = 16;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.label9);
            this.guna2Panel3.Controls.Add(this.guna2CheckBox1);
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(535, 100);
            this.guna2Panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Price: ";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.Location = new System.Drawing.Point(34, 11);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(248, 75);
            this.guna2CheckBox1.TabIndex = 0;
            this.guna2CheckBox1.Text = "guna2CheckBox1";
            this.guna2CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(3, 109);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(535, 100);
            this.guna2Panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(800, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total: ";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.linkLabel1);
            this.guna2Panel2.Controls.Add(this.menuBtn);
            this.guna2Panel2.Location = new System.Drawing.Point(13, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(234, 565);
            this.guna2Panel2.TabIndex = 18;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(20, 509);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(52, 34);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Exit";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(16, 472);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 21);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(1033, 522);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(72, 23);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "Clear";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // orderPanel
            // 
            this.orderPanel.AutoScroll = true;
            this.orderPanel.BackColor = System.Drawing.Color.Silver;
            this.orderPanel.Controls.Add(this.panel2);
            this.orderPanel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPanel.Location = new System.Drawing.Point(804, 76);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(300, 446);
            this.orderPanel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.guna2NumericUpDown1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 145);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(94, 56);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(98, 29);
            this.guna2NumericUpDown1.TabIndex = 3;
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "foodName";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.Location = new System.Drawing.Point(862, 562);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(17, 20);
            this.totalPriceLbl.TabIndex = 22;
            this.totalPriceLbl.Text = "0";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::DKSystem.Properties.Resources.ic_baseline_minus;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(260, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.TabIndex = 5;
            // 
            // menuBtn
            // 
            this.menuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuBtn.FillColor = System.Drawing.Color.Purple;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = global::DKSystem.Properties.Resources.bx_food_menu;
            this.menuBtn.Location = new System.Drawing.Point(-1, 73);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(236, 45);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "MENU";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(21, 8);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(43, 45);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 3;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPOS
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1117, 654);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.menuContentPanel);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuContentPanel.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button generateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel menuContentPanel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button menuBtn;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.FlowLayoutPanel orderPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label9;
    }
}

