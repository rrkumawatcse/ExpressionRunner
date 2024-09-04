namespace ExpressionRunner
{
    partial class ExpressionRunner
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
            dtVariable = new DataGridView();
            txtVariable = new TextBox();
            btnAddVariable = new Button();
            btnExpression = new Button();
            txtExpression = new TextBox();
            dtExpression = new DataGridView();
            btnRun = new Button();
            lblLog = new Label();
            ((System.ComponentModel.ISupportInitialize)dtVariable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtExpression).BeginInit();
            SuspendLayout();
            // 
            // dtVariable
            // 
            dtVariable.AllowUserToAddRows = false;
            dtVariable.AllowUserToDeleteRows = false;
            dtVariable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtVariable.BackgroundColor = Color.White;
            dtVariable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtVariable.Location = new Point(12, 108);
            dtVariable.Name = "dtVariable";
            dtVariable.ReadOnly = true;
            dtVariable.RowHeadersWidth = 51;
            dtVariable.RowTemplate.Height = 40;
            dtVariable.RowTemplate.ReadOnly = true;
            dtVariable.Size = new Size(399, 318);
            dtVariable.TabIndex = 0;
            // 
            // txtVariable
            // 
            txtVariable.BorderStyle = BorderStyle.FixedSingle;
            txtVariable.Location = new Point(12, 58);
            txtVariable.Name = "txtVariable";
            txtVariable.Size = new Size(263, 34);
            txtVariable.TabIndex = 1;
            // 
            // btnAddVariable
            // 
            btnAddVariable.Location = new Point(281, 58);
            btnAddVariable.Name = "btnAddVariable";
            btnAddVariable.Size = new Size(130, 44);
            btnAddVariable.TabIndex = 2;
            btnAddVariable.Text = "Add";
            btnAddVariable.UseVisualStyleBackColor = true;
            btnAddVariable.Click += btnAddVariable_Click;
            // 
            // btnExpression
            // 
            btnExpression.Location = new Point(1117, 58);
            btnExpression.Name = "btnExpression";
            btnExpression.Size = new Size(130, 44);
            btnExpression.TabIndex = 5;
            btnExpression.Text = "Add";
            btnExpression.UseVisualStyleBackColor = true;
            btnExpression.Click += btnExpression_Click;
            // 
            // txtExpression
            // 
            txtExpression.BorderStyle = BorderStyle.FixedSingle;
            txtExpression.Location = new Point(445, 58);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(666, 34);
            txtExpression.TabIndex = 4;
            // 
            // dtExpression
            // 
            dtExpression.AllowUserToAddRows = false;
            dtExpression.AllowUserToDeleteRows = false;
            dtExpression.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtExpression.BackgroundColor = Color.White;
            dtExpression.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtExpression.Location = new Point(445, 108);
            dtExpression.Name = "dtExpression";
            dtExpression.ReadOnly = true;
            dtExpression.RowHeadersWidth = 51;
            dtExpression.RowTemplate.Height = 40;
            dtExpression.RowTemplate.ReadOnly = true;
            dtExpression.Size = new Size(802, 318);
            dtExpression.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(1117, 432);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(130, 44);
            btnRun.TabIndex = 6;
            btnRun.Text = "RUN";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(12, 440);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(26, 28);
            lblLog.TabIndex = 7;
            lblLog.Text = "[]";
            // 
            // ExpressionRunner
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 486);
            Controls.Add(lblLog);
            Controls.Add(btnRun);
            Controls.Add(btnExpression);
            Controls.Add(txtExpression);
            Controls.Add(dtExpression);
            Controls.Add(btnAddVariable);
            Controls.Add(txtVariable);
            Controls.Add(dtVariable);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ExpressionRunner";
            Text = "ExpressionRunner";
            Load += ExpressionRunner_Load;
            ((System.ComponentModel.ISupportInitialize)dtVariable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtExpression).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtVariable;
        private TextBox txtVariable;
        private Button btnAddVariable;
        private Button btnExpression;
        private TextBox txtExpression;
        private DataGridView dtExpression;
        private Button btnRun;
        private Label lblLog;
    }
}