namespace Calculette
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.equalbtn = new System.Windows.Forms.Button();
            this.plusbtn = new System.Windows.Forms.Button();
            this.minbtn = new System.Windows.Forms.Button();
            this.multbtn = new System.Windows.Forms.Button();
            this.porcbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.dotbtn = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.CEbtn = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(3, 41);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(334, 29);
            this.textBox_result.TabIndex = 0;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.9521F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7485F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.equalbtn, 3, 4);
            this.ButtonsPanel.Controls.Add(this.dotbtn, 2, 4);
            this.ButtonsPanel.Controls.Add(this.btn0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.plusbtn, 3, 3);
            this.ButtonsPanel.Controls.Add(this.btn3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.btn2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.btn1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.minbtn, 3, 2);
            this.ButtonsPanel.Controls.Add(this.btn6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.btn5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.btn4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.multbtn, 3, 1);
            this.ButtonsPanel.Controls.Add(this.btn9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.btn8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.btn7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.porcbtn, 3, 0);
            this.ButtonsPanel.Controls.Add(this.delbtn, 2, 0);
            this.ButtonsPanel.Controls.Add(this.Cbtn, 1, 0);
            this.ButtonsPanel.Controls.Add(this.CEbtn, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 76);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(334, 349);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // equalbtn
            // 
            this.equalbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalbtn.Location = new System.Drawing.Point(252, 279);
            this.equalbtn.Name = "equalbtn";
            this.equalbtn.Size = new System.Drawing.Size(79, 67);
            this.equalbtn.TabIndex = 20;
            this.equalbtn.Text = "=";
            this.equalbtn.UseVisualStyleBackColor = true;
            this.equalbtn.Click += new System.EventHandler(this.equalbtn_Click);
            // 
            // plusbtn
            // 
            this.plusbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbtn.Location = new System.Drawing.Point(252, 210);
            this.plusbtn.Name = "plusbtn";
            this.plusbtn.Size = new System.Drawing.Size(79, 63);
            this.plusbtn.TabIndex = 16;
            this.plusbtn.Text = "+";
            this.plusbtn.UseVisualStyleBackColor = true;
            this.plusbtn.Click += new System.EventHandler(this.operationClick);
            // 
            // minbtn
            // 
            this.minbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbtn.Location = new System.Drawing.Point(252, 141);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(79, 63);
            this.minbtn.TabIndex = 12;
            this.minbtn.Text = "-";
            this.minbtn.UseVisualStyleBackColor = true;
            this.minbtn.Click += new System.EventHandler(this.operationClick);
            // 
            // multbtn
            // 
            this.multbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multbtn.Location = new System.Drawing.Point(252, 72);
            this.multbtn.Name = "multbtn";
            this.multbtn.Size = new System.Drawing.Size(79, 63);
            this.multbtn.TabIndex = 8;
            this.multbtn.Text = "X";
            this.multbtn.UseVisualStyleBackColor = true;
            this.multbtn.Click += new System.EventHandler(this.operationClick);
            // 
            // porcbtn
            // 
            this.porcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.porcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcbtn.Location = new System.Drawing.Point(252, 3);
            this.porcbtn.Name = "porcbtn";
            this.porcbtn.Size = new System.Drawing.Size(79, 63);
            this.porcbtn.TabIndex = 4;
            this.porcbtn.Text = "%";
            this.porcbtn.UseVisualStyleBackColor = true;
            this.porcbtn.Click += new System.EventHandler(this.operationClick);
            // 
            // delbtn
            // 
            this.delbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(169, 3);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(77, 63);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "DEL";
            this.delbtn.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(169, 72);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 63);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(169, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 63);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(169, 210);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 63);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // dotbtn
            // 
            this.dotbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotbtn.Location = new System.Drawing.Point(169, 279);
            this.dotbtn.Name = "dotbtn";
            this.dotbtn.Size = new System.Drawing.Size(77, 67);
            this.dotbtn.TabIndex = 19;
            this.dotbtn.Text = ".";
            this.dotbtn.UseVisualStyleBackColor = true;
            this.dotbtn.Click += new System.EventHandler(this.btn_click);
            // 
            // Cbtn
            // 
            this.Cbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbtn.Location = new System.Drawing.Point(83, 3);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(80, 63);
            this.Cbtn.TabIndex = 2;
            this.Cbtn.Text = "C";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(83, 72);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 63);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(83, 141);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 63);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(83, 210);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 63);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(83, 279);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 67);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_click);
            // 
            // CEbtn
            // 
            this.CEbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEbtn.Location = new System.Drawing.Point(3, 3);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(74, 63);
            this.CEbtn.TabIndex = 0;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = true;
            this.CEbtn.Click += new System.EventHandler(this.CEbtn_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 72);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 63);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 141);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 63);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 210);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 63);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_click);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoEllipsis = true;
            this.labelOperation.AutoSize = true;
            this.labelOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.Location = new System.Drawing.Point(2, 18);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 20);
            this.labelOperation.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 427);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button equalbtn;
        private System.Windows.Forms.Button plusbtn;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button multbtn;
        private System.Windows.Forms.Button porcbtn;
        private System.Windows.Forms.Button dotbtn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Label labelOperation;
    }
}

