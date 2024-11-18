namespace FlyeightPattern
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
            pictureBoxImg = new PictureBox();
            buttonSetPic = new Button();
            buttonCreate = new Button();
            comboBoxType = new ComboBox();
            textBoxName = new TextBox();
            textBoxExp = new TextBox();
            textBoxLvl = new TextBox();
            labelLvl = new Label();
            labelExp = new Label();
            labelReturn = new Label();
            buttonAddAtr = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImg
            // 
            pictureBoxImg.Location = new Point(12, 12);
            pictureBoxImg.Name = "pictureBoxImg";
            pictureBoxImg.Size = new Size(248, 301);
            pictureBoxImg.TabIndex = 0;
            pictureBoxImg.TabStop = false;
            // 
            // buttonSetPic
            // 
            buttonSetPic.Location = new Point(297, 70);
            buttonSetPic.Name = "buttonSetPic";
            buttonSetPic.Size = new Size(121, 47);
            buttonSetPic.TabIndex = 1;
            buttonSetPic.Text = "Выбрать изображение";
            buttonSetPic.UseVisualStyleBackColor = true;
            buttonSetPic.Click += buttonSetPic_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(297, 123);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(125, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(297, 12);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(297, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxExp
            // 
            textBoxExp.Location = new Point(297, 196);
            textBoxExp.Name = "textBoxExp";
            textBoxExp.Size = new Size(121, 23);
            textBoxExp.TabIndex = 5;
            // 
            // textBoxLvl
            // 
            textBoxLvl.Location = new Point(297, 240);
            textBoxLvl.Name = "textBoxLvl";
            textBoxLvl.Size = new Size(121, 23);
            textBoxLvl.TabIndex = 5;
            // 
            // labelLvl
            // 
            labelLvl.AutoSize = true;
            labelLvl.Location = new Point(297, 178);
            labelLvl.Name = "labelLvl";
            labelLvl.Size = new Size(56, 15);
            labelLvl.TabIndex = 6;
            labelLvl.Text = "Уровень:";
            // 
            // labelExp
            // 
            labelExp.AutoSize = true;
            labelExp.Location = new Point(297, 222);
            labelExp.Name = "labelExp";
            labelExp.Size = new Size(40, 15);
            labelExp.TabIndex = 6;
            labelExp.Text = "Опыт:";
            // 
            // labelReturn
            // 
            labelReturn.AutoSize = true;
            labelReturn.Location = new Point(12, 351);
            labelReturn.Name = "labelReturn";
            labelReturn.Size = new Size(0, 15);
            labelReturn.TabIndex = 7;
            // 
            // buttonAddAtr
            // 
            buttonAddAtr.Location = new Point(297, 269);
            buttonAddAtr.Name = "buttonAddAtr";
            buttonAddAtr.Size = new Size(121, 44);
            buttonAddAtr.TabIndex = 8;
            buttonAddAtr.Text = "Добавить атрибуты";
            buttonAddAtr.UseVisualStyleBackColor = true;
            buttonAddAtr.Click += buttonAddAtr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 365);
            Controls.Add(buttonAddAtr);
            Controls.Add(labelReturn);
            Controls.Add(labelExp);
            Controls.Add(labelLvl);
            Controls.Add(textBoxLvl);
            Controls.Add(textBoxExp);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxType);
            Controls.Add(buttonCreate);
            Controls.Add(buttonSetPic);
            Controls.Add(pictureBoxImg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImg;
        private Button buttonSetPic;
        private Button buttonCreate;
        private ComboBox comboBoxType;
        private TextBox textBoxName;
        private TextBox textBoxExp;
        private TextBox textBoxLvl;
        private Label labelLvl;
        private Label labelExp;
        private Label labelReturn;
        private Button buttonAddAtr;
    }
}
