namespace WeekThreeDemoTwo
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
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbCustomerFirstName = new System.Windows.Forms.TextBox();
            this.tbCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.tbOrderSummary = new System.Windows.Forms.TextBox();
            this.btnOrderSummary = new System.Windows.Forms.Button();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblQuantityWeight = new System.Windows.Forms.Label();
            this.lblQuantityPrice = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductWeight = new System.Windows.Forms.TextBox();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(213, 12);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(232, 20);
            this.tbCustomerID.TabIndex = 0;
            // 
            // tbCustomerFirstName
            // 
            this.tbCustomerFirstName.Location = new System.Drawing.Point(213, 38);
            this.tbCustomerFirstName.Name = "tbCustomerFirstName";
            this.tbCustomerFirstName.Size = new System.Drawing.Size(232, 20);
            this.tbCustomerFirstName.TabIndex = 1;
            // 
            // tbCustomerLastName
            // 
            this.tbCustomerLastName.Location = new System.Drawing.Point(213, 64);
            this.tbCustomerLastName.Name = "tbCustomerLastName";
            this.tbCustomerLastName.Size = new System.Drawing.Size(232, 20);
            this.tbCustomerLastName.TabIndex = 2;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(12, 9);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(195, 23);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Enter Customer ID:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFirstName.Location = new System.Drawing.Point(12, 35);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(177, 23);
            this.lblCustomerFirstName.TabIndex = 4;
            this.lblCustomerFirstName.Text = "Enter First Name:";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.Location = new System.Drawing.Point(12, 61);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(172, 23);
            this.lblCustomerLastName.TabIndex = 5;
            this.lblCustomerLastName.Text = "Enter Last Name:";
            // 
            // tbOrderSummary
            // 
            this.tbOrderSummary.Location = new System.Drawing.Point(16, 257);
            this.tbOrderSummary.Multiline = true;
            this.tbOrderSummary.Name = "tbOrderSummary";
            this.tbOrderSummary.Size = new System.Drawing.Size(465, 265);
            this.tbOrderSummary.TabIndex = 10;
            // 
            // btnOrderSummary
            // 
            this.btnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSummary.Location = new System.Drawing.Point(60, 198);
            this.btnOrderSummary.Name = "btnOrderSummary";
            this.btnOrderSummary.Size = new System.Drawing.Size(104, 53);
            this.btnOrderSummary.TabIndex = 7;
            this.btnOrderSummary.Text = "Order Summary";
            this.btnOrderSummary.UseVisualStyleBackColor = true;
            this.btnOrderSummary.Click += new System.EventHandler(this.btnOrderSummary_Click);
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Location = new System.Drawing.Point(16, 134);
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(261, 20);
            this.tbProductDescription.TabIndex = 3;
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Location = new System.Drawing.Point(283, 134);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(62, 20);
            this.tbProductQuantity.TabIndex = 4;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(66, 111);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(167, 20);
            this.lblProductDescription.TabIndex = 12;
            this.lblProductDescription.Text = "Product Description";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(285, 115);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblProductQuantity.TabIndex = 13;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // lblQuantityWeight
            // 
            this.lblQuantityWeight.AutoSize = true;
            this.lblQuantityWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityWeight.Location = new System.Drawing.Point(358, 115);
            this.lblQuantityWeight.Name = "lblQuantityWeight";
            this.lblQuantityWeight.Size = new System.Drawing.Size(50, 16);
            this.lblQuantityWeight.TabIndex = 14;
            this.lblQuantityWeight.Text = "Weight";
            // 
            // lblQuantityPrice
            // 
            this.lblQuantityPrice.AutoSize = true;
            this.lblQuantityPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityPrice.Location = new System.Drawing.Point(430, 115);
            this.lblQuantityPrice.Name = "lblQuantityPrice";
            this.lblQuantityPrice.Size = new System.Drawing.Size(39, 16);
            this.lblQuantityPrice.TabIndex = 15;
            this.lblQuantityPrice.Text = "Price";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(419, 134);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(62, 20);
            this.tbProductPrice.TabIndex = 6;
            // 
            // tbProductWeight
            // 
            this.tbProductWeight.Location = new System.Drawing.Point(351, 134);
            this.tbProductWeight.Name = "tbProductWeight";
            this.tbProductWeight.Size = new System.Drawing.Size(62, 20);
            this.tbProductWeight.TabIndex = 5;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitProgram.Location = new System.Drawing.Point(341, 198);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(104, 53);
            this.btnExitProgram.TabIndex = 9;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Current Shipping Cost Per Pound: $0.89/lb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.tbProductWeight);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.lblQuantityPrice);
            this.Controls.Add(this.lblQuantityWeight);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.tbProductDescription);
            this.Controls.Add(this.btnOrderSummary);
            this.Controls.Add(this.tbOrderSummary);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.tbCustomerLastName);
            this.Controls.Add(this.tbCustomerFirstName);
            this.Controls.Add(this.tbCustomerID);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbCustomerFirstName;
        private System.Windows.Forms.TextBox tbCustomerLastName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox tbOrderSummary;
        private System.Windows.Forms.Button btnOrderSummary;
        private System.Windows.Forms.TextBox tbProductDescription;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblQuantityWeight;
        private System.Windows.Forms.Label lblQuantityPrice;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductWeight;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

