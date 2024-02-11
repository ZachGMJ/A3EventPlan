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
            lblHeading.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(273, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(279, 34);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Farm Burger Specials";
            lblHeading.Click += label1_Click;
            // 
            // picPrime
            // 
            picPrime.Location = new Point(98, 102);
            picPrime.Name = "picPrime";
            picPrime.Size = new Size(214, 232);
            picPrime.TabIndex = 1;
            picPrime.TabStop = false;
            // 
            // picVeggie
            // 
            picVeggie.Location = new Point(504, 102);
            picVeggie.Name = "picVeggie";
            picVeggie.Size = new Size(214, 232);
            picVeggie.TabIndex = 2;
            picVeggie.TabStop = false;
            // 
            // btnPrime
            // 
            btnPrime.Location = new Point(147, 355);
            btnPrime.Name = "btnPrime";
            btnPrime.Size = new Size(104, 29);
            btnPrime.TabIndex = 3;
            btnPrime.Text = "Prime Beef";
            btnPrime.UseVisualStyleBackColor = true;
            // 
            // btnVeggie
            // 
            btnVeggie.Location = new Point(553, 355);
            btnVeggie.Name = "btnVeggie";
            btnVeggie.Size = new Size(104, 29);
            btnVeggie.TabIndex = 4;
            btnVeggie.Text = "Veggie";
            btnVeggie.UseVisualStyleBackColor = true;
            // 
            // btnSelectMeal
            // 
            btnSelectMeal.Location = new Point(348, 355);
            btnSelectMeal.Name = "btnSelectMeal";
            btnSelectMeal.Size = new Size(103, 29);
            btnSelectMeal.TabIndex = 5;
            btnSelectMeal.Text = "Select Meal";
            btnSelectMeal.UseVisualStyleBackColor = true;
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
            // 
            // btnExit
            // 
            btnExit.Location = new Point(348, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmBurgers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 552);
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
