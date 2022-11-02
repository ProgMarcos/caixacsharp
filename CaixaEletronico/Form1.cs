namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor, resto, n100, n50, n20, n10, n5, n2;
            bool verifica;

            verifica = int.TryParse(textBox1.Text, out valor);
            if (!verifica)
            {
                MessageBox.Show("Formato inválido, por favor, digite o valor númerico.");
                return;
            }

            n100 = valor / 100; //contagem das notas de 100R$

            resto = valor - (n100 * 100); //valor menos as notas de 100.

            n50 = resto / 50;//contagem das notas de 50R$

            resto = resto - (n50 * 50);

            n20 = resto / 20;//contagem das notas de 20R$

            resto = resto - (n20 * 20);

            n10 = resto / 10;//contagem das notas de 10R$

            resto = resto - (n10 * 10);
            
            if(resto == 5 || resto == 7 || resto == 9)
            {

            n5 = resto / 5;//contagem das notas de 5R$

            resto = resto - (n5 * 5);

            n2 = resto / 2;//contagem das notas de 2R$

            resto = resto - (n2 * 2);
            } else
            {
                n5 = 0;
                n2 = resto / 2;

                resto = resto - (n2 * 2);
            }


            lbl100.Text = string.Format("Notas de 100: {0}",n100);
            lbl50.Text = string.Format("Notas de 50: {0}", n50);
            lbl20.Text = string.Format("Notas de 20: {0}", n20);
            lbl10.Text = string.Format("Notas de 10: {0}", n10);
            lbl5.Text = string.Format("Notas de 5: {0}", n5);
            lbl2.Text = string.Format("Notas de 2: {0}", n2);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}