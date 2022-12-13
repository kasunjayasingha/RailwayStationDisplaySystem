namespace Railway_Station_new
{
    partial class DisplaySampleFri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TrainNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepatureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationsToBeStopped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivateDeactivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportFacilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndis = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnSR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 39);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(650, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(695, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Galle Railway Station";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainNo,
            this.ArrivalTime,
            this.DepatureTime,
            this.StationsToBeStopped,
            this.ActivateDeactivate,
            this.AvailableClass,
            this.TransportFacilities});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 356);
            this.dataGridView1.TabIndex = 7;
            // 
            // TrainNo
            // 
            this.TrainNo.DataPropertyName = "trno";
            this.TrainNo.HeaderText = "Train No";
            this.TrainNo.Name = "TrainNo";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "arrtime";
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // DepatureTime
            // 
            this.DepatureTime.DataPropertyName = "deptime";
            this.DepatureTime.HeaderText = "Depature Time";
            this.DepatureTime.Name = "DepatureTime";
            // 
            // StationsToBeStopped
            // 
            this.StationsToBeStopped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StationsToBeStopped.DataPropertyName = "stations";
            this.StationsToBeStopped.HeaderText = "Stations To Be Stopped";
            this.StationsToBeStopped.Name = "StationsToBeStopped";
            this.StationsToBeStopped.Width = 96;
            // 
            // ActivateDeactivate
            // 
            this.ActivateDeactivate.DataPropertyName = "actdeact";
            this.ActivateDeactivate.HeaderText = "Activate/ Deactivate";
            this.ActivateDeactivate.Name = "ActivateDeactivate";
            // 
            // AvailableClass
            // 
            this.AvailableClass.DataPropertyName = "classes";
            this.AvailableClass.HeaderText = "Available Class";
            this.AvailableClass.Name = "AvailableClass";
            // 
            // TransportFacilities
            // 
            this.TransportFacilities.DataPropertyName = "facilities";
            this.TransportFacilities.HeaderText = "Transport Facilities";
            this.TransportFacilities.Name = "TransportFacilities";
            // 
            // btndis
            // 
            this.btndis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.btndis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btndis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btndis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndis.ForeColor = System.Drawing.Color.White;
            this.btndis.Location = new System.Drawing.Point(634, 410);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(99, 34);
            this.btndis.TabIndex = 8;
            this.btndis.Text = "DISPLAY";
            this.btndis.UseVisualStyleBackColor = false;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.btnup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnup.ForeColor = System.Drawing.Color.White;
            this.btnup.Location = new System.Drawing.Point(514, 410);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(99, 34);
            this.btnup.TabIndex = 9;
            this.btnup.Text = "UPDATE ";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnSR
            // 
            this.btnSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.btnSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSR.ForeColor = System.Drawing.Color.White;
            this.btnSR.Location = new System.Drawing.Point(392, 410);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(99, 34);
            this.btnSR.TabIndex = 10;
            this.btnSR.Text = "SHOW RECORD";
            this.btnSR.UseVisualStyleBackColor = false;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // DisplaySampleFri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 456);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnSR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplaySampleFri";
            this.Text = "DisplaySampleFri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepatureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationsToBeStopped;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivateDeactivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportFacilities;
    }
}