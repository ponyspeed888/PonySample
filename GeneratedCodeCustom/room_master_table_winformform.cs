



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CodeGenApp
{
    public partial class room_master_tableEntityEditor : UserControl
    {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdEditorMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditorMain)).BeginInit();
            this.SuspendLayout();

            

            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 9;
            this.id.Name = "id";
            this.id.Width = 175;
            
            

            this.identity_hash.DataPropertyName = "identity_hash";
            this.identity_hash.HeaderText = "identity_hash";
            this.identity_hash.MinimumWidth = 9;
            this.identity_hash.Name = "identity_hash";
            this.identity_hash.Width = 175;
            
            


            // 
            // EntityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // grdEditorMain
            // 
            this.grdEditorMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdEditorMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEditorMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,this.identity_hash,});
            this.grdEditorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEditorMain.Location = new System.Drawing.Point(0, 0);
            this.grdEditorMain.Name = "grdEditorMain";
            this.grdEditorMain.RowHeadersWidth = 72;
            this.grdEditorMain.Size = new System.Drawing.Size(1092, 750);
            this.grdEditorMain.TabIndex = 0;
            this.grdEditorMain.AutoGenerateColumns = false;

            this.grdEditorMain.Text = "dataGridView1";
            this.Controls.Add(this.grdEditorMain);
            this.Name = "EntityEditor";
            this.Size = new System.Drawing.Size(1092, 750);
            ((System.ComponentModel.ISupportInitialize)(this.grdEditorMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

         private System.Windows.Forms.DataGridViewTextBoxColumn id =  new System.Windows.Forms.DataGridViewTextBoxColumn();
 private System.Windows.Forms.DataGridViewTextBoxColumn identity_hash =  new System.Windows.Forms.DataGridViewTextBoxColumn();

        public System.Windows.Forms.DataGridView grdEditorMain;


        public  room_master_tableEntityEditor()
        {
            InitializeComponent();
        }
    }
}



