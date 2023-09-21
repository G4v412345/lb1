namespace WinFormsApp1
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
            pnName = new Panel();
            pnTools = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnShow = new Button();
            btnHide = new Button();
            btnCreateNew = new Button();
            cbEmblem = new ComboBox();
            label1 = new Label();
            pnTools.SuspendLayout();
            SuspendLayout();
            // 
            // pnName
            // 
            pnName.BackColor = Color.White;
            pnName.BorderStyle = BorderStyle.FixedSingle;
            pnName.Dock = DockStyle.Fill;
            pnName.Location = new Point(0, 0);
            pnName.Name = "pnName";
            pnName.Size = new Size(1154, 450);
            pnName.TabIndex = 0;
            pnName.Paint += pnName_Paint;
            // 
            // pnTools
            // 
            pnTools.Controls.Add(button10);
            pnTools.Controls.Add(button9);
            pnTools.Controls.Add(button8);
            pnTools.Controls.Add(button7);
            pnTools.Controls.Add(button6);
            pnTools.Controls.Add(button5);
            pnTools.Controls.Add(button4);
            pnTools.Controls.Add(button3);
            pnTools.Controls.Add(button2);
            pnTools.Controls.Add(button1);
            pnTools.Controls.Add(btnShow);
            pnTools.Controls.Add(btnHide);
            pnTools.Controls.Add(btnCreateNew);
            pnTools.Controls.Add(cbEmblem);
            pnTools.Controls.Add(label1);
            pnTools.Dock = DockStyle.Right;
            pnTools.Location = new Point(890, 0);
            pnTools.Name = "pnTools";
            pnTools.Size = new Size(264, 450);
            pnTools.TabIndex = 1;
            pnTools.Paint += pnTools_Paint;
            // 
            // button10
            // 
            button10.Location = new Point(90, 309);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 14;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(90, 280);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 13;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(90, 338);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 12;
            button8.Text = "↓";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(90, 367);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "↓↓";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 300);
            button6.Name = "button6";
            button6.Size = new Size(39, 23);
            button6.TabIndex = 10;
            button6.Text = "←←";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(89, 251);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "↑";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 300);
            button4.Name = "button4";
            button4.Size = new Size(31, 23);
            button4.TabIndex = 8;
            button4.Text = "\t→";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(208, 300);
            button3.Name = "button3";
            button3.Size = new Size(36, 23);
            button3.TabIndex = 7;
            button3.Text = "→→";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 300);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 6;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(89, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "↑↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(3, 184);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(258, 23);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показати об'єкт";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(3, 155);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(258, 23);
            btnHide.TabIndex = 3;
            btnHide.Text = "Приховати об'єкт";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(3, 126);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(258, 23);
            btnCreateNew.TabIndex = 2;
            btnCreateNew.Text = "Створити новий об’єкт";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // cbEmblem
            // 
            cbEmblem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmblem.FormattingEnabled = true;
            cbEmblem.Location = new Point(3, 32);
            cbEmblem.Name = "cbEmblem";
            cbEmblem.Size = new Size(258, 23);
            cbEmblem.TabIndex = 1;
            cbEmblem.SelectedIndexChanged += cbEmblem_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Перелік об’єктів";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 450);
            Controls.Add(pnTools);
            Controls.Add(pnName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №1_Циганок";
            Load += Form1_Load;
            pnTools.ResumeLayout(false);
            pnTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnName;
        private Panel pnTools;
        private Button btnShow;
        private Button btnHide;
        private Button btnCreateNew;
        private ComboBox cbEmblem;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
    }
}