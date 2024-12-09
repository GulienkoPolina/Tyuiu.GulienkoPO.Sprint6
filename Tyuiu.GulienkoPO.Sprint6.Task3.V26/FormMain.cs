using System.Drawing.Drawing2D;
using Tyuiu.GulienkoPO.Sprint6.Task3.V26.Lib;
namespace Tyuiu.GulienkoPO.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê3 âûïîëíèëà ñòóäåíòêà ãðóïïû ÈÈÏá-24-2 Êóëüêî Äàðüÿ Àíäðååâíà");
        }
        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mt);
            int row = res.GetUpperBound(0) + 1;
            int col = res.Length / row;
            dataGridView_Output_KDA.ColumnCount = col;
            dataGridView_Output_KDA.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                dataGridView_Output_KDA.Columns[i].Width = 25;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridView_Output_KDA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }

        }

        int[,] mt = { { 16, 19, 17, 2, 8 }, { -17, 8, -17, -8, 1 }, { -7, 17, -2, 1, -3 }, { -12, 0, -17, 15, 6 }, { 17, -6, -17, 18, -19 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mt.GetUpperBound(0) + 1;
            int cols = mt.Length / rows;
            dataGridView_Input_KDA.ColumnCount = cols;
            dataGridView_Input_KDA.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridView_Input_KDA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView_Input_KDA.Rows[i].Cells[j].Value = Convert.ToString(mt[i, j]);
                }
            }
        }


    }
}