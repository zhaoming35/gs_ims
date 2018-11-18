using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;
using GaoShan.Sales.Model;
using Xceed.Words.NET;
using System.Text.RegularExpressions;
using GaoShan.Sales.Doc;

namespace GaoShan.Sales.Template.UI
{
    public partial class UCPartInfo : UCBase
    {
        Logic.TmpManager manager = new Logic.TmpManager();

        public Info_tmp InfoTmp { get; set; }

        public UCPartInfo()
        {
            InitializeComponent();
            this.mDataGrid1.CurrentRowChanged += MDataGrid1_CurrentRowChanged;
            this.mDataGrid1.CellClick += MDataGrid1_CurrentRowChanged;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnBind.Click += BtnBind_Click;
            this.btnOtherInfo.Click += BtnTableSeq_Click;
        }

        private void BtnTableSeq_Click(object sender, EventArgs e)
        {
            FmTmpOtherInfo fm = new FmTmpOtherInfo(this.InfoTmp);
            fm.SelectValue += Fm_SelectValue;
            fm.ShowDialog();
        }

        private void Fm_SelectValue(object obj)
        {
            this.InfoTmp=obj as Info_tmp;
        }

        private void BtnBind_Click(object sender, EventArgs e)
        {
            //组装成整个模板，并提取出变量数据，更新到模板主表
            GetAndSaveTmpVars();
 
            FmVarMapManager fm = new FmVarMapManager();
            fm.Tag = this.InfoTmp.Tmp_Id;
            fm.ShowDialog();
        }

        private void GetAndSaveTmpVars()
        {
            long tmpId= this.InfoTmp.Tmp_Id;
            List<string> parms = null;


            DocBuilder docBuilder = new DocBuilder(this.InfoTmp);

            using (DocX document = DocX.Load(docBuilder.ToStream()))
            {
                string regEx = "\\$\\{[^\\$\\{\\}]*\\}";
                parms = document.FindUniqueByPattern(regEx, RegexOptions.IgnoreCase);

                //string filename = System.IO.Path.Combine("Report", "tmp.docx");
                //Doc.DocBuilder1.SetPageMargin(document);
                //document.SaveAs(filename);
            }


            if (!manager.SaveTmpVars(tmpId, parms))
            {
                MessageBox.Show("模板提取变量失败");
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmPartInfo fm = new FmPartInfo();
            fm.Tag = this.InfoTmp.Tmp_Id;
            fm.SelectValue += FmAdd_SelectValue;
            fm.ShowDialog();
        }

        private void FmAdd_SelectValue(object obj)
        {
            this.mDataGrid1.AddItem<Model.Tb_tmp_part>((Model.Tb_tmp_part)obj);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.mDataGrid1.CurrentRow == null) { this.DoSelectValueEvent(null); return; }

            Model.Tb_tmp_part info = mDataGrid1.GetCurrentEntity() as Model.Tb_tmp_part;

            FmPartInfo fm = new FmPartInfo(info);
            fm.Tag = this.Tag;
            fm.SelectValue += FmEdit_SelectValue;
            fm.ShowDialog();
        }

        private void FmEdit_SelectValue(object obj)
        {
            this.mDataGrid1.EditCurrentItem<Model.Tb_tmp_part>((Model.Tb_tmp_part)obj);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }
            Model.Tb_tmp_part info = mDataGrid1.GetCurrentEntity() as Model.Tb_tmp_part;
            if (Miles.Framework.UI.Function.Dialog.ShowWarningYesNo("确定要删除：" + info.Part_Name + "信息?"))
            {
                if (manager.RemovePart(info))
                {
                    mDataGrid1.DeleteCurrentItem<Model.Info_tmp>();
                }
            }
        }

        private void MDataGrid1_CurrentRowChanged(object sender, EventArgs e)
        {
            if (this.mDataGrid1.CurrentRow == null) { this.DoSelectValueEvent(null); return; }

            Model.Tb_tmp_part info = mDataGrid1.GetCurrentEntity() as Model.Tb_tmp_part;
            this.DoSelectValueEvent(info);
        }

        public override void SetDataSource(object dataSource)
        {
            base.SetDataSource(dataSource);

            this.mDataGrid1.Clear();

            List<Model.Tb_tmp_part> list = dataSource as List<Model.Tb_tmp_part>;

            if (list != null)
                this.mDataGrid1.SetDataSource<Model.Tb_tmp_part>(list);
        }

        public override void Clear()
        {
            this.selectValue = null;
            this.dataSource = null;
            this.mDataGrid1.Clear();
        }
    }
}
