﻿using libplctag.DataTypes;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tag_Manager
{
    public partial class Form1 : Form
    {
        static public IP ipConfig = new IP();

        string enteredTagName;
        bool tagIsUdt;
        int rawTypeID;
        string udtTagType;
        string atomicTagType;

        int[] arrayDims = new int[3];

        System.Data.DataTable dt = new System.Data.DataTable();

        List<string> udtMemberNamesList = new List<string>();
        List<string> udtMemberTypesList = new List<string>();
        List<string[]> tagDataChanges = new List<string[]>();
        List<TagInfo> tagList = new List<TagInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        //FUNCTIONS
        private void WriteTagData()
        {
            //If the first index is > than zero, this is at least a 1D array
            if (arrayDims[0] > 0)
            {
                //If the second index is > 0, this is at least a 2D array
                if (arrayDims[1] > 0)
                {
                    //if the third index is > 0, this is a 3D array
                    if (arrayDims[2] > 0)
                    {
                        for (int i = 0; i < arrayDims[0]; i++)
                        {
                            for (int j = 0; j < arrayDims[1]; j++)
                            {
                                for (int k = 0; k < arrayDims[2]; k++)
                                {
                                    List<string> data = new List<string>();

                                    if (!tagIsUdt)
                                    {
                                        data.Add(CreateTagNameString(new int[] { i, j, k }));
                                        data.Add(ReadSingleTag(enteredTagName, i, j, k));
                                        
                                    }
                                    else
                                    {
                                        data.Add(CreateTagNameString(new int[] { i, j, k }));
                                        foreach (var member in udtMemberNamesList)
                                        {
                                            data.Add(ReadSingleTag(enteredTagName, i, j, k, member));
                                        }
                                    }
                                    //dataGridView1.Rows.Add(data.ToArray());
                                    dt.Rows.Add(data.ToArray());
                                }
                            }
                        }
                    }
                    //Else this is only a 2D array
                    else
                    {
                        for (int i = 0; i < arrayDims[0]; i++)
                        {
                            for (int j = 0; j < arrayDims[1]; j++)
                            {
                                List<string> data = new List<string>();

                                if (!tagIsUdt)
                                {
                                    data.Add(CreateTagNameString(new int[] { i, j }));
                                    data.Add(ReadSingleTag(enteredTagName, i, j));
                                }
                                else
                                {
                                    data.Add(CreateTagNameString(new int[] { i, j }));
                                    foreach (var member in udtMemberNamesList)
                                    {
                                        data.Add(ReadSingleTag(enteredTagName, i, j, 0, member));
                                    }
                                }
                                //dataGridView1.Rows.Add(data.ToArray());
                                dt.Rows.Add(data.ToArray());
                            }
                        }
                    }
                }
                //Else this is only a 1D array
                else
                {
                    for (int i = 0; i < arrayDims[0]; i++)
                    {
                        List<string> data = new List<string>();

                        if (!tagIsUdt)
                        {
                            data.Add(CreateTagNameString(new int[] { i }));
                            data.Add(ReadSingleTag(enteredTagName, i));
                        }
                        else
                        {
                            data.Add(CreateTagNameString(new int[] { i }));
                            foreach (var member in udtMemberNamesList)
                            {
                                data.Add(ReadSingleTag(enteredTagName, i, 0, 0, member));
                            }
                        }
                        //dataGridView1.Rows.Add(data.ToArray());
                        dt.Rows.Add(data.ToArray());
                    }
                }
            }
            //Else this is not an array tag
            else
            {
                List<string> data = new List<string>();

                if (!tagIsUdt)
                {
                    data.Add(enteredTagName);
                    data.Add(ReadSingleTag(enteredTagName));
                }
                else
                {
                    data.Add(enteredTagName);
                    foreach (var member in udtMemberNamesList)
                    {
                        data.Add(ReadSingleTag(enteredTagName, 0, 0, 0, member));
                    }
                }
                //dataGridView1.Rows.Add(data.ToArray());
                dt.Rows.Add(data.ToArray());
            }
        }

        private string ReadSingleTag(string name, int i = 0, int j = 0, int k = 0, string member = null)
        {
            string type = null;
            string data = null;

            //If the tag is not UDT, read each individual tag using its name, index dimensions, and type.
            if (!tagIsUdt)
            {
                foreach (var tag in tagList)
                {
                    if (tag.Name.ToLower() == name.ToLower())
                    {
                        type = GetTypeString(tag.Type).Item2;
                    }
                }

                if (arrayDims[0] > 0)
                {
                    if (arrayDims[1] > 0)
                    {
                        if (arrayDims[2] > 0)
                        {
                            foreach (var tag in tagList)
                            {
                                if (tag.Name.ToLower() == name.ToLower())
                                {
                                    type = GetTypeString(tag.Type).Item2;
                                    data = Mappers.ReadSingleTagData($"{name}[{i},{j},{k}]", type);
                                    return data;
                                }
                            }
                        }
                        else
                        {
                            foreach (var tag in tagList)
                            {
                                if (tag.Name.ToLower() == name.ToLower())
                                {
                                    type = GetTypeString(tag.Type).Item2;
                                    data = Mappers.ReadSingleTagData($"{name}[{i},{j}]", type);
                                    return data;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var tag in tagList)
                        {
                            if (tag.Name.ToLower() == name.ToLower())
                            {
                                type = GetTypeString(tag.Type).Item2;
                                data = Mappers.ReadSingleTagData($"{name}[{i}]", type);
                                return data;
                            }
                        }
                    }
                }
                else
                {
                    foreach (var tag in tagList)
                    {
                        if (tag.Name.ToLower() == name.ToLower())
                        {
                            type = GetTypeString(tag.Type).Item2;
                            data = Mappers.ReadSingleTagData($"{name}", type);
                            return data;
                        }
                    }
                }
            }

            //If the tag is UDT, read each individual tag using its name, index dimensions, member list, and type of each member.
            else
            {
                if (arrayDims[0] > 0)
                {
                    if (arrayDims[1] > 0)
                    {
                        if (arrayDims[2] > 0)
                        {
                            foreach (var tag in tagList)
                            {
                                if (tag.Name.ToLower() == name.ToLower())
                                {
                                    type = udtMemberTypesList[udtMemberNamesList.IndexOf(member)];
                                    data = Mappers.ReadSingleTagData($"{name}[{i},{j},{k}].{member}", type);
                                    return data;
                                }
                            }
                        }
                        else
                        {
                            foreach (var tag in tagList)
                            {
                                if (tag.Name.ToLower() == name.ToLower())
                                {
                                    type = udtMemberTypesList[udtMemberNamesList.IndexOf(member)];
                                    data = Mappers.ReadSingleTagData($"{name}[{i},{j}].{member}", type);
                                    return data;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var tag in tagList)
                        {
                            if (tag.Name.ToLower() == name.ToLower())
                            {
                                type = udtMemberTypesList[udtMemberNamesList.IndexOf(member)];
                                data = Mappers.ReadSingleTagData($"{name}[{i}].{member}", type);
                                return data;
                            }
                        }
                    }
                }
                else
                {
                    foreach (var tag in tagList)
                    {
                        if (tag.Name.ToLower() == name.ToLower())
                        {
                            type = udtMemberTypesList[udtMemberNamesList.IndexOf(member)];
                            data = Mappers.ReadSingleTagData($"{name}.{member}", type);
                            return data;
                        }
                    }
                }
            }
            
            return "Unknown";
        }

        private void PrintTagInfo()
        {
            //Store list of all tags
            var findTag = Mappers.ReadTagInfo();

            foreach (var tag in findTag)
            {
                tagList.Add(tag);
            }

            //For each tag in the list, check the name vs. the user-entered name
            for (int i = 0; i < findTag.Length; i++)
            {
                if (findTag[i].Name.ToLower() == enteredTagName.ToLower())
                {
                    rawTypeID = Convert.ToInt32(findTag[i].Type);
                    int countBuffer = 0;

                    //Store an array of the tag's array dimensions - [X,Y,Z]
                    foreach (var value in findTag[i].Dimensions)
                    {
                        arrayDims[countBuffer] = Convert.ToInt32(value);
                        countBuffer++;
                    }

                    //Check whether or not the tag is a UDT-based tag
                    tagIsUdt = TagUdtCheck(rawTypeID);
                    if (tagIsUdt)
                    {
                        var udtInfo = Mappers.ReadUdtInfo(GetUdtId(rawTypeID));
                        udtTagType = udtInfo.Name;
                        txtTagType.Text = udtTagType.ToString();
                    }
                    else
                    {
                        atomicTagType = GetTypeString(rawTypeID).Item1;
                        txtTagType.Text = atomicTagType;                        
                    }
                }
            }
            txtTagDim1.Text = arrayDims[0].ToString();
            txtTagDim2.Text = arrayDims[1].ToString();
            txtTagDim3.Text = arrayDims[2].ToString();
        }

        private int GetUdtId(int type)
        {
            //Mask all but the last 3 hex digits of the type ID
            const ushort TYPE_UDT_ID_MASK = 0x0FFF;
            return type & TYPE_UDT_ID_MASK;
        }

        private bool TagUdtCheck(int type)
        {
            //Check whether tag type is UDT or Atomic
            const ushort TYPE_IS_UDT = 0x8000;
            const ushort TYPE_IS_ATOMIC = 0x1000;

            return ((type & TYPE_IS_UDT) != 0) && !((type & TYPE_IS_ATOMIC) != 0) && (type.ToString("X") != "8FCE");
        }

        private void WriteColumnHeaders()
        {
            //First column is always a list of the tag names in order
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tag Name", ReadOnly = true, SortMode = DataGridViewColumnSortMode.NotSortable });
            dt.Columns.Add(new DataColumn("Tag Name"));
            dt.Columns[0].ReadOnly = true;

            //If tag is UDT, store list of UDT members and write each one as the header to a new column
            //ZZZZZZZZZ represents hidden SINT array used for BOOL tags, do not display this
            if (tagIsUdt)
            {
                var udtMembers = Mappers.ReadUdtInfo(GetUdtId(rawTypeID));

                foreach (var member in udtMembers.Fields)
                {
                    if (!member.Name.Contains("ZZZZZZZZZZ"))
                    {
                        string name = member.Name;
                        string type = GetTypeString(member.Type).Item1;
                        udtMemberNamesList.Add(name);
                        udtMemberTypesList.Add(type);

                        //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = $"{name} ({type})", SortMode = DataGridViewColumnSortMode.NotSortable });
                        dt.Columns.Add(new DataColumn($"{name} ({type})"));
                    }
                }
            }

            //If tag is NOT UDT, write a single column with the header "Value (TYPE)"
            else
            {
                string type = GetTypeString(rawTypeID).Item1;
                //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = $"Value ({type})", SortMode = DataGridViewColumnSortMode.NotSortable });
                dt.Columns.Add(new DataColumn($"Value ({type})"));
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private string CreateTagNameString(int[] indexes, string udtMember = null)
        {
            StringBuilder sbTagName = new StringBuilder($"{enteredTagName}");

            //If the tag is an array (format Tag_Name[X,Y,Z])
            if (indexes.Length > 0)
            {
                sbTagName.Append($"[{indexes[0]}");
                if (indexes.Length > 1)
                {
                    sbTagName.Append($",{indexes[1]}");
                    if (indexes.Length > 2)
                    {
                        sbTagName.Append($",{indexes[2]}");
                    }
                }

                sbTagName.Append("]");
            }

            //If any UDT members are passed, tag is UDT
            if (udtMember != null)
            {
                sbTagName.Append($".{udtMember}");
            }

            return sbTagName.ToString();
        }

        private (string, string) GetTypeString(int rawType)
        {
            //Split the raw(decimal) type value into MSB (firstHalf) and LSB (secondHalf)
            string firstHalf = (rawType & 0xFF00).ToString("X");
            string secondHalf = (rawType & 0x00FF).ToString("X");
            string type;
            string arraySize;

            //If type is either STRING or ASCII
            if (rawType.ToString("X") == "8FCE" || rawType.ToString("X") == "20C2")
            {
                if (secondHalf == "CE") { return ("STRING", "STRING"); }
                else { return ("ASCII", "ASCII"); }
            }

            else
            {
                //MSB designates array size, if any
                switch (firstHalf)
                {
                    case "2000":
                        arraySize = "1D_";
                        break;
                    case "4000":
                        arraySize = "2D_";
                        break;
                    case "6000":
                        arraySize = "3D_";
                        break;
                    default:
                        arraySize = null;
                        break;
                }

                //LSB designates tag type
                switch (secondHalf)
                {
                    case "C1":
                        type = "BOOL";
                        break;
                    case "C2":
                        type = "SINT";
                        break;
                    case "C3":
                        type = "INT";
                        break;
                    case "C4":
                        type = "DINT";
                        break;
                    case "CA":
                        type = "REAL";
                        break;
                    case "D3":
                        type = "DWORD";
                        break;
                    case "C5":
                        type = "LINT";
                        break;
                    case "20C2":
                        type = "ASCII";
                        break;
                    case "8FCE":
                        type = "STRING";
                        break;
                    default:
                        type = rawType.ToString("X");
                        break;
                }
            }

            return ((arraySize + type), type);
        }



        //STARTUP FUNCTIONS
        public void CheckIP(string address)
        {
            //Verify that the IP Address is an acceptable value
            string[] octets = new string[4];
            int[] parsedOctets = new int[4];
            octets = address.Split('.');

            ipConfig.IPValidated = false;
            panIPAddr.BackColor = Color.Red;

            //Check that the IP address entered is exactly 4 octets (xxx.xxx.xxx.xxx) and parse each octet into an INT
            if (octets.Length == 4)
            {
                for (int i = 0; i < octets.Length; i++)
                {
                    Int32.TryParse(octets[i], out parsedOctets[i]);
                }

                //Pass the IP address if not all 0s or if all octets are below 255
                if (address != "0.0.0.0" && (parsedOctets.Any(z => z <= 255) && parsedOctets.Any(z => z >= 0)))
                {
                    ipConfig.IPValidated = true;
                    panIPAddr.BackColor = Color.FromArgb(0, 225, 0);
                }
            }
        }

        public bool CheckRack(string rack)
        {
            //Verify that the Rack # is a valid number greater than 0
            if (Int32.TryParse(rack, out int num) && num > 0)
            {
                ipConfig.RackValidated = true;
                panRackNum.BackColor = Color.FromArgb(0, 225, 0);
                return true;
            }
            else
            {
                ipConfig.RackValidated = false;
                panRackNum.BackColor = Color.Red;
                return false;
            }
        }

        public bool CheckSlot(string slot)
        {
            //Verify that the Slot # is a valid number of at least 0
            if (Int32.TryParse(slot, out int num) && num >= 0)
            {
                ipConfig.SlotValidated = true;
                panSlotNum.BackColor = Color.FromArgb(0, 225, 0);
                return true;
            }
            else
            {
                ipConfig.SlotValidated = false;
                panSlotNum.BackColor = Color.Red;
                return false;
            }
        }



        //DEFAULT SET/RESTORE FUNCTIONS
        public void SetDefaultComm()
        {
            //Allows the user to set new default values for Comm setup. These should load automatically when program restarts.
            Properties.Settings.Default.defaultIP = inputIPAddr.Text;
            Properties.Settings.Default.defaultRack = inputRackNum.Text;
            Properties.Settings.Default.defaultSlot = inputSlotNum.Text;
            Properties.Settings.Default.defaultController = ddlControllerType.SelectedItem.ToString();
            Properties.Settings.Default.defaultComm = ddlCommProtocol.SelectedItem.ToString();
            Properties.Settings.Default.defaultPath = inputRackNum.Text + "," + inputSlotNum.Text;
            Properties.Settings.Default.Save();
        }

        public void RestoreDefaultComm()
        {
            //Allows the user to restore previously saved default field values for the Comm setup.
            ipConfig.Gateway = Properties.Settings.Default.defaultIP;
            inputIPAddr.Text = Properties.Settings.Default.defaultIP;
            ipConfig.Rack = Properties.Settings.Default.defaultRack;
            inputRackNum.Text = Properties.Settings.Default.defaultRack;
            ipConfig.Slot = Properties.Settings.Default.defaultSlot;
            inputSlotNum.Text = Properties.Settings.Default.defaultSlot;
            ipConfig.CpuType = Properties.Settings.Default.defaultController;
            ddlControllerType.SelectedItem = Properties.Settings.Default.defaultController;
            ipConfig.CommType = ConvertCommType(Properties.Settings.Default.defaultComm);
            ddlCommProtocol.SelectedItem = Properties.Settings.Default.defaultComm;
            ipConfig.Path = Properties.Settings.Default.defaultPath;
        }

        public string ConvertCommType(string type)
        {
            switch (type)
            {
                case "Allen-Bradley EthernetIP":
                    return "ab_eip";
                case "Modbus TCP":
                    return "modbus_tcp";
                default:
                    return "ab_eip";
            }
        }



        //CONTROL EVENTS
        private void Form1_Load(object sender, EventArgs e)
        {
            RestoreDefaultComm();

            //Check default comm fields are valid, color box appropriately
            CheckIP(ipConfig.Gateway);
            CheckRack(ipConfig.Rack);
            CheckSlot(ipConfig.Slot);

            //Highlight IP Address input field when opening program
            inputIPAddr.Select();

            //Fill tag name field with last tag used
            inputTagName.Text = Properties.Settings.Default.lastTagEntered;
            enteredTagName = inputTagName.Text;

            this.dataGridView1.DataSource = dt;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmAppClose = MessageBox.Show("Do you really wish to quit the application? All populated tag data will be lost!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmAppClose == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void xlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                    {
                        var newWidth = Math.Min(255, dataGridView1.Columns[j - 1].Width / 2);
                        ws.Columns[j].ColumnWidth = newWidth;
                        ws.Cells[1, j] = dataGridView1.Columns[j - 1].HeaderText;
                    }
                    int i = 2;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int k = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            ws.Cells[i, k] = cell.Value;
                            k++;
                        }
                        i++;
                    }
                    ws.Cells[1, 1].EntireRow.Font.Bold = true;
                    ws.Columns.AutoFit();
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Export Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text File|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter csv = new StreamWriter(sfd.FileName, false))
                    {
                        int totalCols = dataGridView1.ColumnCount;
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            csv.Write(col.HeaderText);
                            if (col.HeaderText != dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText)
                            {
                                csv.Write(',');
                            }
                        }
                        csv.Write('\n');
                        string data = "";
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;
                            data = "";
                            for (int i = 0; i < totalCols; i++)
                            {
                                data += (row.Cells[i].Value ?? "").ToString();
                                if (i != totalCols - 1)
                                {
                                    data += ",";
                                }
                            }
                            if (data != string.Empty)
                            {
                                csv.WriteLine(data);
                            }
                        }
                    }
                    MessageBox.Show("Export Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputTagName_Leave(object sender, EventArgs e)
        {
            enteredTagName = inputTagName.Text;
            Properties.Settings.Default.lastTagEntered = inputTagName.Text;
        }

        private void inputIPAddr_TextChanged(object sender, EventArgs e)
        {
            ipConfig.Gateway = inputIPAddr.Text;
        }

        private void inputIPAddr_Leave(object sender, EventArgs e)
        {
            CheckIP(ipConfig.Gateway);
        }

        private void inputRackNum_TextChanged(object sender, EventArgs e)
        {
            ipConfig.Rack = inputRackNum.Text;
        }

        private void inputRackNum_Leave(object sender, EventArgs e)
        {
            if (CheckRack(ipConfig.Rack))
            {
                ipConfig.Path = inputRackNum.Text + "," + inputSlotNum.Text;
            }

        }

        private void inputSlotNum_TextChanged(object sender, EventArgs e)
        {
            ipConfig.Slot = inputSlotNum.Text;
        }

        private void inputSlotNum_Leave(object sender, EventArgs e)
        {
            if (CheckSlot(ipConfig.Slot))
            {
                ipConfig.Path = ipConfig.Path;
            }
        }

        private void ddlControllerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update CPU Type when new option is selected from the drop-down menu
            ipConfig.CpuType = ddlControllerType.SelectedItem.ToString();
        }

        private void ddlCommProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update Comm Type when new option is selected from the drop-down menu
            ipConfig.CommType = ConvertCommType(ddlCommProtocol.SelectedItem.ToString());
        }

        private void btnSetDefaultIP_Click(object sender, EventArgs e)
        {

        }

        private void btnRestoreDefaultIP_Click(object sender, EventArgs e)
        {
            var confirmRestore = MessageBox.Show("Are you sure you wish to restore your communication settings to the default configuration?\n\nThis will erase all of your current communication settings and cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmRestore == DialogResult.Yes)
            {
                RestoreDefaultComm();
                MessageBox.Show("Default communication configuration restored!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.Style.BackColor = Color.Yellow;
            tagDataChanges.Add(new string[]{(dataGridView1.CurrentCell.Value.ToString()),(dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText), (dataGridView1.CurrentRow.Cells[0].Value.ToString()) });

            btnCancelChanges.Enabled = true;
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
            tagDataChanges.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.Empty;
                }
            }

            btnCancelChanges.Enabled = false;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clearAll = MessageBox.Show("Are you sure you wish to clear all data from this list?\nThis action cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (clearAll == DialogResult.Yes)
            {
                udtMemberNamesList.Clear();
                udtMemberTypesList.Clear();
                tagList.Clear();
                dt.Columns.Clear();
                dt.Clear();
            }
        }

        private void btnReadTags_Click(object sender, EventArgs e)
        {
            //Clear all lists with every new Read request
            udtMemberNamesList.Clear();
            udtMemberTypesList.Clear();
            tagList.Clear();
            dt.Columns.Clear();
            dt.Clear();

            PrintTagInfo();
            WriteColumnHeaders();
            WriteTagData();

            dt.AcceptChanges();
        }
    }
}