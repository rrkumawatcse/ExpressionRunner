using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressionRunner
{
    public partial class ExpressionRunner : Form
    {
        Dictionary<string, double> dtv;
        public ExpressionRunner()
        {
            InitializeComponent();
        }

        private void ExpressionRunner_Load(object sender, EventArgs e)
        {
            SettingUI();
            dtv = new Dictionary<string, double>();
        }

        private void SettingUI()
        {
            dtVariable.Columns.Add("VariableName", "Variable Name");
            dtVariable.Columns.Add("Value", "Value");

            dtExpression.Columns.Add("Expression", "Expression");
            dtExpression.Columns.Add("Postfix", "Postfix");
            dtExpression.Columns.Add("Result", "Result");

            dtExpression.Columns[1].Visible = false;
            dtExpression.RowHeadersVisible = false;
            dtVariable.RowHeadersVisible = false;

            dtExpression.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            string[] v = txtVariable.Text.Split('=');
            dtVariable.Rows.Add(v[0], v[1]);
            dtv.Add(v[0], double.Parse(v[1]));
            txtVariable.Clear();
        }

        private void btnExpression_Click(object sender, EventArgs e)
        {
            dtExpression.Rows.Add(txtExpression.Text, "-", "-");
            txtExpression.Clear();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                string ex, postfix;
                foreach (DataGridViewRow w in dtExpression.Rows)
                {
                    ex = w.Cells[0].Value.ToString();
                    postfix = new Runner().InfixToPostFix(ex);
                    w.Cells[1].Value = postfix;
                    w.Cells[2].Value = new Runner().Generator(postfix, dtv).ToString();
                    w.Cells[2].Style.BackColor = Color.FromArgb(16, 124, 65);
                    w.Cells[2].Style.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                lblLog.Text = ex.Message;
            }
        }
    }

    public class Runner
    {
        public string InfixToPostFix(string expr)
        {
            char[] infix = (expr + "&").ToCharArray();
            char[] postfix = new char[infix.Length];
            char ch;
            int i = 0, j = 0;
            Stack<char> st = new Stack<char>();
            st.Push('#');

            while ((ch = infix[i++]) != '&')
            {
                if (ch == '(')
                    st.Push(ch);
                else if (char.IsLetter(ch))
                {
                    postfix[j++] = ch;
                }
                else if (ch == ')')
                {
                    while (st.Peek() != '(')
                    {
                        postfix[j++] = st.Pop();
                    }
                }
                else
                {
                    while (privority(st.Peek()) >= privority(ch))
                    {
                        postfix[j++] = st.Pop();
                    }
                    st.Push(ch);
                }
            }
            while (st.Peek() != '#')
            {
                postfix[j++] = st.Pop();
            }
            postfix[j] = '#';
            return new string(postfix);
        }

        private static int privority(char ch)
        {
            switch (ch)
            {
                case '#': return 0;
                case '(': return 1;
                case '+':
                case '-': return 2;
                case '*':
                case '/': return 3;
            }
            return 0;
        }

        private static double GetVariableValue(string ch, Dictionary<string, double> dtv)
        {
            foreach (KeyValuePair<string, double> w in dtv)
            {
                if (ch == w.Key) return w.Value;
            }
            return 0;
        }

        public double Generator(string expression, Dictionary<string, double> dtv)
        {
            char[] postexpr = expression.ToCharArray();
            char ch;
            int i = 0, j = 0;
            Stack<double> st = new Stack<double>();

            while ((ch = postexpr[i++]) != '#')
            {
                if (char.IsLetter(ch))
                    st.Push(GetVariableValue(ch.ToString(), dtv));//return variable value from table
                else if (ch == '(')
                {
                    continue;
                }
                else
                {
                    double v1 = st.Pop();
                    double v2 = st.Pop();

                    switch (ch)
                    {
                        case '+': st.Push(v2 + v1); break;
                        case '-': st.Push(v2 - v1); break;
                        case '*': st.Push(v2 * v1); break;
                        case '/': st.Push(v2 / v1); break;
                    }
                }
            }
            return st.Pop();
        }
    }
}
