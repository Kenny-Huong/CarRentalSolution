﻿namespace CarRenTal
{
    partial class QuanLiXeView
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
            dtg_show = new DataGridView();
            tb_seach = new TextBox();
            bt_dhdk = new Button();
            bt_hhdk = new Button();
            bt_add = new Button();
            bt_bd = new Button();
            cb_lsg = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            bt_edit = new Button();
            bt_bh = new Button();
            bt_dk = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.AllowUserToAddRows = false;
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(42, 105);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(976, 301);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tb_seach
            // 
            tb_seach.Location = new Point(42, 40);
            tb_seach.Name = "tb_seach";
            tb_seach.Size = new Size(293, 27);
            tb_seach.TabIndex = 1;
            tb_seach.TextChanged += tb_seach_TextChanged;
            // 
            // bt_dhdk
            // 
            bt_dhdk.Location = new Point(853, 41);
            bt_dhdk.Name = "bt_dhdk";
            bt_dhdk.Size = new Size(165, 29);
            bt_dhdk.TabIndex = 2;
            bt_dhdk.Text = "Đến hạn đăng kiểm";
            bt_dhdk.UseVisualStyleBackColor = true;
            bt_dhdk.Click += bt_dhdk_Click;
            // 
            // bt_hhdk
            // 
            bt_hhdk.Location = new Point(638, 41);
            bt_hhdk.Name = "bt_hhdk";
            bt_hhdk.Size = new Size(165, 29);
            bt_hhdk.TabIndex = 2;
            bt_hhdk.Text = "Còn hạn đăng kiểm";
            bt_hhdk.UseVisualStyleBackColor = true;
            bt_hhdk.Click += bt_hhdk_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(831, 427);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(187, 39);
            bt_add.TabIndex = 2;
            bt_add.Text = "Thêm xe";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_bd
            // 
            bt_bd.Location = new Point(42, 427);
            bt_bd.Name = "bt_bd";
            bt_bd.Size = new Size(154, 39);
            bt_bd.TabIndex = 2;
            bt_bd.Text = "Xem bảo dưỡng Xe";
            bt_bd.UseVisualStyleBackColor = true;
            bt_bd.Click += bt_dk_Click;
            // 
            // cb_lsg
            // 
            cb_lsg.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_lsg.FormattingEnabled = true;
            cb_lsg.Items.AddRange(new object[] { "", "4", "7", "16", "30", "35", "45", "47" });
            cb_lsg.Location = new Point(379, 41);
            cb_lsg.Name = "cb_lsg";
            cb_lsg.Size = new Size(151, 28);
            cb_lsg.TabIndex = 3;
            cb_lsg.TextChanged += comboBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm theo số ghế";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 9);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 4;
            label2.Text = "Tìm kiếm theo tên";
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(638, 427);
            bt_edit.Margin = new Padding(3, 4, 3, 4);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(187, 39);
            bt_edit.TabIndex = 5;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_bh
            // 
            bt_bh.Location = new Point(203, 427);
            bt_bh.Margin = new Padding(3, 4, 3, 4);
            bt_bh.Name = "bt_bh";
            bt_bh.Size = new Size(154, 39);
            bt_bh.TabIndex = 6;
            bt_bh.Text = "Xem bảo hiểm xe";
            bt_bh.UseVisualStyleBackColor = true;
            bt_bh.Click += bt_bh_Click;
            // 
            // bt_dk
            // 
            bt_dk.Location = new Point(363, 427);
            bt_dk.Margin = new Padding(3, 4, 3, 4);
            bt_dk.Name = "bt_dk";
            bt_dk.Size = new Size(154, 39);
            bt_dk.TabIndex = 7;
            bt_dk.Text = "Xem đăng kiểm xe";
            bt_dk.UseVisualStyleBackColor = true;
            bt_dk.Click += bt_dk_Click_1;
            // 
            // QuanLiXeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 500);
            Controls.Add(bt_dk);
            Controls.Add(bt_bh);
            Controls.Add(bt_edit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_lsg);
            Controls.Add(bt_hhdk);
            Controls.Add(bt_dhdk);
            Controls.Add(bt_bd);
            Controls.Add(bt_add);
            Controls.Add(tb_seach);
            Controls.Add(dtg_show);
            Name = "QuanLiXeView";
            Text = "QuanLiXe";
            Load += QuanLiXe_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_seach;
        private Button bt_dhdk;
        private Button bt_hhdk;
        private Button bt_add;
        private Button bt_bd;
        private ComboBox cb_lsg;
        private Label label1;
        private Label label2;
        private Button bt_edit;
        private Button bt_bh;
        private Button bt_dk;
    }
}