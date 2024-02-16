namespace A3EventPlan
{
    partial class frmBurgers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new Label();
            picPrime = new PictureBox();
            picVeggie = new PictureBox();
            btnPrime = new Button();
            btnVeggie = new Button();
            btnSelectMeal = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picPrime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVeggie).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Tahoma", 16F);
            lblHeading.Location = new Point(260, 31);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(266, 33);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Farm Burger Specials";
            lblHeading.Click += label1_Click;
            // 
            // picPrime
            // 
            picPrime.Image = Properties.Resources.prime;
            picPrime.Location = new Point(66, 84);
            picPrime.Name = "picPrime";
            picPrime.Size = new Size(260, 250);
            picPrime.SizeMode = PictureBoxSizeMode.StretchImage;
            picPrime.TabIndex = 1;
            picPrime.TabStop = false;
            picPrime.Visible = false;
            picPrime.Click += picPrime_Click;
            // 
            // picVeggie
            // 
            picVeggie.Image = Properties.Resources.veggie;
            picVeggie.Location = new Point(479, 84);
            picVeggie.Name = "picVeggie";
            picVeggie.Size = new Size(260, 250);
            picVeggie.SizeMode = PictureBoxSizeMode.StretchImage;
            picVeggie.TabIndex = 2;
            picVeggie.TabStop = false;
            picVeggie.Visible = false;
            // 
            // btnPrime
            // 
            btnPrime.Location = new Point(124, 352);
            btnPrime.Name = "btnPrime";
            btnPrime.Size = new Size(128, 35);
            btnPrime.TabIndex = 3;
            btnPrime.Text = "Prime Beef";
            btnPrime.UseVisualStyleBackColor = true;
            btnPrime.Click += btnPrime_Click;
            // 
            // btnVeggie
            // 
            btnVeggie.Location = new Point(553, 355);
            btnVeggie.Name = "btnVeggie";
            btnVeggie.Size = new Size(128, 35);
            btnVeggie.TabIndex = 4;
            btnVeggie.Text = "Veggie";
            btnVeggie.UseVisualStyleBackColor = true;
            btnVeggie.Click += btnVeggie_Click;
            // 
            // btnSelectMeal
            // 
            btnSelectMeal.Location = new Point(338, 352);
            btnSelectMeal.Name = "btnSelectMeal";
            btnSelectMeal.Size = new Size(128, 35);
            btnSelectMeal.TabIndex = 5;
            btnSelectMeal.Text = "Select Meal";
            btnSelectMeal.UseVisualStyleBackColor = true;
            btnSelectMeal.Click += btnSelectMeal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 418);
            label1.Name = "label1";
            label1.Size = new Size(331, 18);
            label1.TabIndex = 6;
            label1.Text = "Choose a burger then click the Select Meal button";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(310, 451);
            label2.Name = "label2";
            label2.Size = new Size(172, 18);
            label2.TabIndex = 7;
            label2.Text = "Enjoy your special burger";
            label2.Visible = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(338, 496);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 35);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmBurgers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 543);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSelectMeal);
            Controls.Add(btnVeggie);
            Controls.Add(btnPrime);
            Controls.Add(picVeggie);
            Controls.Add(picPrime);
            Controls.Add(lblHeading);
            Name = "frmBurgers";
            Text = "Farm Burgers";
            ((System.ComponentModel.ISupportInitialize)picPrime).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVeggie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private PictureBox picPrime;
        private PictureBox picVeggie;
        private Button btnPrime;
        private Button btnVeggie;
        private Button btnSelectMeal;
        private Label label1;
        private Label label2;
        private Button btnExit;
    }
}
