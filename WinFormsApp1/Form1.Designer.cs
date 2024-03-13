namespace WinFormsApp1
{
    partial class Form1
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
            itemsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            seedBox = new TextBox();
            capacityTextBox = new TextBox();
            generateItemsButton = new Button();
            label4 = new Label();
            label5 = new Label();
            packItemsButton = new Button();
            generatedItemsTextBox = new TextBox();
            packedItemstextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            totalValueLabel = new Label();
            totalWeightLabel = new Label();
            SuspendLayout();
            // 
            // itemsTextBox
            // 
            itemsTextBox.Location = new Point(12, 63);
            itemsTextBox.Name = "itemsTextBox";
            itemsTextBox.Size = new Size(208, 31);
            itemsTextBox.TabIndex = 0;
            itemsTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 1;
            label1.Text = "Ilość przedmiotów";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 2;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 3;
            label3.Text = "Pojemność plecaka";
            // 
            // seedBox
            // 
            seedBox.Location = new Point(12, 157);
            seedBox.Name = "seedBox";
            seedBox.Size = new Size(208, 31);
            seedBox.TabIndex = 4;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(12, 258);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(208, 31);
            capacityTextBox.TabIndex = 5;
            // 
            // generateItemsButton
            // 
            generateItemsButton.BackColor = SystemColors.ActiveCaption;
            generateItemsButton.Font = new Font("Segoe UI", 10F);
            generateItemsButton.Location = new Point(12, 328);
            generateItemsButton.Name = "generateItemsButton";
            generateItemsButton.Size = new Size(208, 46);
            generateItemsButton.TabIndex = 6;
            generateItemsButton.Text = "Wylosuj przedmioty";
            generateItemsButton.UseVisualStyleBackColor = false;
            generateItemsButton.Click += generateItemsButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(281, 17);
            label4.Name = "label4";
            label4.Size = new Size(276, 32);
            label4.TabIndex = 8;
            label4.Text = "Wylosowane przedmioty";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(701, 17);
            label5.Name = "label5";
            label5.Size = new Size(263, 32);
            label5.TabIndex = 10;
            label5.Text = "Spakowane przedmioty";
            // 
            // packItemsButton
            // 
            packItemsButton.BackColor = SystemColors.ActiveCaption;
            packItemsButton.Font = new Font("Segoe UI", 10F);
            packItemsButton.Location = new Point(12, 398);
            packItemsButton.Name = "packItemsButton";
            packItemsButton.Size = new Size(208, 46);
            packItemsButton.TabIndex = 11;
            packItemsButton.Text = "Spakuj przedmioty";
            packItemsButton.UseVisualStyleBackColor = false;
            packItemsButton.Click += packItemsButton_Click;
            // 
            // generatedItemsTextBox
            // 
            generatedItemsTextBox.Location = new Point(248, 63);
            generatedItemsTextBox.Multiline = true;
            generatedItemsTextBox.Name = "generatedItemsTextBox";
            generatedItemsTextBox.ReadOnly = true;
            generatedItemsTextBox.ScrollBars = ScrollBars.Vertical;
            generatedItemsTextBox.Size = new Size(434, 394);
            generatedItemsTextBox.TabIndex = 12;
            // 
            // packedItemstextBox
            // 
            packedItemstextBox.Location = new Point(701, 63);
            packedItemstextBox.Multiline = true;
            packedItemstextBox.Name = "packedItemstextBox";
            packedItemstextBox.ReadOnly = true;
            packedItemstextBox.ScrollBars = ScrollBars.Vertical;
            packedItemstextBox.Size = new Size(472, 251);
            packedItemstextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(701, 353);
            label6.Name = "label6";
            label6.Size = new Size(192, 30);
            label6.TabIndex = 14;
            label6.Text = "Całkowita wartość:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(701, 406);
            label7.Name = "label7";
            label7.Size = new Size(169, 30);
            label7.TabIndex = 15;
            label7.Text = "Całkowita waga:";
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Font = new Font("Segoe UI", 11F);
            totalValueLabel.Location = new Point(964, 344);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(0, 30);
            totalValueLabel.TabIndex = 16;
            // 
            // totalWeightLabel
            // 
            totalWeightLabel.AutoSize = true;
            totalWeightLabel.Font = new Font("Segoe UI", 11F);
            totalWeightLabel.Location = new Point(964, 406);
            totalWeightLabel.Name = "totalWeightLabel";
            totalWeightLabel.Size = new Size(0, 30);
            totalWeightLabel.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 469);
            Controls.Add(totalWeightLabel);
            Controls.Add(totalValueLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(packedItemstextBox);
            Controls.Add(generatedItemsTextBox);
            Controls.Add(packItemsButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(generateItemsButton);
            Controls.Add(capacityTextBox);
            Controls.Add(seedBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(itemsTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemsTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox seedBox;
        private TextBox capacityTextBox;
        private Button generateItemsButton;
        private Label label4;
        private Label label5;
        private Button packItemsButton;
        private TextBox generatedItemsTextBox;
        private TextBox packedItemstextBox;
        private Label label6;
        private Label label7;
        private Label totalValueLabel;
        private Label totalWeightLabel;
    }
}
