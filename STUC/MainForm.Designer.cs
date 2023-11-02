namespace STUC
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            btnCalculate = new Button();
            lblRecomendPrice = new Label();
            lblBonus = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbItemName = new TextBox();
            lblCSMarketPrice = new Label();
            lblSteamPrice = new Label();
            lblVolume = new Label();
            lblResult = new Label();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(175, 125);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(154, 54);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblRecomendPrice
            // 
            lblRecomendPrice.AutoSize = true;
            lblRecomendPrice.Location = new Point(12, 107);
            lblRecomendPrice.Name = "lblRecomendPrice";
            lblRecomendPrice.Size = new Size(128, 15);
            lblRecomendPrice.TabIndex = 1;
            lblRecomendPrice.Text = "Рекомендуемая цена*";
            // 
            // lblBonus
            // 
            lblBonus.Location = new Point(175, 107);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(154, 15);
            lblBonus.TabIndex = 2;
            lblBonus.Text = "Бонус:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, -1);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 3;
            label3.Text = "Цена на CSMarket";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 4;
            label4.Text = "Цена в Steam";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 5;
            label5.Text = "Продаж за сутки";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(175, -1);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 6;
            label6.Text = "Название предмета";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(175, 56);
            label7.Name = "label7";
            label7.Size = new Size(154, 25);
            label7.TabIndex = 7;
            label7.Text = "Итог";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbItemName
            // 
            tbItemName.BackColor = SystemColors.Control;
            tbItemName.BorderStyle = BorderStyle.FixedSingle;
            tbItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbItemName.Location = new Point(175, 24);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(154, 29);
            tbItemName.TabIndex = 12;
            // 
            // lblCSMarketPrice
            // 
            lblCSMarketPrice.BorderStyle = BorderStyle.FixedSingle;
            lblCSMarketPrice.FlatStyle = FlatStyle.Flat;
            lblCSMarketPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCSMarketPrice.Location = new Point(12, 24);
            lblCSMarketPrice.Name = "lblCSMarketPrice";
            lblCSMarketPrice.Size = new Size(154, 29);
            lblCSMarketPrice.TabIndex = 13;
            lblCSMarketPrice.Tag = "label8";
            lblCSMarketPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSteamPrice
            // 
            lblSteamPrice.BorderStyle = BorderStyle.FixedSingle;
            lblSteamPrice.FlatStyle = FlatStyle.Flat;
            lblSteamPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSteamPrice.Location = new Point(12, 78);
            lblSteamPrice.Name = "lblSteamPrice";
            lblSteamPrice.Size = new Size(154, 29);
            lblSteamPrice.TabIndex = 14;
            lblSteamPrice.Tag = "label8";
            lblSteamPrice.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lblSteamPrice, "Двойное нажатие чтобы скопировать значение");
            // 
            // lblVolume
            // 
            lblVolume.BorderStyle = BorderStyle.FixedSingle;
            lblVolume.FlatStyle = FlatStyle.Flat;
            lblVolume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolume.Location = new Point(12, 150);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(154, 29);
            lblVolume.TabIndex = 15;
            lblVolume.Tag = "label8";
            lblVolume.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.FlatStyle = FlatStyle.Flat;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(175, 78);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(154, 29);
            lblResult.TabIndex = 16;
            lblResult.Tag = "label8";
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(lblResult, "Двойное нажатие чтобы скопировать значение");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(341, 189);
            Controls.Add(lblResult);
            Controls.Add(lblVolume);
            Controls.Add(lblSteamPrice);
            Controls.Add(lblCSMarketPrice);
            Controls.Add(tbItemName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblBonus);
            Controls.Add(lblRecomendPrice);
            Controls.Add(btnCalculate);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STUC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblRecomendPrice;
        private Label lblBonus;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbItemName;
        private Label lblCSMarketPrice;
        private Label lblSteamPrice;
        private Label lblVolume;
        private Label lblResult;
        private ToolTip toolTip;
    }
}