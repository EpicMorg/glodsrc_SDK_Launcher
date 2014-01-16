﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace gSDK_Launcher.UI {
    partial class FrmCustomSection {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel_back = new System.Windows.Forms.Panel();
            this.lbl_programselect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_commandline = new System.Windows.Forms.Label();
            this.lbl_custom_list = new System.Windows.Forms.Label();
            this.txt_arguments = new System.Windows.Forms.TextBox();
            this.list_custom_items = new System.Windows.Forms.ListView();
            this.btn_saveit = new System.Windows.Forms.Button();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.btn_delete_selected = new System.Windows.Forms.Button();
            this.ofdExe = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Enabled = false;
            this.pic_btn_min.Location = new System.Drawing.Point(274, 12);
            this.pic_btn_min.Visible = false;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Enabled = false;
            this.pic_btn_max.Location = new System.Drawing.Point(298, 12);
            this.pic_btn_max.Visible = false;
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Location = new System.Drawing.Point(322, 12);
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new System.Drawing.Size(54, 13);
            this.lbl_title.Text = "Edit menu";
            // 
            // panel_back
            // 
            this.panel_back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.panel_back.Controls.Add(this.lbl_programselect);
            this.panel_back.Controls.Add(this.button1);
            this.panel_back.Controls.Add(this.textBox1);
            this.panel_back.Controls.Add(this.lbl_commandline);
            this.panel_back.Controls.Add(this.lbl_custom_list);
            this.panel_back.Controls.Add(this.txt_arguments);
            this.panel_back.Controls.Add(this.list_custom_items);
            this.panel_back.Location = new System.Drawing.Point(12, 34);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(328, 293);
            this.panel_back.TabIndex = 7;
            // 
            // lbl_programselect
            // 
            this.lbl_programselect.AutoSize = true;
            this.lbl_programselect.Location = new System.Drawing.Point(3, 213);
            this.lbl_programselect.Name = "lbl_programselect";
            this.lbl_programselect.Size = new System.Drawing.Size(49, 13);
            this.lbl_programselect.TabIndex = 5;
            this.lbl_programselect.Text = "Program:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(68)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(286, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_commandline
            // 
            this.lbl_commandline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_commandline.AutoSize = true;
            this.lbl_commandline.Location = new System.Drawing.Point(3, 254);
            this.lbl_commandline.Name = "lbl_commandline";
            this.lbl_commandline.Size = new System.Drawing.Size(119, 13);
            this.lbl_commandline.TabIndex = 2;
            this.lbl_commandline.Text = "Commanline arguments:";
            // 
            // lbl_custom_list
            // 
            this.lbl_custom_list.AutoSize = true;
            this.lbl_custom_list.Location = new System.Drawing.Point(3, 9);
            this.lbl_custom_list.Name = "lbl_custom_list";
            this.lbl_custom_list.Size = new System.Drawing.Size(72, 13);
            this.lbl_custom_list.TabIndex = 2;
            this.lbl_custom_list.Text = "Custom items:";
            // 
            // txt_arguments
            // 
            this.txt_arguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_arguments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.txt_arguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_arguments.Location = new System.Drawing.Point(6, 270);
            this.txt_arguments.Name = "txt_arguments";
            this.txt_arguments.Size = new System.Drawing.Size(319, 20);
            this.txt_arguments.TabIndex = 1;
            // 
            // list_custom_items
            // 
            this.list_custom_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_custom_items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_custom_items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_custom_items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_custom_items.Location = new System.Drawing.Point(3, 25);
            this.list_custom_items.Name = "list_custom_items";
            this.list_custom_items.Size = new System.Drawing.Size(322, 185);
            this.list_custom_items.TabIndex = 0;
            this.list_custom_items.UseCompatibleStateImageBehavior = false;
            // 
            // btn_saveit
            // 
            this.btn_saveit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saveit.Location = new System.Drawing.Point(265, 333);
            this.btn_saveit.Name = "btn_saveit";
            this.btn_saveit.Size = new System.Drawing.Size(75, 23);
            this.btn_saveit.TabIndex = 8;
            this.btn_saveit.Text = "Save";
            this.btn_saveit.UseVisualStyleBackColor = true;
            this.btn_saveit.Click += new System.EventHandler(this.btn_saveit_Click);
            // 
            // btn_add_item
            // 
            this.btn_add_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_item.Location = new System.Drawing.Point(12, 333);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(75, 23);
            this.btn_add_item.TabIndex = 8;
            this.btn_add_item.Text = "Add";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // btn_delete_selected
            // 
            this.btn_delete_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_selected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete_selected.Location = new System.Drawing.Point(93, 333);
            this.btn_delete_selected.Name = "btn_delete_selected";
            this.btn_delete_selected.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_selected.TabIndex = 8;
            this.btn_delete_selected.Text = "Delete";
            this.btn_delete_selected.UseVisualStyleBackColor = true;
            this.btn_delete_selected.Click += new System.EventHandler(this.btn_delete_selected_Click);
            // 
            // ofdExe
            // 
            this.ofdExe.RestoreDirectory = true;
            this.ofdExe.Title = "Select program";
            // 
            // FrmCustomSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(352, 368);
            this.Controls.Add(this.btn_delete_selected);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.btn_saveit);
            this.Controls.Add(this.panel_back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 368);
            this.Name = "FrmCustomSection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit menu";
            this.Load += new System.EventHandler(this.FrmCustomSection_Load);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.panel_back, 0);
            this.Controls.SetChildIndex(this.btn_saveit, 0);
            this.Controls.SetChildIndex(this.btn_add_item, 0);
            this.Controls.SetChildIndex(this.btn_delete_selected, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_back.ResumeLayout(false);
            this.panel_back.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_back;
        private Button btn_saveit;
        private ListView list_custom_items;
        private Button btn_delete_selected;
        private Button btn_add_item;
        private Label lbl_commandline;
        private Label lbl_custom_list;
        private TextBox txt_arguments;
        private Label lbl_programselect;
        private Button button1;
        private TextBox textBox1;
        private OpenFileDialog ofdExe;
    }
}