using System;
using System.Drawing;
using System.Windows.Forms;
using MVVM.ViewModel;
using MVVM.Model;
using System.Threading.Tasks;

namespace MVVM.View
{
    public class Form1 : Form
    {
        public Button button1;
        public TextBox textbx;
        public TextBox textbxId;
        public TextBox textbxName;
        public TextBox textbxPrice;
        public Label label;
        public Label labelId;
        public Label labelName;
        public Label labelPrice;
        public Label labelRes;

        public Form1() {

            System.Console.WriteLine("@Entrei na View");

            label = new Label();
            label.Size = new Size(40, 30);
            label.Location = new Point(30, 30);
            label.Text = "Busca";
            this.Controls.Add(label);

            textbx = new TextBox();
            textbx.Size = new Size(70, 30);
            textbx.Location = new Point(80, 30);
            this.Controls.Add(textbx);

            button1 = new Button();
            button1.Size = new Size(100, 30);
            button1.Location = new Point(170, 30);
            button1.Text = "Clique";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_ClickAsync);

            labelId = new Label();
            labelId.Size = new Size(40, 30);
            labelId.Location = new Point(30, 70);
            labelId.Text = "Id";
            this.Controls.Add(labelId);

            textbxId = new TextBox();
            textbxId.Size = new Size(40, 30);
            textbxId.Location = new Point(80, 70);
            this.Controls.Add(textbxId);

            labelName = new Label();
            labelName.Size = new Size(40, 30);
            labelName.Location = new Point(30, 110);
            labelName.Text = "Nome";
            this.Controls.Add(labelName);

            textbxName = new TextBox();
            textbxName.Size = new Size(100, 30);
            textbxName.Location = new Point(80, 110);
            this.Controls.Add(textbxName);

            labelPrice = new Label();
            labelPrice.Size = new Size(40, 30);
            labelPrice.Location = new Point(30, 150);
            labelPrice.Text = "Preço";
            this.Controls.Add(labelPrice);

            textbxPrice = new TextBox();
            textbxPrice.Size = new Size(50, 30);
            textbxPrice.Location = new Point(80, 150);
            this.Controls.Add(textbxPrice);

            labelRes = new Label();
            labelRes.Size = new Size(140, 30);
            labelRes.Location = new Point(30, 190);
            this.Controls.Add(labelRes);

            
        }
        
 
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            
            ProdutoViewModel prodVM = new ProdutoViewModel();

            prodVM.Criterio = textbx.Text;
            await prodVM.Procurar();

            if (prodVM.Produtos.Length!=0)
            {
                textbxId.Text = prodVM.Produtos[0].Id.ToString();
                textbxName.Text = prodVM.Produtos[0].Nome;
                textbxPrice.Text = prodVM.Produtos[0].Preco.ToString();
            } else
            {
                this.clean();
                labelRes.Text = "Nenhum resultado";
            }

            System.Console.WriteLine("@Voltei à View");
        }

        private void clean()
        {
            textbx.Text = "";
            textbxId.Text = "";
            textbxName.Text = "";
            textbxPrice.Text = "";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "Busca Vestuário";

        }
    }

}
