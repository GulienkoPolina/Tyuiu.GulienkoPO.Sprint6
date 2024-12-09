using System.Windows.Forms.VisualStyles;
using Tyuiu.GulienkoPO.Sprint6.Task4.V18.Lib;
namespace Tyuiu.GulienkoPO.Sprint6.Task4.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxStart.Text);
                int z = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(a, z).Length;
                double[] mass;
                mass = new double[len];
                mass = ds.GetMassFunction(a, z);

                for (int i = 0; i < len; i++)
                {
                    this.chart1.Series[0].Points.AddXY(a, mass[i]);
                    textBoxDone.AppendText(mass[i] + Environment.NewLine);
                    a++;
                }

            }
            catch
            {
                MessageBox.Show("îøèáêà", "îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê4 âûïîëíèëà ñòóäåíòêà ãðóïïû ÈÈÏá-24-2 Êóëüêî Äàðüÿ Àíäðååâíà");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V18.txt");
            File.WriteAllText(path, textBoxDone.Text);
            DialogResult dialogResult = MessageBox.Show("Ôàéë " + path + " ñîçäàí, îòêðûòü åãî?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
    }
}