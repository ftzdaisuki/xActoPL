namespace PhotoLibrary
{
    partial class Form1
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
            this.importButton = new System.Windows.Forms.Button();
            this.outerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.innerSplitLeft = new System.Windows.Forms.SplitContainer();
            this.tagCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.innerSplitRight = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dbDebugButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outerSplitContainer)).BeginInit();
            this.outerSplitContainer.Panel1.SuspendLayout();
            this.outerSplitContainer.Panel2.SuspendLayout();
            this.outerSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innerSplitLeft)).BeginInit();
            this.innerSplitLeft.Panel1.SuspendLayout();
            this.innerSplitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innerSplitRight)).BeginInit();
            this.innerSplitRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(10, 9);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outerSplitContainer
            // 
            this.outerSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outerSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outerSplitContainer.Location = new System.Drawing.Point(12, 38);
            this.outerSplitContainer.Name = "outerSplitContainer";
            // 
            // outerSplitContainer.Panel1
            // 
            this.outerSplitContainer.Panel1.Controls.Add(this.innerSplitLeft);
            this.outerSplitContainer.Panel1.Controls.Add(this.label1);
            this.outerSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // outerSplitContainer.Panel2
            // 
            this.outerSplitContainer.Panel2.Controls.Add(this.innerSplitRight);
            this.outerSplitContainer.Panel2.Controls.Add(this.label2);
            this.outerSplitContainer.Size = new System.Drawing.Size(789, 434);
            this.outerSplitContainer.SplitterDistance = 262;
            this.outerSplitContainer.TabIndex = 1;
            // 
            // innerSplitLeft
            // 
            this.innerSplitLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.innerSplitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerSplitLeft.Location = new System.Drawing.Point(0, 0);
            this.innerSplitLeft.Name = "innerSplitLeft";
            this.innerSplitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // innerSplitLeft.Panel1
            // 
            this.innerSplitLeft.Panel1.Controls.Add(this.tagCheckListBox);
            this.innerSplitLeft.Size = new System.Drawing.Size(262, 434);
            this.innerSplitLeft.SplitterDistance = 182;
            this.innerSplitLeft.TabIndex = 1;
            this.innerSplitLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.innerSplitLeft_SplitterMoved);
            // 
            // tagCheckListBox
            // 
            this.tagCheckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagCheckListBox.FormattingEnabled = true;
            this.tagCheckListBox.Location = new System.Drawing.Point(-1, 17);
            this.tagCheckListBox.Name = "tagCheckListBox";
            this.tagCheckListBox.Size = new System.Drawing.Size(262, 166);
            this.tagCheckListBox.TabIndex = 0;
            this.tagCheckListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here\'s where your tags will go!";
            // 
            // innerSplitRight
            // 
            this.innerSplitRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.innerSplitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerSplitRight.Location = new System.Drawing.Point(0, 0);
            this.innerSplitRight.Name = "innerSplitRight";
            this.innerSplitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.innerSplitRight.Size = new System.Drawing.Size(523, 434);
            this.innerSplitRight.SplitterDistance = 340;
            this.innerSplitRight.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Here\'s where your photos will be!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dbDebugButton
            // 
            this.dbDebugButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbDebugButton.Location = new System.Drawing.Point(725, 9);
            this.dbDebugButton.Name = "dbDebugButton";
            this.dbDebugButton.Size = new System.Drawing.Size(75, 23);
            this.dbDebugButton.TabIndex = 2;
            this.dbDebugButton.Text = "DB Debug";
            this.dbDebugButton.UseVisualStyleBackColor = true;
            this.dbDebugButton.Click += new System.EventHandler(this.dbDebugButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 484);
            this.Controls.Add(this.dbDebugButton);
            this.Controls.Add(this.outerSplitContainer);
            this.Controls.Add(this.importButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outerSplitContainer.Panel1.ResumeLayout(false);
            this.outerSplitContainer.Panel1.PerformLayout();
            this.outerSplitContainer.Panel2.ResumeLayout(false);
            this.outerSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outerSplitContainer)).EndInit();
            this.outerSplitContainer.ResumeLayout(false);
            this.innerSplitLeft.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.innerSplitLeft)).EndInit();
            this.innerSplitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.innerSplitRight)).EndInit();
            this.innerSplitRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button importButton;
        private SplitContainer outerSplitContainer;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button dbDebugButton;
        private SplitContainer innerSplitLeft;
        private SplitContainer innerSplitRight;
        private CheckedListBox tagCheckListBox;
    }
}