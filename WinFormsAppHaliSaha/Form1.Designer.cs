namespace WinFormsAppHaliSaha
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
            label1 = new Label();
            listBoxKatilanlar = new ListBox();
            buttonKatil = new Button();
            listBoxHediyeler = new ListBox();
            buttonGetir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 24F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(177, 25);
            label1.Name = "label1";
            label1.Size = new Size(437, 38);
            label1.TabIndex = 0;
            label1.Text = "BÜYÜK DEVELOPER ÇEKİLİŞİ";
            // 
            // listBoxKatilanlar
            // 
            listBoxKatilanlar.FormattingEnabled = true;
            listBoxKatilanlar.ItemHeight = 15;
            listBoxKatilanlar.Location = new Point(139, 116);
            listBoxKatilanlar.Name = "listBoxKatilanlar";
            listBoxKatilanlar.Size = new Size(120, 94);
            listBoxKatilanlar.TabIndex = 1;
            // 
            // buttonKatil
            // 
            buttonKatil.Location = new Point(304, 154);
            buttonKatil.Name = "buttonKatil";
            buttonKatil.Size = new Size(75, 23);
            buttonKatil.TabIndex = 2;
            buttonKatil.Text = "KATIL";
            buttonKatil.UseVisualStyleBackColor = true;
            buttonKatil.Click += buttonKatil_Click;
            // 
            // listBoxHediyeler
            // 
            listBoxHediyeler.FormattingEnabled = true;
            listBoxHediyeler.ItemHeight = 15;
            listBoxHediyeler.Location = new Point(448, 116);
            listBoxHediyeler.Name = "listBoxHediyeler";
            listBoxHediyeler.Size = new Size(120, 94);
            listBoxHediyeler.TabIndex = 3;
            // 
            // buttonGetir
            // 
            buttonGetir.Location = new Point(632, 162);
            buttonGetir.Name = "buttonGetir";
            buttonGetir.Size = new Size(84, 23);
            buttonGetir.TabIndex = 4;
            buttonGetir.Text = "GETİR";
            buttonGetir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGetir);
            Controls.Add(listBoxHediyeler);
            Controls.Add(buttonKatil);
            Controls.Add(listBoxKatilanlar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxKatilanlar;
        private Button buttonKatil;
        private ListBox listBoxHediyeler;
        private Button buttonGetir;
    }
}
