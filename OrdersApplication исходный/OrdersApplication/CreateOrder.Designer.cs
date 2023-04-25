namespace OrdersApplication
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderItemsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addItemsButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalItemsLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderItemsCheckedListBox
            // 
            this.orderItemsCheckedListBox.FormattingEnabled = true;
            this.orderItemsCheckedListBox.Items.AddRange(new object[] {
            "Racing Wheel",
            "Pedals",
            "Racer bicycle",
            "Mountain bicycle",
            "Drinking bottle"});
            this.orderItemsCheckedListBox.Location = new System.Drawing.Point(12, 51);
            this.orderItemsCheckedListBox.Name = "orderItemsCheckedListBox";
            this.orderItemsCheckedListBox.Size = new System.Drawing.Size(169, 79);
            this.orderItemsCheckedListBox.TabIndex = 2;
            // 
            // addItemsButton
            // 
            this.addItemsButton.Location = new System.Drawing.Point(13, 156);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(75, 23);
            this.addItemsButton.TabIndex = 3;
            this.addItemsButton.Text = "Add Item(s)";
            this.addItemsButton.UseVisualStyleBackColor = true;
            this.addItemsButton.Click += new System.EventHandler(this.addItemsButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Items: ";
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.Location = new System.Drawing.Point(90, 202);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(10, 13);
            this.totalItemsLabel.TabIndex = 10;
            this.totalItemsLabel.Text = " ";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(70, 15);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(10, 13);
            this.orderIdLabel.TabIndex = 11;
            this.orderIdLabel.Text = " ";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 273);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.totalItemsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.addItemsButton);
            this.Controls.Add(this.orderItemsCheckedListBox);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckedListBox orderItemsCheckedListBox;
        private System.Windows.Forms.Button addItemsButton;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalItemsLabel;
        private System.Windows.Forms.Label orderIdLabel;
    }
}