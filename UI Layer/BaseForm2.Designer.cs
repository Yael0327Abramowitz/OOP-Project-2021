
namespace UI_Layer
{
    partial class BaseForm2
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
            this.buttonModifyEnter = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.ButtonBackToMenu = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.ButtonShowAll = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxReadAll = new System.Windows.Forms.TextBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.ButtonDeleteEnter = new System.Windows.Forms.Button();
            this.buttonEnterNew = new System.Windows.Forms.Button();
            this.buttonEnterShowOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModifyEnter
            // 
            this.buttonModifyEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonModifyEnter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyEnter.Location = new System.Drawing.Point(637, 330);
            this.buttonModifyEnter.Name = "buttonModifyEnter";
            this.buttonModifyEnter.Size = new System.Drawing.Size(102, 121);
            this.buttonModifyEnter.TabIndex = 37;
            this.buttonModifyEnter.Text = "Enter";
            this.buttonModifyEnter.UseVisualStyleBackColor = false;
            this.buttonModifyEnter.Visible = false;
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonModify.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(481, 21);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(151, 303);
            this.buttonModify.TabIndex = 33;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // ButtonBackToMenu
            // 
            this.ButtonBackToMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonBackToMenu.Location = new System.Drawing.Point(24, 360);
            this.ButtonBackToMenu.Name = "ButtonBackToMenu";
            this.ButtonBackToMenu.Size = new System.Drawing.Size(138, 23);
            this.ButtonBackToMenu.TabIndex = 35;
            this.ButtonBackToMenu.Text = "Back to menu";
            this.ButtonBackToMenu.UseVisualStyleBackColor = false;
            this.ButtonBackToMenu.Visible = false;
            this.ButtonBackToMenu.Click += new System.EventHandler(this.ButtonBackToMenu_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(637, 208);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 116);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonShow.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(324, 21);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(151, 303);
            this.buttonShow.TabIndex = 32;
            this.buttonShow.Text = "show one";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // ButtonShowAll
            // 
            this.ButtonShowAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonShowAll.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAll.Location = new System.Drawing.Point(168, 21);
            this.ButtonShowAll.Name = "ButtonShowAll";
            this.ButtonShowAll.Size = new System.Drawing.Size(151, 303);
            this.ButtonShowAll.TabIndex = 31;
            this.ButtonShowAll.Text = "show all ";
            this.ButtonShowAll.UseVisualStyleBackColor = false;
            this.ButtonShowAll.Click += new System.EventHandler(this.ButtonShowAll_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNew.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(11, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(151, 303);
            this.buttonNew.TabIndex = 30;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxReadAll
            // 
            this.textBoxReadAll.Location = new System.Drawing.Point(782, 81);
            this.textBoxReadAll.Multiline = true;
            this.textBoxReadAll.Name = "textBoxReadAll";
            this.textBoxReadAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReadAll.Size = new System.Drawing.Size(306, 399);
            this.textBoxReadAll.TabIndex = 38;
            this.textBoxReadAll.Visible = false;
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(782, 42);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(284, 35);
            this.InventoryLabel.TabIndex = 39;
            this.InventoryLabel.Text = "This is your inventory:";
            this.InventoryLabel.Visible = false;
            // 
            // ButtonDeleteEnter
            // 
            this.ButtonDeleteEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonDeleteEnter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteEnter.Location = new System.Drawing.Point(637, 330);
            this.ButtonDeleteEnter.Name = "ButtonDeleteEnter";
            this.ButtonDeleteEnter.Size = new System.Drawing.Size(102, 121);
            this.ButtonDeleteEnter.TabIndex = 42;
            this.ButtonDeleteEnter.Text = "Enter";
            this.ButtonDeleteEnter.UseVisualStyleBackColor = false;
            this.ButtonDeleteEnter.Visible = false;
            this.ButtonDeleteEnter.Click += new System.EventHandler(this.ButtonDeleteEnter_Click);
            // 
            // buttonEnterNew
            // 
            this.buttonEnterNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEnterNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterNew.Location = new System.Drawing.Point(637, 330);
            this.buttonEnterNew.Name = "buttonEnterNew";
            this.buttonEnterNew.Size = new System.Drawing.Size(102, 121);
            this.buttonEnterNew.TabIndex = 41;
            this.buttonEnterNew.Text = "Enter";
            this.buttonEnterNew.UseVisualStyleBackColor = false;
            this.buttonEnterNew.Visible = false;
            this.buttonEnterNew.Click += new System.EventHandler(this.buttonEnterNew_Click);
            // 
            // buttonEnterShowOne
            // 
            this.buttonEnterShowOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEnterShowOne.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterShowOne.Location = new System.Drawing.Point(637, 330);
            this.buttonEnterShowOne.Name = "buttonEnterShowOne";
            this.buttonEnterShowOne.Size = new System.Drawing.Size(102, 121);
            this.buttonEnterShowOne.TabIndex = 40;
            this.buttonEnterShowOne.Text = "Enter";
            this.buttonEnterShowOne.UseVisualStyleBackColor = false;
            this.buttonEnterShowOne.Visible = false;
            // 
            // BaseForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 495);
            this.Controls.Add(this.ButtonDeleteEnter);
            this.Controls.Add(this.buttonEnterNew);
            this.Controls.Add(this.buttonEnterShowOne);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.textBoxReadAll);
            this.Controls.Add(this.buttonModifyEnter);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.ButtonBackToMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.ButtonShowAll);
            this.Controls.Add(this.buttonNew);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BaseForm2";
            this.Text = "BaseForm2";
            this.Load += new System.EventHandler(this.BaseForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonModifyEnter;
        protected System.Windows.Forms.Button buttonModify;
        protected System.Windows.Forms.Button ButtonBackToMenu;
        protected System.Windows.Forms.Button buttonDelete;
        protected System.Windows.Forms.Button buttonShow;
        protected System.Windows.Forms.Button ButtonShowAll;
        protected System.Windows.Forms.Button buttonNew;
        protected System.Windows.Forms.TextBox textBoxReadAll;
        protected System.Windows.Forms.Label InventoryLabel;
        protected System.Windows.Forms.Button ButtonDeleteEnter;
        protected System.Windows.Forms.Button buttonEnterNew;
        protected System.Windows.Forms.Button buttonEnterShowOne;
    }
}