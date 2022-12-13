namespace Railway_Station_new
{
    partial class DisplayFri
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TrainNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepatureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationsToBeStopped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivateDeactivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportFacilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 87);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME TO GALLE RAILWAY STATION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Railway_Station_new.Properties.Resources.Contols___Add_On_29_512;
            this.pictureBox2.Location = new System.Drawing.Point(0, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1358, 669);
            this.dataGridView1.TabIndex = 15;
            // 
            // TrainNo
            // 
            this.TrainNo.DataPropertyName = "trno";
            this.TrainNo.HeaderText = "Train No";
            this.TrainNo.Name = "TrainNo";
            this.TrainNo.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "arrtime";
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // DepatureTime
            // 
            this.DepatureTime.DataPropertyName = "deptime";
            this.DepatureTime.HeaderText = "Destination Time";
            this.DepatureTime.Name = "DepatureTime";
            this.DepatureTime.ReadOnly = true;
            // 
            // StationsToBeStopped
            // 
            this.StationsToBeStopped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationsToBeStopped.DataPropertyName = "stations";
            this.StationsToBeStopped.HeaderText = "Stations To Be Stopped";
            this.StationsToBeStopped.Name = "StationsToBeStopped";
            this.StationsToBeStopped.ReadOnly = true;
            // 
            // ActivateDeactivate
            // 
            this.ActivateDeactivate.DataPropertyName = "actdeact";
            this.ActivateDeactivate.HeaderText = "Activate/ Deactivate";
            this.ActivateDeactivate.Name = "ActivateDeactivate";
            this.ActivateDeactivate.ReadOnly = true;
            // 
            // AvailableClass
            // 
            this.AvailableClass.DataPropertyName = "classes";
            this.AvailableClass.HeaderText = "Available Class";
            this.AvailableClass.Name = "AvailableClass";
            this.AvailableClass.ReadOnly = true;
            // 
            // TransportFacilities
            // 
            this.TransportFacilities.DataPropertyName = "facilities";
            this.TransportFacilities.HeaderText = "Transport Facilities";
            this.TransportFacilities.Name = "TransportFacilities";
            this.TransportFacilities.ReadOnly = true;
            // 
            // Timeid
            // 
            this.Timeid.AutoSize = true;
            this.Timeid.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timeid.ForeColor = System.Drawing.Color.Black;
            this.Timeid.Location = new System.Drawing.Point(572, 89);
            this.Timeid.Name = "Timeid";
            this.Timeid.Size = new System.Drawing.Size(92, 37);
            this.Timeid.TabIndex = 17;
            this.Timeid.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DisplayFri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 770);
            this.Controls.Add(this.Timeid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayFri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayFri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayFri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepatureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationsToBeStopped;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivateDeactivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportFacilities;
        private System.Windows.Forms.Label Timeid;
        private System.Windows.Forms.Timer timer1;
    }
}