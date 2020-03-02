namespace Autoclickerro
{
    partial class fMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSetHotkeys = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.WorkingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timesText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectbuttonCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clicktypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCords = new System.Windows.Forms.Label();
            this.labelFixed = new System.Windows.Forms.Label();
            this.rbtnByFixed = new System.Windows.Forms.RadioButton();
            this.rbtnByCursor = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClickTiicker = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemOptions,
            this.menuItemHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(426, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(93, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSetHotkeys});
            this.menuItemOptions.Name = "menuItemOptions";
            this.menuItemOptions.Size = new System.Drawing.Size(61, 20);
            this.menuItemOptions.Text = "Options";
            // 
            // menuItemSetHotkeys
            // 
            this.menuItemSetHotkeys.Name = "menuItemSetHotkeys";
            this.menuItemSetHotkeys.Size = new System.Drawing.Size(143, 22);
            this.menuItemSetHotkeys.Text = "Set hotkeys...";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.menuItemAbout.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStatus,
            this.WorkingStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(67, 20);
            this.toolStripLabelStatus.Text = "STATUS:";
            // 
            // WorkingStatusLabel
            // 
            this.WorkingStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WorkingStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.WorkingStatusLabel.Name = "WorkingStatusLabel";
            this.WorkingStatusLabel.Size = new System.Drawing.Size(94, 20);
            this.WorkingStatusLabel.Text = "Not Clicking";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(21, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 124);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start (?)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnStart_KeyPress);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(222, 290);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(195, 124);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop (?)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Times to click? (0 = infinite) -";
            // 
            // timesText
            // 
            this.timesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesText.Location = new System.Drawing.Point(322, 34);
            this.timesText.Name = "timesText";
            this.timesText.Size = new System.Drawing.Size(88, 23);
            this.timesText.TabIndex = 4;
            this.timesText.Text = "0";
            this.timesText.TextChanged += new System.EventHandler(this.timesText_TextChanged);
            this.timesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timesText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(145, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval mSec";
            // 
            // intervalText
            // 
            this.intervalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.intervalText.Location = new System.Drawing.Point(322, 63);
            this.intervalText.Name = "intervalText";
            this.intervalText.Size = new System.Drawing.Size(88, 23);
            this.intervalText.TabIndex = 5;
            this.intervalText.Text = "1000";
            this.intervalText.TextChanged += new System.EventHandler(this.intervalText_TextChanged);
            this.intervalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervalText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(219, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select button -";
            // 
            // selectbuttonCombo
            // 
            this.selectbuttonCombo.DisplayMember = "1";
            this.selectbuttonCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectbuttonCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectbuttonCombo.FormattingEnabled = true;
            this.selectbuttonCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectbuttonCombo.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.selectbuttonCombo.Location = new System.Drawing.Point(322, 92);
            this.selectbuttonCombo.Name = "selectbuttonCombo";
            this.selectbuttonCombo.Size = new System.Drawing.Size(88, 24);
            this.selectbuttonCombo.TabIndex = 7;
            this.selectbuttonCombo.SelectedIndexChanged += new System.EventHandler(this.selectbuttonCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(219, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type of click  - ";
            // 
            // clicktypeCombo
            // 
            this.clicktypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clicktypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clicktypeCombo.FormattingEnabled = true;
            this.clicktypeCombo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.clicktypeCombo.Location = new System.Drawing.Point(322, 122);
            this.clicktypeCombo.Name = "clicktypeCombo";
            this.clicktypeCombo.Size = new System.Drawing.Size(88, 24);
            this.clicktypeCombo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCords);
            this.groupBox1.Controls.Add(this.labelFixed);
            this.groupBox1.Controls.Add(this.rbtnByFixed);
            this.groupBox1.Controls.Add(this.rbtnByCursor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(54, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click location";
            // 
            // labelCords
            // 
            this.labelCords.AutoSize = true;
            this.labelCords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCords.Location = new System.Drawing.Point(269, 52);
            this.labelCords.Name = "labelCords";
            this.labelCords.Size = new System.Drawing.Size(80, 15);
            this.labelCords.TabIndex = 3;
            this.labelCords.Text = "X = 0, Y = 0";
            // 
            // labelFixed
            // 
            this.labelFixed.AutoSize = true;
            this.labelFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFixed.Location = new System.Drawing.Point(145, 52);
            this.labelFixed.Name = "labelFixed";
            this.labelFixed.Size = new System.Drawing.Size(114, 15);
            this.labelFixed.TabIndex = 2;
            this.labelFixed.Text = "(Press ? to Set) :";
            // 
            // rbtnByFixed
            // 
            this.rbtnByFixed.AutoSize = true;
            this.rbtnByFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnByFixed.Location = new System.Drawing.Point(148, 22);
            this.rbtnByFixed.Name = "rbtnByFixed";
            this.rbtnByFixed.Size = new System.Drawing.Size(117, 21);
            this.rbtnByFixed.TabIndex = 1;
            this.rbtnByFixed.TabStop = true;
            this.rbtnByFixed.Text = "Fixed Location";
            this.rbtnByFixed.UseVisualStyleBackColor = true;
            this.rbtnByFixed.CheckedChanged += new System.EventHandler(this.rbtnByFixed_CheckedChanged);
            // 
            // rbtnByCursor
            // 
            this.rbtnByCursor.AutoSize = true;
            this.rbtnByCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnByCursor.Location = new System.Drawing.Point(33, 22);
            this.rbtnByCursor.Name = "rbtnByCursor";
            this.rbtnByCursor.Size = new System.Drawing.Size(68, 21);
            this.rbtnByCursor.TabIndex = 0;
            this.rbtnByCursor.TabStop = true;
            this.rbtnByCursor.Text = "Cursor";
            this.rbtnByCursor.UseVisualStyleBackColor = true;
            this.rbtnByCursor.CheckedChanged += new System.EventHandler(this.rbtnByCursor_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Autoclickerro.Properties.Resources.click;
            this.pictureBox1.Location = new System.Drawing.Point(23, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "AutoClickerro!";
            // 
            // ClickTiicker
            // 
            this.ClickTiicker.Tick += new System.EventHandler(this.ClickTiicker_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(238, 63);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(44, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(275, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 464);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clicktypeCombo);
            this.Controls.Add(this.selectbuttonCombo);
            this.Controls.Add(this.intervalText);
            this.Controls.Add(this.timesText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "fMain";
            this.Text = "AutoClickerrro !";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel WorkingStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem menuItemSetHotkeys;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timesText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intervalText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectbuttonCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox clicktypeCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnByFixed;
        private System.Windows.Forms.RadioButton rbtnByCursor;
        private System.Windows.Forms.Label labelCords;
        private System.Windows.Forms.Label labelFixed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ClickTiicker;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

