namespace ListProject
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSequentialSearch = new System.Windows.Forms.Button();
            this.btnInitialization = new System.Windows.Forms.Button();
            this.btnIndexOfSearch = new System.Windows.Forms.Button();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.btnListInt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(45, 260);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(361, 161);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(45, 50);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 45);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSequentialSearch
            // 
            this.btnSequentialSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSequentialSearch.Location = new System.Drawing.Point(236, 49);
            this.btnSequentialSearch.Name = "btnSequentialSearch";
            this.btnSequentialSearch.Size = new System.Drawing.Size(170, 45);
            this.btnSequentialSearch.TabIndex = 2;
            this.btnSequentialSearch.Text = "Sequential Search";
            this.btnSequentialSearch.UseVisualStyleBackColor = true;
            this.btnSequentialSearch.Click += new System.EventHandler(this.btnSequentialSearch_Click);
            // 
            // btnInitialization
            // 
            this.btnInitialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialization.Location = new System.Drawing.Point(45, 113);
            this.btnInitialization.Name = "btnInitialization";
            this.btnInitialization.Size = new System.Drawing.Size(170, 45);
            this.btnInitialization.TabIndex = 3;
            this.btnInitialization.Text = "List with initialization";
            this.btnInitialization.UseVisualStyleBackColor = true;
            this.btnInitialization.Click += new System.EventHandler(this.btnInitialization_Click);
            // 
            // btnIndexOfSearch
            // 
            this.btnIndexOfSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndexOfSearch.Location = new System.Drawing.Point(236, 113);
            this.btnIndexOfSearch.Name = "btnIndexOfSearch";
            this.btnIndexOfSearch.Size = new System.Drawing.Size(170, 45);
            this.btnIndexOfSearch.TabIndex = 4;
            this.btnIndexOfSearch.Text = "(indexOf) Search";
            this.btnIndexOfSearch.UseVisualStyleBackColor = true;
            this.btnIndexOfSearch.Click += new System.EventHandler(this.btnIndexOfSearch_Click);
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(265, 12);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(170, 20);
            this.txtSeach.TabIndex = 5;
            // 
            // btnListInt
            // 
            this.btnListInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListInt.Location = new System.Drawing.Point(45, 177);
            this.btnListInt.Name = "btnListInt";
            this.btnListInt.Size = new System.Drawing.Size(170, 45);
            this.btnListInt.TabIndex = 6;
            this.btnListInt.Text = "List <int>";
            this.btnListInt.UseVisualStyleBackColor = true;
            this.btnListInt.Click += new System.EventHandler(this.btnListInt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "What do you want to find in the Zodiac list?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListInt);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.btnIndexOfSearch);
            this.Controls.Add(this.btnInitialization);
            this.Controls.Add(this.btnSequentialSearch);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSequentialSearch;
        private System.Windows.Forms.Button btnInitialization;
        private System.Windows.Forms.Button btnIndexOfSearch;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Button btnListInt;
        private System.Windows.Forms.Label label1;
    }
}

