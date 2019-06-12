namespace MessageView
{
    partial class MessageScreenView
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
            this.tb_Parent = new System.Windows.Forms.TableLayoutPanel();
            this.img_Icon = new System.Windows.Forms.PictureBox();
            this.tb_Text = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.img_2 = new System.Windows.Forms.PictureBox();
            this.tb_Button = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.mtxt_Input = new System.Windows.Forms.MaskedTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tb_Parent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Icon)).BeginInit();
            this.tb_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).BeginInit();
            this.tb_Button.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Parent
            // 
            this.tb_Parent.ColumnCount = 2;
            this.tb_Parent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tb_Parent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_Parent.Controls.Add(this.img_Icon, 0, 0);
            this.tb_Parent.Controls.Add(this.tb_Text, 1, 0);
            this.tb_Parent.Controls.Add(this.img_2, 0, 1);
            this.tb_Parent.Controls.Add(this.tb_Button, 2, 1);
            this.tb_Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Parent.Location = new System.Drawing.Point(0, 0);
            this.tb_Parent.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Parent.Name = "tb_Parent";
            this.tb_Parent.RowCount = 2;
            this.tb_Parent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tb_Parent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_Parent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_Parent.Size = new System.Drawing.Size(576, 141);
            this.tb_Parent.TabIndex = 0;
            // 
            // img_Icon
            // 
            this.img_Icon.BackColor = System.Drawing.Color.Gainsboro;
            this.img_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_Icon.Image = global::MessageView.Properties.Resources.Confirmation_125px;
            this.img_Icon.Location = new System.Drawing.Point(0, 0);
            this.img_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.img_Icon.Name = "img_Icon";
            this.img_Icon.Size = new System.Drawing.Size(100, 100);
            this.img_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Icon.TabIndex = 1;
            this.img_Icon.TabStop = false;
            // 
            // tb_Text
            // 
            this.tb_Text.ColumnCount = 1;
            this.tb_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_Text.Controls.Add(this.lbl_Title, 0, 0);
            this.tb_Text.Controls.Add(this.lbl_Description, 0, 1);
            this.tb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Text.Location = new System.Drawing.Point(103, 3);
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tb_Text.RowCount = 2;
            this.tb_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tb_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tb_Text.Size = new System.Drawing.Size(470, 94);
            this.tb_Text.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(13, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(454, 51);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_Description.Location = new System.Drawing.Point(13, 51);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(454, 43);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Lorem ipsum dolor sit amet consectetur adipiscing elit.";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_2
            // 
            this.img_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_2.Location = new System.Drawing.Point(0, 100);
            this.img_2.Margin = new System.Windows.Forms.Padding(0);
            this.img_2.Name = "img_2";
            this.img_2.Size = new System.Drawing.Size(100, 41);
            this.img_2.TabIndex = 3;
            this.img_2.TabStop = false;
            // 
            // tb_Button
            // 
            this.tb_Button.ColumnCount = 3;
            this.tb_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tb_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Button.Controls.Add(this.btn_Cancel, 1, 0);
            this.tb_Button.Controls.Add(this.btn_Ok, 2, 0);
            this.tb_Button.Controls.Add(this.mtxt_Input, 0, 0);
            this.tb_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Button.Location = new System.Drawing.Point(100, 100);
            this.tb_Button.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Button.Name = "tb_Button";
            this.tb_Button.RowCount = 1;
            this.tb_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_Button.Size = new System.Drawing.Size(476, 41);
            this.tb_Button.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(300, 0);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 41);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(388, 0);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(88, 41);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "Aceptar";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // mtxt_Input
            // 
            this.mtxt_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxt_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxt_Input.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_Input.Location = new System.Drawing.Point(20, 4);
            this.mtxt_Input.Margin = new System.Windows.Forms.Padding(20, 4, 3, 3);
            this.mtxt_Input.Mask = "00.00";
            this.mtxt_Input.Name = "mtxt_Input";
            this.mtxt_Input.Size = new System.Drawing.Size(277, 32);
            this.mtxt_Input.SkipLiterals = false;
            this.mtxt_Input.TabIndex = 2;
            this.mtxt_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxt_Input.ValidatingType = typeof(int);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.tb_Parent);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(576, 141);
            this.panel.TabIndex = 1;
            // 
            // MessageScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 141);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageScreenView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tb_Parent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Icon)).EndInit();
            this.tb_Text.ResumeLayout(false);
            this.tb_Text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).EndInit();
            this.tb_Button.ResumeLayout(false);
            this.tb_Button.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tb_Parent;
        private System.Windows.Forms.PictureBox img_Icon;
        private System.Windows.Forms.TableLayoutPanel tb_Text;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox img_2;
        private System.Windows.Forms.TableLayoutPanel tb_Button;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.MaskedTextBox mtxt_Input;
    }
}

