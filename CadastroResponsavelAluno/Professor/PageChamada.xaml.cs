using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
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

namespace CadastroResponsavelAluno
{
    /// <summary>
    /// Interação lógica para PageChamada.xam
    /// </summary>
    public partial class PageChamada : Page
    {
        public PageChamada()
        {
            InitializeComponent();

            AdicionarTurmas();
        }

        private void ComboBoxTurma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarregarDados();
        }

        public void CarregarDados()
        {
            List<Aluno> alunos = new List<Aluno>();

            using (SQLiteConnection conexao = new SQLiteConnection("Data Source=" + System.IO.Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "ChegouBD.db")))
            {
                conexao.Open();
                string strSql = "SELECT * FROM Alunos WHERE Turma = @turma";
                using (SQLiteCommand cmd = new SQLiteCommand(strSql, conexao))
                {
                    cmd.Parameters.AddWithValue("@turma", ComboBoxTurma.SelectedItem.ToString());

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aluno aluno = new Aluno
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString()
                            };
                            alunos.Add(aluno);
                        }
                    }
                }
            }
            DataGridChamada.ItemsSource = alunos;
        }

        private void AdicionarTurmas()
        {
            ComboBoxTurma.Items.Add("1º A");
            ComboBoxTurma.Items.Add("1º B");
            ComboBoxTurma.Items.Add("1º C");
            ComboBoxTurma.Items.Add("2º A");
            ComboBoxTurma.Items.Add("2º B");
            ComboBoxTurma.Items.Add("2º C");
        }

        private void botaoSalvarPresenca_Click(object sender, RoutedEventArgs e)
        {

            // Assumindo que você tem uma lista de CheckBoxes em um painel, por exemplo, um StackPanel.
            foreach (var item in DataGridChamada.Items)
            {
                if (item is CheckBox checkBox)
                {
                    string nome = checkBox.Content.ToString();
                    string status = checkBox.IsChecked == true ? "presente" : "ausente";

                }
            }


            //criar uma tabela com a turma e o data atual e se a tabela nao existir o sistema vai criar 
            //buscar todos os nomes e fazer os que tiver selecionado no <CheckBox IsChecked=" virar uma string de presente.
            // e os que nao estiver selecionado<CheckBox IsChecked=" virar uma string de ausente 
        }


        private void SalvarChamada(List<Aluno> alunosPresentes)
        {
            string nomeTabela = "Chamada" + ComboBoxTurma.Text + DateTime.Now.Date;

            using (SQLiteConnection conexao = new SQLiteConnection("Data Source=" + System.IO.Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "ChegouBD.db")))
            {
                conexao.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS @NomeTabela (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT,
                                        Data DATE,
                                        Presente INTEGER
                                    )";
                createTableQuery.Parameters.AddWithValue("@NomeTabela",nomeTabela );
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, conexao))
                {
                    command.ExecuteNonQuery();
                }

                string insertQuery = @"INSERT INTO Presenca (Nome, Data, Presente) VALUES (@Nome, @Data, @Presente)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, conexao))
                {
                    foreach (var aluno in alunosPresentes)
                    {
                        command.Parameters.AddWithValue("@Nome", aluno.Nome);
                        command.Parameters.AddWithValue("@Data", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@Presente", 1); // 1 para presente

                        command.ExecuteNonQuery();
                    }
                }
            }
        }




    }
}
