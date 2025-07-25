namespace Payroll_Management_App
{
    partial class PaySalaryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); 
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            monthLabel = new Label();
            monthComboBox = new ComboBox();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            bonusLabel = new Label();
            bonusTextBox = new TextBox();
            
            // Employee selection
            employeeSelectionLabel = new Label();
            employeeSelectionComboBox = new ComboBox();
            
            // Allowances section
            allowancesLabel = new Label();
            allowancesPanel = new Panel();
            houseRentAllowanceLabel = new Label();
            houseRentAllowanceTextBox = new TextBox();
            medicalAllowanceLabel = new Label();
            medicalAllowanceTextBox = new TextBox();
            educationAllowanceLabel = new Label();
            educationAllowanceTextBox = new TextBox();
            telephoneAllowanceLabel = new Label();
            telephoneAllowanceTextBox = new TextBox();
            festivalBonusLabel = new Label();
            festivalBonusTextBox = new TextBox();
            transportAllowanceLabel = new Label();
            transportAllowanceTextBox = new TextBox();
            othersAllowanceLabel = new Label();
            othersAllowanceTextBox = new TextBox();
            
            // Deductions section
            deductionsLabel = new Label();
            deductionsPanel = new Panel();
            gpfLabel = new Label();
            gpfTextBox = new TextBox();
            houseRentDeductionLabel = new Label();
            houseRentDeductionTextBox = new TextBox();
            insurancePremiumLabel = new Label();
            insurancePremiumTextBox = new TextBox();
            electricityBillLabel = new Label();
            electricityBillTextBox = new TextBox();
            transportBillLabel = new Label();
            transportBillTextBox = new TextBox();
            incomeTaxLabel = new Label();
            incomeTaxTextBox = new TextBox();
            othersDeductionLabel = new Label();
            othersDeductionTextBox = new TextBox();
            
            submitButton = new Button();
            
            allowancesPanel.SuspendLayout();
            deductionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(33, 37, 41);
            titleLabel.Location = new Point(30, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(180, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Salary Processing";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            monthLabel.ForeColor = Color.FromArgb(33, 37, 41);
            monthLabel.Location = new Point(30, 80);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(50, 19);
            monthLabel.TabIndex = 1;
            monthLabel.Text = "Month";
            // 
            // monthComboBox
            // 
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.Font = new Font("Segoe UI", 10F);
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(30, 105);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(200, 25);
            monthComboBox.TabIndex = 2;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            yearLabel.ForeColor = Color.FromArgb(33, 37, 41);
            yearLabel.Location = new Point(260, 80);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(35, 19);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "Year";
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Segoe UI", 10F);
            yearTextBox.Location = new Point(260, 105);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(120, 25);
            yearTextBox.TabIndex = 4;
            yearTextBox.Text = "2025";
            // 
            // bonusLabel
            // 
            bonusLabel.AutoSize = true;
            bonusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bonusLabel.ForeColor = Color.FromArgb(33, 37, 41);
            bonusLabel.Location = new Point(410, 80);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new Size(78, 19);
            bonusLabel.TabIndex = 5;
            bonusLabel.Text = "Bonus (%)";
            // 
            // bonusTextBox
            // 
            bonusTextBox.Font = new Font("Segoe UI", 10F);
            bonusTextBox.Location = new Point(410, 105);
            bonusTextBox.Name = "bonusTextBox";
            bonusTextBox.Size = new Size(120, 25);
            bonusTextBox.TabIndex = 6;
            bonusTextBox.Text = "0";
            // 
            // employeeSelectionLabel
            // 
            employeeSelectionLabel.AutoSize = true;
            employeeSelectionLabel.Font = new Font("Segoe UI", 10F);
            employeeSelectionLabel.ForeColor = Color.FromArgb(33, 37, 41);
            employeeSelectionLabel.Location = new Point(570, 80);
            employeeSelectionLabel.Name = "employeeSelectionLabel";
            employeeSelectionLabel.Size = new Size(105, 19);
            employeeSelectionLabel.TabIndex = 7;
            employeeSelectionLabel.Text = "Select Employee";
            // 
            // employeeSelectionComboBox
            // 
            employeeSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeSelectionComboBox.Font = new Font("Segoe UI", 10F);
            employeeSelectionComboBox.Location = new Point(570, 105);
            employeeSelectionComboBox.Name = "employeeSelectionComboBox";
            employeeSelectionComboBox.Size = new Size(150, 25);
            employeeSelectionComboBox.TabIndex = 8;
            // 
            // allowancesLabel
            // 
            allowancesLabel.AutoSize = true;
            allowancesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            allowancesLabel.ForeColor = Color.FromArgb(33, 37, 41);
            allowancesLabel.Location = new Point(30, 160);
            allowancesLabel.Name = "allowancesLabel";
            allowancesLabel.Size = new Size(100, 25);
            allowancesLabel.TabIndex = 7;
            allowancesLabel.Text = "Allowances";
            
            // 
            // allowancesPanel
            // 
            allowancesPanel.BackColor = Color.FromArgb(248, 249, 250);
            allowancesPanel.BorderStyle = BorderStyle.FixedSingle;
            allowancesPanel.Controls.Add(houseRentAllowanceLabel);
            allowancesPanel.Controls.Add(houseRentAllowanceTextBox);
            allowancesPanel.Controls.Add(medicalAllowanceLabel);
            allowancesPanel.Controls.Add(medicalAllowanceTextBox);
            allowancesPanel.Controls.Add(educationAllowanceLabel);
            allowancesPanel.Controls.Add(educationAllowanceTextBox);
            allowancesPanel.Controls.Add(telephoneAllowanceLabel);
            allowancesPanel.Controls.Add(telephoneAllowanceTextBox);
            allowancesPanel.Controls.Add(festivalBonusLabel);
            allowancesPanel.Controls.Add(festivalBonusTextBox);
            allowancesPanel.Controls.Add(transportAllowanceLabel);
            allowancesPanel.Controls.Add(transportAllowanceTextBox);
            allowancesPanel.Controls.Add(othersAllowanceLabel);
            allowancesPanel.Controls.Add(othersAllowanceTextBox);
            allowancesPanel.Location = new Point(30, 190);
            allowancesPanel.Name = "allowancesPanel";
            allowancesPanel.Size = new Size(350, 250);
            allowancesPanel.TabIndex = 8;
            
            // House Rent Allowance
            houseRentAllowanceLabel.AutoSize = true;
            houseRentAllowanceLabel.Font = new Font("Segoe UI", 9F);
            houseRentAllowanceLabel.Location = new Point(10, 15);
            houseRentAllowanceLabel.Name = "houseRentAllowanceLabel";
            houseRentAllowanceLabel.Size = new Size(120, 15);
            houseRentAllowanceLabel.Text = "House Rent Allowance:";
            
            houseRentAllowanceTextBox.Font = new Font("Segoe UI", 9F);
            houseRentAllowanceTextBox.Location = new Point(200, 12);
            houseRentAllowanceTextBox.Name = "houseRentAllowanceTextBox";
            houseRentAllowanceTextBox.Size = new Size(120, 23);
            houseRentAllowanceTextBox.Text = "0";
            
            // Medical Allowance
            medicalAllowanceLabel.AutoSize = true;
            medicalAllowanceLabel.Font = new Font("Segoe UI", 9F);
            medicalAllowanceLabel.Location = new Point(10, 45);
            medicalAllowanceLabel.Name = "medicalAllowanceLabel";
            medicalAllowanceLabel.Size = new Size(105, 15);
            medicalAllowanceLabel.Text = "Medical Allowance:";
            
            medicalAllowanceTextBox.Font = new Font("Segoe UI", 9F);
            medicalAllowanceTextBox.Location = new Point(200, 42);
            medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            medicalAllowanceTextBox.Size = new Size(120, 23);
            medicalAllowanceTextBox.Text = "0";
            
            // Education Allowance
            educationAllowanceLabel.AutoSize = true;
            educationAllowanceLabel.Font = new Font("Segoe UI", 9F);
            educationAllowanceLabel.Location = new Point(10, 75);
            educationAllowanceLabel.Name = "educationAllowanceLabel";
            educationAllowanceLabel.Size = new Size(115, 15);
            educationAllowanceLabel.Text = "Education Allowance:";
            
            educationAllowanceTextBox.Font = new Font("Segoe UI", 9F);
            educationAllowanceTextBox.Location = new Point(200, 72);
            educationAllowanceTextBox.Name = "educationAllowanceTextBox";
            educationAllowanceTextBox.Size = new Size(120, 23);
            educationAllowanceTextBox.Text = "0";
            
            // Telephone Allowance
            telephoneAllowanceLabel.AutoSize = true;
            telephoneAllowanceLabel.Font = new Font("Segoe UI", 9F);
            telephoneAllowanceLabel.Location = new Point(10, 105);
            telephoneAllowanceLabel.Name = "telephoneAllowanceLabel";
            telephoneAllowanceLabel.Size = new Size(115, 15);
            telephoneAllowanceLabel.Text = "Telephone Allowance:";
            
            telephoneAllowanceTextBox.Font = new Font("Segoe UI", 9F);
            telephoneAllowanceTextBox.Location = new Point(200, 102);
            telephoneAllowanceTextBox.Name = "telephoneAllowanceTextBox";
            telephoneAllowanceTextBox.Size = new Size(120, 23);
            telephoneAllowanceTextBox.Text = "0";
            
            // Festival Bonus
            festivalBonusLabel.AutoSize = true;
            festivalBonusLabel.Font = new Font("Segoe UI", 9F);
            festivalBonusLabel.Location = new Point(10, 135);
            festivalBonusLabel.Name = "festivalBonusLabel";
            festivalBonusLabel.Size = new Size(85, 15);
            festivalBonusLabel.Text = "Festival Bonus:";
            
            festivalBonusTextBox.Font = new Font("Segoe UI", 9F);
            festivalBonusTextBox.Location = new Point(200, 132);
            festivalBonusTextBox.Name = "festivalBonusTextBox";
            festivalBonusTextBox.Size = new Size(120, 23);
            festivalBonusTextBox.Text = "0";
            
            // Transport Allowance
            transportAllowanceLabel.AutoSize = true;
            transportAllowanceLabel.Font = new Font("Segoe UI", 9F);
            transportAllowanceLabel.Location = new Point(10, 165);
            transportAllowanceLabel.Name = "transportAllowanceLabel";
            transportAllowanceLabel.Size = new Size(115, 15);
            transportAllowanceLabel.Text = "Transport Allowance:";
            
            transportAllowanceTextBox.Font = new Font("Segoe UI", 9F);
            transportAllowanceTextBox.Location = new Point(200, 162);
            transportAllowanceTextBox.Name = "transportAllowanceTextBox";
            transportAllowanceTextBox.Size = new Size(120, 23);
            transportAllowanceTextBox.Text = "0";
            
            // Others Allowance
            othersAllowanceLabel.AutoSize = true;
            othersAllowanceLabel.Font = new Font("Segoe UI", 9F);
            othersAllowanceLabel.Location = new Point(10, 195);
            othersAllowanceLabel.Name = "othersAllowanceLabel";
            othersAllowanceLabel.Size = new Size(95, 15);
            othersAllowanceLabel.Text = "Others Allowance:";
            
            othersAllowanceTextBox.Font = new Font("Segoe UI", 9F);
            othersAllowanceTextBox.Location = new Point(200, 192);
            othersAllowanceTextBox.Name = "othersAllowanceTextBox";
            othersAllowanceTextBox.Size = new Size(120, 23);
            othersAllowanceTextBox.Text = "0";
            
            // 
            // deductionsLabel
            // 
            deductionsLabel.AutoSize = true;
            deductionsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deductionsLabel.ForeColor = Color.FromArgb(33, 37, 41);
            deductionsLabel.Location = new Point(400, 160);
            deductionsLabel.Name = "deductionsLabel";
            deductionsLabel.Size = new Size(100, 25);
            deductionsLabel.TabIndex = 9;
            deductionsLabel.Text = "Deductions";
            
            // 
            // deductionsPanel
            // 
            deductionsPanel.BackColor = Color.FromArgb(248, 249, 250);
            deductionsPanel.BorderStyle = BorderStyle.FixedSingle;
            deductionsPanel.Controls.Add(gpfLabel);
            deductionsPanel.Controls.Add(gpfTextBox);
            deductionsPanel.Controls.Add(houseRentDeductionLabel);
            deductionsPanel.Controls.Add(houseRentDeductionTextBox);
            deductionsPanel.Controls.Add(insurancePremiumLabel);
            deductionsPanel.Controls.Add(insurancePremiumTextBox);
            deductionsPanel.Controls.Add(electricityBillLabel);
            deductionsPanel.Controls.Add(electricityBillTextBox);
            deductionsPanel.Controls.Add(transportBillLabel);
            deductionsPanel.Controls.Add(transportBillTextBox);
            deductionsPanel.Controls.Add(incomeTaxLabel);
            deductionsPanel.Controls.Add(incomeTaxTextBox);
            deductionsPanel.Controls.Add(othersDeductionLabel);
            deductionsPanel.Controls.Add(othersDeductionTextBox);
            deductionsPanel.Location = new Point(400, 190);
            deductionsPanel.Name = "deductionsPanel";
            deductionsPanel.Size = new Size(350, 250);
            deductionsPanel.TabIndex = 10;
            
            // GPF
            gpfLabel.AutoSize = true;
            gpfLabel.Font = new Font("Segoe UI", 9F);
            gpfLabel.Location = new Point(10, 15);
            gpfLabel.Name = "gpfLabel";
            gpfLabel.Size = new Size(30, 15);
            gpfLabel.Text = "GPF:";
            
            gpfTextBox.Font = new Font("Segoe UI", 9F);
            gpfTextBox.Location = new Point(200, 12);
            gpfTextBox.Name = "gpfTextBox";
            gpfTextBox.Size = new Size(120, 23);
            gpfTextBox.Text = "0";
            
            // House Rent Deduction
            houseRentDeductionLabel.AutoSize = true;
            houseRentDeductionLabel.Font = new Font("Segoe UI", 9F);
            houseRentDeductionLabel.Location = new Point(10, 45);
            houseRentDeductionLabel.Name = "houseRentDeductionLabel";
            houseRentDeductionLabel.Size = new Size(125, 15);
            houseRentDeductionLabel.Text = "House Rent Deduction:";
            
            houseRentDeductionTextBox.Font = new Font("Segoe UI", 9F);
            houseRentDeductionTextBox.Location = new Point(200, 42);
            houseRentDeductionTextBox.Name = "houseRentDeductionTextBox";
            houseRentDeductionTextBox.Size = new Size(120, 23);
            houseRentDeductionTextBox.Text = "0";
            
            // Insurance Premium
            insurancePremiumLabel.AutoSize = true;
            insurancePremiumLabel.Font = new Font("Segoe UI", 9F);
            insurancePremiumLabel.Location = new Point(10, 75);
            insurancePremiumLabel.Name = "insurancePremiumLabel";
            insurancePremiumLabel.Size = new Size(110, 15);
            insurancePremiumLabel.Text = "Insurance Premium:";
            
            insurancePremiumTextBox.Font = new Font("Segoe UI", 9F);
            insurancePremiumTextBox.Location = new Point(200, 72);
            insurancePremiumTextBox.Name = "insurancePremiumTextBox";
            insurancePremiumTextBox.Size = new Size(120, 23);
            insurancePremiumTextBox.Text = "0";
            
            // Electricity Bill
            electricityBillLabel.AutoSize = true;
            electricityBillLabel.Font = new Font("Segoe UI", 9F);
            electricityBillLabel.Location = new Point(10, 105);
            electricityBillLabel.Name = "electricityBillLabel";
            electricityBillLabel.Size = new Size(80, 15);
            electricityBillLabel.Text = "Electricity Bill:";
            
            electricityBillTextBox.Font = new Font("Segoe UI", 9F);
            electricityBillTextBox.Location = new Point(200, 102);
            electricityBillTextBox.Name = "electricityBillTextBox";
            electricityBillTextBox.Size = new Size(120, 23);
            electricityBillTextBox.Text = "0";
            
            // Transport Bill
            transportBillLabel.AutoSize = true;
            transportBillLabel.Font = new Font("Segoe UI", 9F);
            transportBillLabel.Location = new Point(10, 135);
            transportBillLabel.Name = "transportBillLabel";
            transportBillLabel.Size = new Size(80, 15);
            transportBillLabel.Text = "Transport Bill:";
            
            transportBillTextBox.Font = new Font("Segoe UI", 9F);
            transportBillTextBox.Location = new Point(200, 132);
            transportBillTextBox.Name = "transportBillTextBox";
            transportBillTextBox.Size = new Size(120, 23);
            transportBillTextBox.Text = "0";
            
            // Income Tax
            incomeTaxLabel.AutoSize = true;
            incomeTaxLabel.Font = new Font("Segoe UI", 9F);
            incomeTaxLabel.Location = new Point(10, 165);
            incomeTaxLabel.Name = "incomeTaxLabel";
            incomeTaxLabel.Size = new Size(70, 15);
            incomeTaxLabel.Text = "Income Tax:";
            
            incomeTaxTextBox.Font = new Font("Segoe UI", 9F);
            incomeTaxTextBox.Location = new Point(200, 162);
            incomeTaxTextBox.Name = "incomeTaxTextBox";
            incomeTaxTextBox.Size = new Size(120, 23);
            incomeTaxTextBox.Text = "0";
            
            // Others Deduction
            othersDeductionLabel.AutoSize = true;
            othersDeductionLabel.Font = new Font("Segoe UI", 9F);
            othersDeductionLabel.Location = new Point(10, 195);
            othersDeductionLabel.Name = "othersDeductionLabel";
            othersDeductionLabel.Size = new Size(100, 15);
            othersDeductionLabel.Text = "Others Deduction:";
            
            othersDeductionTextBox.Font = new Font("Segoe UI", 9F);
            othersDeductionTextBox.Location = new Point(200, 192);
            othersDeductionTextBox.Name = "othersDeductionTextBox";
            othersDeductionTextBox.Size = new Size(120, 23);
            othersDeductionTextBox.Text = "0";
            
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(0, 123, 255);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(350, 460);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(160, 50);
            submitButton.TabIndex = 11;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            
            // 
            // PaySalaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 530);
            Controls.Add(submitButton);
            Controls.Add(deductionsPanel);
            Controls.Add(deductionsLabel);
            Controls.Add(allowancesPanel);
            Controls.Add(allowancesLabel);
            Controls.Add(employeeSelectionComboBox);
            Controls.Add(employeeSelectionLabel);
            Controls.Add(bonusTextBox);
            Controls.Add(bonusLabel);
            Controls.Add(yearTextBox);
            Controls.Add(yearLabel);
            Controls.Add(monthComboBox);
            Controls.Add(monthLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaySalaryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Salary Processing";
            allowancesPanel.ResumeLayout(false);
            allowancesPanel.PerformLayout();
            deductionsPanel.ResumeLayout(false);
            deductionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Label monthLabel;
        private ComboBox monthComboBox;
        private Label yearLabel;
        private TextBox yearTextBox;
        private Label bonusLabel;
        private TextBox bonusTextBox;
        
        // Employee Selection
        private Label employeeSelectionLabel;
        private ComboBox employeeSelectionComboBox;
        
        // Allowances Section
        private Label allowancesLabel;
        private Panel allowancesPanel;
        private Label houseRentAllowanceLabel;
        private TextBox houseRentAllowanceTextBox;
        private Label medicalAllowanceLabel;
        private TextBox medicalAllowanceTextBox;
        private Label educationAllowanceLabel;
        private TextBox educationAllowanceTextBox;
        private Label telephoneAllowanceLabel;
        private TextBox telephoneAllowanceTextBox;
        private Label festivalBonusLabel;
        private TextBox festivalBonusTextBox;
        private Label transportAllowanceLabel;
        private TextBox transportAllowanceTextBox;
        private Label othersAllowanceLabel;
        private TextBox othersAllowanceTextBox;
        
        // Deductions Section
        private Label deductionsLabel;
        private Panel deductionsPanel;
        private Label gpfLabel;
        private TextBox gpfTextBox;
        private Label houseRentDeductionLabel;
        private TextBox houseRentDeductionTextBox;
        private Label insurancePremiumLabel;
        private TextBox insurancePremiumTextBox;
        private Label electricityBillLabel;
        private TextBox electricityBillTextBox;
        private Label transportBillLabel;
        private TextBox transportBillTextBox;
        private Label incomeTaxLabel;
        private TextBox incomeTaxTextBox;
        private Label othersDeductionLabel;
        private TextBox othersDeductionTextBox;
        
        private Button submitButton;
    }
}
