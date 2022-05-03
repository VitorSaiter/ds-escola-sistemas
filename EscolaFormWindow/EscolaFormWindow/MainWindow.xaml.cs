using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using EscolaFormWindow.Database;

namespace EscolaFormWindow
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            string nomeFan = txtNomeFantasia.Text;

            string cnpj = txtCNPJ.Text;

            string razaoSocial = txtRazaoSocial.Text;

            string inscricaoEsta = txtInscEstadual.Text;

            string tipo = "Privado";
            if ((bool)rbPublico.IsChecked)
            {
                tipo = "Pública";
            }
           
            string nomeRes = txtNomeRespon.Text;

            string telefoneRes = txtTelefoneRespon.Text;

            string telefoneConta = txtTelefoneContato.Text;

            string emailConta = txtEmailContato.Text;

            string rua = txtRuaEndereco.Text;

            string numero = txtNumCasaEndereco.Text;

            string bairro = txtBairroEndereco.Text;

            string complemento = txtComplementoEndereco.Text;

            string cep = txtCEPEndereco.Text;

            string cidade = txtCidadeEndereco.Text;

            string data = dpDataCriacao.Text;

            string estado = cbxEstadoEndereco.Text;

            /*MessageBox.Show("Nome:" + nomeFan + "\n"
                + "CNPJ:" + cnpj + "\n"
                + "Razão Social:" + razaoSocial + "\n"
                + "Inscrição Estadual:" + inscricaoEsta + "\n"
                + "Tipo:" + tipo + "\n"
                + "Data Criação:" + data + "\n"
                + "Nome do Responsável:" + nomeRes + "\n"
                + "Telefone do Responsável:" + telefoneRes + "\n"
                + "Telefone:" + telefoneConta + "\n"
                + "E-mail:" + emailConta + "\n"
                + "Rua:" + rua + "\n"
                + "Numero:" + numero + "\n"
                + "Bairro:" + bairro + "\n"
                + "Complemento" + complemento + "\n"
                + "CEP:" + cep + "\n"
                + "Cidade:" + cidade + "\n"
                + "Estado:" + estado);*/

            try
            {
                var conexao = new Conexao();
                var comando = conexao.Query();


                comando.CommandText = "insert into Escola (nome_fantasia_esc, razao_social_esc, cnpj_esc, insc_estadual_esc, tipo_esc, data_criacao_esc, " +
                "responsavel_esc, responsavel_telefone_esc, email_esc, telefone_esc, rua_esc, numero_esc, bairro_esc, complemento_esc, cep_esc, cidade_esc, estado_esc) values (@nomefantasia, @razaosocial, @cnpj, @inscestadual, @tipo, @datacriacao, @responsavel, @responsaveltelefone, @email, @telefone, @rua, " +
                "@numero, @bairro, @complemento, @cep, @cidade, @estado);";

                comando.Parameters.AddWithValue("@nome", nomeFan);
                comando.Parameters.AddWithValue("@razaosocial", razaoSocial);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@inscestadual", inscricaoEsta);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@datacriacao", data);
                comando.Parameters.AddWithValue("@responsavel", nomeRes);
                comando.Parameters.AddWithValue("@responsaveltelefone", telefoneRes);
                comando.Parameters.AddWithValue("@email", emailConta);
                comando.Parameters.AddWithValue("@telefone", telefoneConta);
                comando.Parameters.AddWithValue("@rua", rua);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@complemento", complemento);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estado", estado);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                    MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
