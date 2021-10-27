using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWidget
{
    public partial class ДобавитьЗапись : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=myWidget;Integrated Security=True";
        public ДобавитьЗапись()
        {
            InitializeComponent();
        }

        private void writeTask_Click(object sender, EventArgs e)
        {
            string sqlExpression = "хп_ЗаписатьЗадачи @задача = '"
            + пЗадача.Text +"'";
            if (checkBoxDate.Checked)
                sqlExpression += ", @Дата='" + datePicker.Value.ToShortDateString().Replace('.', '/') + "'";
            //выставлять время да нет
            if (checkBoxTimeAdd.Checked)
                sqlExpression += ", @Время = '" + TimePicker.Value.ToShortTimeString() + "'";
            if (checkBoxGood.Checked)
                sqlExpression += ", @Выполнено = 1";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader number = command.ExecuteReader();
                connection.Close();
                number.Close();
            }
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
