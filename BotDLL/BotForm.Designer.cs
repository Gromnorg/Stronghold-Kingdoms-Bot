﻿// Developed by Riketta https://github.com/Riketta/Stronghold-Kingdoms-Bot


namespace BotDLL
{
    partial class BotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotForm));
            this.listBox_ResList = new System.Windows.Forms.ListBox();
            this.textBox_TradeTargetID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Trade = new System.Windows.Forms.Button();
            this.button_MapEditing = new System.Windows.Forms.Button();
            this.richTextBox_In = new System.Windows.Forms.RichTextBox();
            this.button_Exec = new System.Windows.Forms.Button();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.textBox_ResCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Admin = new System.Windows.Forms.Button();
            this.checkBox_FreeCard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox_ResList
            // 
            this.listBox_ResList.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_ResList.FormattingEnabled = true;
            this.listBox_ResList.Items.AddRange(new object[] {
            "6 - Wood",
            "7 - Stone",
            "8 - Iron",
            "9 - Pitch",
            "12 - Ale",
            "13 - Apples",
            "14 - Bread",
            "15 - Veg",
            "16 - Meat",
            "17 - Cheese",
            "18 - Fish",
            "19 - Clothes",
            "21 - Furniture",
            "22 - Venison",
            "23 - Salt",
            "24 - Spices",
            "25 - Salt",
            "26 - Metalware",
            "28 - Pikes",
            "29 - Bows",
            "30 - Swords",
            "31 - Armour",
            "32 - Catapults",
            "33 - Wine"});
            this.listBox_ResList.Location = new System.Drawing.Point(0, 0);
            this.listBox_ResList.Name = "listBox_ResList";
            this.listBox_ResList.Size = new System.Drawing.Size(86, 381);
            this.listBox_ResList.TabIndex = 0;
            this.listBox_ResList.SelectedIndexChanged += new System.EventHandler(this.listBox_ResList_SelectedIndexChanged);
            // 
            // textBox_TradeTargetID
            // 
            this.textBox_TradeTargetID.Location = new System.Drawing.Point(140, 6);
            this.textBox_TradeTargetID.Name = "textBox_TradeTargetID";
            this.textBox_TradeTargetID.Size = new System.Drawing.Size(58, 20);
            this.textBox_TradeTargetID.TabIndex = 1;
            this.textBox_TradeTargetID.Text = "52792";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID цели:";
            // 
            // button_Trade
            // 
            this.button_Trade.Location = new System.Drawing.Point(383, 4);
            this.button_Trade.Name = "button_Trade";
            this.button_Trade.Size = new System.Drawing.Size(75, 23);
            this.button_Trade.TabIndex = 3;
            this.button_Trade.Text = "Торговать";
            this.button_Trade.UseVisualStyleBackColor = true;
            this.button_Trade.Click += new System.EventHandler(this.button_Trade_Click);
            // 
            // button_MapEditing
            // 
            this.button_MapEditing.Location = new System.Drawing.Point(363, 86);
            this.button_MapEditing.Name = "button_MapEditing";
            this.button_MapEditing.Size = new System.Drawing.Size(75, 23);
            this.button_MapEditing.TabIndex = 4;
            this.button_MapEditing.Text = "MapEditing";
            this.button_MapEditing.UseVisualStyleBackColor = true;
            this.button_MapEditing.Click += new System.EventHandler(this.button_MapEditing_Click);
            // 
            // richTextBox_In
            // 
            this.richTextBox_In.Location = new System.Drawing.Point(92, 115);
            this.richTextBox_In.Name = "richTextBox_In";
            this.richTextBox_In.Size = new System.Drawing.Size(346, 100);
            this.richTextBox_In.TabIndex = 5;
            this.richTextBox_In.Text = "";
            // 
            // button_Exec
            // 
            this.button_Exec.Location = new System.Drawing.Point(92, 277);
            this.button_Exec.Name = "button_Exec";
            this.button_Exec.Size = new System.Drawing.Size(346, 26);
            this.button_Exec.TabIndex = 6;
            this.button_Exec.Text = "Выполнить код";
            this.button_Exec.UseVisualStyleBackColor = true;
            this.button_Exec.Click += new System.EventHandler(this.button_Exec_Click);
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Location = new System.Drawing.Point(92, 221);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.ReadOnly = true;
            this.richTextBox_Out.Size = new System.Drawing.Size(346, 50);
            this.richTextBox_Out.TabIndex = 7;
            this.richTextBox_Out.Text = "";
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(92, 308);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(346, 70);
            this.richTextBox_Log.TabIndex = 8;
            this.richTextBox_Log.Text = "";
            // 
            // textBox_ResCount
            // 
            this.textBox_ResCount.Location = new System.Drawing.Point(309, 6);
            this.textBox_ResCount.Name = "textBox_ResCount";
            this.textBox_ResCount.Size = new System.Drawing.Size(68, 20);
            this.textBox_ResCount.TabIndex = 9;
            this.textBox_ResCount.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол-во на трейдера:";
            // 
            // button_Admin
            // 
            this.button_Admin.Location = new System.Drawing.Point(282, 86);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(75, 23);
            this.button_Admin.TabIndex = 11;
            this.button_Admin.Text = "Admin";
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // checkBox_FreeCard
            // 
            this.checkBox_FreeCard.AutoSize = true;
            this.checkBox_FreeCard.Checked = true;
            this.checkBox_FreeCard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FreeCard.Location = new System.Drawing.Point(92, 90);
            this.checkBox_FreeCard.Name = "checkBox_FreeCard";
            this.checkBox_FreeCard.Size = new System.Drawing.Size(123, 17);
            this.checkBox_FreeCard.TabIndex = 12;
            this.checkBox_FreeCard.Text = "AutoLoot Free Cards";
            this.checkBox_FreeCard.UseVisualStyleBackColor = true;
            this.checkBox_FreeCard.CheckedChanged += new System.EventHandler(this.checkBox_FreeCard_CheckedChanged);
            // 
            // BotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.checkBox_FreeCard);
            this.Controls.Add(this.button_Admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ResCount);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.richTextBox_Out);
            this.Controls.Add(this.button_Exec);
            this.Controls.Add(this.richTextBox_In);
            this.Controls.Add(this.button_MapEditing);
            this.Controls.Add(this.button_Trade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TradeTargetID);
            this.Controls.Add(this.listBox_ResList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BotForm";
            this.Text = "Bot Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BotForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ResList;
        private System.Windows.Forms.TextBox textBox_TradeTargetID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Trade;
        private System.Windows.Forms.Button button_MapEditing;
        private System.Windows.Forms.RichTextBox richTextBox_In;
        private System.Windows.Forms.Button button_Exec;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.TextBox textBox_ResCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.CheckBox checkBox_FreeCard;
    }
}