﻿namespace View
{
    partial class GeneralForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Open = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Figure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Random = new System.Windows.Forms.Button();
            this.RemoveFigure = new System.Windows.Forms.Button();
            this.AddFigure = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Open);
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Location = new System.Drawing.Point(7, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elements";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(103, 256);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 4;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Figure,
            this.Volume});
            this.Grid.Location = new System.Drawing.Point(6, 19);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(268, 231);
            this.Grid.TabIndex = 0;
            // 
            // Figure
            // 
            this.Figure.Frozen = true;
            this.Figure.HeaderText = "Figure";
            this.Figure.Name = "Figure";
            this.Figure.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(6, 256);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Random);
            this.groupBox2.Controls.Add(this.RemoveFigure);
            this.groupBox2.Controls.Add(this.AddFigure);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface";
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(199, 19);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(75, 23);
            this.Random.TabIndex = 2;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // RemoveFigure
            // 
            this.RemoveFigure.Location = new System.Drawing.Point(87, 19);
            this.RemoveFigure.Name = "RemoveFigure";
            this.RemoveFigure.Size = new System.Drawing.Size(106, 23);
            this.RemoveFigure.TabIndex = 1;
            this.RemoveFigure.Text = "Remove Figure";
            this.RemoveFigure.UseVisualStyleBackColor = true;
            this.RemoveFigure.Click += new System.EventHandler(this.RemoveFigyre_Click);
            // 
            // AddFigure
            // 
            this.AddFigure.Location = new System.Drawing.Point(6, 19);
            this.AddFigure.Name = "AddFigure";
            this.AddFigure.Size = new System.Drawing.Size(75, 23);
            this.AddFigure.TabIndex = 0;
            this.AddFigure.Text = "Add Figure";
            this.AddFigure.UseVisualStyleBackColor = true;
            this.AddFigure.Click += new System.EventHandler(this.AddFigyre_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "(*.vol)|*.vol";
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            this.openDialog.Filter = "(*.vol)|*.vol";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(199, 256);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GeneralForm";
            this.Text = "Volume figures";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button RemoveFigure;
        private System.Windows.Forms.Button AddFigure;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn Figure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button Clear;
    }
}

