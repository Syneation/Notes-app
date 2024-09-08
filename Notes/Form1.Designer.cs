namespace Notes
{
    partial class Notes
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.DataGridView();
            this.Loadb = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(420, 38);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(402, 20);
            this.titleBox.TabIndex = 0;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(420, 89);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(410, 436);
            this.noteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "title:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(417, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            // 
            // previous
            // 
            this.previous.BackgroundColor = System.Drawing.Color.White;
            this.previous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previous.GridColor = System.Drawing.Color.White;
            this.previous.Location = new System.Drawing.Point(12, 12);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(402, 422);
            this.previous.TabIndex = 4;
            this.previous.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previes_CellDoubleClick);
            // 
            // Loadb
            // 
            this.Loadb.Location = new System.Drawing.Point(12, 440);
            this.Loadb.Name = "Loadb";
            this.Loadb.Size = new System.Drawing.Size(201, 42);
            this.Loadb.TabIndex = 5;
            this.Loadb.Text = "Load";
            this.Loadb.UseVisualStyleBackColor = true;
            this.Loadb.Click += new System.EventHandler(this.Load_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(219, 440);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(195, 42);
            this.delete.TabIndex = 6;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(219, 488);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(195, 37);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(12, 488);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(201, 37);
            this.New.TabIndex = 8;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 537);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Loadb);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView previous;
        private System.Windows.Forms.Button Loadb;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button New;
    }
}

