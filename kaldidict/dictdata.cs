using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaldidict
{
    public partial class dictdata : Form
    {
        public dictdata()
        {
            InitializeComponent();
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定导入kalid字典?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None) != DialogResult.OK)
            {

                return;
            }

                if (!File.Exists("lexicon.txt"))
            {
                textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "lexicon.txt不存在,无法导入!!!"));
                return;
            }
            if (!File.Exists("lexiconp.txt"))
            {
                textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "lexiconp.txt不存在,无法导入!!!"));
                return;
            }
            if (!File.Exists("lexiconp_silprob.txt"))
            {
                textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "lexiconp_silprob.txt不存在,无法导入!!!"));
                return;
            }
            var a1list = File.ReadAllLines("lexicon.txt");
            var a2list = File.ReadAllLines("lexiconp.txt");
            var a3list = File.ReadAllLines("lexiconp_silprob.txt");
            List<string> sqllist = new List<string>();
            string sqlstr = "";
            int sqlcount = 0;
            if (!(a1list.Count() == a2list.Count() && a2list.Count() == a3list.Count()))
            {
                textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "文本行数不对!!!"));
                return;
            }
            int rowcount = a1list.Count();
            textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "insert kaldi dict start..."));
            string turncatsql = "TRUNCATE TABLE kaldidict;";
            sqllist.Add(turncatsql);
            for (int i = 3; i < rowcount; i++)
            {
                sqlcount++;
                string a1 = a1list[i];
                string word1 = a1.Split(' ')[0];
                string a2 = a2list[i];
                string a3 = a3list[i];
                try
                {
                    string sql1 = string.Format("INSERT INTO kaldidict (dictword, lexicon,lexiconp,lexiconp_silprob) VALUES ('{0}','{1}','{2}','{3}')", word1.Replace("'", @"\'"), a1.Replace("'", @"\'"), a2.Replace("'", @"\'"), a3.Replace("'", @"\'"));
                    sqlstr = sqlstr + ";" + sql1;
                    if (sqlcount % 50 == 0)
                    {
                        sqllist.Add(sqlstr);
                        sqlstr = "";
                    }
                }
                catch (Exception)
                {
                }
            }
            sqllist.Add(sqlstr);
            MySqlHelper.ExecuteSqlTran(sqllist, textBox1, "insert kaldi dict ");
            textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "insert kaldi dict end"));


        }

        private void btncmudict_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定导入cmu字典?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None) != DialogResult.OK)
            {

                return;
            }
            if (!File.Exists("cmu_dict.txt"))
            {
                textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "cmu_dict.txt不存在,无法导入!!!"));
                return;
            }
            var a1list = File.ReadAllLines("cmu_dict.txt");
            List<string> sqllist = new List<string>();
            string sqlstr = "";
            int sqlcount = 0;
            textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "insert cmu dict start..."));
            string turncatsql = "TRUNCATE TABLE cmudict;";
            sqllist.Add(turncatsql);
            foreach (var a in a1list)
            {
                sqlcount++;
                try
                {
                    string word = a.Split(' ')[0];
                    string sql1 = string.Format("INSERT INTO cmudict (dictword, pronunciation) VALUES ('{0}','{1}')", word.Replace("'", @"\'"), a.Replace("'", @"\'"));
                    sqlstr = sqlstr + ";" + sql1;
                    if (sqlcount % 50 == 0)
                    {
                        sqllist.Add(sqlstr);
                        sqlstr = "";
                    }
                }
                catch (Exception)
                {

                }
            }
            sqllist.Add(sqlstr);
            MySqlHelper.ExecuteSqlTran(sqllist, textBox1, "insert cmu dict ");
            textBox1.AppendText(string.Format("{0} {1} \r\n", DateTime.Now, "insert cmu dict end"));
        }
    }
}
