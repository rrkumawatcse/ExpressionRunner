namespace ExpressionRunner
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
            txtExpression = new TextBox();
            txtPostFix = new TextBox();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // txtExpression
            // 
            txtExpression.BorderStyle = BorderStyle.FixedSingle;
            txtExpression.Location = new Point(82, 85);
            txtExpression.Margin = new Padding(4);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(449, 34);
            txtExpression.TabIndex = 0;
            // 
            // txtPostFix
            // 
            txtPostFix.BorderStyle = BorderStyle.FixedSingle;
            txtPostFix.Location = new Point(82, 136);
            txtPostFix.Margin = new Padding(4);
            txtPostFix.Name = "txtPostFix";
            txtPostFix.Size = new Size(449, 34);
            txtPostFix.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Location = new Point(226, 186);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(165, 52);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 398);
            Controls.Add(btnCheck);
            Controls.Add(txtPostFix);
            Controls.Add(txtExpression);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpression;
        private TextBox txtPostFix;
        private Button btnCheck;
    }
}