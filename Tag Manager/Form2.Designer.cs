namespace Tag_Manager
{
    partial class Form2
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
            this.btnExpandTag = new System.Windows.Forms.Button();
            this.btnSelectTag = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnExpandTag
            // 
            this.btnExpandTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandTag.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandTag.Location = new System.Drawing.Point(12, 582);
            this.btnExpandTag.Name = "btnExpandTag";
            this.btnExpandTag.Size = new System.Drawing.Size(125, 51);
            this.btnExpandTag.TabIndex = 45;
            this.btnExpandTag.Text = "Expand Tag";
            this.btnExpandTag.UseVisualStyleBackColor = true;
            this.btnExpandTag.Click += new System.EventHandler(this.btnReadTags_Click);
            // 
            // btnSelectTag
            // 
            this.btnSelectTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTag.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTag.Location = new System.Drawing.Point(143, 582);
            this.btnSelectTag.Name = "btnSelectTag";
            this.btnSelectTag.Size = new System.Drawing.Size(125, 51);
            this.btnSelectTag.TabIndex = 46;
            this.btnSelectTag.Text = "Select Tag";
            this.btnSelectTag.UseVisualStyleBackColor = true;
            this.btnSelectTag.Click += new System.EventHandler(this.btnSelectTag_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(274, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 51);
            this.button2.TabIndex = 47;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(387, 550);
            this.treeView1.TabIndex = 49;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectTag);
            this.Controls.Add(this.btnExpandTag);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Tag List";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExpandTag;
        private System.Windows.Forms.Button btnSelectTag;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.TreeView treeView1;
    }
}