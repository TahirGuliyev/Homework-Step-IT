
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFavouriteCar = new System.Windows.Forms.TextBox();
            this.textBoxFavouriteFilm = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelFavouriteCar = new System.Windows.Forms.Label();
            this.labelFavouriteFilm = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRegistrationMenu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textBoxFavouriteCar);
            this.panel1.Controls.Add(this.textBoxFavouriteFilm);
            this.panel1.Controls.Add(this.textBoxGender);
            this.panel1.Controls.Add(this.textBoxAge);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.labelFavouriteCar);
            this.panel1.Controls.Add(this.labelFavouriteFilm);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.labelLastname);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelRegistrationMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.buttonSave.Location = new System.Drawing.Point(215, 324);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(103, 36);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFavouriteCar
            // 
            this.textBoxFavouriteCar.Location = new System.Drawing.Point(171, 259);
            this.textBoxFavouriteCar.Name = "textBoxFavouriteCar";
            this.textBoxFavouriteCar.Size = new System.Drawing.Size(147, 20);
            this.textBoxFavouriteCar.TabIndex = 13;
            // 
            // textBoxFavouriteFilm
            // 
            this.textBoxFavouriteFilm.Location = new System.Drawing.Point(171, 217);
            this.textBoxFavouriteFilm.Name = "textBoxFavouriteFilm";
            this.textBoxFavouriteFilm.Size = new System.Drawing.Size(147, 20);
            this.textBoxFavouriteFilm.TabIndex = 12;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(171, 173);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(147, 20);
            this.textBoxGender.TabIndex = 11;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(171, 129);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(147, 20);
            this.textBoxAge.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(171, 89);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(147, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(171, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(147, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Aqua;
            this.buttonCheck.Location = new System.Drawing.Point(27, 324);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(103, 36);
            this.buttonCheck.TabIndex = 7;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelFavouriteCar
            // 
            this.labelFavouriteCar.AutoSize = true;
            this.labelFavouriteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFavouriteCar.Location = new System.Drawing.Point(22, 259);
            this.labelFavouriteCar.Name = "labelFavouriteCar";
            this.labelFavouriteCar.Size = new System.Drawing.Size(108, 20);
            this.labelFavouriteCar.TabIndex = 6;
            this.labelFavouriteCar.Text = "Favourite Car:";
            // 
            // labelFavouriteFilm
            // 
            this.labelFavouriteFilm.AutoSize = true;
            this.labelFavouriteFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFavouriteFilm.Location = new System.Drawing.Point(23, 215);
            this.labelFavouriteFilm.Name = "labelFavouriteFilm";
            this.labelFavouriteFilm.Size = new System.Drawing.Size(112, 20);
            this.labelFavouriteFilm.TabIndex = 5;
            this.labelFavouriteFilm.Text = "Favourite Film:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGender.Location = new System.Drawing.Point(23, 173);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 20);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAge.Location = new System.Drawing.Point(23, 129);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 20);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLastname.Location = new System.Drawing.Point(23, 87);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(84, 20);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Lastname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.Location = new System.Drawing.Point(23, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelRegistrationMenu
            // 
            this.labelRegistrationMenu.AutoSize = true;
            this.labelRegistrationMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRegistrationMenu.ForeColor = System.Drawing.Color.Green;
            this.labelRegistrationMenu.Location = new System.Drawing.Point(21, 9);
            this.labelRegistrationMenu.Name = "labelRegistrationMenu";
            this.labelRegistrationMenu.Size = new System.Drawing.Size(169, 25);
            this.labelRegistrationMenu.TabIndex = 0;
            this.labelRegistrationMenu.Text = "Registration Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Registration Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRegistrationMenu;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFavouriteCar;
        private System.Windows.Forms.TextBox textBoxFavouriteFilm;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelFavouriteCar;
        private System.Windows.Forms.Label labelFavouriteFilm;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelName;
    }
}

