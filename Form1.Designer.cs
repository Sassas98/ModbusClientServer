namespace ModbusClientServer {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            textIP = new TextBox();
            btnConnect = new Button();
            label3 = new Label();
            StatoLabel = new Label();
            btnScrivi = new Button();
            textValue = new TextBox();
            textAddress = new TextBox();
            labelValue = new Label();
            label7 = new Label();
            btnUpdate = new Button();
            output = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 53);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Server";
            // 
            // textIP
            // 
            textIP.Location = new Point(90, 53);
            textIP.Margin = new Padding(3, 2, 3, 2);
            textIP.Name = "textIP";
            textIP.Size = new Size(110, 23);
            textIP.TabIndex = 2;
            textIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(90, 88);
            btnConnect.Margin = new Padding(3, 2, 3, 2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(109, 22);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += Connetti;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 124);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Stato: ";
            // 
            // StatoLabel
            // 
            StatoLabel.AutoSize = true;
            StatoLabel.Location = new Point(131, 124);
            StatoLabel.Name = "StatoLabel";
            StatoLabel.Size = new Size(12, 15);
            StatoLabel.TabIndex = 6;
            StatoLabel.Text = "-";
            // 
            // btnScrivi
            // 
            btnScrivi.Location = new Point(90, 249);
            btnScrivi.Margin = new Padding(3, 2, 3, 2);
            btnScrivi.Name = "btnScrivi";
            btnScrivi.Size = new Size(109, 22);
            btnScrivi.TabIndex = 11;
            btnScrivi.Text = "Write";
            btnScrivi.UseVisualStyleBackColor = true;
            btnScrivi.Click += Scrivi;
            // 
            // textValue
            // 
            textValue.Location = new Point(90, 211);
            textValue.Margin = new Padding(3, 2, 3, 2);
            textValue.Name = "textValue";
            textValue.Size = new Size(110, 23);
            textValue.TabIndex = 10;
            textValue.Text = "0";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(90, 182);
            textAddress.Margin = new Padding(3, 2, 3, 2);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(110, 23);
            textAddress.TabIndex = 9;
            textAddress.Text = "0";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(42, 211);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(35, 15);
            labelValue.TabIndex = 8;
            labelValue.Text = "Value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 182);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 7;
            label7.Text = "Address";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(403, 280);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 22);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // output
            // 
            output.BackColor = Color.White;
            output.Location = new Point(309, 53);
            output.Margin = new Padding(3, 2, 3, 2);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(293, 204);
            output.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(700, 338);
            Controls.Add(output);
            Controls.Add(btnUpdate);
            Controls.Add(btnScrivi);
            Controls.Add(textValue);
            Controls.Add(textAddress);
            Controls.Add(labelValue);
            Controls.Add(label7);
            Controls.Add(StatoLabel);
            Controls.Add(label3);
            Controls.Add(btnConnect);
            Controls.Add(textIP);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textIP;
        private Button btnConnect;
        private Label label3;
        private Label StatoLabel;
        private Button btnScrivi;
        private TextBox textValue;
        private TextBox textAddress;
        private Label labelValue;
        private Label label7;
        private Button btnUpdate;
        private TextBox output;
    }
}