namespace Lab4_GUIShapes
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.rectangle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(13, 13);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(75, 23);
            this.rectangle.TabIndex = 0;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(13, 42);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 23);
            this.square.TabIndex = 1;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(13, 71);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(73, 23);
            this.circle.TabIndex = 2;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // triangle
            // 
            this.triangle.Location = new System.Drawing.Point(13, 100);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(73, 23);
            this.triangle.TabIndex = 3;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.square);
            this.Controls.Add(this.rectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button triangle;
    }
}

