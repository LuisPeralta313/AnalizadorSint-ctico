﻿
namespace ProyectoLFA
{
    partial class TransitionsView
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
            this.RTXtext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FollowTable = new System.Windows.Forms.DataGridView();
            this.TreeTable = new System.Windows.Forms.DataGridView();
            this.TransitionsTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FollowTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransitionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RTXtext
            // 
            this.RTXtext.BackColor = System.Drawing.Color.Khaki;
            this.RTXtext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTXtext.ForeColor = System.Drawing.Color.Red;
            this.RTXtext.Location = new System.Drawing.Point(16, 54);
            this.RTXtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RTXtext.Name = "RTXtext";
            this.RTXtext.Size = new System.Drawing.Size(468, 116);
            this.RTXtext.TabIndex = 0;
            this.RTXtext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(175, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOKENS";
            // 
            // FollowTable
            // 
            this.FollowTable.BackgroundColor = System.Drawing.Color.Khaki;
            this.FollowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FollowTable.Location = new System.Drawing.Point(511, 54);
            this.FollowTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FollowTable.Name = "FollowTable";
            this.FollowTable.RowHeadersVisible = false;
            this.FollowTable.RowHeadersWidth = 51;
            this.FollowTable.Size = new System.Drawing.Size(380, 561);
            this.FollowTable.TabIndex = 2;
            // 
            // TreeTable
            // 
            this.TreeTable.BackgroundColor = System.Drawing.Color.Khaki;
            this.TreeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TreeTable.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.TreeTable.Location = new System.Drawing.Point(16, 474);
            this.TreeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TreeTable.Name = "TreeTable";
            this.TreeTable.RowHeadersVisible = false;
            this.TreeTable.RowHeadersWidth = 51;
            this.TreeTable.Size = new System.Drawing.Size(468, 124);
            this.TreeTable.TabIndex = 3;
            // 
            // TransitionsTable
            // 
            this.TransitionsTable.BackgroundColor = System.Drawing.Color.Khaki;
            this.TransitionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransitionsTable.Location = new System.Drawing.Point(16, 244);
            this.TransitionsTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransitionsTable.Name = "TransitionsTable";
            this.TransitionsTable.RowHeadersVisible = false;
            this.TransitionsTable.RowHeadersWidth = 51;
            this.TransitionsTable.Size = new System.Drawing.Size(468, 167);
            this.TransitionsTable.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(165, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabla de transiciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(126, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabla de First, Last y Nullable\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(632, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tabla de Follow";
            // 
            // TransitionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(953, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransitionsTable);
            this.Controls.Add(this.TreeTable);
            this.Controls.Add(this.FollowTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTXtext);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransitionsView";
            this.Text = "TransitionsView";
            this.Load += new System.EventHandler(this.TransitionsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FollowTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransitionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTXtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FollowTable;
        private System.Windows.Forms.DataGridView TreeTable;
        private System.Windows.Forms.DataGridView TransitionsTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}