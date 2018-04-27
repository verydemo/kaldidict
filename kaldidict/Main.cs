using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kaldidict
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }




        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchtxt = txtsearch.Text.Trim();
            if (searchtxt == "") {
                MessageBox.Show("请填写搜索文本！！！");
                txtsearch.Focus();
                return;
            }
            labdgvcmu.Visible = false;
            Application.DoEvents();
            var dicta = data.Cmudictlist;
            Regex regex1 = new Regex(string.Format(@"^{0}([\(][0-9][\)])", searchtxt), RegexOptions.IgnoreCase);
            var dictb=dicta.Where(a => a.Key== searchtxt.ToUpper()|| regex1.IsMatch(a.Key)).Select(b=>b.First()).ToList();
            if (dictb.Count() > 0)
            {
                labdgvcmu.Visible = false;
                dgvcmudata.DataSource = dictb;
            }
            else {
                labdgvcmu.Visible = true;
                dgvcmudata.DataSource = dictb;
            }
            dgvcmudata.ClearSelection();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvcmudata.AutoGenerateColumns = false;
            dgvcompareword.AutoGenerateColumns = false;
            dgvcmudata.SelectionChanged += Dgvcmudata_SelectionChanged;
            dgvcompareword.SelectionChanged += Dgvcompareword_SelectionChanged;
            dgvcompareword.CellBeginEdit += dgvcompareword_CellBeginEdit;
            dgvcompareword.CellEndEdit += dgvcompareword_CellEndEdit;
            label6.Click += Label6_Click;
            if (!MySqlHelper.Testcon())
            {
                MessageBox.Show("数据库连接失败!!!");
            }

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("1 0.19 1.00 1.00");
        }

        private void Dgvcompareword_SelectionChanged(object sender, EventArgs e)
        {
            txtsearch.Text = dgvcompareword.CurrentRow.Cells[0].Value.ToString();
            //btnsearch_Click(null,null);
        }

        private void Dgvcmudata_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvcmudata.SelectedRows.Count > 0)
            {
                txtword.Text = dgvcmudata.Rows[0].Cells[0].Value.ToString();
                txtlexicon.Text = dgvcmudata.SelectedRows[0].Cells[2].Value.ToString().Replace("  "," ");
                int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(CommandType.Text, string.Format("SELECT count(*) FROM kaldidict WHERE dictword='{0}'", txtword.Text.Trim())));
                if (count > 0)
                {
                    labnote.Text = "kaldi字典库已经添加该单词,无需重复添加!!!";
                }
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtlexicon.Text.Trim() == "" || txtlexiconp.Text.Trim() == "" || txtlexiconp_silprob.Text.Trim() == "" || txtword.Text.Trim() == "")
            {
                MessageBox.Show("word,lexicon,lexiconp,lexiconp_silprob不能为空!!!");
                return;
            }

            int count =Convert.ToInt32( MySqlHelper.ExecuteScalar(CommandType.Text, string.Format("SELECT count(*) FROM kaldidict WHERE dictword='{0}'", txtword.Text.Trim())));
            if (count >0)
            {
                MessageBox.Show("kaldi字典库已经添加该单词,无需重复添加!!!");
                return;
            }
            else {
                string sqlstr=string.Format("INSERT INTO kaldidict.kaldidict (dictword, lexicon, lexiconp, lexiconp_silprob) VALUES ('{0}','{1}','{2}','{3}')", txtword.Text.Trim(), txtlexicon.Text.Trim().Replace("'", @"\'"), txtlexiconp.Text.Trim().Replace("'", @"\'"), txtlexiconp_silprob.Text.Trim().Replace("'", @"\'"));
                MySqlHelper.ExecuteScalar(CommandType.Text,sqlstr);
                MessageBox.Show("添加成功!!!");
                string sqlstr1 = string.Format("UPDATE compareword SET status='1',note='已添加' WHERE upper(word)={0}", txtword.Text.Trim().Replace("'", @"\'"));
                MySqlHelper.ExecuteNonQuery(CommandType.Text, sqlstr1);
                Loaddgvcompareword();
            }
        }
        private int batchno = 0;

        private void btnimportcompare_Click(object sender, EventArgs e)
        {
            List<string> strlist = new List<string>();
            OpenFileDialog ofd1 = new OpenFileDialog();

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                labdgvcompara.Visible = false;
                Application.DoEvents();
                var cmudictlist = data.Cmudictlist;
                string alltxt = File.ReadAllText(ofd1.FileName);
                Regex regex1 = new Regex("[^a-zA-Z' ]");
                if (regex1.IsMatch(alltxt))
                {
                    MessageBox.Show("文本中存在特殊字符,请选择正确的文本文件!!!");
                    return;
                }
                var alist = File.ReadAllText(ofd1.FileName).Split(' ').GroupBy(a=>a).ToList();
                alist.ForEach(a => {
                    if (!cmudictlist.Contains(a.Key.ToUpper())){
                        strlist.Add(a.Key);
                    }            
                });
                if (strlist.Count > 0)
                {
                    List<string> sqllist = new List<string>();
                    string sqlstr = "";
                    int num = 0;

                    var maxbatchno = MySqlHelper.ExecuteScalar(CommandType.Text, "SELECT max(batchno) FROM compareword");
                    if (!maxbatchno.IsNullOrEmpty())
                    {
                        batchno = Convert.ToInt32(maxbatchno) + 1;
                    }
                    else
                    {
                        batchno = 1;
                    }
                    strlist.ForEach(a => {
                        num++;
                        string sql = string.Format("INSERT INTO compareword (word, status, note, wordsplit, examname,batchno) VALUES ('{0}','{1}','{2}','{3}','{4}',{5})", a.Replace("'", @"\'"), "0", "未处理", "", Path.GetFileName(ofd1.FileName), batchno);
                        sqlstr = sqlstr + ";" + sql;
                        if (num % 30 == 0)
                        {
                            sqllist.Add(sqlstr);
                            sqlstr = "";
                        }
                    });
                    sqllist.Add(sqlstr);
                    MySqlHelper.ExecuteSqlTran(sqllist);

                }

                Loaddgvcompareword();
            }
        }



        #region DGV直接编辑修改数据的功能
        /// <summary>
        /// 用来存放DGV单元格修改之前值
        /// </summary>
        Object cellTempValue = null;

        /// <summary>
        /// DGV单元格开始编辑时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvcompareword_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = dgvcompareword.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        /// <summary>
        /// DGV单元格结束编辑时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvcompareword_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Object.Equals(cellTempValue, dgvcompareword.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            {
                return;
            }
            if (MessageBox.Show("确定修改?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None) != DialogResult.OK)
            {
                dgvcompareword.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                return;
            }
            string wordsplit = dgvcompareword.Rows[e.RowIndex].Cells["splitword"].Value.ToString().Trim();
            int id =Convert.ToInt32( dgvcompareword.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim());
            string sql = string.Format("UPDATE compareword SET status='2',note='已拆分',wordsplit='{0}' WHERE id={1}", wordsplit.Replace("'", @"\'"), id);

            try
            {
                MySqlHelper.ExecuteNonQuery(CommandType.Text, sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Loaddgvcompareword();
            MyInvoke loaddgv = new MyInvoke(Loaddgvcompareword);
            this.BeginInvoke(loaddgv);
        }
        #endregion

        public delegate void MyInvoke();
        private void Loaddgvcompareword()
        {
            var alist = MySqlHelper.GetDataSetnew(string.Format("select * from compareword where batchno={0}", batchno)).Tables[0].ToModels<compareword>();
            if (alist.Count > 0)
            {
                labdgvcompara.Visible = false;
                dgvcompareword.DataSource = alist;
                dgvcompareword.ClearSelection();
            }
            else
            {
                labdgvcompara.Visible = true;
                dgvcompareword.DataSource = alist;
            }

        }

        private void tsmidictdata_Click(object sender, EventArgs e)
        {
            dictdata dd1 = new dictdata();
            dd1.ShowDialog();
        }

        private void btnexportdict_Click(object sender, EventArgs e)
        {
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            string dicdir = Path.Combine(currentpath, "dict");
            string path1 = Path.Combine(currentpath, "dict\\lexicon.txt");
            string path2 = Path.Combine(currentpath, "dict\\lexiconp.txt");
            string path3 = Path.Combine(currentpath, "dict\\lexiconp_silprob.txt");
            if (Directory.Exists(dicdir))
            {
                Directory.Delete(dicdir,true);
            }
            System.IO.Directory.CreateDirectory(dicdir);        
            StreamWriter sw1 = File.AppendText(path1);
            StreamWriter sw2 = File.AppendText(path2);
            StreamWriter sw3 = File.AppendText(path3);
            sw1.WriteLine("!SIL SIL"); sw1.WriteLine("<SPOKEN_NOISE> SPN"); sw1.WriteLine("<UNK> SPN");
            sw2.WriteLine("!SIL 1 SIL"); sw2.WriteLine("<SPOKEN_NOISE> 1 SPN"); sw2.WriteLine("<UNK> 1 SPN");            
            sw3.WriteLine("!SIL 1 0.19 1.00 1.00 SIL"); sw3.WriteLine("<SPOKEN_NOISE> 1 0.19 1.00 1.00 SPN"); sw3.WriteLine("<UNK> 1 0.45 1.35 0.94 SPN");
            var alist = MySqlHelper.GetDataSetnew("SELECT * FROM kaldidict").Tables[0].ToModels<kaldidict>();
            alist.ForEach(a=> {
                sw1.WriteLine(a.lexicon);
                sw2.WriteLine(a.lexiconp);
                sw3.WriteLine(a.lexiconp_silprob);
            });
            sw1.Close();sw2.Close();sw3.Close();
            MessageBox.Show(string.Format("生成成功!!!路径：{0}", currentpath+"\\dict"));
        }

        private void btnreplacetext_Click(object sender, EventArgs e)
        {

            if (dgvcompareword.Rows.Count > 0)
            {
                SaveFileDialog sfd1 = new SaveFileDialog();
                string examname = dgvcompareword.Rows[0].Cells["examname"].Value.ToString();
                sfd1.FileName = examname.Replace(".txt", "_replace.txt");
                if (sfd1.ShowDialog() == DialogResult.OK)
                {
                    int batchno1 = Convert.ToInt32(dgvcompareword.Rows[0].Cells["Batchnumber"].Value);
                    string sql = string.Format("SELECT * FROM compareword WHERE batchno={0}", batchno1);
                    var alist = MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<compareword>();
                    StreamWriter sw = File.AppendText(sfd1.FileName);
                    alist.ForEach(a =>
                    {
                        sw.WriteLine(a.word+"\t"+a.wordsplit);
                    });
                    sw.Close();
                    MessageBox.Show("生成成功!!!");
                }
            }
            else {
                MessageBox.Show("没有数据!!!");
            }
        }


    }
}
