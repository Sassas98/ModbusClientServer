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
            label1.Location = new Point(31, 71);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "IP Server";
            // 
            // textIP
            // 
            textIP.Location = new Point(103, 71);
            textIP.Name = "textIP";
            textIP.Size = new Size(125, 27);
            textIP.TabIndex = 2;
            textIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(103, 117);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(125, 29);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += Connetti;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 166);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Stato: ";
            // 
            // StatoLabel
            // 
            StatoLabel.AutoSize = true;
            StatoLabel.Location = new Point(150, 166);
            StatoLabel.Name = "StatoLabel";
            StatoLabel.Size = new Size(15, 20);
            StatoLabel.TabIndex = 6;
            StatoLabel.Text = "-";
            // 
            // btnScrivi
            // 
            btnScrivi.Location = new Point(103, 332);
            btnScrivi.Name = "btnScrivi";
            btnScrivi.Size = new Size(125, 29);
            btnScrivi.TabIndex = 11;
            btnScrivi.Text = "Write";
            btnScrivi.UseVisualStyleBackColor = true;
            btnScrivi.Click += Scrivi;
            // 
            // textValue
            // 
            textValue.Location = new Point(103, 281);
            textValue.Name = "textValue";
            textValue.Size = new Size(125, 27);
            textValue.TabIndex = 10;
            textValue.Text = "0";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(103, 243);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(125, 27);
            textAddress.TabIndex = 9;
            textAddress.Text = "0";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(48, 281);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(45, 20);
            labelValue.TabIndex = 8;
            labelValue.Text = "Value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 243);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 7;
            label7.Text = "Address";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(461, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // output
            // 
            output.BackColor = Color.White;
            output.Location = new Point(353, 71);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(334, 271);
            output.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
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