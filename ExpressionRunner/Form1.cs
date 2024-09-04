namespace ExpressionRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public static string InfixPostFix(string expr)
        {
            char[] infix = expr.ToCharArray();
           
            char[] postfix = new char[50];
            Stack<char> st = new Stack<char>();
            int i = 0, j = 0;
            char ch;
            st.Push('#');
            while ((ch = infix[i++]) != '&')
            {
                if (ch == '(')
                    st.Push(ch);
                else if ((char.IsLetter(ch)))
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
                    while (pr(st.Peek()) >= pr(ch))
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
            //postfix[j] = '#';

            return new string(postfix);

        }

        public static int pr(char ch)
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtPostFix.Text = InfixPostFix(txtExpression.Text + "&");
        }
    }
}