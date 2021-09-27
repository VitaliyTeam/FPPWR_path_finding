
namespace FPPWR_path_finding
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnCreateNewMap = new System.Windows.Forms.Button();
            this.btnDrawNet = new System.Windows.Forms.Button();
            this.btnCalculateRoute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(751, 637);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnCreateNewMap
            // 
            this.btnCreateNewMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateNewMap.Location = new System.Drawing.Point(783, 54);
            this.btnCreateNewMap.Name = "btnCreateNewMap";
            this.btnCreateNewMap.Size = new System.Drawing.Size(206, 62);
            this.btnCreateNewMap.TabIndex = 1;
            this.btnCreateNewMap.Text = "Create new map";
            this.btnCreateNewMap.UseVisualStyleBackColor = true;
            this.btnCreateNewMap.Click += new System.EventHandler(this.btnCreateNewMap_Click);
            // 
            // btnDrawNet
            // 
            this.btnDrawNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrawNet.Location = new System.Drawing.Point(783, 135);
            this.btnDrawNet.Name = "btnDrawNet";
            this.btnDrawNet.Size = new System.Drawing.Size(206, 62);
            this.btnDrawNet.TabIndex = 2;
            this.btnDrawNet.Text = "Draw net";
            this.btnDrawNet.UseVisualStyleBackColor = true;
            this.btnDrawNet.Click += new System.EventHandler(this.btnDrawNet_Click);
            // 
            // btnCalculateRoute
            // 
            this.btnCalculateRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculateRoute.Location = new System.Drawing.Point(783, 218);
            this.btnCalculateRoute.Name = "btnCalculateRoute";
            this.btnCalculateRoute.Size = new System.Drawing.Size(206, 62);
            this.btnCalculateRoute.TabIndex = 3;
            this.btnCalculateRoute.Text = "Calculate route";
            this.btnCalculateRoute.UseVisualStyleBackColor = true;
            this.btnCalculateRoute.Click += new System.EventHandler(this.btnCalculateRoute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 661);
            this.Controls.Add(this.btnCalculateRoute);
            this.Controls.Add(this.btnDrawNet);
            this.Controls.Add(this.btnCreateNewMap);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnCreateNewMap;
        private System.Windows.Forms.Button btnDrawNet;
        private System.Windows.Forms.Button btnCalculateRoute;
    }
}

