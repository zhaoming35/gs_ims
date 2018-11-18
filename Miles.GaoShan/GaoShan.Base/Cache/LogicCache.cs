using Miles.IMSFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Cache
{
    public class LogicCache
    {

        static Dictionary<long, Model.Info_dept_role> _DicSalaryDeptRole;
        public static Dictionary<long, Model.Info_dept_role> DicSalaryDeptRole
        {

            get
            {
                if (_DicSalaryDeptRole == null)
                {
                    _DicSalaryDeptRole = new Logic.EmployManager().GetDeptRole("004");
                    foreach(var v in _DicSalaryDeptRole)
                    {
                        if (_DicSalaryDeptRole.ContainsKey(v.Value.Parent_Role_Id))
                        {
                            v.Value.Parent = _DicSalaryDeptRole[v.Value.Parent_Role_Id];
                        }
                    }
                }

                return _DicSalaryDeptRole;
            }
        }


        static Model.Tb_tmp_main _TmpMain;
        public static Model.Tb_tmp_main TmpMain
        {
            get
            {
                if (_TmpMain == null) { _TmpMain = new Logic.TmpManager().GetTmpMain(); }
                return _TmpMain;
            }
        }

        static Dictionary<string, Sm_employee> _DicEmployee;

        public static Dictionary<string, Sm_employee> DicEmployee
        {
            get
            {
                if (_DicEmployee == null)
                {
                    _DicEmployee = new Logic.EmployManager().GetAllEmployee();
                }
                return _DicEmployee;
            }
        }
    

        static Dictionary<string, Model.Info_mtl_item> _DicMtlItem;
        public static Dictionary<string, Model.Info_mtl_item> DicMtlItem
        {
            get
            {
                if (_DicMtlItem == null)
                {
                    _DicMtlItem= new Logic.MtlManager().GetMapItems();
                }

                return _DicMtlItem;

            }
        }

        static Dictionary<string, Model.Tb_mtl_kind> _DicMtlKind;
        public static Dictionary<string, Model.Tb_mtl_kind> DicMtlKind
        {
            get
            {
                if (_DicMtlKind == null)
                {
                    _DicMtlKind = new Logic.MtlManager().GetAllKind();
                }

                return _DicMtlKind;

            }
        }

        static Dictionary<string, List<string>> _DicChildKind;
        public static Dictionary<string,List<string>> DicChildKind
        {
            get
            {
                if (_DicChildKind == null)
                {
                    _DicChildKind = new Dictionary<string, List<string>>();

                    Dictionary<string, Model.Tb_mtl_kind> dicMtlKind = DicMtlKind;
                    var queryPartent = from item in dicMtlKind
                                       where item.Value.Kind_Level == 0
                                       select item.Key;

                    foreach(var v in queryPartent)
                    {
                        _DicChildKind.Add(v, new List<string>());
                    }

                    var queryChild = from item in dicMtlKind
                                       where item.Value.Kind_Level >0
                                       select item.Value;

                    foreach(var v in queryChild)
                    {
                        _DicChildKind[v.Kind_Parent].Add(v.Kind_Code);
                    }
                }


                return _DicChildKind;
            }
        }

        static Dictionary<string, Model.Info_mtl_kind> _DicGroupKind;
        public static Dictionary<string, Model.Info_mtl_kind> DicGroupKind
        {
            get
            {
                if (_DicGroupKind == null)
                {
                    _DicGroupKind = new Logic.MtlManager().GetAllGroupKind();
                }

                return _DicGroupKind;

            }
        }

        static Dictionary<string, Model.Info_matchTb_tmp_set> _MatchTbTmpSet=new Dictionary<string, Model.Info_matchTb_tmp_set> ();
        public static Model.Info_matchTb_tmp_set GetMatchTbTmpSet(decimal tent_Weight,string tent_MainSpec)
        {
            string key = tent_Weight.ToString() + "@" + tent_MainSpec;
            if (!_MatchTbTmpSet.ContainsKey(key))
            {
                Model.Info_matchTb_tmp_set tmpSet = new Logic.MatchTbTmpManager().GetTheSet(tent_Weight, tent_MainSpec);
                _MatchTbTmpSet.Add(key, tmpSet);
            }

            return _MatchTbTmpSet[key];
        }

        static Dictionary<long, Model.Info_place_info> _DicPlaces = null;
        public static Dictionary<long, Model.Info_place_info> DicPlaces
        {
            get
            {
                if (_DicPlaces == null) {
                    _DicPlaces = new Logic.PlaceInfoManager().GetAllPlaces();

                    var rootQuery = from item in _DicPlaces
                                    where item.Value.Level == 0
                                    select item;

                    Model.Info_place_info root = null;
                    foreach (var v in rootQuery)
                    {
                        root = v.Value;
                        break;
                    }

                    GetChildren(root);
                }

                return _DicPlaces;
            }

        }

        static void GetChildren(Model.Info_place_info parent)
        {
            var queryChild = from item in _DicPlaces
                             where item.Value.Parent_Id == parent.Place_Id
                             select item;

            foreach (var v in queryChild)
            {
                parent.Children.Add(v.Value);
                v.Value.Parent = parent;
                GetChildren(v.Value);
            }

        }

        public static List<Model.Info_place_info> GetAllProvince()
        {
            List<Model.Info_place_info> list = DicPlaces.Values.ToList<Model.Info_place_info>();
            var rootQuery = from item in list
                            where item.Level == 1
                            select item;

            return rootQuery.ToList<Model.Info_place_info>();
        }

        public static List<Model.Info_place_info> GetAllChildren(long parentId)
        {
            List<Model.Info_place_info> list = DicPlaces.Values.ToList<Model.Info_place_info>();
            var rootQuery = from item in list
                            where item.Parent_Id == parentId
                            select item;

            return rootQuery.ToList<Model.Info_place_info>();
        }


    }
}
