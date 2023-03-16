namespace Tag_Manager
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTagDim3 = new System.Windows.Forms.TextBox();
            this.txtTagDim1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xlsxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTagType = new System.Windows.Forms.TextBox();
            this.txtTagDim2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestoreDefaultIP = new System.Windows.Forms.Button();
            this.btnSetDefaultIP = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddlControllerType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReadTags = new System.Windows.Forms.Button();
            this.inputTagName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTagListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIPAddr = new System.Windows.Forms.Label();
            this.inputIPAddr = new System.Windows.Forms.TextBox();
            this.panIPAddr = new System.Windows.Forms.Panel();
            this.ddlCommProtocol = new System.Windows.Forms.ComboBox();
            this.inputSlotNum = new System.Windows.Forms.TextBox();
            this.inputRackNum = new System.Windows.Forms.TextBox();
            this.panRackNum = new System.Windows.Forms.Panel();
            this.panSlotNum = new System.Windows.Forms.Panel();
            this.txtCommProtocol = new System.Windows.Forms.Label();
            this.txtControllerType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSlotNum = new System.Windows.Forms.Label();
            this.txtRackNum = new System.Windows.Forms.Label();
            this.btnWriteChanges = new System.Windows.Forms.Button();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Tag_Manager.DataSet1();
            this.btnDefaultTag = new System.Windows.Forms.Button();
            this.txtIPStatus = new System.Windows.Forms.Label();
            this.iPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtLoadingOverlay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1071, 463);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // txtTagDim3
            // 
            this.txtTagDim3.Location = new System.Drawing.Point(216, 131);
            this.txtTagDim3.Name = "txtTagDim3";
            this.txtTagDim3.ReadOnly = true;
            this.txtTagDim3.Size = new System.Drawing.Size(34, 20);
            this.txtTagDim3.TabIndex = 43;
            this.txtTagDim3.TabStop = false;
            // 
            // txtTagDim1
            // 
            this.txtTagDim1.Location = new System.Drawing.Point(136, 131);
            this.txtTagDim1.Name = "txtTagDim1";
            this.txtTagDim1.ReadOnly = true;
            this.txtTagDim1.Size = new System.Drawing.Size(34, 20);
            this.txtTagDim1.TabIndex = 41;
            this.txtTagDim1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = ",";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tag Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = ",";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.importFromToolStripMenuItem,
            this.exportToToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear Data";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // importFromToolStripMenuItem
            // 
            this.importFromToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xlsxToolStripMenuItem1});
            this.importFromToolStripMenuItem.Name = "importFromToolStripMenuItem";
            this.importFromToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importFromToolStripMenuItem.Text = "Import from...";
            // 
            // xlsxToolStripMenuItem1
            // 
            this.xlsxToolStripMenuItem1.Name = "xlsxToolStripMenuItem1";
            this.xlsxToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xlsxToolStripMenuItem1.Text = ".xlsx";
            this.xlsxToolStripMenuItem1.Click += new System.EventHandler(this.xlsxToolStripMenuItem1_Click);
            // 
            // exportToToolStripMenuItem
            // 
            this.exportToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvToolStripMenuItem,
            this.xlsxToolStripMenuItem});
            this.exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            this.exportToToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToToolStripMenuItem.Text = "Export to...";
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csvToolStripMenuItem.Text = ".csv";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // xlsxToolStripMenuItem
            // 
            this.xlsxToolStripMenuItem.Name = "xlsxToolStripMenuItem";
            this.xlsxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xlsxToolStripMenuItem.Text = ".xlsx";
            this.xlsxToolStripMenuItem.Click += new System.EventHandler(this.xlsxToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtTagType
            // 
            this.txtTagType.Location = new System.Drawing.Point(528, 131);
            this.txtTagType.Name = "txtTagType";
            this.txtTagType.ReadOnly = true;
            this.txtTagType.Size = new System.Drawing.Size(154, 20);
            this.txtTagType.TabIndex = 45;
            this.txtTagType.TabStop = false;
            // 
            // txtTagDim2
            // 
            this.txtTagDim2.Location = new System.Drawing.Point(176, 131);
            this.txtTagDim2.Name = "txtTagDim2";
            this.txtTagDim2.ReadOnly = true;
            this.txtTagDim2.Size = new System.Drawing.Size(34, 20);
            this.txtTagDim2.TabIndex = 42;
            this.txtTagDim2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRestoreDefaultIP
            // 
            this.btnRestoreDefaultIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDefaultIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDefaultIP.Location = new System.Drawing.Point(1089, 38);
            this.btnRestoreDefaultIP.Name = "btnRestoreDefaultIP";
            this.btnRestoreDefaultIP.Size = new System.Drawing.Size(125, 51);
            this.btnRestoreDefaultIP.TabIndex = 65;
            this.btnRestoreDefaultIP.TabStop = false;
            this.btnRestoreDefaultIP.Text = "Restore Default\r\nComm Settings\r\n";
            this.btnRestoreDefaultIP.UseVisualStyleBackColor = true;
            this.btnRestoreDefaultIP.Click += new System.EventHandler(this.btnRestoreDefaultIP_Click);
            // 
            // btnSetDefaultIP
            // 
            this.btnSetDefaultIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDefaultIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDefaultIP.Location = new System.Drawing.Point(958, 38);
            this.btnSetDefaultIP.Name = "btnSetDefaultIP";
            this.btnSetDefaultIP.Size = new System.Drawing.Size(125, 51);
            this.btnSetDefaultIP.TabIndex = 64;
            this.btnSetDefaultIP.TabStop = false;
            this.btnSetDefaultIP.Text = "Set Default\r\nComm Settings";
            this.btnSetDefaultIP.UseVisualStyleBackColor = true;
            this.btnSetDefaultIP.Click += new System.EventHandler(this.btnSetDefaultIP_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.githubToolStripMenuItem.Text = "GitHub";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // ddlControllerType
            // 
            this.ddlControllerType.BackColor = System.Drawing.SystemColors.Window;
            this.ddlControllerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlControllerType.FormattingEnabled = true;
            this.ddlControllerType.Items.AddRange(new object[] {
            "ControlLogix",
            "Plc5",
            "Slc500",
            "LogixPccc",
            "Micro800",
            "MicroLogix",
            "Omron"});
            this.ddlControllerType.Location = new System.Drawing.Point(528, 37);
            this.ddlControllerType.Name = "ddlControllerType";
            this.ddlControllerType.Size = new System.Drawing.Size(154, 21);
            this.ddlControllerType.TabIndex = 4;
            this.ddlControllerType.SelectedIndexChanged += new System.EventHandler(this.ddlControllerType_SelectedIndexChanged);
            this.ddlControllerType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1226, 2);
            this.label9.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(0, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1226, 2);
            this.label8.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(0, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1226, 2);
            this.label7.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tag Dimensions [";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReadTags
            // 
            this.btnReadTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadTags.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadTags.Location = new System.Drawing.Point(1089, 103);
            this.btnReadTags.Name = "btnReadTags";
            this.btnReadTags.Size = new System.Drawing.Size(125, 51);
            this.btnReadTags.TabIndex = 7;
            this.btnReadTags.Text = "Read Tags";
            this.btnReadTags.UseVisualStyleBackColor = true;
            this.btnReadTags.Click += new System.EventHandler(this.btnReadTags_Click);
            this.btnReadTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnReadTags_KeyDown);
            // 
            // inputTagName
            // 
            this.inputTagName.Location = new System.Drawing.Point(98, 103);
            this.inputTagName.Name = "inputTagName";
            this.inputTagName.Size = new System.Drawing.Size(584, 20);
            this.inputTagName.TabIndex = 6;
            this.inputTagName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.inputTagName.Leave += new System.EventHandler(this.inputTagName_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTagListToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createTagListToolStripMenuItem
            // 
            this.createTagListToolStripMenuItem.Enabled = false;
            this.createTagListToolStripMenuItem.Name = "createTagListToolStripMenuItem";
            this.createTagListToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.createTagListToolStripMenuItem.Text = "View Tag List";
            this.createTagListToolStripMenuItem.ToolTipText = "Must have a valid IP connection\r\n";
            this.createTagListToolStripMenuItem.Click += new System.EventHandler(this.createTagListToolStripMenuItem_Click);
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddr.Location = new System.Drawing.Point(4, 37);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(91, 23);
            this.txtIPAddr.TabIndex = 57;
            this.txtIPAddr.Text = "IP Address";
            this.txtIPAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputIPAddr
            // 
            this.inputIPAddr.Location = new System.Drawing.Point(98, 37);
            this.inputIPAddr.Name = "inputIPAddr";
            this.inputIPAddr.Size = new System.Drawing.Size(208, 20);
            this.inputIPAddr.TabIndex = 1;
            this.inputIPAddr.TextChanged += new System.EventHandler(this.inputIPAddr_TextChanged);
            this.inputIPAddr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.inputIPAddr.Leave += new System.EventHandler(this.inputIPAddr_Leave);
            // 
            // panIPAddr
            // 
            this.panIPAddr.BackColor = System.Drawing.SystemColors.Control;
            this.panIPAddr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panIPAddr.Location = new System.Drawing.Point(310, 41);
            this.panIPAddr.Name = "panIPAddr";
            this.panIPAddr.Size = new System.Drawing.Size(14, 14);
            this.panIPAddr.TabIndex = 62;
            // 
            // ddlCommProtocol
            // 
            this.ddlCommProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCommProtocol.FormattingEnabled = true;
            this.ddlCommProtocol.Items.AddRange(new object[] {
            "Allen-Bradley EthernetIP",
            "Modbus TCP"});
            this.ddlCommProtocol.Location = new System.Drawing.Point(528, 66);
            this.ddlCommProtocol.Name = "ddlCommProtocol";
            this.ddlCommProtocol.Size = new System.Drawing.Size(154, 21);
            this.ddlCommProtocol.TabIndex = 5;
            this.ddlCommProtocol.SelectedIndexChanged += new System.EventHandler(this.ddlCommProtocol_SelectedIndexChanged);
            this.ddlCommProtocol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // inputSlotNum
            // 
            this.inputSlotNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSlotNum.Location = new System.Drawing.Point(270, 66);
            this.inputSlotNum.Name = "inputSlotNum";
            this.inputSlotNum.Size = new System.Drawing.Size(36, 20);
            this.inputSlotNum.TabIndex = 3;
            this.inputSlotNum.Text = "0";
            this.inputSlotNum.TextChanged += new System.EventHandler(this.inputSlotNum_TextChanged);
            this.inputSlotNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.inputSlotNum.Leave += new System.EventHandler(this.inputSlotNum_Leave);
            // 
            // inputRackNum
            // 
            this.inputRackNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRackNum.Location = new System.Drawing.Point(98, 66);
            this.inputRackNum.Name = "inputRackNum";
            this.inputRackNum.Size = new System.Drawing.Size(36, 20);
            this.inputRackNum.TabIndex = 2;
            this.inputRackNum.Text = "1";
            this.inputRackNum.TextChanged += new System.EventHandler(this.inputRackNum_TextChanged);
            this.inputRackNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.inputRackNum.Leave += new System.EventHandler(this.inputRackNum_Leave);
            // 
            // panRackNum
            // 
            this.panRackNum.BackColor = System.Drawing.SystemColors.Control;
            this.panRackNum.Location = new System.Drawing.Point(96, 64);
            this.panRackNum.Name = "panRackNum";
            this.panRackNum.Size = new System.Drawing.Size(40, 24);
            this.panRackNum.TabIndex = 53;
            // 
            // panSlotNum
            // 
            this.panSlotNum.BackColor = System.Drawing.SystemColors.Control;
            this.panSlotNum.Location = new System.Drawing.Point(268, 64);
            this.panSlotNum.Name = "panSlotNum";
            this.panSlotNum.Size = new System.Drawing.Size(40, 24);
            this.panSlotNum.TabIndex = 55;
            // 
            // txtCommProtocol
            // 
            this.txtCommProtocol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommProtocol.Location = new System.Drawing.Point(432, 66);
            this.txtCommProtocol.Name = "txtCommProtocol";
            this.txtCommProtocol.Size = new System.Drawing.Size(93, 23);
            this.txtCommProtocol.TabIndex = 63;
            this.txtCommProtocol.Text = "Comm Type";
            this.txtCommProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtControllerType
            // 
            this.txtControllerType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControllerType.Location = new System.Drawing.Point(434, 37);
            this.txtControllerType.Name = "txtControllerType";
            this.txtControllerType.Size = new System.Drawing.Size(91, 23);
            this.txtControllerType.TabIndex = 61;
            this.txtControllerType.Text = "Controller";
            this.txtControllerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tag Datatype";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSlotNum
            // 
            this.txtSlotNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlotNum.Location = new System.Drawing.Point(176, 65);
            this.txtSlotNum.Name = "txtSlotNum";
            this.txtSlotNum.Size = new System.Drawing.Size(91, 23);
            this.txtSlotNum.TabIndex = 60;
            this.txtSlotNum.Text = "CPU Slot";
            this.txtSlotNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRackNum
            // 
            this.txtRackNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRackNum.Location = new System.Drawing.Point(4, 66);
            this.txtRackNum.Name = "txtRackNum";
            this.txtRackNum.Size = new System.Drawing.Size(91, 23);
            this.txtRackNum.TabIndex = 59;
            this.txtRackNum.Text = "CPU Rack";
            this.txtRackNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnWriteChanges
            // 
            this.btnWriteChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteChanges.Enabled = false;
            this.btnWriteChanges.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteChanges.Location = new System.Drawing.Point(1089, 589);
            this.btnWriteChanges.Name = "btnWriteChanges";
            this.btnWriteChanges.Size = new System.Drawing.Size(125, 51);
            this.btnWriteChanges.TabIndex = 68;
            this.btnWriteChanges.TabStop = false;
            this.btnWriteChanges.Text = "Write Changes";
            this.btnWriteChanges.UseVisualStyleBackColor = true;
            this.btnWriteChanges.Click += new System.EventHandler(this.btnWriteChanges_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelChanges.Enabled = false;
            this.btnCancelChanges.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChanges.Location = new System.Drawing.Point(1089, 177);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(125, 51);
            this.btnCancelChanges.TabIndex = 67;
            this.btnCancelChanges.TabStop = false;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDefaultTag
            // 
            this.btnDefaultTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultTag.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultTag.Location = new System.Drawing.Point(958, 103);
            this.btnDefaultTag.Name = "btnDefaultTag";
            this.btnDefaultTag.Size = new System.Drawing.Size(125, 51);
            this.btnDefaultTag.TabIndex = 66;
            this.btnDefaultTag.TabStop = false;
            this.btnDefaultTag.Text = "Set Default Tag";
            this.btnDefaultTag.UseVisualStyleBackColor = true;
            this.btnDefaultTag.Click += new System.EventHandler(this.btnDefaultTag_Click);
            // 
            // txtIPStatus
            // 
            this.txtIPStatus.AutoSize = true;
            this.txtIPStatus.Location = new System.Drawing.Point(324, 42);
            this.txtIPStatus.Name = "txtIPStatus";
            this.txtIPStatus.Size = new System.Drawing.Size(103, 13);
            this.txtIPStatus.TabIndex = 71;
            this.txtIPStatus.Text = "No Device Selected";
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSet1;
            // 
            // txtLoadingOverlay
            // 
            this.txtLoadingOverlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoadingOverlay.AutoSize = true;
            this.txtLoadingOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoadingOverlay.Location = new System.Drawing.Point(432, 395);
            this.txtLoadingOverlay.Name = "txtLoadingOverlay";
            this.txtLoadingOverlay.Size = new System.Drawing.Size(231, 26);
            this.txtLoadingOverlay.TabIndex = 72;
            this.txtLoadingOverlay.Text = "Loading. Please wait...";
            this.txtLoadingOverlay.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 646);
            this.Controls.Add(this.txtLoadingOverlay);
            this.Controls.Add(this.txtIPStatus);
            this.Controls.Add(this.btnDefaultTag);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.btnWriteChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTagDim3);
            this.Controls.Add(this.txtTagDim1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTagType);
            this.Controls.Add(this.txtTagDim2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestoreDefaultIP);
            this.Controls.Add(this.btnSetDefaultIP);
            this.Controls.Add(this.ddlControllerType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReadTags);
            this.Controls.Add(this.inputTagName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtIPAddr);
            this.Controls.Add(this.inputIPAddr);
            this.Controls.Add(this.panIPAddr);
            this.Controls.Add(this.ddlCommProtocol);
            this.Controls.Add(this.inputSlotNum);
            this.Controls.Add(this.inputRackNum);
            this.Controls.Add(this.panRackNum);
            this.Controls.Add(this.panSlotNum);
            this.Controls.Add(this.txtCommProtocol);
            this.Controls.Add(this.txtControllerType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSlotNum);
            this.Controls.Add(this.txtRackNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(980, 350);
            this.Name = "Form1";
            this.Text = "TAG MASTER 5000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTagDim3;
        private System.Windows.Forms.TextBox txtTagDim1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xlsxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTagType;
        private System.Windows.Forms.TextBox txtTagDim2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestoreDefaultIP;
        private System.Windows.Forms.Button btnSetDefaultIP;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ComboBox ddlControllerType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource iPBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReadTags;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label txtIPAddr;
        private System.Windows.Forms.TextBox inputIPAddr;
        private System.Windows.Forms.Panel panIPAddr;
        private System.Windows.Forms.ComboBox ddlCommProtocol;
        private System.Windows.Forms.TextBox inputSlotNum;
        private System.Windows.Forms.TextBox inputRackNum;
        private System.Windows.Forms.Panel panRackNum;
        private System.Windows.Forms.Panel panSlotNum;
        private System.Windows.Forms.Label txtCommProtocol;
        private System.Windows.Forms.Label txtControllerType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtSlotNum;
        private System.Windows.Forms.Label txtRackNum;
        private System.Windows.Forms.Button btnWriteChanges;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.ToolTip toolTip1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        public System.Windows.Forms.TextBox inputTagName;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.Button btnDefaultTag;
        private System.Windows.Forms.Label txtIPStatus;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTagListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xlsxToolStripMenuItem1;
        private System.Windows.Forms.Label txtLoadingOverlay;
    }
}

