using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private ProductDbContext context;
        public Form1()
        {
            InitializeComponent();
            context = new ProductDbContext();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Loja teste da DevMedia"
            };
            context.Lojas.Add(loja);
            Produto produto = new Produto()
            {
                Nome = "Produto teste",
                Valor = 20m,
                Loja = loja
            };
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        private void BtnSelectInsert_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(3);

            Produto novoProduto = new Produto()
            {
                Nome = "Novo produto",
                Valor = 100m,
                LojaId = loja.Id,
                Loja = loja
            };

            context.Produtos.Add(novoProduto);

            context.SaveChanges();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Produto produto = context.Produtos.Find(2);

            Loja lojaProduto = produto.Loja;
            String nomeLoja = produto.Loja.Nome;
        }

        private void BtnSelectWhere_Click(object sender, EventArgs e)
        {
            IEnumerable<Produto> produtosComecadosComA = context.Produtos.Where(p => p.Nome.StartsWith("A")).ToList();

            IEnumerable<Produto> produtosDaLoja = context.Produtos.Where(p => p.LojaId == 1).ToList();

            IEnumerable<Produto> produtosDaLoja2 = context.Lojas.Find(1).Produtos;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(3);
            loja.Nome = "Teste update DevMedia";

            Produto produto = context.Produtos.Find(4);
            produto.Nome = "Update produto DevMedia";
            produto.Loja.Nome = "Update via produto";

            loja.Produtos.ForEach(p => p.Valor += p.Valor * 0.1m);

            context.SaveChanges();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Loja loja = context.Lojas.Find(3);
            //context.Lojas.Remove(loja);

            Produto produto = context.Produtos.Find(4);
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }

        private void BtnUpdateEntityState_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = 2,
                Nome = "Teste DevMedia EntityState",
                LojaId = 1
            };
            context.Entry(produto).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
