using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.MatchTb.UI
{
    public partial class UCMatchTbInfo : GaoShan.Sales.UI.UC.UCBase
    {
   
        Logic.MatchTbManager manager = new Logic.MatchTbManager();

        public UCMatchTbInfo()
        {
            InitializeComponent();
            this.btnReCreate.Click += BtnReCreate_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        public override bool Save(ToolStripButton sender)
        {
            Dictionary<Control, string> dicEmptyCtrs = this.GetValidEmptyCtrs();
            if (dicEmptyCtrs.Count > 0)
            {
                foreach (var ctr in dicEmptyCtrs.Keys)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(ctr, dicEmptyCtrs[ctr], 1000);
                    return false;
                }
            }

            List<Model.Info_matchTb_item> items = mDataGridItem.GetDataSource<Model.Info_matchTb_item>();
            if (items == null || items.Count < 1)
            {
                return false;
            }

            Model.Info_matchTb info = dataSource as Model.Info_matchTb;
            Model.Info_matchTb infoMatchTb = this.GetDataBind<Model.Info_matchTb>(info);
            infoMatchTb.Items = items;

            if (manager.Save(infoMatchTb))
            {
                base.SetDataSource(infoMatchTb);
                base.selectValue = infoMatchTb;
            }

            return true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGridItem.CurrentRow == null) { return; }
            Model.Info_matchTb_item item = mDataGridItem.GetCurrentEntity() as Model.Info_matchTb_item;

            string msg = string.Format("确定删除:{0}?", item.Mtl_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                mDataGridItem.DeleteCurrentItem<Model.Info_matchTb_item>();
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmMtlSelect fm = new FmMtlSelect();
            fm.SelectValue += (obj) =>
            {
                Model.Info_mtl_item mtl = obj as Model.Info_mtl_item;
                Model.Info_matchTb_item item = Mtl2MatchTbItem(mtl);
                
                mDataGridItem.AddItem<Model.Info_matchTb_item>(item);
            };
            fm.ShowDialog();
        }

        private Info_matchTb_item Mtl2MatchTbItem(Info_mtl_item mtl)
        {
            Model.Info_matchTb_item item = Miles.Coro.Common.Utils.CopyToOther<Model.Info_mtl_item, Model.Info_matchTb_item>(mtl);
            item.Group_Name = Cache.LogicCache.DicGroupKind[mtl.Kind_Code].Kind_Name;
            item.MatchTb_Id = (long)this.Tag;
            return item;
        }

        GaoShan.Sales.UI.Report.FmMatchTbManagerReport reportMatchTb = null;// new Report.FmMatchTbManagerReport();

        private void BtnReCreate_Click(object sender, EventArgs e)
        {
            if(reportMatchTb==null)
            reportMatchTb = new GaoShan.Sales.UI.Report.FmMatchTbManagerReport();
            Model.Info_matchTb info = dataSource as Model.Info_matchTb;

            //reportMatchTb.ShowGrid(info);
            Dictionary<string,object> dicVar= reportMatchTb.GetMatchTbVars(info);
            //获得生成物料
            Model.Info_matchTb_tmp_set tmpSet=Cache.LogicCache.GetMatchTbTmpSet(info.Tent_Width, info.Tent_MainSpec);
            if (tmpSet == null)
            {
                string msg = string.Format("不存在宽度{0}米，主材规格{1}的物料组成数据",info.Tent_Width, info.Tent_MainSpec);
                Miles.Framework.UI.Function.MForm.SetToolTip(btnReCreate, msg, 1000);

                return;
            }

            Dictionary<string, Model.Info_mtl_item> dicMtlItem = Cache.LogicCache.DicMtlItem;
            List<Model.Info_matchTb_item> items = new List<Model.Info_matchTb_item>();
           
            foreach(var v in tmpSet.SetItems)
            {
                Model.Info_mtl_item mtl = dicMtlItem[v.Key];
                Model.Info_matchTb_item item = Mtl2MatchTbItem(mtl);

                object value = GaoShan.Sales.UI.Report.ReportTemplateBase.ParseFormula(v.Value, dicVar);
                decimal result = -1;
                decimal.TryParse(value.ToString(), out result);

                item.Item_Count = result;
    
                items.Add(item);
            }

            mDataGridItem.Clear();
            mDataGridItem.SetDataSource<Model.Info_matchTb_item>(items);
        }

        public override void Clear()
        {
            base.Clear();
            this.mDataGridItem.Clear();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);
            base.selectValue = dataSource;
            if (dataSource == null) { return; }

            Model.Info_matchTb info = dataSource as Model.Info_matchTb;
            this.Tag = info.MatchTb_Id;
            this.SetDataBind(dataSource);

            //商品列表添加

            this.mDataGridItem.SetDataSource<Model.Info_matchTb_item>(info.Items);

        }
    }
}
