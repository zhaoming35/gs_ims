/*
Navicat SQL Server Data Transfer

Source Server         : 192.168.1.88
Source Server Version : 105000
Source Host           : 192.168.1.88:1433
Source Database       : GaoShan_db
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2018-11-09 17:36:46
*/


-- ----------------------------
-- Table structure for sm_childmenu_form
-- ----------------------------
DROP TABLE [dbo].[sm_childmenu_form]
GO
CREATE TABLE [dbo].[sm_childmenu_form] (
[FM_ID] int NOT NULL DEFAULT ((0)) ,
[M_ID] int NOT NULL DEFAULT ((0)) ,
[Y] int NOT NULL DEFAULT ((0)) ,
[CM_Value] varchar(200) NULL ,
[F_ID] int NULL 
)


GO

-- ----------------------------
-- Records of sm_childmenu_form
-- ----------------------------
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'2', N'1', N'1', N'部门员工管理', N'4')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'1', N'1', N'合同模板管理', N'42')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'1', N'2', N'产品信息管理', N'38')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'1', N'3', N'Excel模板管理', N'40')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'2', N'1', N'公司合同账号管理', N'37')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'3', N'1', N'基础信息枚举管理', N'34')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'4', N'1', N'物料基础信息管理', N'39')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'5', N'1', N'配套表模板变量管理', N'44')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'5', N'2', N'配套表模板物料组成管理', N'43')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'6', N'3', N'运费各地基础数据管理', N'47')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'6', N'4', N'运输用车算法变量', N'48')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'6', N'5', N'运输用车最长件算法', N'49')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'7', N'1', N'篷房报价模板', N'41')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'3', N'8', N'1', N'提成算法模板', N'59')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'4', N'1', N'1', N'运费预估管理', N'50')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'4', N'1', N'2', N'产品报价预估', N'46')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'4', N'2', N'1', N'合同拟定管理', N'12')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'4', N'2', N'2', N'通过合同查询', N'52')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'4', N'3', N'1', N'合同摘要管理', N'16')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'4', N'4', N'1', N'项目联络单管理', N'18')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'5', N'1', N'1', N'下级合同审核', N'15')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'6', N'1', N'1', N'工程费用管理', N'19')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'6', N'2', N'1', N'工程费用查询', N'67')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'1', N'1', N'财务项目回款管理', N'20')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'1', N'2', N'财务项目退款管理', N'60')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'2', N'1', N'财务回款审核', N'21')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'2', N'2', N'财务项目退款审核', N'61')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'3', N'1', N'合同回款查询', N'58')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'4', N'1', N'财务提成计算管理', N'62')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'4', N'2', N'财务提成发放管理', N'64')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'7', N'5', N'1', N'财务合同摘要审核', N'63')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'8', N'1', N'1', N'配套表管理', N'45')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'1', N'1', N'物料库存管理', N'51')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'2', N'1', N'订单出库管理', N'53')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'3', N'1', N'租赁回库管理', N'54')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'3', N'2', N'直接入库', N'55')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'4', N'1', N'盘库管理', N'56')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'5', N'1', N'入库记录查询', N'69')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'9', N'5', N'2', N'出库记录查询', N'70')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'10', N'1', N'1', N'运输单管理', N'36')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'10', N'2', N'1', N'运输单查询', N'68')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'11', N'1', N'1', N'盘库审核', N'57')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'12', N'1', N'1', N'费用回访管理', N'65')
GO
GO
INSERT INTO [dbo].[sm_childmenu_form] ([FM_ID], [M_ID], [Y], [CM_Value], [F_ID]) VALUES (N'12', N'2', N'1', N'发送短信参数设置', N'66')
GO
GO

-- ----------------------------
-- Table structure for sm_ChinaRegion
-- ----------------------------
DROP TABLE [dbo].[sm_ChinaRegion]
GO
CREATE TABLE [dbo].[sm_ChinaRegion] (
[ID] varchar(20) NOT NULL ,
[Name] varchar(200) NOT NULL ,
[Remark] varchar(200) NULL ,
[Level] int NOT NULL ,
[ParentID] varchar(20) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_ChinaRegion', 
'COLUMN', N'ID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'ID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'ID'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_ChinaRegion', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_ChinaRegion', 
'COLUMN', N'Remark')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'Remark'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'Remark'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_ChinaRegion', 
'COLUMN', N'Level')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'级别1，省，2，市，3区、县'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'Level'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'级别1，省，2，市，3区、县'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'Level'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_ChinaRegion', 
'COLUMN', N'ParentID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'上一级ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'ParentID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'上一级ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_ChinaRegion'
, @level2type = 'COLUMN', @level2name = N'ParentID'
GO

-- ----------------------------
-- Records of sm_ChinaRegion
-- ----------------------------
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C1', N'北京市', N'市', N'2', N'P1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C10', N'唐山市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C100', N'六安市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C101', N'亳州市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C102', N'池州市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C103', N'宣城市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C104', N'福州市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C105', N'厦门市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C106', N'宁德市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C107', N'莆田市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C108', N'泉州市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C109', N'漳州市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C11', N'廊坊市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C110', N'龙岩市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C111', N'三明市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C112', N'南平市', N'市', N'2', N'P13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C113', N'鹰潭市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C114', N'新余市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C115', N'南昌市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C116', N'九江市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C117', N'上饶市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C118', N'抚州市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C119', N'宜春市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C12', N'沧州市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C120', N'吉安市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C121', N'赣州市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C122', N'景德镇市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C123', N'萍乡市', N'市', N'2', N'P14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C124', N'菏泽市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C125', N'济南市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C126', N'青岛市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C127', N'淄博市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C128', N'德州市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C129', N'烟台市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C13', N'衡水市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C130', N'潍坊市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C131', N'济宁市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C132', N'泰安市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C133', N'临沂市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C134', N'滨州市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C135', N'东营市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C136', N'威海市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C137', N'枣庄市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C138', N'日照市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C139', N'莱芜市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C14', N'邢台市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C140', N'聊城市', N'市', N'2', N'P15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C141', N'商丘市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C142', N'郑州市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C143', N'安阳市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C144', N'新乡市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C145', N'许昌市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C146', N'平顶山市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C147', N'信阳市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C148', N'南阳市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C149', N'开封市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C15', N'秦皇岛市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C150', N'洛阳市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C151', N'济源市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C152', N'焦作市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C153', N'鹤壁市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C154', N'濮阳市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C155', N'周口市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C156', N'漯河市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C157', N'驻马店市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C158', N'三门峡市', N'市', N'2', N'P16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C159', N'武汉市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C16', N'朔州市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C160', N'襄樊市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C161', N'鄂州市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C162', N'孝感市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C163', N'黄冈市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C164', N'黄石市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C165', N'咸宁市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C166', N'荆州市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C167', N'宜昌市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C168', N'恩施土家族苗族自治州', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C169', N'神农架林区', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C17', N'忻州市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C170', N'十堰市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C171', N'随州市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C172', N'荆门市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C173', N'仙桃市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C174', N'天门市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C175', N'潜江市', N'市', N'2', N'P17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C176', N'岳阳市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C177', N'长沙市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C178', N'湘潭市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C179', N'株洲市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C18', N'太原市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C180', N'衡阳市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C181', N'郴州市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C182', N'常德市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C183', N'益阳市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C184', N'娄底市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C185', N'邵阳市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C186', N'湘西土家族苗族自治州', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C187', N'张家界市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C188', N'怀化市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C189', N'永州市', N'市', N'2', N'P18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C19', N'大同市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C190', N'广州市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C191', N'汕尾市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C192', N'阳江市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C193', N'揭阳市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C194', N'茂名市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C195', N'惠州市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C196', N'江门市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C197', N'韶关市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C198', N'梅州市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C199', N'汕头市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C2', N'天津市', N'市', N'2', N'P2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C20', N'阳泉市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C200', N'深圳市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C201', N'珠海市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C202', N'佛山市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C203', N'肇庆市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C204', N'湛江市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C205', N'中山市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C206', N'河源市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C207', N'清远市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C208', N'云浮市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C209', N'潮州市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C21', N'晋中市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C210', N'东莞市', N'市', N'2', N'P19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C211', N'兰州市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C212', N'金昌市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C213', N'白银市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C214', N'天水市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C215', N'嘉峪关市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C216', N'武威市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C217', N'张掖市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C218', N'平凉市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C219', N'酒泉市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C22', N'长治市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C220', N'庆阳市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C221', N'定西市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C222', N'陇南市', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C223', N'临夏回族自治州', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C224', N'甘南藏族自治州', N'市', N'2', N'P22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C225', N'成都市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C226', N'攀枝花市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C227', N'自贡市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C228', N'绵阳市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C229', N'南充市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C23', N'晋城市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C230', N'达州市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C231', N'遂宁市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C232', N'广安市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C233', N'巴中市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C234', N'泸州市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C235', N'宜宾市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C236', N'资阳市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C237', N'内江市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C238', N'乐山市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C239', N'眉山市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C24', N'临汾市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C240', N'凉山彝族自治州', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C241', N'雅安市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C242', N'甘孜藏族自治州', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C243', N'阿坝藏族羌族自治州', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C244', N'德阳市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C245', N'广元市', N'市', N'2', N'P28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C246', N'贵阳市', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C247', N'遵义市', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C248', N'安顺市', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C249', N'黔南布依族苗族自治州', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C25', N'吕梁市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C250', N'黔东南苗族侗族自治州', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C251', N'铜仁地区', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C252', N'毕节地区', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C253', N'六盘水市', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C254', N'黔西南布依族苗族自治州', N'市', N'2', N'P29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C255', N'海口市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C256', N'三亚市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C257', N'五指山市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C258', N'琼海市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C259', N'儋州市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C26', N'运城市', N'市', N'2', N'P4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C260', N'文昌市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C261', N'万宁市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C262', N'东方市', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C263', N'澄迈县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C264', N'定安县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C265', N'屯昌县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C266', N'临高县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C267', N'白沙黎族自治县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C268', N'昌江黎族自治县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C269', N'乐东黎族自治县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C27', N'沈阳市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C270', N'陵水黎族自治县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C271', N'保亭黎族苗族自治县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C272', N'琼中黎族苗族自治县', N'市', N'2', N'P20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C273', N'西双版纳傣族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C274', N'德宏傣族景颇族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C275', N'昭通市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C276', N'昆明市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C277', N'大理白族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C278', N'红河哈尼族彝族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C279', N'曲靖市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C28', N'铁岭市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C280', N'保山市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C281', N'文山壮族苗族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C282', N'玉溪市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C283', N'楚雄彝族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C284', N'普洱市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C285', N'临沧市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C286', N'怒江傈傈族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C287', N'迪庆藏族自治州', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C288', N'丽江市', N'市', N'2', N'P30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C289', N'海北藏族自治州', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C29', N'大连市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C290', N'西宁市', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C291', N'海东地区', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C292', N'黄南藏族自治州', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C293', N'海南藏族自治州', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C294', N'果洛藏族自治州', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C295', N'玉树藏族自治州', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C296', N'海西蒙古族藏族自治州', N'市', N'2', N'P25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C297', N'西安市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C298', N'咸阳市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C299', N'延安市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C3', N'上海市', N'市', N'2', N'P9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C30', N'鞍山市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C300', N'榆林市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C301', N'渭南市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C302', N'商洛市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C303', N'安康市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C304', N'汉中市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C305', N'宝鸡市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C306', N'铜川市', N'市', N'2', N'P23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C307', N'防城港市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C308', N'南宁市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C309', N'崇左市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C31', N'抚顺市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C310', N'来宾市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C311', N'柳州市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C312', N'桂林市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C313', N'梧州市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C314', N'贺州市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C315', N'贵港市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C316', N'玉林市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C317', N'百色市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C318', N'钦州市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C319', N'河池市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C32', N'本溪市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C320', N'北海市', N'市', N'2', N'P21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C321', N'拉萨市', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C322', N'日喀则地区', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C323', N'山南地区', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C324', N'林芝地区', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C325', N'昌都地区', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C326', N'那曲地区', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C327', N'阿里地区', N'市', N'2', N'P31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C328', N'银川市', N'市', N'2', N'P26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C329', N'石嘴山市', N'市', N'2', N'P26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C33', N'丹东市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C330', N'吴忠市', N'市', N'2', N'P26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C331', N'固原市', N'市', N'2', N'P26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C332', N'中卫市', N'市', N'2', N'P26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C333', N'塔城地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C334', N'哈密地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C335', N'和田地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C336', N'阿勒泰地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C337', N'克孜勒苏柯尔克孜自治州', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C338', N'博尔塔拉蒙古自治州', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C339', N'克拉玛依市', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C34', N'锦州市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C340', N'乌鲁木齐市', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C341', N'石河子市', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C342', N'昌吉回族自治州', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C343', N'五家渠市', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C344', N'吐鲁番地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C345', N'巴音郭楞蒙古自治州', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C346', N'阿克苏地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C347', N'阿拉尔市', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C348', N'喀什地区', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C349', N'图木舒克市', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C35', N'营口市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C350', N'伊犁哈萨克自治州', N'市', N'2', N'P24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C351', N'呼伦贝尔市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C352', N'呼和浩特市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C353', N'包头市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C354', N'乌海市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C355', N'乌兰察布市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C356', N'通辽市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C357', N'赤峰市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C358', N'鄂尔多斯市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C359', N'巴彦淖尔市', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C36', N'阜新市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C360', N'锡林郭勒盟', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C361', N'兴安盟', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C362', N'阿拉善盟', N'市', N'2', N'P5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C363', N'台北市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C364', N'高雄市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C365', N'基隆市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C366', N'台中市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C367', N'台南市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C368', N'新竹市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C369', N'嘉义市', N'市', N'2', N'P32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C37', N'辽阳市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C370', N'澳门特别行政区', N'市', N'2', N'P33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C371', N'香港特别行政区', N'市', N'2', N'P34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C38', N'朝阳市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C39', N'盘锦市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C4', N'重庆市', N'市', N'2', N'P27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C40', N'葫芦岛市', N'市', N'2', N'P6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C41', N'长春市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C42', N'吉林市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C43', N'延边朝鲜族自治州', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C44', N'四平市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C45', N'通化市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C46', N'白城市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C47', N'辽源市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C48', N'松原市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C49', N'白山市', N'市', N'2', N'P7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C5', N'邯郸市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C50', N'哈尔滨市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C51', N'齐齐哈尔市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C52', N'鸡西市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C53', N'牡丹江市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C54', N'七台河市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C55', N'佳木斯市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C56', N'鹤岗市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C57', N'双鸭山市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C58', N'绥化市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C59', N'黑河市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C6', N'石家庄市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C60', N'大兴安岭地区', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C61', N'伊春市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C62', N'大庆市', N'市', N'2', N'P8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C63', N'南京市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C64', N'无锡市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C65', N'镇江市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C66', N'苏州市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C67', N'南通市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C68', N'扬州市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C69', N'盐城市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C7', N'保定市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C70', N'徐州市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C71', N'淮安市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C72', N'连云港市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C73', N'常州市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C74', N'泰州市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C75', N'宿迁市', N'市', N'2', N'P10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C76', N'舟山市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C77', N'衢州市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C78', N'杭州市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C79', N'湖州市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C8', N'张家口市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C80', N'嘉兴市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C81', N'宁波市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C82', N'绍兴市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C83', N'温州市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C84', N'丽水市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C85', N'金华市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C86', N'台州市', N'市', N'2', N'P11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C87', N'合肥市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C88', N'芜湖市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C89', N'蚌埠市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C9', N'承德市', N'市', N'2', N'P3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C90', N'淮南市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C91', N'马鞍山市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C92', N'淮北市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C93', N'铜陵市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C94', N'安庆市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C95', N'黄山市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C96', N'滁州市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C97', N'阜阳市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C98', N'宿州市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'C99', N'巢湖市', N'市', N'2', N'P12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P1', N'北京市', N'直辖市', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P10', N'江苏省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P11', N'浙江省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P12', N'安徽省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P13', N'福建省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P14', N'江西省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P15', N'山东省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P16', N'河南省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P17', N'湖北省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P18', N'湖南省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P19', N'广东省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P2', N'天津市', N'直辖市', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P20', N'海南省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P21', N'广西壮族自治区', N'自治区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P22', N'甘肃省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P23', N'陕西省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P24', N'新 疆维吾尔自治区', N'自治区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P25', N'青海省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P26', N'宁夏回族自治区', N'自治区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P27', N'重庆市', N'直辖市', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P28', N'四川省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P29', N'贵州省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P3', N'河北省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P30', N'云南省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P31', N'西藏自治区', N'自治区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P32', N'台湾省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P33', N'澳门特别行政区', N'特别行政区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P34', N'香港特别行政区', N'特别行政区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P4', N'山西省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P5', N'内蒙古自治区', N'自治区', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P6', N'辽宁省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P7', N'吉林省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P8', N'黑龙江省', N'省份', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'P9', N'上海市', N'直辖市', N'1', null)
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1', N'东城区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z10', N'房山区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z100', N'邯郸县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1000', N'仙游县', N'区县', N'3', N'C107')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1001', N'鲤城区', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1002', N'丰泽区', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1003', N'洛江区', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1004', N'泉港区', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1005', N'惠安县', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1006', N'安溪县', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1007', N'永春县', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1008', N'德化县', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1009', N'石狮市', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z101', N'临漳县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1010', N'晋江市', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1011', N'南安市', N'区县', N'3', N'C108')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1012', N'芗城区', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1013', N'龙文区', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1014', N'云霄县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1015', N'漳浦县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1016', N'诏安县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1017', N'长泰县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1018', N'东山县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1019', N'南靖县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z102', N'成安县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1020', N'平和县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1021', N'华安县', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1022', N'龙海市', N'区县', N'3', N'C109')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1023', N'新罗区', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1024', N'长汀县', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1025', N'永定县', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1026', N'上杭县', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1027', N'武平县', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1028', N'连城县', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1029', N'漳平市', N'区县', N'3', N'C110')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z103', N'大名县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1030', N'梅列区', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1031', N'三元区', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1032', N'明溪县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1033', N'清流县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1034', N'宁化县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1035', N'大田县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1036', N'尤溪县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1037', N'沙县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1038', N'将乐县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1039', N'泰宁县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z104', N'涉县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1040', N'建宁县', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1041', N'永安市', N'区县', N'3', N'C111')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1042', N'延平区', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1043', N'顺昌县', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1044', N'浦城县', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1045', N'光泽县', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1046', N'松溪县', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1047', N'政和县', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1048', N'邵武市', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1049', N'武夷山市', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z105', N'磁县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1050', N'建瓯市', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1051', N'建阳市', N'区县', N'3', N'C112')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1052', N'月湖区', N'区县', N'3', N'C113')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1053', N'余江县', N'区县', N'3', N'C113')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1054', N'贵溪市', N'区县', N'3', N'C113')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1055', N'渝水区', N'区县', N'3', N'C114')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1056', N'分宜县', N'区县', N'3', N'C114')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1057', N'东湖区', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1058', N'西湖区', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1059', N'青云谱区', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z106', N'肥乡县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1060', N'湾里区', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1061', N'青山湖区', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1062', N'南昌县', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1063', N'新建县', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1064', N'安义县', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1065', N'进贤县', N'区县', N'3', N'C115')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1066', N'庐山区', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1067', N'浔阳区', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1068', N'九江县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1069', N'武宁县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z107', N'永年县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1070', N'修水县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1071', N'永修县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1072', N'德安县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1073', N'星子县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1074', N'都昌县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1075', N'湖口县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1076', N'彭泽县', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1077', N'瑞昌市', N'区县', N'3', N'C116')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1078', N'信州区', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1079', N'上饶县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z108', N'邱县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1080', N'广丰县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1081', N'玉山县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1082', N'铅山县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1083', N'横峰县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1084', N'弋阳县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1085', N'余干县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1086', N'鄱阳县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1087', N'万年县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1088', N'婺源县', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1089', N'德兴市', N'区县', N'3', N'C117')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z109', N'鸡泽县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1090', N'临川区', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1091', N'南城县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1092', N'黎川县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1093', N'南丰县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1094', N'崇仁县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1095', N'乐安县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1096', N'宜黄县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1097', N'金溪县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1098', N'资溪县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1099', N'东乡县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z11', N'通州区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z110', N'广平县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1100', N'广昌县', N'区县', N'3', N'C118')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1101', N'袁州区', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1102', N'奉新县', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1103', N'万载县', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1104', N'上高县', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1105', N'宜丰县', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1106', N'靖安县', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1107', N'铜鼓县', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1108', N'丰城市', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1109', N'樟树市', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z111', N'馆陶县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1110', N'高安市', N'区县', N'3', N'C119')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1111', N'吉州区', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1112', N'青原区', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1113', N'吉安县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1114', N'吉水县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1115', N'峡江县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1116', N'新干县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1117', N'永丰县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1118', N'泰和县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1119', N'遂川县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z112', N'魏县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1120', N'万安县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1121', N'安福县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1122', N'永新县', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1123', N'井冈山市', N'区县', N'3', N'C120')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1124', N'章贡区', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1125', N'赣县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1126', N'信丰县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1127', N'大余县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1128', N'上犹县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1129', N'崇义县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z113', N'曲周县', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1130', N'安远县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1131', N'龙南县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1132', N'定南县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1133', N'全南县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1134', N'宁都县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1135', N'于都县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1136', N'兴国县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1137', N'会昌县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1138', N'寻乌县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1139', N'石城县', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z114', N'武安市', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1140', N'瑞金市', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1141', N'南康市', N'区县', N'3', N'C121')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1142', N'昌江区', N'区县', N'3', N'C122')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1143', N'珠山区', N'区县', N'3', N'C122')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1144', N'浮梁县', N'区县', N'3', N'C122')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1145', N'乐平市', N'区县', N'3', N'C122')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1146', N'安源区', N'区县', N'3', N'C123')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1147', N'湘东区', N'区县', N'3', N'C123')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1148', N'莲花县', N'区县', N'3', N'C123')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1149', N'上栗县', N'区县', N'3', N'C123')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z115', N'长安区', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1150', N'芦溪县', N'区县', N'3', N'C123')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1151', N'牡丹区', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1152', N'曹县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1153', N'单县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1154', N'成武县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1155', N'巨野县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1156', N'郓城县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1157', N'鄄城县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1158', N'定陶县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1159', N'东明县', N'区县', N'3', N'C124')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z116', N'桥东区', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1160', N'历下区', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1161', N'市中区', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1162', N'槐荫区', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1163', N'天桥区', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1164', N'历城区', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1165', N'长清区', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1166', N'平阴县', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1167', N'济阳县', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1168', N'商河县', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1169', N'章丘市', N'区县', N'3', N'C125')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z117', N'桥西区', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1170', N'市南区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1171', N'市北区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1172', N'四方区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1173', N'黄岛区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1174', N'崂山区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1175', N'李沧区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1176', N'城阳区', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1177', N'胶州市', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1178', N'即墨市', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1179', N'平度市', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z118', N'新华区', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1180', N'胶南市', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1181', N'莱西市', N'区县', N'3', N'C126')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1182', N'淄川区', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1183', N'张店区', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1184', N'博山区', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1185', N'临淄区', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1186', N'周村区', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1187', N'桓台县', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1188', N'高青县', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1189', N'沂源县', N'区县', N'3', N'C127')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z119', N'井陉矿区', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1190', N'德城区', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1191', N'陵县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1192', N'宁津县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1193', N'庆云县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1194', N'临邑县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1195', N'齐河县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1196', N'平原县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1197', N'夏津县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1198', N'武城县', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1199', N'乐陵市', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z12', N'顺义区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z120', N'裕华区', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1200', N'禹城市', N'区县', N'3', N'C128')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1201', N'芝罘区', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1202', N'福山区', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1203', N'牟平区', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1204', N'莱山区', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1205', N'长岛县', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1206', N'龙口市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1207', N'莱阳市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1208', N'莱州市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1209', N'蓬莱市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z121', N'井陉县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1210', N'招远市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1211', N'栖霞市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1212', N'海阳市', N'区县', N'3', N'C129')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1213', N'潍城区', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1214', N'寒亭区', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1215', N'坊子区', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1216', N'奎文区', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1217', N'临朐县', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1218', N'昌乐县', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1219', N'青州市', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z122', N'正定县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1220', N'诸城市', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1221', N'寿光市', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1222', N'安丘市', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1223', N'高密市', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1224', N'昌邑市', N'区县', N'3', N'C130')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1225', N'市中区', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1226', N'任城区', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1227', N'微山县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1228', N'鱼台县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1229', N'金乡县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z123', N'栾城县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1230', N'嘉祥县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1231', N'汶上县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1232', N'泗水县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1233', N'梁山县', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1234', N'曲阜市', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1235', N'兖州市', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1236', N'邹城市', N'区县', N'3', N'C131')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1237', N'泰山区', N'区县', N'3', N'C132')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1238', N'岱岳区', N'区县', N'3', N'C132')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1239', N'宁阳县', N'区县', N'3', N'C132')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z124', N'行唐县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1240', N'东平县', N'区县', N'3', N'C132')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1241', N'新泰市', N'区县', N'3', N'C132')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1242', N'肥城市', N'区县', N'3', N'C132')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1243', N'兰山区', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1244', N'罗庄区', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1245', N'河东区', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1246', N'沂南县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1247', N'郯城县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1248', N'沂水县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1249', N'苍山县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z125', N'灵寿县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1250', N'费县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1251', N'平邑县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1252', N'莒南县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1253', N'蒙阴县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1254', N'临沭县', N'区县', N'3', N'C133')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1255', N'滨城区', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1256', N'惠民县', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1257', N'阳信县', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1258', N'无棣县', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1259', N'沾化县', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z126', N'高邑县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1260', N'博兴县', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1261', N'邹平县', N'区县', N'3', N'C134')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1262', N'东营区', N'区县', N'3', N'C135')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1263', N'河口区', N'区县', N'3', N'C135')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1264', N'垦利县', N'区县', N'3', N'C135')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1265', N'利津县', N'区县', N'3', N'C135')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1266', N'广饶县', N'区县', N'3', N'C135')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1267', N'环翠区', N'区县', N'3', N'C136')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1268', N'文登市', N'区县', N'3', N'C136')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1269', N'荣成市', N'区县', N'3', N'C136')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z127', N'深泽县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1270', N'乳山市', N'区县', N'3', N'C136')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1271', N'市中区', N'区县', N'3', N'C137')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1272', N'薛城区', N'区县', N'3', N'C137')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1273', N'峄城区', N'区县', N'3', N'C137')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1274', N'台儿庄区', N'区县', N'3', N'C137')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1275', N'山亭区', N'区县', N'3', N'C137')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1276', N'滕州市', N'区县', N'3', N'C137')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1277', N'东港区', N'区县', N'3', N'C138')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1278', N'岚山区', N'区县', N'3', N'C138')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1279', N'五莲县', N'区县', N'3', N'C138')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z128', N'赞皇县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1280', N'莒县', N'区县', N'3', N'C138')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1281', N'莱城区', N'区县', N'3', N'C139')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1282', N'钢城区', N'区县', N'3', N'C139')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1283', N'东昌府区', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1284', N'阳谷县', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1285', N'莘县', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1286', N'茌平县', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1287', N'东阿县', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1288', N'冠县', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1289', N'高唐县', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z129', N'无极县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1290', N'临清市', N'区县', N'3', N'C140')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1291', N'梁园区', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1292', N'睢阳区', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1293', N'民权县', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1294', N'睢县', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1295', N'宁陵县', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1296', N'柘城县', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1297', N'虞城县', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1298', N'夏邑县', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1299', N'永城市', N'区县', N'3', N'C141')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z13', N'昌平区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z130', N'平山县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1300', N'中原区', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1301', N'二七区', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1302', N'管城回族区', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1303', N'金水区', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1304', N'上街区', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1305', N'惠济区', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1306', N'中牟县', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1307', N'巩义市', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1308', N'荥阳市', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1309', N'新密市', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z131', N'元氏县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1310', N'新郑市', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1311', N'登封市', N'区县', N'3', N'C142')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1312', N'文峰区', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1313', N'北关区', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1314', N'殷都区', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1315', N'龙安区', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1316', N'安阳县', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1317', N'汤阴县', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1318', N'滑县', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1319', N'内黄县', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z132', N'赵县', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1320', N'林州市', N'区县', N'3', N'C143')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1321', N'红旗区', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1322', N'卫滨区', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1323', N'凤泉区', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1324', N'牧野区', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1325', N'新乡县', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1326', N'获嘉县', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1327', N'原阳县', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1328', N'延津县', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1329', N'封丘县', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z133', N'辛集市', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1330', N'长垣县', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1331', N'卫辉市', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1332', N'辉县市', N'区县', N'3', N'C144')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1333', N'魏都区', N'区县', N'3', N'C145')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1334', N'许昌县', N'区县', N'3', N'C145')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1335', N'鄢陵县', N'区县', N'3', N'C145')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1336', N'襄城县', N'区县', N'3', N'C145')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1337', N'禹州市', N'区县', N'3', N'C145')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1338', N'长葛市', N'区县', N'3', N'C145')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1339', N'新华区', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z134', N'藁城市', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1340', N'卫东区', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1341', N'石龙区', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1342', N'湛河区', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1343', N'宝丰县', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1344', N'叶县', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1345', N'鲁山县', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1346', N'郏县', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1347', N'舞钢市', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1348', N'汝州市', N'区县', N'3', N'C146')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1349', N'浉河区', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z135', N'晋州市', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1350', N'平桥区', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1351', N'罗山县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1352', N'光山县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1353', N'新县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1354', N'商城县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1355', N'固始县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1356', N'潢川县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1357', N'淮滨县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1358', N'息县', N'区县', N'3', N'C147')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1359', N'宛城区', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z136', N'新乐市', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1360', N'卧龙区', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1361', N'南召县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1362', N'方城县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1363', N'西峡县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1364', N'镇平县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1365', N'内乡县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1366', N'淅川县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1367', N'社旗县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1368', N'唐河县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1369', N'新野县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z137', N'鹿泉市', N'区县', N'3', N'C6')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1370', N'桐柏县', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1371', N'邓州市', N'区县', N'3', N'C148')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1372', N'龙亭区', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1373', N'顺河回族区', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1374', N'鼓楼区', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1375', N'禹王台区', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1376', N'金明区', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1377', N'杞县', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1378', N'通许县', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1379', N'尉氏县', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z138', N'新市区', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1380', N'开封县', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1381', N'兰考县', N'区县', N'3', N'C149')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1382', N'老城区', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1383', N'西工区', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1384', N'瀍河回族区', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1385', N'涧西区', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1386', N'吉利区', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1387', N'洛龙区', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1388', N'孟津县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1389', N'新安县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z139', N'北市区', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1390', N'栾川县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1391', N'嵩县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1392', N'汝阳县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1393', N'宜阳县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1394', N'洛宁县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1395', N'伊川县', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1396', N'偃师市', N'区县', N'3', N'C150')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1397', N'解放区', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1398', N'中站区', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1399', N'马村区', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z14', N'大兴区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z140', N'南市区', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1400', N'山阳区', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1401', N'修武县', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1402', N'博爱县', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1403', N'武陟县', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1404', N'温县', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1405', N'沁阳市', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1406', N'孟州市', N'区县', N'3', N'C152')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1407', N'鹤山区', N'区县', N'3', N'C153')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1408', N'山城区', N'区县', N'3', N'C153')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1409', N'淇滨区', N'区县', N'3', N'C153')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z141', N'满城县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1410', N'浚县', N'区县', N'3', N'C153')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1411', N'淇县', N'区县', N'3', N'C153')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1412', N'华龙区', N'区县', N'3', N'C154')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1413', N'清丰县', N'区县', N'3', N'C154')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1414', N'南乐县', N'区县', N'3', N'C154')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1415', N'范县', N'区县', N'3', N'C154')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1416', N'台前县', N'区县', N'3', N'C154')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1417', N'濮阳县', N'区县', N'3', N'C154')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1418', N'川汇区', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1419', N'扶沟县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z142', N'清苑县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1420', N'西华县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1421', N'商水县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1422', N'沈丘县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1423', N'郸城县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1424', N'淮阳县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1425', N'太康县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1426', N'鹿邑县', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1427', N'项城市', N'区县', N'3', N'C155')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1428', N'源汇区', N'区县', N'3', N'C156')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1429', N'郾城区', N'区县', N'3', N'C156')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z143', N'涞水县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1430', N'召陵区', N'区县', N'3', N'C156')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1431', N'舞阳县', N'区县', N'3', N'C156')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1432', N'临颍县', N'区县', N'3', N'C156')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1433', N'驿城区', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1434', N'西平县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1435', N'上蔡县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1436', N'平舆县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1437', N'正阳县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1438', N'确山县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1439', N'泌阳县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z144', N'阜平县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1440', N'汝南县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1441', N'遂平县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1442', N'新蔡县', N'区县', N'3', N'C157')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1443', N'湖滨区', N'区县', N'3', N'C158')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1444', N'渑池县', N'区县', N'3', N'C158')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1445', N'陕县', N'区县', N'3', N'C158')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1446', N'卢氏县', N'区县', N'3', N'C158')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1447', N'义马市', N'区县', N'3', N'C158')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1448', N'灵宝市', N'区县', N'3', N'C158')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1449', N'江岸区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z145', N'徐水县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1450', N'江汉区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1451', N'硚口区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1452', N'汉阳区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1453', N'武昌区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1454', N'青山区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1455', N'洪山区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1456', N'东西湖区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1457', N'汉南区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1458', N'蔡甸区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1459', N'江夏区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z146', N'定兴县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1460', N'黄陂区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1461', N'新洲区', N'区县', N'3', N'C159')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1462', N'襄城区', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1463', N'樊城区', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1464', N'襄阳区', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1465', N'南漳县', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1466', N'谷城县', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1467', N'保康县', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1468', N'老河口市', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1469', N'枣阳市', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z147', N'唐县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1470', N'宜城市', N'区县', N'3', N'C160')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1471', N'梁子湖区', N'区县', N'3', N'C161')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1472', N'华容区', N'区县', N'3', N'C161')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1473', N'鄂城区', N'区县', N'3', N'C161')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1474', N'孝南区', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1475', N'孝昌县', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1476', N'大悟县', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1477', N'云梦县', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1478', N'应城市', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1479', N'安陆市', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z148', N'高阳县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1480', N'汉川市', N'区县', N'3', N'C162')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1481', N'黄州区', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1482', N'团风县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1483', N'红安县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1484', N'罗田县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1485', N'英山县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1486', N'浠水县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1487', N'蕲春县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1488', N'黄梅县', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1489', N'麻城市', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z149', N'容城县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1490', N'武穴市', N'区县', N'3', N'C163')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1491', N'黄石港区', N'区县', N'3', N'C164')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1492', N'西塞山区', N'区县', N'3', N'C164')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1493', N'下陆区', N'区县', N'3', N'C164')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1494', N'铁山区', N'区县', N'3', N'C164')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1495', N'阳新县', N'区县', N'3', N'C164')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1496', N'大冶市', N'区县', N'3', N'C164')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1497', N'咸安区', N'区县', N'3', N'C165')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1498', N'嘉鱼县', N'区县', N'3', N'C165')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1499', N'通城县', N'区县', N'3', N'C165')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z15', N'怀柔区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z150', N'涞源县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1500', N'崇阳县', N'区县', N'3', N'C165')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1501', N'通山县', N'区县', N'3', N'C165')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1502', N'赤壁市', N'区县', N'3', N'C165')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1503', N'沙市区', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1504', N'荆州区', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1505', N'公安县', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1506', N'监利县', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1507', N'江陵县', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1508', N'石首市', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1509', N'洪湖市', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z151', N'望都县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1510', N'松滋市', N'区县', N'3', N'C166')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1511', N'西陵区', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1512', N'伍家岗区', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1513', N'点军区', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1514', N'猇亭区', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1515', N'夷陵区', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1516', N'远安县', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1517', N'兴山县', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1518', N'秭归县', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1519', N'长阳土家族自治县', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z152', N'安新县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1520', N'五峰土家族自治县', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1521', N'宜都市', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1522', N'当阳市', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1523', N'枝江市', N'区县', N'3', N'C167')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1524', N'恩施市', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1525', N'利川市', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1526', N'建始县', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1527', N'巴东县', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1528', N'宣恩县', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1529', N'咸丰县', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z153', N'易县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1530', N'来凤县', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1531', N'鹤峰县', N'区县', N'3', N'C168')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1532', N'茅箭区', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1533', N'张湾区', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1534', N'郧县', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1535', N'郧西县', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1536', N'竹山县', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1537', N'竹溪县', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1538', N'房县', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1539', N'丹江口市', N'区县', N'3', N'C170')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z154', N'曲阳县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1540', N'曾都区', N'区县', N'3', N'C171')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1541', N'广水市', N'区县', N'3', N'C171')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1542', N'东宝区', N'区县', N'3', N'C172')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1543', N'掇刀区', N'区县', N'3', N'C172')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1544', N'京山县', N'区县', N'3', N'C172')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1545', N'沙洋县', N'区县', N'3', N'C172')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1546', N'钟祥市', N'区县', N'3', N'C172')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1547', N'岳阳楼区', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1548', N'云溪区', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1549', N'君山区', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z155', N'蠡县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1550', N'岳阳县', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1551', N'华容县', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1552', N'湘阴县', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1553', N'平江县', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1554', N'汨罗市', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1555', N'临湘市', N'区县', N'3', N'C176')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1556', N'芙蓉区', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1557', N'天心区', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1558', N'岳麓区', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1559', N'开福区', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z156', N'顺平县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1560', N'雨花区', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1561', N'长沙县', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1562', N'望城县', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1563', N'宁乡县', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1564', N'浏阳市', N'区县', N'3', N'C177')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1565', N'雨湖区', N'区县', N'3', N'C178')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1566', N'岳塘区', N'区县', N'3', N'C178')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1567', N'湘潭县', N'区县', N'3', N'C178')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1568', N'湘乡市', N'区县', N'3', N'C178')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1569', N'韶山市', N'区县', N'3', N'C178')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z157', N'博野县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1570', N'荷塘区', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1571', N'芦淞区', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1572', N'石峰区', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1573', N'天元区', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1574', N'株洲县', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1575', N'攸县', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1576', N'茶陵县', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1577', N'炎陵县', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1578', N'醴陵市', N'区县', N'3', N'C179')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1579', N'珠晖区', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z158', N'雄县', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1580', N'雁峰区', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1581', N'石鼓区', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1582', N'蒸湘区', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1583', N'南岳区', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1584', N'衡阳县', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1585', N'衡南县', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1586', N'衡山县', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1587', N'衡东县', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1588', N'祁东县', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1589', N'耒阳市', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z159', N'涿州市', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1590', N'常宁市', N'区县', N'3', N'C180')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1591', N'北湖区', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1592', N'苏仙区', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1593', N'桂阳县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1594', N'宜章县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1595', N'永兴县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1596', N'嘉禾县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1597', N'临武县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1598', N'汝城县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1599', N'桂东县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z16', N'平谷区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z160', N'定州市', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1600', N'安仁县', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1601', N'资兴市', N'区县', N'3', N'C181')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1602', N'武陵区', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1603', N'鼎城区', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1604', N'安乡县', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1605', N'汉寿县', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1606', N'澧县', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1607', N'临澧县', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1608', N'桃源县', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1609', N'石门县', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z161', N'安国市', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1610', N'津市市', N'区县', N'3', N'C182')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1611', N'资阳区', N'区县', N'3', N'C183')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1612', N'赫山区', N'区县', N'3', N'C183')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1613', N'南县', N'区县', N'3', N'C183')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1614', N'桃江县', N'区县', N'3', N'C183')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1615', N'安化县', N'区县', N'3', N'C183')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1616', N'沅江市', N'区县', N'3', N'C183')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1617', N'娄星区', N'区县', N'3', N'C184')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1618', N'双峰县', N'区县', N'3', N'C184')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1619', N'新化县', N'区县', N'3', N'C184')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z162', N'高碑店市', N'区县', N'3', N'C7')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1620', N'冷水江市', N'区县', N'3', N'C184')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1621', N'涟源市', N'区县', N'3', N'C184')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1622', N'双清区', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1623', N'大祥区', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1624', N'北塔区', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1625', N'邵东县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1626', N'新邵县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1627', N'邵阳县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1628', N'隆回县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1629', N'洞口县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z163', N'桥东区', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1630', N'绥宁县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1631', N'新宁县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1632', N'城步苗族自治县', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1633', N'武冈市', N'区县', N'3', N'C185')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1634', N'吉首市', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1635', N'泸溪县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1636', N'凤凰县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1637', N'花垣县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1638', N'保靖县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1639', N'古丈县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z164', N'桥西区', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1640', N'永顺县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1641', N'龙山县', N'区县', N'3', N'C186')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1642', N'永定区', N'区县', N'3', N'C187')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1643', N'武陵源区', N'区县', N'3', N'C187')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1644', N'慈利县', N'区县', N'3', N'C187')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1645', N'桑植县', N'区县', N'3', N'C187')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1646', N'鹤城区', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1647', N'中方县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1648', N'沅陵县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1649', N'辰溪县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z165', N'宣化区', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1650', N'溆浦县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1651', N'会同县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1652', N'麻阳苗族自治县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1653', N'新晃侗族自治县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1654', N'芷江侗族自治县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1655', N'靖州苗族侗族自治县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1656', N'通道侗族自治县', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1657', N'洪江市', N'区县', N'3', N'C188')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1658', N'零陵区', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1659', N'冷水滩区', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z166', N'下花园区', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1660', N'祁阳县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1661', N'东安县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1662', N'双牌县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1663', N'道县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1664', N'江永县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1665', N'宁远县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1666', N'蓝山县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1667', N'新田县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1668', N'江华瑶族自治县', N'区县', N'3', N'C189')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1669', N'从化市', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z167', N'宣化县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1670', N'荔湾区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1671', N'越秀区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1672', N'海珠区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1673', N'天河区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1674', N'白云区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1675', N'花都区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1676', N'黄埔区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1677', N'萝岗区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1678', N'南沙区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1679', N'番禺区', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z168', N'张北县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1680', N'增城市', N'区县', N'3', N'C190')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1681', N'海丰县', N'区县', N'3', N'C191')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1682', N'陆河县', N'区县', N'3', N'C191')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1683', N'陆丰市', N'区县', N'3', N'C191')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1684', N'江城区', N'区县', N'3', N'C192')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1685', N'阳西县', N'区县', N'3', N'C192')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1686', N'阳东县', N'区县', N'3', N'C192')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1687', N'阳春市', N'区县', N'3', N'C192')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1688', N'榕城区', N'区县', N'3', N'C193')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1689', N'揭东县', N'区县', N'3', N'C193')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z169', N'康保县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1690', N'揭西县', N'区县', N'3', N'C193')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1691', N'惠来县', N'区县', N'3', N'C193')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1692', N'普宁市', N'区县', N'3', N'C193')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1693', N'茂南区', N'区县', N'3', N'C194')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1694', N'茂港区', N'区县', N'3', N'C194')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1695', N'电白县', N'区县', N'3', N'C194')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1696', N'高州市', N'区县', N'3', N'C194')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1697', N'化州市', N'区县', N'3', N'C194')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1698', N'信宜市', N'区县', N'3', N'C194')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1699', N'惠城区', N'区县', N'3', N'C195')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z17', N'密云县', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z170', N'沽源县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1700', N'惠阳区', N'区县', N'3', N'C195')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1701', N'博罗县', N'区县', N'3', N'C195')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1702', N'惠东县', N'区县', N'3', N'C195')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1703', N'龙门县', N'区县', N'3', N'C195')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1704', N'蓬江区', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1705', N'江海区', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1706', N'新会区', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1707', N'台山市', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1708', N'开平市', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1709', N'鹤山市', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z171', N'尚义县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1710', N'恩平市', N'区县', N'3', N'C196')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1711', N'武江区', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1712', N'浈江区', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1713', N'曲江区', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1714', N'始兴县', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1715', N'仁化县', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1716', N'翁源县', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1717', N'乳源瑶族自治县', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1718', N'新丰县', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1719', N'乐昌市', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z172', N'蔚县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1720', N'南雄市', N'区县', N'3', N'C197')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1721', N'梅江区', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1722', N'梅县', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1723', N'大埔县', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1724', N'丰顺县', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1725', N'五华县', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1726', N'平远县', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1727', N'蕉岭县', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1728', N'兴宁市', N'区县', N'3', N'C198')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1729', N'龙湖区', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z173', N'阳原县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1730', N'金平区', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1731', N'濠江区', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1732', N'潮阳区', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1733', N'潮南区', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1734', N'澄海区', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1735', N'南澳县', N'区县', N'3', N'C199')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1736', N'罗湖区', N'区县', N'3', N'C200')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1737', N'福田区', N'区县', N'3', N'C200')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1738', N'南山区', N'区县', N'3', N'C200')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1739', N'宝安区', N'区县', N'3', N'C200')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z174', N'怀安县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1740', N'龙岗区', N'区县', N'3', N'C200')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1741', N'盐田区', N'区县', N'3', N'C200')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1742', N'香洲区', N'区县', N'3', N'C201')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1743', N'斗门区', N'区县', N'3', N'C201')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1744', N'金湾区', N'区县', N'3', N'C201')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1745', N'禅城区', N'区县', N'3', N'C202')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1746', N'南海区', N'区县', N'3', N'C202')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1747', N'顺德区', N'区县', N'3', N'C202')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1748', N'三水区', N'区县', N'3', N'C202')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1749', N'高明区', N'区县', N'3', N'C202')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z175', N'万全县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1750', N'端州区', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1751', N'鼎湖区', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1752', N'广宁县', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1753', N'怀集县', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1754', N'封开县', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1755', N'德庆县', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1756', N'高要市', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1757', N'四会市', N'区县', N'3', N'C203')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1758', N'赤坎区', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1759', N'霞山区', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z176', N'怀来县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1760', N'坡头区', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1761', N'麻章区', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1762', N'遂溪县', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1763', N'徐闻县', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1764', N'廉江市', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1765', N'雷州市', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1766', N'吴川市', N'区县', N'3', N'C204')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1767', N'源城区', N'区县', N'3', N'C206')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1768', N'紫金县', N'区县', N'3', N'C206')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1769', N'龙川县', N'区县', N'3', N'C206')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z177', N'涿鹿县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1770', N'连平县', N'区县', N'3', N'C206')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1771', N'和平县', N'区县', N'3', N'C206')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1772', N'东源县', N'区县', N'3', N'C206')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1773', N'清城区', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1774', N'佛冈县', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1775', N'阳山县', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1776', N'连山壮族瑶族自治县', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1777', N'连南瑶族自治县', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1778', N'清新县', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1779', N'英德市', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z178', N'赤城县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1780', N'连州市', N'区县', N'3', N'C207')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1781', N'云城区', N'区县', N'3', N'C208')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1782', N'新兴县', N'区县', N'3', N'C208')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1783', N'郁南县', N'区县', N'3', N'C208')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1784', N'云安县', N'区县', N'3', N'C208')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1785', N'罗定市', N'区县', N'3', N'C208')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1786', N'湘桥区', N'区县', N'3', N'C209')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1787', N'潮安县', N'区县', N'3', N'C209')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1788', N'饶平县', N'区县', N'3', N'C209')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1789', N'城关区', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z179', N'崇礼县', N'区县', N'3', N'C8')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1790', N'七里河区', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1791', N'西固区', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1792', N'安宁区', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1793', N'红古区', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1794', N'永登县', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1795', N'皋兰县', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1796', N'榆中县', N'区县', N'3', N'C211')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1797', N'金川区', N'区县', N'3', N'C212')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1798', N'永昌县', N'区县', N'3', N'C212')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1799', N'白银区', N'区县', N'3', N'C213')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z18', N'延庆县', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z180', N'双桥区', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1800', N'平川区', N'区县', N'3', N'C213')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1801', N'靖远县', N'区县', N'3', N'C213')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1802', N'会宁县', N'区县', N'3', N'C213')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1803', N'景泰县', N'区县', N'3', N'C213')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1804', N'秦州区', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1805', N'麦积区', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1806', N'清水县', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1807', N'秦安县', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1808', N'甘谷县', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1809', N'武山县', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z181', N'双滦区', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1810', N'张家川回族自治县', N'区县', N'3', N'C214')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1811', N'凉州区', N'区县', N'3', N'C216')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1812', N'民勤县', N'区县', N'3', N'C216')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1813', N'古浪县', N'区县', N'3', N'C216')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1814', N'天祝藏族自治县', N'区县', N'3', N'C216')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1815', N'甘州区', N'区县', N'3', N'C217')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1816', N'肃南裕固族自治县', N'区县', N'3', N'C217')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1817', N'民乐县', N'区县', N'3', N'C217')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1818', N'临泽县', N'区县', N'3', N'C217')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1819', N'高台县', N'区县', N'3', N'C217')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z182', N'鹰手营子矿区', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1820', N'山丹县', N'区县', N'3', N'C217')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1821', N'崆峒区', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1822', N'泾川县', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1823', N'灵台县', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1824', N'崇信县', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1825', N'华亭县', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1826', N'庄浪县', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1827', N'静宁县', N'区县', N'3', N'C218')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1828', N'肃州区', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1829', N'金塔县', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z183', N'承德县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1830', N'瓜州县', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1831', N'肃北蒙古族自治县', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1832', N'阿克塞哈萨克族自治县', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1833', N'玉门市', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1834', N'敦煌市', N'区县', N'3', N'C219')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1835', N'西峰区', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1836', N'庆城县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1837', N'环县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1838', N'华池县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1839', N'合水县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z184', N'兴隆县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1840', N'正宁县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1841', N'宁县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1842', N'镇原县', N'区县', N'3', N'C220')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1843', N'安定区', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1844', N'通渭县', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1845', N'陇西县', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1846', N'渭源县', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1847', N'临洮县', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1848', N'漳县', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1849', N'岷县', N'区县', N'3', N'C221')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z185', N'平泉县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1850', N'武都区', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1851', N'成县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1852', N'文县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1853', N'宕昌县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1854', N'康县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1855', N'西和县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1856', N'礼县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1857', N'徽县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1858', N'两当县', N'区县', N'3', N'C222')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1859', N'临夏市', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z186', N'滦平县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1860', N'临夏县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1861', N'康乐县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1862', N'永靖县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1863', N'广河县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1864', N'和政县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1865', N'东乡族自治县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1866', N'积石山保安族东乡族撒拉族自治县', N'区县', N'3', N'C223')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1867', N'合作市', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1868', N'临潭县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1869', N'卓尼县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z187', N'隆化县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1870', N'舟曲县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1871', N'迭部县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1872', N'玛曲县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1873', N'碌曲县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1874', N'夏河县', N'区县', N'3', N'C224')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1875', N'锦江区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1876', N'青羊区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1877', N'金牛区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1878', N'武侯区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1879', N'成华区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z188', N'丰宁满族自治县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1880', N'龙泉驿区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1881', N'青白江区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1882', N'新都区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1883', N'温江区', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1884', N'金堂县', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1885', N'双流县', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1886', N'郫县', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1887', N'大邑县', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1888', N'蒲江县', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1889', N'新津县', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z189', N'宽城满族自治县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1890', N'都江堰市', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1891', N'彭州市', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1892', N'邛崃市', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1893', N'崇州市', N'区县', N'3', N'C225')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1894', N'东区', N'区县', N'3', N'C226')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1895', N'西区', N'区县', N'3', N'C226')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1896', N'仁和区', N'区县', N'3', N'C226')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1897', N'米易县', N'区县', N'3', N'C226')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1898', N'盐边县', N'区县', N'3', N'C226')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1899', N'自流井区', N'区县', N'3', N'C227')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z19', N'和平区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z190', N'围场满族蒙古族自治县', N'区县', N'3', N'C9')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1900', N'贡井区', N'区县', N'3', N'C227')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1901', N'大安区', N'区县', N'3', N'C227')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1902', N'沿滩区', N'区县', N'3', N'C227')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1903', N'荣县', N'区县', N'3', N'C227')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1904', N'富顺县', N'区县', N'3', N'C227')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1905', N'涪城区', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1906', N'游仙区', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1907', N'三台县', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1908', N'盐亭县', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1909', N'安县', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z191', N'路南区', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1910', N'梓潼县', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1911', N'北川羌族自治县', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1912', N'平武县', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1913', N'江油市', N'区县', N'3', N'C228')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1914', N'顺庆区', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1915', N'高坪区', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1916', N'嘉陵区', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1917', N'南部县', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1918', N'营山县', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1919', N'蓬安县', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z192', N'路北区', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1920', N'仪陇县', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1921', N'西充县', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1922', N'阆中市', N'区县', N'3', N'C229')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1923', N'通川区', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1924', N'达县', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1925', N'宣汉县', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1926', N'开江县', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1927', N'大竹县', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1928', N'渠县', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1929', N'万源市', N'区县', N'3', N'C230')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z193', N'古冶区', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1930', N'船山区', N'区县', N'3', N'C231')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1931', N'安居区', N'区县', N'3', N'C231')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1932', N'蓬溪县', N'区县', N'3', N'C231')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1933', N'射洪县', N'区县', N'3', N'C231')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1934', N'大英县', N'区县', N'3', N'C231')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1935', N'广安区', N'区县', N'3', N'C232')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1936', N'岳池县', N'区县', N'3', N'C232')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1937', N'武胜县', N'区县', N'3', N'C232')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1938', N'邻水县', N'区县', N'3', N'C232')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1939', N'华蓥市', N'区县', N'3', N'C232')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z194', N'开平区', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1940', N'巴州区', N'区县', N'3', N'C233')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1941', N'通江县', N'区县', N'3', N'C233')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1942', N'南江县', N'区县', N'3', N'C233')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1943', N'平昌县', N'区县', N'3', N'C233')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1944', N'江阳区', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1945', N'纳溪区', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1946', N'龙马潭区', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1947', N'泸县', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1948', N'合江县', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1949', N'叙永县', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z195', N'丰南区', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1950', N'古蔺县', N'区县', N'3', N'C234')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1951', N'翠屏区', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1952', N'宜宾县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1953', N'南溪县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1954', N'江安县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1955', N'长宁县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1956', N'高县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1957', N'珙县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1958', N'筠连县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1959', N'兴文县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z196', N'丰润区', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1960', N'屏山县', N'区县', N'3', N'C235')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1961', N'雁江区', N'区县', N'3', N'C236')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1962', N'安岳县', N'区县', N'3', N'C236')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1963', N'乐至县', N'区县', N'3', N'C236')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1964', N'简阳市', N'区县', N'3', N'C236')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1965', N'市中区', N'区县', N'3', N'C237')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1966', N'东兴区', N'区县', N'3', N'C237')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1967', N'威远县', N'区县', N'3', N'C237')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1968', N'资中县', N'区县', N'3', N'C237')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1969', N'隆昌县', N'区县', N'3', N'C237')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z197', N'滦县', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1970', N'市中区', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1971', N'沙湾区', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1972', N'五通桥区', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1973', N'金口河区', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1974', N'犍为县', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1975', N'井研县', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1976', N'夹江县', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1977', N'沐川县', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1978', N'峨边彝族自治县', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1979', N'马边彝族自治县', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z198', N'滦南县', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1980', N'峨眉山市', N'区县', N'3', N'C238')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1981', N'东坡区', N'区县', N'3', N'C239')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1982', N'仁寿县', N'区县', N'3', N'C239')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1983', N'彭山县', N'区县', N'3', N'C239')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1984', N'洪雅县', N'区县', N'3', N'C239')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1985', N'丹棱县', N'区县', N'3', N'C239')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1986', N'青神县', N'区县', N'3', N'C239')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1987', N'西昌市', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1988', N'木里藏族自治县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1989', N'盐源县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z199', N'乐亭县', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1990', N'德昌县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1991', N'会理县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1992', N'会东县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1993', N'宁南县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1994', N'普格县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1995', N'布拖县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1996', N'金阳县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1997', N'昭觉县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1998', N'喜德县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z1999', N'冕宁县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2', N'西城区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z20', N'河东区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z200', N'迁西县', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2000', N'越西县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2001', N'甘洛县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2002', N'美姑县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2003', N'雷波县', N'区县', N'3', N'C240')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2004', N'雨城区', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2005', N'名山县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2006', N'荥经县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2007', N'汉源县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2008', N'石棉县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2009', N'天全县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z201', N'玉田县', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2010', N'芦山县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2011', N'宝兴县', N'区县', N'3', N'C241')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2012', N'康定县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2013', N'泸定县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2014', N'丹巴县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2015', N'九龙县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2016', N'雅江县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2017', N'道孚县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2018', N'炉霍县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2019', N'甘孜县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z202', N'唐海县', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2020', N'新龙县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2021', N'德格县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2022', N'白玉县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2023', N'石渠县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2024', N'色达县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2025', N'理塘县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2026', N'巴塘县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2027', N'乡城县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2028', N'稻城县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2029', N'得荣县', N'区县', N'3', N'C242')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z203', N'遵化市', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2030', N'汶川县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2031', N'理县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2032', N'茂县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2033', N'松潘县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2034', N'九寨沟县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2035', N'金川县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2036', N'小金县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2037', N'黑水县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2038', N'马尔康县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2039', N'壤塘县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z204', N'迁安市', N'区县', N'3', N'C10')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2040', N'阿坝县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2041', N'若尔盖县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2042', N'红原县', N'区县', N'3', N'C243')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2043', N'旌阳区', N'区县', N'3', N'C244')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2044', N'中江县', N'区县', N'3', N'C244')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2045', N'罗江县', N'区县', N'3', N'C244')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2046', N'广汉市', N'区县', N'3', N'C244')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2047', N'什邡市', N'区县', N'3', N'C244')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2048', N'绵竹市', N'区县', N'3', N'C244')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2049', N'市中区', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z205', N'安次区', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2050', N'元坝区', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2051', N'朝天区', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2052', N'旺苍县', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2053', N'青川县', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2054', N'剑阁县', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2055', N'苍溪县', N'区县', N'3', N'C245')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2056', N'南明区', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2057', N'云岩区', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2058', N'花溪区', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2059', N'乌当区', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z206', N'广阳区', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2060', N'白云区', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2061', N'小河区', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2062', N'开阳县', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2063', N'息烽县', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2064', N'修文县', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2065', N'清镇市', N'区县', N'3', N'C246')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2066', N'红花岗区', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2067', N'汇川区', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2068', N'遵义县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2069', N'桐梓县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z207', N'固安县', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2070', N'绥阳县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2071', N'正安县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2072', N'道真仡佬族苗族自治县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2073', N'务川仡佬族苗族自治县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2074', N'凤冈县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2075', N'湄潭县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2076', N'余庆县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2077', N'习水县', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2078', N'赤水市', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2079', N'仁怀市', N'区县', N'3', N'C247')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z208', N'永清县', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2080', N'西秀区', N'区县', N'3', N'C248')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2081', N'平坝县', N'区县', N'3', N'C248')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2082', N'普定县', N'区县', N'3', N'C248')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2083', N'镇宁布依族苗族自治县', N'区县', N'3', N'C248')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2084', N'关岭布依族苗族自治县', N'区县', N'3', N'C248')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2085', N'紫云苗族布依族自治县', N'区县', N'3', N'C248')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2086', N'都匀市', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2087', N'福泉市', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2088', N'荔波县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2089', N'贵定县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z209', N'香河县', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2090', N'瓮安县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2091', N'独山县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2092', N'平塘县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2093', N'罗甸县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2094', N'长顺县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2095', N'龙里县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2096', N'惠水县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2097', N'三都水族自治县', N'区县', N'3', N'C249')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2098', N'凯里市', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2099', N'黄平县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z21', N'河西区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z210', N'大城县', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2100', N'施秉县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2101', N'三穗县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2102', N'镇远县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2103', N'岑巩县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2104', N'天柱县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2105', N'锦屏县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2106', N'剑河县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2107', N'台江县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2108', N'黎平县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2109', N'榕江县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z211', N'文安县', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2110', N'从江县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2111', N'雷山县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2112', N'麻江县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2113', N'丹寨县', N'区县', N'3', N'C250')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2114', N'铜仁市', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2115', N'江口县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2116', N'玉屏侗族自治县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2117', N'石阡县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2118', N'思南县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2119', N'印江土家族苗族自治县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z212', N'大厂回族自治县', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2120', N'德江县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2121', N'沿河土家族自治县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2122', N'松桃苗族自治县', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2123', N'万山特区', N'区县', N'3', N'C251')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2124', N'毕节市', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2125', N'大方县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2126', N'黔西县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2127', N'金沙县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2128', N'织金县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2129', N'纳雍县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z213', N'霸州市', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2130', N'威宁彝族回族苗族自治县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2131', N'赫章县', N'区县', N'3', N'C252')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2132', N'钟山区', N'区县', N'3', N'C253')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2133', N'六枝特区', N'区县', N'3', N'C253')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2134', N'水城县', N'区县', N'3', N'C253')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2135', N'盘县', N'区县', N'3', N'C253')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2136', N'兴义市', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2137', N'兴仁县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2138', N'普安县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2139', N'晴隆县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z214', N'三河市', N'区县', N'3', N'C11')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2140', N'贞丰县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2141', N'望谟县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2142', N'册亨县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2143', N'安龙县', N'区县', N'3', N'C254')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2144', N'秀英区', N'区县', N'3', N'C255')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2145', N'龙华区', N'区县', N'3', N'C255')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2146', N'琼山区', N'区县', N'3', N'C255')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2147', N'美兰区', N'区县', N'3', N'C255')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2148', N'景洪市', N'区县', N'3', N'C273')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2149', N'勐海县', N'区县', N'3', N'C273')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z215', N'新华区', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2150', N'勐腊县', N'区县', N'3', N'C273')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2151', N'瑞丽市', N'区县', N'3', N'C274')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2152', N'潞西市', N'区县', N'3', N'C274')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2153', N'梁河县', N'区县', N'3', N'C274')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2154', N'盈江县', N'区县', N'3', N'C274')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2155', N'陇川县', N'区县', N'3', N'C274')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2156', N'昭阳区', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2157', N'鲁甸县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2158', N'巧家县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2159', N'盐津县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z216', N'运河区', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2160', N'大关县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2161', N'永善县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2162', N'绥江县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2163', N'镇雄县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2164', N'彝良县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2165', N'威信县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2166', N'水富县', N'区县', N'3', N'C275')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2167', N'五华区', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2168', N'盘龙区', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2169', N'官渡区', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z217', N'沧县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2170', N'西山区', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2171', N'东川区', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2172', N'呈贡县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2173', N'晋宁县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2174', N'富民县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2175', N'宜良县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2176', N'石林彝族自治县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2177', N'嵩明县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2178', N'禄劝彝族苗族自治县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2179', N'寻甸回族彝族自治县', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z218', N'青县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2180', N'安宁市', N'区县', N'3', N'C276')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2181', N'大理市', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2182', N'漾濞彝族自治县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2183', N'祥云县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2184', N'宾川县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2185', N'弥渡县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2186', N'南涧彝族自治县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2187', N'巍山彝族回族自治县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2188', N'永平县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2189', N'云龙县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z219', N'东光县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2190', N'洱源县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2191', N'剑川县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2192', N'鹤庆县', N'区县', N'3', N'C277')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2193', N'个旧市', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2194', N'开远市', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2195', N'蒙自县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2196', N'屏边苗族自治县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2197', N'建水县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2198', N'石屏县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2199', N'弥勒县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z22', N'南开区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z220', N'海兴县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2200', N'泸西县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2201', N'元阳县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2202', N'红河县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2203', N'金平苗族瑶族傣族自治县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2204', N'绿春县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2205', N'河口瑶族自治县', N'区县', N'3', N'C278')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2206', N'麒麟区', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2207', N'马龙县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2208', N'陆良县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2209', N'师宗县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z221', N'盐山县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2210', N'罗平县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2211', N'富源县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2212', N'会泽县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2213', N'沾益县', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2214', N'宣威市', N'区县', N'3', N'C279')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2215', N'隆阳区', N'区县', N'3', N'C280')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2216', N'施甸县', N'区县', N'3', N'C280')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2217', N'腾冲县', N'区县', N'3', N'C280')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2218', N'龙陵县', N'区县', N'3', N'C280')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2219', N'昌宁县', N'区县', N'3', N'C280')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z222', N'肃宁县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2220', N'文山县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2221', N'砚山县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2222', N'西畴县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2223', N'麻栗坡县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2224', N'马关县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2225', N'丘北县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2226', N'广南县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2227', N'富宁县', N'区县', N'3', N'C281')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2228', N'红塔区', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2229', N'江川县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z223', N'南皮县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2230', N'澄江县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2231', N'通海县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2232', N'华宁县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2233', N'易门县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2234', N'峨山彝族自治县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2235', N'新平彝族傣族自治县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2236', N'元江哈尼族彝族傣族自治县', N'区县', N'3', N'C282')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2237', N'楚雄市', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2238', N'双柏县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2239', N'牟定县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z224', N'吴桥县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2240', N'南华县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2241', N'姚安县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2242', N'大姚县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2243', N'永仁县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2244', N'元谋县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2245', N'武定县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2246', N'禄丰县', N'区县', N'3', N'C283')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2247', N'思茅区', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2248', N'宁洱哈尼族彝族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2249', N'墨江哈尼族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z225', N'献县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2250', N'景东彝族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2251', N'景谷傣族彝族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2252', N'镇沅彝族哈尼族拉祜族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2253', N'江城哈尼族彝族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2254', N'孟连傣族拉祜族佤族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2255', N'澜沧拉祜族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2256', N'西盟佤族自治县', N'区县', N'3', N'C284')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2257', N'临翔区', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2258', N'凤庆县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2259', N'云县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z226', N'孟村回族自治县', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2260', N'永德县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2261', N'镇康县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2262', N'双江拉祜族佤族布朗族傣族自治县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2263', N'耿马傣族佤族自治县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2264', N'沧源佤族自治县', N'区县', N'3', N'C285')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2265', N'泸水县', N'区县', N'3', N'C286')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2266', N'福贡县', N'区县', N'3', N'C286')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2267', N'贡山独龙族怒族自治县', N'区县', N'3', N'C286')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2268', N'兰坪白族普米族自治县', N'区县', N'3', N'C286')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2269', N'香格里拉县', N'区县', N'3', N'C287')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z227', N'泊头市', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2270', N'德钦县', N'区县', N'3', N'C287')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2271', N'维西傈僳族自治县', N'区县', N'3', N'C287')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2272', N'古城区', N'区县', N'3', N'C288')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2273', N'玉龙纳西族自治县', N'区县', N'3', N'C288')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2274', N'永胜县', N'区县', N'3', N'C288')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2275', N'华坪县', N'区县', N'3', N'C288')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2276', N'宁蒗彝族自治县', N'区县', N'3', N'C288')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2277', N'门源回族自治县', N'区县', N'3', N'C289')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2278', N'祁连县', N'区县', N'3', N'C289')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2279', N'海晏县', N'区县', N'3', N'C289')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z228', N'任丘市', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2280', N'刚察县', N'区县', N'3', N'C289')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2281', N'城东区', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2282', N'城中区', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2283', N'城西区', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2284', N'城北区', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2285', N'大通回族土族自治县', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2286', N'湟中县', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2287', N'湟源县', N'区县', N'3', N'C290')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2288', N'平安县', N'区县', N'3', N'C291')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2289', N'民和回族土族自治县', N'区县', N'3', N'C291')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z229', N'黄骅市', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2290', N'乐都县', N'区县', N'3', N'C291')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2291', N'互助土族自治县', N'区县', N'3', N'C291')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2292', N'化隆回族自治县', N'区县', N'3', N'C291')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2293', N'循化撒拉族自治县', N'区县', N'3', N'C291')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2294', N'同仁县', N'区县', N'3', N'C292')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2295', N'尖扎县', N'区县', N'3', N'C292')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2296', N'泽库县', N'区县', N'3', N'C292')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2297', N'河南蒙古族自治县', N'区县', N'3', N'C292')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2298', N'共和县', N'区县', N'3', N'C293')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2299', N'同德县', N'区县', N'3', N'C293')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z23', N'河北区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z230', N'河间市', N'区县', N'3', N'C12')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2300', N'贵德县', N'区县', N'3', N'C293')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2301', N'兴海县', N'区县', N'3', N'C293')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2302', N'贵南县', N'区县', N'3', N'C293')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2303', N'玛沁县', N'区县', N'3', N'C294')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2304', N'班玛县', N'区县', N'3', N'C294')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2305', N'甘德县', N'区县', N'3', N'C294')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2306', N'达日县', N'区县', N'3', N'C294')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2307', N'久治县', N'区县', N'3', N'C294')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2308', N'玛多县', N'区县', N'3', N'C294')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2309', N'玉树县', N'区县', N'3', N'C295')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z231', N'桃城区', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2310', N'杂多县', N'区县', N'3', N'C295')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2311', N'称多县', N'区县', N'3', N'C295')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2312', N'治多县', N'区县', N'3', N'C295')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2313', N'囊谦县', N'区县', N'3', N'C295')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2314', N'曲麻莱县', N'区县', N'3', N'C295')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2315', N'格尔木市', N'区县', N'3', N'C296')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2316', N'德令哈市', N'区县', N'3', N'C296')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2317', N'乌兰县', N'区县', N'3', N'C296')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2318', N'都兰县', N'区县', N'3', N'C296')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2319', N'天峻县', N'区县', N'3', N'C296')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z232', N'枣强县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2320', N'新城区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2321', N'碑林区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2322', N'莲湖区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2323', N'灞桥区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2324', N'未央区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2325', N'雁塔区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2326', N'阎良区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2327', N'临潼区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2328', N'长安区', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2329', N'蓝田县', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z233', N'武邑县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2330', N'周至县', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2331', N'户县', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2332', N'高陵县', N'区县', N'3', N'C297')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2333', N'秦都区', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2334', N'杨陵区', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2335', N'渭城区', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2336', N'三原县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2337', N'泾阳县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2338', N'乾县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2339', N'礼泉县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z234', N'武强县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2340', N'永寿县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2341', N'彬县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2342', N'长武县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2343', N'旬邑县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2344', N'淳化县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2345', N'武功县', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2346', N'兴平市', N'区县', N'3', N'C298')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2347', N'宝塔区', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2348', N'延长县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2349', N'延川县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z235', N'饶阳县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2350', N'子长县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2351', N'安塞县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2352', N'志丹县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2353', N'吴起县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2354', N'甘泉县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2355', N'富县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2356', N'洛川县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2357', N'宜川县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2358', N'黄龙县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2359', N'黄陵县', N'区县', N'3', N'C299')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z236', N'安平县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2360', N'榆阳区', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2361', N'神木县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2362', N'府谷县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2363', N'横山县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2364', N'靖边县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2365', N'定边县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2366', N'绥德县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2367', N'米脂县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2368', N'佳县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2369', N'吴堡县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z237', N'故城县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2370', N'清涧县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2371', N'子洲县', N'区县', N'3', N'C300')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2372', N'临渭区', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2373', N'华县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2374', N'潼关县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2375', N'大荔县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2376', N'合阳县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2377', N'澄城县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2378', N'蒲城县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2379', N'白水县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z238', N'景县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2380', N'富平县', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2381', N'韩城市', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2382', N'华阴市', N'区县', N'3', N'C301')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2383', N'商州区', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2384', N'洛南县', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2385', N'丹凤县', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2386', N'商南县', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2387', N'山阳县', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2388', N'镇安县', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2389', N'柞水县', N'区县', N'3', N'C302')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z239', N'阜城县', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2390', N'汉滨区', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2391', N'汉阴县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2392', N'石泉县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2393', N'宁陕县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2394', N'紫阳县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2395', N'岚皋县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2396', N'平利县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2397', N'镇坪县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2398', N'旬阳县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2399', N'白河县', N'区县', N'3', N'C303')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z24', N'红桥区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z240', N'冀州市', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2400', N'汉台区', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2401', N'南郑县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2402', N'城固县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2403', N'洋县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2404', N'西乡县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2405', N'勉县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2406', N'宁强县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2407', N'略阳县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2408', N'镇巴县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2409', N'留坝县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z241', N'深州市', N'区县', N'3', N'C13')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2410', N'佛坪县', N'区县', N'3', N'C304')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2411', N'渭滨区', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2412', N'金台区', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2413', N'陈仓区', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2414', N'凤翔县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2415', N'岐山县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2416', N'扶风县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2417', N'眉县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2418', N'陇县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2419', N'千阳县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z242', N'桥东区', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2420', N'麟游县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2421', N'凤县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2422', N'太白县', N'区县', N'3', N'C305')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2423', N'王益区', N'区县', N'3', N'C306')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2424', N'印台区', N'区县', N'3', N'C306')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2425', N'耀州区', N'区县', N'3', N'C306')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2426', N'宜君县', N'区县', N'3', N'C306')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2427', N'港口区', N'区县', N'3', N'C307')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2428', N'防城区', N'区县', N'3', N'C307')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2429', N'上思县', N'区县', N'3', N'C307')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z243', N'桥西区', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2430', N'东兴市', N'区县', N'3', N'C307')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2431', N'兴宁区', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2432', N'青秀区', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2433', N'江南区', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2434', N'西乡塘区', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2435', N'良庆区', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2436', N'邕宁区', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2437', N'武鸣县', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2438', N'隆安县', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2439', N'马山县', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z244', N'邢台县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2440', N'上林县', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2441', N'宾阳县', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2442', N'横县', N'区县', N'3', N'C308')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2443', N'江洲区', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2444', N'扶绥县', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2445', N'宁明县', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2446', N'龙州县', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2447', N'大新县', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2448', N'天等县', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2449', N'凭祥市', N'区县', N'3', N'C309')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z245', N'临城县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2450', N'兴宾区', N'区县', N'3', N'C310')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2451', N'忻城县', N'区县', N'3', N'C310')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2452', N'象州县', N'区县', N'3', N'C310')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2453', N'武宣县', N'区县', N'3', N'C310')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2454', N'金秀瑶族自治县', N'区县', N'3', N'C310')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2455', N'合山市', N'区县', N'3', N'C310')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2456', N'城中区', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2457', N'鱼峰区', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2458', N'柳南区', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2459', N'柳北区', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z246', N'内丘县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2460', N'柳江县', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2461', N'柳城县', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2462', N'鹿寨县', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2463', N'融安县', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2464', N'融水苗族自治县', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2465', N'三江侗族自治县', N'区县', N'3', N'C311')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2466', N'秀峰区', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2467', N'叠彩区', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2468', N'象山区', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2469', N'七星区', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z247', N'柏乡县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2470', N'雁山区', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2471', N'阳朔县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2472', N'临桂县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2473', N'灵川县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2474', N'全州县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2475', N'兴安县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2476', N'永福县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2477', N'灌阳县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2478', N'龙胜各族自治县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2479', N'资源县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z248', N'隆尧县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2480', N'平乐县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2481', N'荔浦县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2482', N'恭城瑶族自治县', N'区县', N'3', N'C312')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2483', N'万秀区', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2484', N'碟山区', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2485', N'长洲区', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2486', N'苍梧县', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2487', N'藤县', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2488', N'蒙山县', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2489', N'岑溪市', N'区县', N'3', N'C313')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z249', N'任县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2490', N'八步区', N'区县', N'3', N'C314')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2491', N'昭平县', N'区县', N'3', N'C314')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2492', N'钟山县', N'区县', N'3', N'C314')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2493', N'富川瑶族自治县', N'区县', N'3', N'C314')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2494', N'港北区', N'区县', N'3', N'C315')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2495', N'港南区', N'区县', N'3', N'C315')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2496', N'覃塘区', N'区县', N'3', N'C315')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2497', N'平南县', N'区县', N'3', N'C315')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2498', N'桂平市', N'区县', N'3', N'C315')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2499', N'玉州区', N'区县', N'3', N'C316')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z25', N'塘沽区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z250', N'南和县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2500', N'容县', N'区县', N'3', N'C316')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2501', N'陆川县', N'区县', N'3', N'C316')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2502', N'博白县', N'区县', N'3', N'C316')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2503', N'兴业县', N'区县', N'3', N'C316')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2504', N'北流市', N'区县', N'3', N'C316')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2505', N'右江区', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2506', N'田阳县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2507', N'田东县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2508', N'平果县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2509', N'德保县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z251', N'宁晋县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2510', N'靖西县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2511', N'那坡县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2512', N'凌云县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2513', N'乐业县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2514', N'田林县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2515', N'西林县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2516', N'隆林各族自治县', N'区县', N'3', N'C317')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2517', N'钦南区', N'区县', N'3', N'C318')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2518', N'钦北区', N'区县', N'3', N'C318')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2519', N'灵山县', N'区县', N'3', N'C318')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z252', N'巨鹿县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2520', N'浦北县', N'区县', N'3', N'C318')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2521', N'金城江区', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2522', N'南丹县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2523', N'天峨县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2524', N'凤山县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2525', N'东兰县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2526', N'罗城仫佬族自治县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2527', N'环江毛南族自治县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2528', N'巴马瑶族自治县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2529', N'都安瑶族自治县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z253', N'新河县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2530', N'大化瑶族自治县', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2531', N'宜州市', N'区县', N'3', N'C319')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2532', N'海城区', N'区县', N'3', N'C320')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2533', N'银海区', N'区县', N'3', N'C320')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2534', N'铁山港区', N'区县', N'3', N'C320')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2535', N'合浦县', N'区县', N'3', N'C320')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2536', N'城关区', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2537', N'林周县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2538', N'当雄县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2539', N'尼木县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z254', N'广宗县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2540', N'曲水县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2541', N'堆龙德庆县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2542', N'达孜县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2543', N'墨竹工卡县', N'区县', N'3', N'C321')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2544', N'日喀则市', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2545', N'南木林县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2546', N'江孜县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2547', N'定日县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2548', N'萨迦县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2549', N'拉孜县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z255', N'平乡县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2550', N'昂仁县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2551', N'谢通门县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2552', N'白朗县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2553', N'仁布县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2554', N'康马县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2555', N'定结县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2556', N'仲巴县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2557', N'亚东县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2558', N'吉隆县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2559', N'聂拉木县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z256', N'威县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2560', N'萨嘎县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2561', N'岗巴县', N'区县', N'3', N'C322')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2562', N'乃东县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2563', N'扎囊县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2564', N'贡嘎县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2565', N'桑日县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2566', N'琼结县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2567', N'曲松县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2568', N'措美县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2569', N'洛扎县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z257', N'清河县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2570', N'加查县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2571', N'隆子县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2572', N'错那县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2573', N'浪卡子县', N'区县', N'3', N'C323')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2574', N'林芝县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2575', N'工布江达县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2576', N'米林县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2577', N'墨脱县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2578', N'波密县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2579', N'察隅县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z258', N'临西县', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2580', N'朗县', N'区县', N'3', N'C324')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2581', N'昌都县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2582', N'江达县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2583', N'贡觉县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2584', N'类乌齐县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2585', N'丁青县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2586', N'察雅县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2587', N'八宿县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2588', N'左贡县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2589', N'芒康县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z259', N'南宫市', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2590', N'洛隆县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2591', N'边坝县', N'区县', N'3', N'C325')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2592', N'那曲县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2593', N'嘉黎县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2594', N'比如县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2595', N'聂荣县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2596', N'安多县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2597', N'申扎县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2598', N'索县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2599', N'班戈县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z26', N'汉沽区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z260', N'沙河市', N'区县', N'3', N'C14')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2600', N'巴青县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2601', N'尼玛县', N'区县', N'3', N'C326')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2602', N'普兰县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2603', N'札达县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2604', N'噶尔县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2605', N'日土县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2606', N'革吉县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2607', N'改则县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2608', N'措勤县', N'区县', N'3', N'C327')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2609', N'兴庆区', N'区县', N'3', N'C328')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z261', N'海港区', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2610', N'西夏区', N'区县', N'3', N'C328')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2611', N'金凤区', N'区县', N'3', N'C328')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2612', N'永宁县', N'区县', N'3', N'C328')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2613', N'贺兰县', N'区县', N'3', N'C328')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2614', N'灵武市', N'区县', N'3', N'C328')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2615', N'大武口区', N'区县', N'3', N'C329')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2616', N'惠农区', N'区县', N'3', N'C329')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2617', N'平罗县', N'区县', N'3', N'C329')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2618', N'利通区', N'区县', N'3', N'C330')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2619', N'盐池县', N'区县', N'3', N'C330')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z262', N'山海关区', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2620', N'同心县', N'区县', N'3', N'C330')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2621', N'青铜峡市', N'区县', N'3', N'C330')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2622', N'原州区', N'区县', N'3', N'C331')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2623', N'西吉县', N'区县', N'3', N'C331')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2624', N'隆德县', N'区县', N'3', N'C331')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2625', N'泾源县', N'区县', N'3', N'C331')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2626', N'彭阳县', N'区县', N'3', N'C331')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2627', N'沙坡头区', N'区县', N'3', N'C332')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2628', N'中宁县', N'区县', N'3', N'C332')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2629', N'海原县', N'区县', N'3', N'C332')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z263', N'北戴河区', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2630', N'塔城市', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2631', N'乌苏市', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2632', N'额敏县', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2633', N'沙湾县', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2634', N'托里县', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2635', N'裕民县', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2636', N'和布克赛尔蒙古自治县', N'区县', N'3', N'C333')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2637', N'哈密市', N'区县', N'3', N'C334')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2638', N'巴里坤哈萨克自治县', N'区县', N'3', N'C334')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2639', N'伊吾县', N'区县', N'3', N'C334')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z264', N'青龙满族自治县', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2640', N'和田市', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2641', N'和田县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2642', N'墨玉县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2643', N'皮山县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2644', N'洛浦县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2645', N'策勒县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2646', N'于田县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2647', N'民丰县', N'区县', N'3', N'C335')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2648', N'阿勒泰市', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2649', N'布尔津县', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z265', N'昌黎县', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2650', N'富蕴县', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2651', N'福海县', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2652', N'哈巴河县', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2653', N'青河县', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2654', N'吉木乃县', N'区县', N'3', N'C336')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2655', N'阿图什市', N'区县', N'3', N'C337')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2656', N'阿克陶县', N'区县', N'3', N'C337')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2657', N'阿合奇县', N'区县', N'3', N'C337')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2658', N'乌恰县', N'区县', N'3', N'C337')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2659', N'博乐市', N'区县', N'3', N'C338')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z266', N'抚宁县', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2660', N'精河县', N'区县', N'3', N'C338')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2661', N'温泉县', N'区县', N'3', N'C338')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2662', N'独山子区', N'区县', N'3', N'C339')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2663', N'克拉玛依区', N'区县', N'3', N'C339')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2664', N'白碱滩区', N'区县', N'3', N'C339')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2665', N'乌尔禾区', N'区县', N'3', N'C339')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2666', N'天山区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2667', N'沙依巴克区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2668', N'新市区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2669', N'水磨沟区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z267', N'卢龙县', N'区县', N'3', N'C15')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2670', N'头屯河区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2671', N'达坂城区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2672', N'米东区', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2673', N'乌鲁木齐县', N'区县', N'3', N'C340')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2674', N'昌吉市', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2675', N'阜康市', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2676', N'呼图壁县', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2677', N'玛纳斯县', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2678', N'奇台县', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2679', N'吉木萨尔县', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z268', N'朔城区', N'区县', N'3', N'C16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2680', N'木垒哈萨克自治县', N'区县', N'3', N'C342')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2681', N'吐鲁番市', N'区县', N'3', N'C344')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2682', N'鄯善县', N'区县', N'3', N'C344')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2683', N'托克逊县', N'区县', N'3', N'C344')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2684', N'库尔勒市', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2685', N'轮台县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2686', N'尉犁县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2687', N'若羌县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2688', N'且末县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2689', N'焉耆回族自治县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z269', N'平鲁区', N'区县', N'3', N'C16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2690', N'和静县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2691', N'和硕县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2692', N'博湖县', N'区县', N'3', N'C345')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2693', N'阿克苏市', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2694', N'温宿县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2695', N'库车县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2696', N'沙雅县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2697', N'新和县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2698', N'拜城县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2699', N'乌什县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z27', N'大港区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z270', N'山阴县', N'区县', N'3', N'C16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2700', N'阿瓦提县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2701', N'柯坪县', N'区县', N'3', N'C346')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2702', N'喀什市', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2703', N'疏附县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2704', N'疏勒县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2705', N'英吉沙县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2706', N'泽普县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2707', N'莎车县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2708', N'叶城县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2709', N'麦盖提县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z271', N'应县', N'区县', N'3', N'C16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2710', N'岳普湖县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2711', N'伽师县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2712', N'巴楚县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2713', N'塔什库尔干塔吉克自治县', N'区县', N'3', N'C348')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2714', N'伊宁市', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2715', N'奎屯市', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2716', N'伊宁县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2717', N'察布查尔锡伯自治县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2718', N'霍城县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2719', N'巩留县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z272', N'右玉县', N'区县', N'3', N'C16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2720', N'新源县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2721', N'昭苏县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2722', N'特克斯县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2723', N'尼勒克县', N'区县', N'3', N'C350')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2724', N'海拉尔区', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2725', N'阿荣旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2726', N'莫力达瓦达斡尔族自治旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2727', N'鄂伦春自治旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2728', N'鄂温克族自治旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2729', N'陈巴尔虎旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z273', N'怀仁县', N'区县', N'3', N'C16')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2730', N'新巴尔虎左旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2731', N'新巴尔虎右旗', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2732', N'满洲里市', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2733', N'牙克石市', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2734', N'扎兰屯市', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2735', N'额尔古纳市', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2736', N'根河市', N'区县', N'3', N'C351')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2737', N'新城区', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2738', N'回民区', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2739', N'玉泉区', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z274', N'忻府区', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2740', N'赛罕区', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2741', N'土默特左旗', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2742', N'托克托县', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2743', N'和林格尔县', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2744', N'清水河县', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2745', N'武川县', N'区县', N'3', N'C352')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2746', N'东河区', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2747', N'昆都仑区', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2748', N'青山区', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2749', N'石拐区', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z275', N'定襄县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2750', N'白云鄂博矿区', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2751', N'九原区', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2752', N'土默特右旗', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2753', N'固阳县', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2754', N'达尔罕茂明安联合旗', N'区县', N'3', N'C353')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2755', N'海勃湾区', N'区县', N'3', N'C354')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2756', N'海南区', N'区县', N'3', N'C354')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2757', N'乌达区', N'区县', N'3', N'C354')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2758', N'集宁区', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2759', N'卓资县', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z276', N'五台县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2760', N'化德县', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2761', N'商都县', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2762', N'兴和县', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2763', N'凉城县', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2764', N'察哈尔右翼前旗', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2765', N'察哈尔右翼中旗', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2766', N'察哈尔右翼后旗', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2767', N'四子王旗', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2768', N'丰镇市', N'区县', N'3', N'C355')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2769', N'科尔沁区', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z277', N'代县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2770', N'科尔沁左翼中旗', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2771', N'科尔沁左翼后旗', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2772', N'开鲁县', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2773', N'库伦旗', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2774', N'奈曼旗', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2775', N'扎鲁特旗', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2776', N'霍林郭勒市', N'区县', N'3', N'C356')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2777', N'红山区', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2778', N'元宝山区', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2779', N'松山区', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z278', N'繁峙县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2780', N'阿鲁科尔沁旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2781', N'巴林左旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2782', N'巴林右旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2783', N'林西县', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2784', N'克什克腾旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2785', N'翁牛特旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2786', N'喀喇沁旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2787', N'宁城县', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2788', N'敖汉旗', N'区县', N'3', N'C357')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2789', N'东胜区', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z279', N'宁武县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2790', N'达拉特旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2791', N'准格尔旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2792', N'鄂托克前旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2793', N'鄂托克旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2794', N'杭锦旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2795', N'乌审旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2796', N'伊金霍洛旗', N'区县', N'3', N'C358')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2797', N'临河区', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2798', N'五原县', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2799', N'磴口县', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z28', N'东丽区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z280', N'静乐县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2800', N'乌拉特前旗', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2801', N'乌拉特中旗', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2802', N'乌拉特后旗', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2803', N'杭锦后旗', N'区县', N'3', N'C359')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2804', N'二连浩特市', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2805', N'锡林浩特市', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2806', N'阿巴嘎旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2807', N'苏尼特左旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2808', N'苏尼特右旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2809', N'东乌珠穆沁旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z281', N'神池县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2810', N'西乌珠穆沁旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2811', N'太仆寺旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2812', N'镶黄旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2813', N'正镶白旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2814', N'正蓝旗', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2815', N'多伦县', N'区县', N'3', N'C360')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2816', N'乌兰浩特市', N'区县', N'3', N'C361')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2817', N'阿尔山市', N'区县', N'3', N'C361')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2818', N'科尔沁右翼前旗', N'区县', N'3', N'C361')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2819', N'科尔沁右翼中旗', N'区县', N'3', N'C361')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z282', N'五寨县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2820', N'扎赉特旗', N'区县', N'3', N'C361')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2821', N'突泉县', N'区县', N'3', N'C361')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2822', N'阿拉善左旗', N'区县', N'3', N'C362')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2823', N'阿拉善右旗', N'区县', N'3', N'C362')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z2824', N'额济纳旗', N'区县', N'3', N'C362')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z283', N'岢岚县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z284', N'河曲县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z285', N'保德县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z286', N'偏关县', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z287', N'原平市', N'区县', N'3', N'C17')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z288', N'小店区', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z289', N'迎泽区', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z29', N'西青区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z290', N'杏花岭区', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z291', N'尖草坪区', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z292', N'万柏林区', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z293', N'晋源区', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z294', N'清徐县', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z295', N'阳曲县', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z296', N'娄烦县', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z297', N'古交市', N'区县', N'3', N'C18')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z298', N'矿区', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z299', N'南郊区', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z3', N'崇文区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z30', N'津南区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z300', N'新荣区', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z301', N'阳高县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z302', N'天镇县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z303', N'广灵县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z304', N'灵丘县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z305', N'浑源县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z306', N'左云县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z307', N'大同县', N'区县', N'3', N'C19')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z308', N'矿区', N'区县', N'3', N'C20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z309', N'平定县', N'区县', N'3', N'C20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z31', N'北辰区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z310', N'盂县', N'区县', N'3', N'C20')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z311', N'榆次区', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z312', N'榆社县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z313', N'左权县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z314', N'和顺县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z315', N'昔阳县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z316', N'寿阳县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z317', N'太谷县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z318', N'祁县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z319', N'平遥县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z32', N'武清区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z320', N'灵石县', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z321', N'介休市', N'区县', N'3', N'C21')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z322', N'长治县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z323', N'襄垣县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z324', N'屯留县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z325', N'平顺县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z326', N'黎城县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z327', N'壶关县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z328', N'长子县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z329', N'武乡县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z33', N'宝坻区', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z330', N'沁县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z331', N'沁源县', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z332', N'潞城市', N'区县', N'3', N'C22')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z333', N'沁水县', N'区县', N'3', N'C23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z334', N'阳城县', N'区县', N'3', N'C23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z335', N'陵川县', N'区县', N'3', N'C23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z336', N'泽州县', N'区县', N'3', N'C23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z337', N'高平市', N'区县', N'3', N'C23')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z338', N'尧都区', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z339', N'曲沃县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z34', N'宁河县', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z340', N'翼城县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z341', N'襄汾县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z342', N'洪洞县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z343', N'古县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z344', N'安泽县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z345', N'浮山县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z346', N'吉县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z347', N'乡宁县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z348', N'大宁县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z349', N'隰县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z35', N'静海县', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z350', N'永和县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z351', N'蒲县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z352', N'汾西县', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z353', N'侯马市', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z354', N'霍州市', N'区县', N'3', N'C24')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z355', N'离石区', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z356', N'文水县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z357', N'交城县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z358', N'兴县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z359', N'临县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z36', N'蓟县', N'区县', N'3', N'C2')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z360', N'柳林县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z361', N'石楼县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z362', N'岚县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z363', N'方山县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z364', N'中阳县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z365', N'交口县', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z366', N'孝义市', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z367', N'汾阳市', N'区县', N'3', N'C25')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z368', N'盐湖区', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z369', N'临猗县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z37', N'黄浦区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z370', N'万荣县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z371', N'闻喜县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z372', N'稷山县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z373', N'新绛县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z374', N'绛县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z375', N'垣曲县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z376', N'夏县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z377', N'平陆县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z378', N'芮城县', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z379', N'永济市', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z38', N'卢湾区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z380', N'河津市', N'区县', N'3', N'C26')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z381', N'和平区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z382', N'沈河区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z383', N'大东区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z384', N'皇姑区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z385', N'铁西区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z386', N'苏家屯区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z387', N'东陵区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z388', N'沈北新区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z389', N'于洪区', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z39', N'徐汇区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z390', N'辽中县', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z391', N'康平县', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z392', N'法库县', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z393', N'新民市', N'区县', N'3', N'C27')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z394', N'银州区', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z395', N'清河区', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z396', N'铁岭县', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z397', N'西丰县', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z398', N'昌图县', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z399', N'调兵山市', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z4', N'宣武区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z40', N'长宁区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z400', N'开原市', N'区县', N'3', N'C28')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z401', N'长海县', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z402', N'旅顺口区', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z403', N'中山区', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z404', N'西岗区', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z405', N'沙河口区', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z406', N'甘井子区', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z407', N'金州区', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z408', N'普兰店市', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z409', N'瓦房店市', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z41', N'静安区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z410', N'庄河市', N'区县', N'3', N'C29')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z411', N'铁东区', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z412', N'铁西区', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z413', N'立山区', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z414', N'千山区', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z415', N'台安县', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z416', N'岫岩满族自治县', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z417', N'海城市', N'区县', N'3', N'C30')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z418', N'新抚区', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z419', N'东洲区', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z42', N'普陀区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z420', N'望花区', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z421', N'顺城区', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z422', N'抚顺县', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z423', N'新宾满族自治县', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z424', N'清原满族自治县', N'区县', N'3', N'C31')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z425', N'平山区', N'区县', N'3', N'C32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z426', N'溪湖区', N'区县', N'3', N'C32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z427', N'明山区', N'区县', N'3', N'C32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z428', N'南芬区', N'区县', N'3', N'C32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z429', N'本溪满族自治县', N'区县', N'3', N'C32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z43', N'闸北区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z430', N'桓仁满族自治县', N'区县', N'3', N'C32')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z431', N'元宝区', N'区县', N'3', N'C33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z432', N'振兴区', N'区县', N'3', N'C33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z433', N'振安区', N'区县', N'3', N'C33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z434', N'宽甸满族自治县', N'区县', N'3', N'C33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z435', N'东港市', N'区县', N'3', N'C33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z436', N'凤城市', N'区县', N'3', N'C33')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z437', N'古塔区', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z438', N'凌河区', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z439', N'太和区', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z44', N'虹口区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z440', N'黑山县', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z441', N'义县', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z442', N'凌海市', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z443', N'北镇市', N'区县', N'3', N'C34')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z444', N'站前区', N'区县', N'3', N'C35')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z445', N'西市区', N'区县', N'3', N'C35')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z446', N'鮁鱼圈区', N'区县', N'3', N'C35')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z447', N'老边区', N'区县', N'3', N'C35')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z448', N'盖州市', N'区县', N'3', N'C35')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z449', N'大石桥市', N'区县', N'3', N'C35')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z45', N'杨浦区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z450', N'海州区', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z451', N'新邱区', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z452', N'太平区', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z453', N'清河门区', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z454', N'细河区', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z455', N'阜新蒙古族自治县', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z456', N'彰武县', N'区县', N'3', N'C36')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z457', N'白塔区', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z458', N'文圣区', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z459', N'宏伟区', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z46', N'闵行区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z460', N'弓长岭区', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z461', N'太子河区', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z462', N'辽阳县', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z463', N'灯塔市', N'区县', N'3', N'C37')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z464', N'双塔区', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z465', N'龙城区', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z466', N'朝阳县', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z467', N'建平县', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z468', N'喀喇沁左翼蒙古族自治县', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z469', N'北票市', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z47', N'宝山区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z470', N'凌源市', N'区县', N'3', N'C38')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z471', N'双台子区', N'区县', N'3', N'C39')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z472', N'兴隆台区', N'区县', N'3', N'C39')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z473', N'大洼县', N'区县', N'3', N'C39')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z474', N'盘山县', N'区县', N'3', N'C39')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z475', N'连山区', N'区县', N'3', N'C40')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z476', N'龙港区', N'区县', N'3', N'C40')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z477', N'南票区', N'区县', N'3', N'C40')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z478', N'绥中县', N'区县', N'3', N'C40')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z479', N'建昌县', N'区县', N'3', N'C40')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z48', N'嘉定区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z480', N'兴城市', N'区县', N'3', N'C40')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z481', N'南关区', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z482', N'宽城区', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z483', N'朝阳区', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z484', N'二道区', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z485', N'绿园区', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z486', N'双阳区', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z487', N'农安县', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z488', N'九台市', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z489', N'榆树市', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z49', N'浦东新区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z490', N'德惠市', N'区县', N'3', N'C41')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z491', N'昌邑区', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z492', N'龙潭区', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z493', N'船营区', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z494', N'丰满区', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z495', N'永吉县', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z496', N'蛟河市', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z497', N'桦甸市', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z498', N'舒兰市', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z499', N'磐石市', N'区县', N'3', N'C42')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z5', N'朝阳区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z50', N'金山区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z500', N'延吉市', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z501', N'图们市', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z502', N'敦化市', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z503', N'珲春市', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z504', N'龙井市', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z505', N'和龙市', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z506', N'汪清县', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z507', N'安图县', N'区县', N'3', N'C43')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z508', N'铁西区', N'区县', N'3', N'C44')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z509', N'铁东区', N'区县', N'3', N'C44')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z51', N'松江区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z510', N'梨树县', N'区县', N'3', N'C44')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z511', N'伊通满族自治县', N'区县', N'3', N'C44')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z512', N'公主岭市', N'区县', N'3', N'C44')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z513', N'双辽市', N'区县', N'3', N'C44')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z514', N'东昌区', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z515', N'二道江区', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z516', N'通化县', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z517', N'辉南县', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z518', N'柳河县', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z519', N'梅河口市', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z52', N'青浦区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z520', N'集安市', N'区县', N'3', N'C45')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z521', N'洮北区', N'区县', N'3', N'C46')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z522', N'镇赉县', N'区县', N'3', N'C46')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z523', N'通榆县', N'区县', N'3', N'C46')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z524', N'洮南市', N'区县', N'3', N'C46')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z525', N'大安市', N'区县', N'3', N'C46')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z526', N'龙山区', N'区县', N'3', N'C47')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z527', N'西安区', N'区县', N'3', N'C47')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z528', N'东丰县', N'区县', N'3', N'C47')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z529', N'东辽县', N'区县', N'3', N'C47')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z53', N'南汇区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z530', N'宁江区', N'区县', N'3', N'C48')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z531', N'前郭尔罗斯蒙古族自治县', N'区县', N'3', N'C48')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z532', N'长岭县', N'区县', N'3', N'C48')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z533', N'乾安县', N'区县', N'3', N'C48')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z534', N'扶余县', N'区县', N'3', N'C48')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z535', N'八道江区', N'区县', N'3', N'C49')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z536', N'江源区', N'区县', N'3', N'C49')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z537', N'抚松县', N'区县', N'3', N'C49')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z538', N'靖宇县', N'区县', N'3', N'C49')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z539', N'长白朝鲜族自治县', N'区县', N'3', N'C49')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z54', N'奉贤区', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z540', N'临江市', N'区县', N'3', N'C49')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z541', N'道里区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z542', N'南岗区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z543', N'道外区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z544', N'平房区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z545', N'松北区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z546', N'香坊区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z547', N'呼兰区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z548', N'阿城区', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z549', N'依兰县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z55', N'崇明县', N'区县', N'3', N'C3')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z550', N'方正县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z551', N'宾县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z552', N'巴彦县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z553', N'木兰县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z554', N'通河县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z555', N'延寿县', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z556', N'双城市', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z557', N'尚志市', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z558', N'五常市', N'区县', N'3', N'C50')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z559', N'龙沙区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z56', N'万州区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z560', N'建华区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z561', N'铁锋区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z562', N'昂昂溪区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z563', N'富拉尔基区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z564', N'碾子山区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z565', N'梅里斯达翰尔族区', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z566', N'龙江县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z567', N'依安县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z568', N'泰来县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z569', N'甘南县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z57', N'涪陵区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z570', N'富裕县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z571', N'克山县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z572', N'克东县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z573', N'拜泉县', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z574', N'讷河市', N'区县', N'3', N'C51')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z575', N'鸡冠区', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z576', N'恒山区', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z577', N'滴道区', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z578', N'梨树区', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z579', N'城子河区', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z58', N'渝中区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z580', N'麻山区', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z581', N'鸡东县', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z582', N'虎林市', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z583', N'密山市', N'区县', N'3', N'C52')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z584', N'东安区', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z585', N'阳明区', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z586', N'爱民区', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z587', N'西安区', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z588', N'东宁县', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z589', N'林口县', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z59', N'大渡口区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z590', N'绥芬河市', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z591', N'海林市', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z592', N'宁安市', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z593', N'穆棱市', N'区县', N'3', N'C53')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z594', N'新兴区', N'区县', N'3', N'C54')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z595', N'桃山区', N'区县', N'3', N'C54')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z596', N'茄子河区', N'区县', N'3', N'C54')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z597', N'勃利县', N'区县', N'3', N'C54')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z598', N'向阳区', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z599', N'前进区', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z6', N'丰台区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z60', N'江北区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z600', N'东风区', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z601', N'桦南县', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z602', N'桦川县', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z603', N'汤原县', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z604', N'抚远县', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z605', N'同江市', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z606', N'富锦市', N'区县', N'3', N'C55')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z607', N'向阳区', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z608', N'工农区', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z609', N'南山区', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z61', N'沙坪坝区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z610', N'兴安区', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z611', N'东山区', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z612', N'兴山区', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z613', N'萝北县', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z614', N'绥滨县', N'区县', N'3', N'C56')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z615', N'尖山区', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z616', N'岭东区', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z617', N'四方台区', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z618', N'宝山区', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z619', N'集贤县', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z62', N'九龙坡区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z620', N'友谊县', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z621', N'宝清县', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z622', N'饶河县', N'区县', N'3', N'C57')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z623', N'北林区', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z624', N'望奎县', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z625', N'兰西县', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z626', N'青冈县', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z627', N'庆安县', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z628', N'明水县', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z629', N'绥棱县', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z63', N'南岸区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z630', N'安达市', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z631', N'肇东市', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z632', N'海伦市', N'区县', N'3', N'C58')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z633', N'爱辉区', N'区县', N'3', N'C59')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z634', N'嫩江县', N'区县', N'3', N'C59')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z635', N'逊克县', N'区县', N'3', N'C59')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z636', N'孙吴县', N'区县', N'3', N'C59')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z637', N'北安市', N'区县', N'3', N'C59')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z638', N'五大连池市', N'区县', N'3', N'C59')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z639', N'呼玛县', N'区县', N'3', N'C60')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z64', N'北碚区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z640', N'塔河县', N'区县', N'3', N'C60')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z641', N'漠河县', N'区县', N'3', N'C60')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z642', N'伊春区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z643', N'南岔区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z644', N'友好区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z645', N'西林区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z646', N'翠峦区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z647', N'新青区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z648', N'美溪区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z649', N'金山屯区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z65', N'万盛区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z650', N'五营区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z651', N'乌马河区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z652', N'汤旺河区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z653', N'带岭区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z654', N'乌伊岭区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z655', N'红星区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z656', N'上甘岭区', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z657', N'嘉荫县', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z658', N'铁力市', N'区县', N'3', N'C61')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z659', N'萨尔图区', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z66', N'双桥区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z660', N'龙凤区', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z661', N'让胡路区', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z662', N'红岗区', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z663', N'大同区', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z664', N'肇州县', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z665', N'肇源县', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z666', N'林甸县', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z667', N'杜尔伯特蒙古族自治县', N'区县', N'3', N'C62')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z668', N'江宁区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z669', N'浦口区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z67', N'渝北区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z670', N'玄武区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z671', N'白下区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z672', N'秦淮区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z673', N'建邺区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z674', N'鼓楼区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z675', N'下关区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z676', N'栖霞区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z677', N'雨花台区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z678', N'六合区', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z679', N'溧水县', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z68', N'巴南区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z680', N'高淳县', N'区县', N'3', N'C63')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z681', N'崇安区', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z682', N'南长区', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z683', N'北塘区', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z684', N'锡山区', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z685', N'惠山区', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z686', N'滨湖区', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z687', N'江阴市', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z688', N'宜兴市', N'区县', N'3', N'C64')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z689', N'京口区', N'区县', N'3', N'C65')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z69', N'黔江区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z690', N'润州区', N'区县', N'3', N'C65')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z691', N'丹徒区', N'区县', N'3', N'C65')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z692', N'丹阳市', N'区县', N'3', N'C65')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z693', N'扬中市', N'区县', N'3', N'C65')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z694', N'句容市', N'区县', N'3', N'C65')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z695', N'沧浪区', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z696', N'常熟市', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z697', N'平江区', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z698', N'金阊区', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z699', N'虎丘区', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z7', N'石景山区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z70', N'长寿区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z700', N'昆山市', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z701', N'太仓市', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z702', N'吴江市', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z703', N'吴中区', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z704', N'相城区', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z705', N'张家港市', N'区县', N'3', N'C66')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z706', N'崇川区', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z707', N'港闸区', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z708', N'海安县', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z709', N'如东县', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z71', N'江津区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z710', N'启东市', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z711', N'如皋市', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z712', N'通州市', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z713', N'海门市', N'区县', N'3', N'C67')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z714', N'高邮市', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z715', N'广陵区', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z716', N'邗江区', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z717', N'维扬区', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z718', N'宝应县', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z719', N'江都市', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z72', N'合川区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z720', N'仪征市', N'区县', N'3', N'C68')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z721', N'亭湖区', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z722', N'盐都区', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z723', N'响水县', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z724', N'滨海县', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z725', N'阜宁县', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z726', N'射阳县', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z727', N'建湖县', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z728', N'东台市', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z729', N'大丰市', N'区县', N'3', N'C69')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z73', N'永川区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z730', N'鼓楼区', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z731', N'云龙区', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z732', N'九里区', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z733', N'贾汪区', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z734', N'泉山区', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z735', N'丰县', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z736', N'沛县', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z737', N'铜山县', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z738', N'睢宁县', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z739', N'新沂市', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z74', N'南川区', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z740', N'邳州市', N'区县', N'3', N'C70')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z741', N'清河区', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z742', N'楚州区', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z743', N'淮阴区', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z744', N'清浦区', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z745', N'涟水县', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z746', N'洪泽县', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z747', N'盱眙县', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z748', N'金湖县', N'区县', N'3', N'C71')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z749', N'连云区', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z75', N'綦江县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z750', N'新浦区', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z751', N'海州区', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z752', N'赣榆县', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z753', N'东海县', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z754', N'灌云县', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z755', N'灌南县', N'区县', N'3', N'C72')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z756', N'天宁区', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z757', N'钟楼区', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z758', N'戚墅堰区', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z759', N'新北区', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z76', N'潼南县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z760', N'武进区', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z761', N'溧阳市', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z762', N'金坛市', N'区县', N'3', N'C73')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z763', N'海陵区', N'区县', N'3', N'C74')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z764', N'高港区', N'区县', N'3', N'C74')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z765', N'兴化市', N'区县', N'3', N'C74')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z766', N'靖江市', N'区县', N'3', N'C74')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z767', N'泰兴市', N'区县', N'3', N'C74')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z768', N'姜堰市', N'区县', N'3', N'C74')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z769', N'宿城区', N'区县', N'3', N'C75')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z77', N'铜梁县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z770', N'宿豫区', N'区县', N'3', N'C75')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z771', N'沭阳县', N'区县', N'3', N'C75')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z772', N'泗阳县', N'区县', N'3', N'C75')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z773', N'泗洪县', N'区县', N'3', N'C75')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z774', N'定海区', N'区县', N'3', N'C76')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z775', N'普陀区', N'区县', N'3', N'C76')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z776', N'岱山县', N'区县', N'3', N'C76')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z777', N'嵊泗县', N'区县', N'3', N'C76')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z778', N'柯城区', N'区县', N'3', N'C77')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z779', N'衢江区', N'区县', N'3', N'C77')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z78', N'大足县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z780', N'常山县', N'区县', N'3', N'C77')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z781', N'开化县', N'区县', N'3', N'C77')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z782', N'龙游县', N'区县', N'3', N'C77')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z783', N'江山市', N'区县', N'3', N'C77')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z784', N'上城区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z785', N'下城区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z786', N'江干区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z787', N'拱墅区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z788', N'西湖区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z789', N'滨江区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z79', N'荣昌县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z790', N'余杭区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z791', N'桐庐县', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z792', N'淳安县', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z793', N'建德市', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z794', N'富阳市', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z795', N'临安市', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z796', N'萧山区', N'区县', N'3', N'C78')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z797', N'吴兴区', N'区县', N'3', N'C79')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z798', N'南浔区', N'区县', N'3', N'C79')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z799', N'德清县', N'区县', N'3', N'C79')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z8', N'海淀区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z80', N'璧山县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z800', N'长兴县', N'区县', N'3', N'C79')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z801', N'安吉县', N'区县', N'3', N'C79')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z802', N' 南湖区', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z803', N' 秀洲区', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z804', N' 嘉善县', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z805', N' 海盐县', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z806', N' 海宁市', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z807', N' 平湖市', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z808', N' 桐乡市 ', N'区县', N'3', N'C80')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z809', N'海曙区', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z81', N'梁平县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z810', N'江东区', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z811', N'江北区', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z812', N'北仑区', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z813', N'镇海区', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z814', N'鄞州区', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z815', N'象山县', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z816', N'宁海县', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z817', N'余姚市', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z818', N'慈溪市', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z819', N'奉化市', N'区县', N'3', N'C81')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z82', N'城口县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z820', N'越城区', N'区县', N'3', N'C82')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z821', N'绍兴县', N'区县', N'3', N'C82')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z822', N'新昌县', N'区县', N'3', N'C82')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z823', N'诸暨市', N'区县', N'3', N'C82')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z824', N'上虞市', N'区县', N'3', N'C82')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z825', N'嵊州市', N'区县', N'3', N'C82')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z826', N'鹿城区', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z827', N'龙湾区', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z828', N'瓯海区', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z829', N'洞头县', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z83', N'丰都县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z830', N'永嘉县', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z831', N'平阳县', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z832', N'苍南县', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z833', N'文成县', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z834', N'泰顺县', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z835', N'瑞安市', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z836', N'乐清市', N'区县', N'3', N'C83')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z837', N'莲都区', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z838', N'青田县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z839', N'缙云县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z84', N'垫江县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z840', N'遂昌县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z841', N'松阳县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z842', N'云和县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z843', N'庆元县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z844', N'景宁畲族自治县', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z845', N'龙泉市', N'区县', N'3', N'C84')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z846', N'婺城区', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z847', N'金东区', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z848', N'武义县', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z849', N'浦江县', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z85', N'武隆县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z850', N'磐安县', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z851', N'兰溪市', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z852', N'义乌市', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z853', N'东阳市', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z854', N'永康市', N'区县', N'3', N'C85')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z855', N'椒江区', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z856', N'黄岩区', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z857', N'路桥区', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z858', N'玉环县', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z859', N'三门县', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z86', N'忠县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z860', N'天台县', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z861', N'仙居县', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z862', N'温岭市', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z863', N'临海市', N'区县', N'3', N'C86')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z864', N'瑶海区', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z865', N'庐阳区', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z866', N'蜀山区', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z867', N'包河区', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z868', N'长丰县', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z869', N'肥东县', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z87', N'开县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z870', N'肥西县', N'区县', N'3', N'C87')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z871', N'镜湖区', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z872', N'弋江区', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z873', N'鸠江区', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z874', N'三山区', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z875', N'芜湖县', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z876', N'繁昌县', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z877', N'南陵县', N'区县', N'3', N'C88')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z878', N'龙子湖区', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z879', N'蚌山区', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z88', N'云阳县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z880', N'禹会区', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z881', N'淮上区', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z882', N'怀远县', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z883', N'五河县', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z884', N'固镇县', N'区县', N'3', N'C89')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z885', N'大通区', N'区县', N'3', N'C90')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z886', N'田家庵区', N'区县', N'3', N'C90')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z887', N'谢家集区', N'区县', N'3', N'C90')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z888', N'八公山区', N'区县', N'3', N'C90')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z889', N'潘集区', N'区县', N'3', N'C90')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z89', N'奉节县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z890', N'凤台县', N'区县', N'3', N'C90')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z891', N'金家庄区', N'区县', N'3', N'C91')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z892', N'花山区', N'区县', N'3', N'C91')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z893', N'雨山区', N'区县', N'3', N'C91')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z894', N'当涂县', N'区县', N'3', N'C91')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z895', N'杜集区', N'区县', N'3', N'C92')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z896', N'相山区', N'区县', N'3', N'C92')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z897', N'烈山区', N'区县', N'3', N'C92')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z898', N'濉溪县 ', N'区县', N'3', N'C92')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z899', N'铜官山区', N'区县', N'3', N'C93')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z9', N'门头沟区', N'区县', N'3', N'C1')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z90', N'巫山县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z900', N'狮子山区', N'区县', N'3', N'C93')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z901', N'铜陵县', N'区县', N'3', N'C93')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z902', N'迎江区', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z903', N'大观区', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z904', N'宜秀区', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z905', N'怀宁县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z906', N'枞阳县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z907', N'潜山县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z908', N'太湖县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z909', N'宿松县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z91', N'巫溪县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z910', N'望江县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z911', N'岳西县', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z912', N'桐城市', N'区县', N'3', N'C94')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z913', N'屯溪区', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z914', N'黄山区', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z915', N'徽州区', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z916', N'歙县', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z917', N'休宁县', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z918', N'黟县', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z919', N'祁门县', N'区县', N'3', N'C95')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z92', N'石柱土家族自治县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z920', N'琅琊区', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z921', N'南谯区', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z922', N'来安县', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z923', N'全椒县', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z924', N'定远县', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z925', N'凤阳县', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z926', N'天长市', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z927', N'明光市', N'区县', N'3', N'C96')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z928', N'颍州区', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z929', N'颍东区', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z93', N'秀山土家族苗族自治县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z930', N'颍泉区', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z931', N'临泉县', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z932', N'太和县', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z933', N'阜南县', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z934', N'颍上县', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z935', N'界首市', N'区县', N'3', N'C97')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z936', N'埇桥区', N'区县', N'3', N'C98')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z937', N'砀山县', N'区县', N'3', N'C98')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z938', N'萧县', N'区县', N'3', N'C98')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z939', N'灵璧县', N'区县', N'3', N'C98')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z94', N'酉阳土家族苗族自治县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z940', N'泗县 ', N'区县', N'3', N'C98')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z941', N'居巢区', N'区县', N'3', N'C99')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z942', N'庐江县', N'区县', N'3', N'C99')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z943', N'无为县', N'区县', N'3', N'C99')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z944', N'含山县', N'区县', N'3', N'C99')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z945', N'和县 ', N'区县', N'3', N'C99')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z946', N'金安区', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z947', N'裕安区', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z948', N'寿县', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z949', N'霍邱县', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z95', N'彭水苗族土家族自治县', N'区县', N'3', N'C4')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z950', N'舒城县', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z951', N'金寨县', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z952', N'霍山县', N'区县', N'3', N'C100')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z953', N'谯城区', N'区县', N'3', N'C101')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z954', N'涡阳县', N'区县', N'3', N'C101')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z955', N'蒙城县', N'区县', N'3', N'C101')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z956', N'利辛县', N'区县', N'3', N'C101')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z957', N'贵池区', N'区县', N'3', N'C102')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z958', N'东至县', N'区县', N'3', N'C102')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z959', N'石台县', N'区县', N'3', N'C102')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z96', N'邯山区', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z960', N'青阳县', N'区县', N'3', N'C102')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z961', N'宣州区', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z962', N'郎溪县', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z963', N'广德县', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z964', N'泾县', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z965', N'绩溪县', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z966', N'旌德县', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z967', N'宁国市', N'区县', N'3', N'C103')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z968', N'鼓楼区', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z969', N'台江区', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z97', N'丛台区', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z970', N'仓山区', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z971', N'马尾区', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z972', N'晋安区', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z973', N'闽侯县', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z974', N'连江县', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z975', N'罗源县', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z976', N'闽清县', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z977', N'永泰县', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z978', N'平潭县', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z979', N'福清市', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z98', N'复兴区', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z980', N'长乐市', N'区县', N'3', N'C104')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z981', N'思明区', N'区县', N'3', N'C105')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z982', N'海沧区', N'区县', N'3', N'C105')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z983', N'湖里区', N'区县', N'3', N'C105')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z984', N'集美区', N'区县', N'3', N'C105')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z985', N'同安区', N'区县', N'3', N'C105')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z986', N'翔安区', N'区县', N'3', N'C105')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z987', N'蕉城区', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z988', N'霞浦县', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z989', N'古田县', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z99', N'峰峰矿区', N'区县', N'3', N'C5')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z990', N'屏南县', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z991', N'寿宁县', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z992', N'周宁县', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z993', N'柘荣县', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z994', N'福安市', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z995', N'福鼎市', N'区县', N'3', N'C106')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z996', N'城厢区', N'区县', N'3', N'C107')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z997', N'涵江区', N'区县', N'3', N'C107')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z998', N'荔城区', N'区县', N'3', N'C107')
GO
GO
INSERT INTO [dbo].[sm_ChinaRegion] ([ID], [Name], [Remark], [Level], [ParentID]) VALUES (N'Z999', N'秀屿区', N'区县', N'3', N'C107')
GO
GO

-- ----------------------------
-- Table structure for sm_dept
-- ----------------------------
DROP TABLE [dbo].[sm_dept]
GO
CREATE TABLE [dbo].[sm_dept] (
[dept_Code] varchar(50) NOT NULL DEFAULT '' ,
[dept_Name] varchar(50) NULL ,
[valid_Flag] int NULL 
)


GO

-- ----------------------------
-- Records of sm_dept
-- ----------------------------
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'000', N'系统管理', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'001', N'财务部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'002', N'储运部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'003', N'采购部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'004', N'销售一部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'005', N'销售二部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'006', N'销售三部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'007', N'销售四部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'008', N'工程部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'009', N'总经办', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'010', N'生产部', N'0')
GO
GO
INSERT INTO [dbo].[sm_dept] ([dept_Code], [dept_Name], [valid_Flag]) VALUES (N'011', N'人事部', N'0')
GO
GO

-- ----------------------------
-- Table structure for sm_dept_role
-- ----------------------------
DROP TABLE [dbo].[sm_dept_role]
GO
CREATE TABLE [dbo].[sm_dept_role] (
[role_Id] bigint NOT NULL ,
[role_Name] varchar(100) NULL ,
[parent_Role_Id] bigint NULL ,
[level] int NULL ,
[dept_Code] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of sm_dept_role
-- ----------------------------
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4619489429463298525', N'工程师', N'5061725116829142281', N'2', N'010')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4658033902091172163', N'销售总监', N'0', N'0', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4668418400219441094', N'组员', N'4905068721379914318', N'3', N'010')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4675433097871916401', N'销售组长', N'5099904187257014961', N'4', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4677406185782397907', N'采购部副经理', N'4880479426047451255', N'1', N'003')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4682184998411078600', N'行政专员', N'5593815260217045129', N'2', N'011')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4716476333819416248', N'董事长', N'0', N'0', N'009')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4720455488005006364', N'明星销售员', N'5161720140553131468', N'5', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4722909659166928326', N'销售部副经理', N'4821692879894691110', N'3', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4753348060037337172', N'明星销售员', N'4675433097871916401', N'5', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4771654635415301513', N'财务部经理', N'5495300941761775954', N'2', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4779861912260944931', N'销售员', N'5651541369424302754', N'5', N'005')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4787578912702679601', N'调度员', N'5572334586288571221', N'3', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4808684293593031775', N'销售员', N'4675433097871916401', N'5', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4810607464731670528', N'销售员', N'5668285020592756582', N'5', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4821692879894691110', N'销售部经理', N'5328357273351022599', N'2', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4828579130962139724', N'销售部经理', N'5512094111108124104', N'2', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4844895333790152364', N'行政人事部经理', N'0', N'0', N'011')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4858707176535425405', N'销售副总监', N'5211123440521712707', N'1', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4880479426047451255', N'采购部经理', N'0', N'0', N'003')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4893630052888293514', N'销售部副经理', N'4828579130962139724', N'3', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4903231945412572415', N'销售部经理', N'4858707176535425405', N'2', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4905068721379914318', N'生产组长', N'5061725116829142281', N'2', N'010')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4942112135862946065', N'内勤组长', N'5569459454153723056', N'2', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4965493114346653961', N'工程部经理', N'0', N'0', N'008')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4986069805452990582', N'明星销售员', N'5668285020592756582', N'5', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'4994932516563855737', N'系统管理员', N'0', N'0', N'000')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5043547877565053762', N'销售总监', N'0', N'0', N'005')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5056470603907942122', N'联络员', N'4942112135862946065', N'3', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5061725116829142281', N'生产部副经理', N'5113942944804776959', N'1', N'010')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5099904187257014961', N'销售部副经理', N'4903231945412572415', N'3', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5113942944804776959', N'生产部经理', N'0', N'0', N'010')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5124312185368264968', N'明星销售员', N'5651541369424302754', N'5', N'005')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5128714514459874264', N'采购专员', N'4677406185782397907', N'2', N'003')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5161720140553131468', N'销售组长', N'4722909659166928326', N'4', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5162319046412185304', N'主管会计', N'5417688059915890797', N'4', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5173902305148546598', N'仓管员', N'5675566733714155633', N'3', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5211123440521712707', N'销售总监', N'0', N'0', N'006')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5220671772344246129', N'销售总监', N'0', N'0', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5227352152884909609', N'销售部经理', N'5547938385216504705', N'2', N'005')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5299089426594489602', N'工程部内勤', N'5556374658627391173', N'2', N'008')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5309275077944165490', N'总经理', N'4716476333819416248', N'1', N'009')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5314857441777340703', N'采购员', N'5128714514459874264', N'3', N'003')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5328357273351022599', N'销售副总监', N'5220671772344246129', N'1', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5389018953274466190', N'出纳', N'5417688059915890797', N'4', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5417688059915890797', N'财务部副经理', N'4771654635415301513', N'3', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5422601102275167452', N'组员', N'5499847359080885171', N'3', N'008')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5495300941761775954', N'财务副总监', N'5621766706628027354', N'1', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5499847359080885171', N'工程部组长', N'5556374658627391173', N'2', N'008')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5507720083171425004', N'副总经理', N'5309275077944165490', N'2', N'009')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5512094111108124104', N'销售副总监', N'4658033902091172163', N'1', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5521515996607048136', N'会计', N'5162319046412185304', N'5', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5547938385216504705', N'销售副总监', N'5043547877565053762', N'1', N'005')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5556374658627391173', N'工程部副经理', N'4965493114346653961', N'1', N'008')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5569459454153723056', N'储运部副经理', N'5741319240679750284', N'1', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5572334586288571221', N'物流组长', N'5569459454153723056', N'2', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5588909507755959819', N'人事专员', N'5593815260217045129', N'2', N'011')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5593815260217045129', N'行政人事部副经理', N'4844895333790152364', N'1', N'011')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5621766706628027354', N'财务总监', N'0', N'0', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5624194518862011704', N'销售员', N'5161720140553131468', N'5', N'007')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5650920757624920835', N'助理会计', N'5162319046412185304', N'5', N'001')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5651541369424302754', N'销售组长', N'5747516387975246606', N'4', N'005')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5668285020592756582', N'销售组长', N'4893630052888293514', N'4', N'004')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5675566733714155633', N'仓库组长', N'5569459454153723056', N'2', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5730601465280379040', N'工程部助理', N'5556374658627391173', N'2', N'008')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5741319240679750284', N'储运部经理', N'0', N'0', N'002')
GO
GO
INSERT INTO [dbo].[sm_dept_role] ([role_Id], [role_Name], [parent_Role_Id], [level], [dept_Code]) VALUES (N'5747516387975246606', N'销售部副经理', N'5227352152884909609', N'3', N'005')
GO
GO

-- ----------------------------
-- Table structure for sm_dictionary
-- ----------------------------
DROP TABLE [dbo].[sm_dictionary]
GO
CREATE TABLE [dbo].[sm_dictionary] (
[Kind] varchar(30) NOT NULL DEFAULT '' ,
[Open_Flag] varchar(20) NULL ,
[Value] varchar(100) NULL ,
[ID] varchar(30) NOT NULL DEFAULT '' ,
[Kind_Flag] varchar(2) NOT NULL DEFAULT '' 
)


GO

-- ----------------------------
-- Records of sm_dictionary
-- ----------------------------
INSERT INTO [dbo].[sm_dictionary] ([Kind], [Open_Flag], [Value], [ID], [Kind_Flag]) VALUES (N'Sex', N'0', N'男', N'1', N'0')
GO
GO
INSERT INTO [dbo].[sm_dictionary] ([Kind], [Open_Flag], [Value], [ID], [Kind_Flag]) VALUES (N'Sex', N'0', N'女', N'2', N'0')
GO
GO
INSERT INTO [dbo].[sm_dictionary] ([Kind], [Open_Flag], [Value], [ID], [Kind_Flag]) VALUES (N'Sex', N'0', N'性别', N'Sex', N'1')
GO
GO

-- ----------------------------
-- Table structure for sm_downfile
-- ----------------------------
DROP TABLE [dbo].[sm_downfile]
GO
CREATE TABLE [dbo].[sm_downfile] (
[File_Name] varchar(300) NOT NULL DEFAULT '' ,
[Path] varchar(300) NOT NULL DEFAULT '' ,
[File_Content] image NULL ,
[oper_code] varchar(30) NULL ,
[oper_date] datetime NULL ,
[md5] varchar(200) NULL 
)


GO

-- ----------------------------
-- Records of sm_downfile
-- ----------------------------
GO
GO

-- ----------------------------
-- Table structure for sm_employee
-- ----------------------------
DROP TABLE [dbo].[sm_employee]
GO
CREATE TABLE [dbo].[sm_employee] (
[employ_Code] varchar(50) NOT NULL ,
[employ_Name] varchar(50) NULL ,
[Sex] varchar(20) NULL ,
[birthday] datetime NULL ,
[IDcardNo] varchar(20) NULL ,
[adress] varchar(50) NULL ,
[post_Code] varchar(20) NULL ,
[phone] varchar(20) NULL ,
[mobile] varchar(20) NULL ,
[dept_Code] varchar(50) NULL ,
[user_Name] varchar(50) NULL ,
[valid_Flag] int NULL ,
[role_Id] bigint NULL ,
[user_Password] varchar(255) NULL ,
[parent_Code] varchar(50) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'员工信息表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'员工信息表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'employ_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'employ_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'employ_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'employ_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'Sex')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'性别'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'Sex'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'性别'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'Sex'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'birthday')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'生日'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'birthday'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'生日'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'birthday'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'IDcardNo')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'身份证号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'IDcardNo'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'身份证号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'IDcardNo'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'adress')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'住址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'adress'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'住址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'adress'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'post_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'邮编'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'post_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'邮编'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'post_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'固定电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'固定电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'mobile')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'手机'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'mobile'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'手机'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'mobile'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'dept_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'部门编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'dept_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'部门编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'dept_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'sm_employee', 
'COLUMN', N'user_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'user_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'sm_employee'
, @level2type = 'COLUMN', @level2name = N'user_Name'
GO

-- ----------------------------
-- Records of sm_employee
-- ----------------------------
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'001', N'山常娥', N'女', N'2018-11-08 14:00:05.647', N'', N'', N'', N'', N'', N'009', N'001', N'1', N'4716476333819416248', N'DE-45-C6-D8-1B-13-2C-2C', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'002', N'山长勇', N'男', N'2018-11-08 14:00:26.360', N'', N'', N'', N'', N'', N'009', N'002', N'1', N'5309275077944165490', N'DF-C6-A6-69-CB-69-93-72', N'001')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'019', N'陈永野', N'男', N'2018-11-08 13:53:16.080', N'', N'', N'', N'', N'', N'005', N'019', N'1', N'5227352152884909609', N'96-AD-19-B1-D5-71-46-B7', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'022', N'杨森', N'男', N'2018-11-08 13:56:56.990', N'', N'', N'', N'', N'', N'006', N'022', N'1', N'4675433097871916401', N'78-67-39-05-EA-F5-BC-97', N'070')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'027', N'赵旭', N'男', N'2018-11-08 13:58:27.450', N'', N'', N'', N'', N'', N'008', N'027', N'1', N'5556374658627391173', N'3D-14-AA-CF-79-78-35-6A', N'040')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'033', N'孙宾', N'男', N'2018-11-08 13:46:48.627', N'', N'', N'', N'', N'', N'004', N'033', N'1', N'4828579130962139724', N'D7-81-38-96-BE-2F-82-AF', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'034', N'陈妍', N'女', N'2018-11-08 13:35:41.473', N'', N'', N'', N'', N'', N'001', N'034', N'1', N'4771654635415301513', N'D8-9B-E9-DD-22-03-61-D0', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'035', N'魏家红', N'女', N'2018-11-08 13:36:48.917', N'', N'', N'', N'', N'', N'001', N'035', N'1', N'5162319046412185304', N'CF-B1-E3-A6-CE-B8-B1-87', N'034')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'040', N'张国清', N'男', N'2018-11-08 13:57:57.100', N'', N'', N'', N'', N'', N'008', N'040', N'1', N'4965493114346653961', N'5A-A5-2B-CB-5A-ED-65-6B', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'052', N'贾丙余', N'男', N'2018-11-08 13:54:02.773', N'', N'', N'', N'', N'', N'005', N'052', N'1', N'4779861912260944931', N'DF-81-73-C2-0D-E7-36-F2', N'081')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'069', N'金勇日', N'男', N'2018-11-08 13:50:54.043', N'', N'', N'', N'', N'', N'004', N'069', N'1', N'4810607464731670528', N'DE-F3-65-B9-3F-4A-60-49', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'070', N'薛继亮', N'男', N'2018-11-08 13:56:20.360', N'', N'', N'', N'', N'', N'006', N'070', N'1', N'5099904187257014961', N'BC-E1-7C-75-7E-A5-58-73', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'081', N'李东', N'男', N'2018-11-08 13:53:38.807', N'', N'', N'', N'', N'', N'005', N'081', N'1', N'5747516387975246606', N'7C-19-FC-CC-72-86-56-F7', N'019')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'082', N'王伟庆', N'男', N'2018-11-08 13:42:08.687', N'', N'', N'', N'', N'', N'002', N'082', N'1', N'5741319240679750284', N'8A-0D-64-DC-C7-8C-C9-AC', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'153', N'吕雪亮', N'男', N'2018-11-08 13:47:47.870', N'', N'', N'', N'', N'', N'004', N'153', N'1', N'5668285020592756582', N'3C-D6-21-F8-0C-53-98-63', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'185', N'杨航', N'男', N'2018-11-08 13:48:24.917', N'', N'', N'', N'', N'', N'004', N'185', N'1', N'4810607464731670528', N'0B-A4-84-32-89-1D-AF-F3', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'191', N'韩冲', N'男', N'2018-11-08 13:54:46.750', N'', N'', N'', N'', N'', N'005', N'191', N'1', N'4779861912260944931', N'A4-A6-13-D5-95-E2-7B-C5', N'081')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'195', N'刘广亮', N'男', N'2018-11-08 13:55:06.437', N'', N'', N'', N'', N'', N'005', N'195', N'1', N'4779861912260944931', N'7D-03-B4-C4-37-3F-4B-2F', N'081')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'280', N'王海锋', N'男', N'2018-11-08 13:51:17.727', N'', N'', N'', N'', N'', N'004', N'280', N'1', N'4810607464731670528', N'E7-B7-60-01-E9-9C-C6-ED', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'332', N'田芳镇', N'男', N'2018-11-08 13:44:13.097', N'', N'', N'', N'', N'', N'002', N'332', N'1', N'4942112135862946065', N'6B-43-FC-92-8E-43-9B-41', N'082')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'344', N'周勇', N'男', N'2018-11-08 13:49:59.510', N'', N'', N'', N'', N'', N'004', N'344', N'1', N'4810607464731670528', N'D0-E2-06-5D-91-39-26-46', N'153')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'381', N'张渝', N'女', N'2018-11-08 13:37:32.463', N'', N'', N'', N'', N'', N'001', N'381', N'1', N'5389018953274466190', N'9C-46-81-8A-EF-DC-DB-66', N'034')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'387', N'赵猛', N'男', N'2018-11-08 13:55:31.837', N'', N'', N'', N'', N'', N'005', N'387', N'1', N'4779861912260944931', N'0A-B6-0D-AC-86-1F-88-A6', N'081')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'400', N'王旭', N'男', N'2018-11-08 13:57:13.473', N'', N'', N'', N'', N'', N'006', N'400', N'1', N'4808684293593031775', N'AB-C2-74-FF-3E-5C-64-96', N'022')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'402', N'黄东旭', N'男', N'2018-11-08 13:57:32.423', N'', N'', N'', N'', N'', N'006', N'402', N'1', N'4808684293593031775', N'AD-26-01-53-B5-DA-41-18', N'022')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'403', N'杨芳', N'女', N'2018-11-08 13:39:07.733', N'', N'', N'', N'', N'', N'001', N'403', N'1', N'5521515996607048136', N'A6-B8-58-44-CC-9D-04-7C', N'035')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'404', N'汪玥', N'女', N'2018-11-08 13:39:39.190', N'', N'', N'', N'', N'', N'001', N'404', N'1', N'5650920757624920835', N'70-55-18-F4-00-92-75-C1', N'035')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'414', N'郑国铁', N'男', N'2018-11-08 13:51:42.263', N'', N'', N'', N'', N'', N'004', N'414', N'1', N'4810607464731670528', N'A0-9A-07-C4-AE-65-52-4E', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'415', N'兰闯', N'男', N'2018-11-08 13:50:21.140', N'', N'', N'', N'', N'', N'004', N'415', N'1', N'4810607464731670528', N'75-7A-14-2F-28-66-20-3A', N'153')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'416', N'胡悦', N'女', N'2018-11-08 13:42:40.420', N'', N'', N'', N'', N'', N'002', N'416', N'1', N'4787578912702679601', N'1B-5B-AC-24-92-D7-4E-E2', N'082')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'432', N'田更', N'男', N'2018-11-08 13:52:06.763', N'', N'', N'', N'', N'', N'004', N'432', N'1', N'4810607464731670528', N'C7-84-DF-EA-C3-4F-36-71', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'471', N'吴海红', N'女', N'2018-11-08 13:44:52.720', N'', N'', N'', N'', N'', N'002', N'471', N'1', N'5056470603907942122', N'DE-6D-A1-E2-90-A6-04-EE', N'332')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'479', N'张玉铎', N'男', N'2018-11-08 13:45:38.723', N'', N'', N'', N'', N'', N'003', N'479', N'1', N'5314857441777340703', N'C7-5E-A6-69-E3-81-11-5A', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'490', N'刘涛', N'男', N'2018-11-08 13:46:15.783', N'', N'', N'', N'', N'', N'003', N'490', N'1', N'5314857441777340703', N'CF-7F-74-03-06-6C-19-CB', null)
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'499', N'窦永欢', N'男', N'2018-11-08 13:52:32.827', N'', N'', N'', N'', N'', N'004', N'499', N'1', N'4810607464731670528', N'CE-43-04-F1-F8-2A-1A-17', N'033')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'507', N'王恬', N'女', N'2018-11-08 13:40:41.773', N'', N'', N'', N'', N'', N'001', N'507', N'1', N'5521515996607048136', N'3D-77-3C-6A-3A-F0-23-A9', N'035')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'509', N'万丽', N'女', N'2018-11-08 13:58:46.463', N'', N'', N'', N'', N'', N'008', N'509', N'1', N'5299089426594489602', N'FF-9D-1C-1D-E0-D4-54-54', N'027')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'516', N'董阳', N'男', N'2018-11-08 13:55:52.287', N'', N'', N'', N'', N'', N'005', N'516', N'1', N'4779861912260944931', N'39-BE-F7-B2-98-B8-90-91', N'081')
GO
GO
INSERT INTO [dbo].[sm_employee] ([employ_Code], [employ_Name], [Sex], [birthday], [IDcardNo], [adress], [post_Code], [phone], [mobile], [dept_Code], [user_Name], [valid_Flag], [role_Id], [user_Password], [parent_Code]) VALUES (N'admin', N'管理员', N'男', N'2018-05-23 17:30:49.567', N'', N'', N'', N'', N'', N'000', N'admin', N'1', N'4994932516563855737', N'6F-64-39-3F-6A-AC-09-1E', null)
GO
GO

-- ----------------------------
-- Table structure for sm_fm_summenu
-- ----------------------------
DROP TABLE [dbo].[sm_fm_summenu]
GO
CREATE TABLE [dbo].[sm_fm_summenu] (
[FM_ID] int NOT NULL DEFAULT ((0)) ,
[X] int NOT NULL DEFAULT ((0)) ,
[M_ID] int NULL ,
[M_Value] varchar(200) NULL 
)


GO

-- ----------------------------
-- Records of sm_fm_summenu
-- ----------------------------
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'2', N'1', N'1', N'部门员工管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'1', N'1', N'合同信息')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'2', N'2', N'公司信息')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'3', N'3', N'基础数据信息')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'4', N'4', N'物料信息')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'5', N'5', N'配套表')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'6', N'6', N'物流费用')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'7', N'7', N'篷房报价信息')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'3', N'8', N'8', N'提成算法模板')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'4', N'1', N'1', N'价格预估')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'4', N'2', N'2', N'合同信息')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'4', N'3', N'3', N'合同摘要')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'4', N'4', N'4', N'项目联络单')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'5', N'1', N'1', N'合同审核')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'6', N'1', N'1', N'工程费用管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'6', N'2', N'2', N'查询统计')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'7', N'1', N'5', N'合同摘要')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'7', N'2', N'1', N'项目回款')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'7', N'3', N'2', N'回款审核')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'7', N'4', N'4', N'提成管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'7', N'5', N'3', N'查询统计')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'8', N'1', N'1', N'配套表管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'9', N'1', N'1', N'物料库存')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'9', N'2', N'2', N'出库管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'9', N'3', N'3', N'入库管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'9', N'4', N'4', N'盘库管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'9', N'5', N'5', N'查询统计')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'10', N'1', N'1', N'运输单')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'10', N'2', N'2', N'查询统计')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'11', N'1', N'1', N'盘库审核')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'12', N'1', N'1', N'回访管理')
GO
GO
INSERT INTO [dbo].[sm_fm_summenu] ([FM_ID], [X], [M_ID], [M_Value]) VALUES (N'12', N'2', N'2', N'发送参数设置')
GO
GO

-- ----------------------------
-- Table structure for sm_functionmodule
-- ----------------------------
DROP TABLE [dbo].[sm_functionmodule]
GO
CREATE TABLE [dbo].[sm_functionmodule] (
[FM_ID] int NOT NULL DEFAULT ((0)) ,
[FM_Name] varchar(300) NULL 
)


GO

-- ----------------------------
-- Records of sm_functionmodule
-- ----------------------------
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'2', N'公司组成管理')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'3', N'基础信息维护')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'4', N'合同管理(销售员)')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'5', N'拟定合同审核')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'6', N'工程费用管理')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'7', N'财务管理')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'8', N'配套表管理')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'9', N'库存管理')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'10', N'物流管理')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'11', N'盘库审核')
GO
GO
INSERT INTO [dbo].[sm_functionmodule] ([FM_ID], [FM_Name]) VALUES (N'12', N'费用回访管理')
GO
GO

-- ----------------------------
-- Table structure for sm_role_fm
-- ----------------------------
DROP TABLE [dbo].[sm_role_fm]
GO
CREATE TABLE [dbo].[sm_role_fm] (
[role_Id] bigint NOT NULL ,
[FM_ID] int NOT NULL 
)


GO

-- ----------------------------
-- Records of sm_role_fm
-- ----------------------------
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4658033902091172163', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4658033902091172163', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4675433097871916401', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4720455488005006364', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4722909659166928326', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4722909659166928326', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4753348060037337172', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4771654635415301513', N'6')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4771654635415301513', N'7')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4771654635415301513', N'9')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4779861912260944931', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4787578912702679601', N'10')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4808684293593031775', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4810607464731670528', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4821692879894691110', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4821692879894691110', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4828579130962139724', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4828579130962139724', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4858707176535425405', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4858707176535425405', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4893630052888293514', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4893630052888293514', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4903231945412572415', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4903231945412572415', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4942112135862946065', N'8')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4965493114346653961', N'6')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'4986069805452990582', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5043547877565053762', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5043547877565053762', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5056470603907942122', N'8')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5099904187257014961', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5099904187257014961', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5124312185368264968', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5161720140553131468', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5162319046412185304', N'7')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5173902305148546598', N'9')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5211123440521712707', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5211123440521712707', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5220671772344246129', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5220671772344246129', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5227352152884909609', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5227352152884909609', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5299089426594489602', N'6')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5314857441777340703', N'12')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5328357273351022599', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5328357273351022599', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5417688059915890797', N'6')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5417688059915890797', N'7')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5417688059915890797', N'9')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5512094111108124104', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5512094111108124104', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5521515996607048136', N'7')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5547938385216504705', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5547938385216504705', N'5')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5556374658627391173', N'6')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5569459454153723056', N'9')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5572334586288571221', N'10')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5624194518862011704', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5650920757624920835', N'7')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5651541369424302754', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5668285020592756582', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5675566733714155633', N'9')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5741319240679750284', N'9')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5741319240679750284', N'11')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5747516387975246606', N'4')
GO
GO
INSERT INTO [dbo].[sm_role_fm] ([role_Id], [FM_ID]) VALUES (N'5747516387975246606', N'5')
GO
GO

-- ----------------------------
-- Table structure for sm_sql
-- ----------------------------
DROP TABLE [dbo].[sm_sql]
GO
CREATE TABLE [dbo].[sm_sql] (
[Oper_date] datetime NULL ,
[Oper_code] varchar(20) NULL ,
[Sql_Remark] varchar(200) NULL ,
[Sql_Content] text NULL ,
[Sql_Index] varchar(200) NOT NULL 
)


GO

-- ----------------------------
-- Records of sm_sql
-- ----------------------------

-- ----------------------------
-- Table structure for sm_ui_fm_f_property
-- ----------------------------
DROP TABLE [dbo].[sm_ui_fm_f_property]
GO
CREATE TABLE [dbo].[sm_ui_fm_f_property] (
[FM_ID] int NOT NULL DEFAULT ((0)) ,
[F_ID] int NOT NULL DEFAULT ((0)) ,
[PropertyName] varchar(100) NOT NULL DEFAULT '' ,
[PropertyValue] varchar(100) NULL ,
[M_ID] int NULL ,
[Y] int NULL 
)


GO

-- ----------------------------
-- Records of sm_ui_fm_f_property
-- ----------------------------

-- ----------------------------
-- Table structure for sm_ui_form
-- ----------------------------
DROP TABLE [dbo].[sm_ui_form]
GO
CREATE TABLE [dbo].[sm_ui_form] (
[F_ID] int NOT NULL DEFAULT ((0)) ,
[Dll_Name] varchar(200) NULL ,
[Class_Name] varchar(300) NULL ,
[F_Name] varchar(200) NULL 
)


GO

-- ----------------------------
-- Records of sm_ui_form
-- ----------------------------
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'4', N'Miles.IMSFramework.dll', N'Miles.IMSFramework.UI.FmDeptEmployeeManager', N'部门员工管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'12', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Order.FmOrderManager', N'合同拟定管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'15', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Order.FmOrderCheckManager', N'拟定合同审核')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'16', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Gen.FmOrderGenManager', N'合同摘要管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'18', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.LinkBill.FmLinkBillManager', N'项目联络单管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'19', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.ProjectCost.FmProjectCostManager', N'工程费用管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'20', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Fin.FmProjectIncomeManager', N'财务项目回款管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'21', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Fin.FmIncomeCheckManager', N'财务回款审核')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'34', N'Miles.App.Entity.dll', N'Miles.App.Entity.UI.FmEnumManager', N'基础信息枚举管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'36', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Carriage.FmCarriageManager', N'运输单管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'37', N'GaoShan.Sales.Com.dll', N'GaoShan.Sales.Com.UI.FmAccountManager', N'公司合同账户管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'38', N'GaoShan.Sales.Com.dll', N'GaoShan.Sales.Com.UI.FmProductManager', N'产品信息管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'39', N'GaoShan.Sales.Com.dll', N'GaoShan.Sales.Com.UI.FmMtlManager', N'物料基础信息管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'40', N'GaoShan.Sales.Xls.dll', N'GaoShan.Sales.Xls.UI.FmTmpXlsManager', N'Excel模板管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'41', N'GaoShan.Sales.Xls.dll', N'GaoShan.Sales.Xls.UI.FmTmpXlsDocManager', N'Excel简单文档管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'42', N'GaoShan.Sales.Template.dll', N'GaoShan.Sales.Template.UI.FmTemplateManager', N'合同模板管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'43', N'GaoShan.Sales.MatchTb.dll', N'GaoShan.Sales.MatchTb.UI.FmMatchTbMtlManager', N'配套表模板物料组成管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'44', N'GaoShan.Sales.MatchTb.dll', N'GaoShan.Sales.MatchTb.UI.FmMatchTbVarManager', N'配套表模板变量管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'45', N'GaoShan.Sales.MatchTb.dll', N'GaoShan.Sales.MatchTb.UI.FmMatchTbManager', N'配套表管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'46', N'GaoShan.Sales.Quote.dll', N'GaoShan.Sales.Quote.UI.FmProductQuote', N'产品报价管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'47', N'GaoShan.Sales.Quote.dll', N'GaoShan.Sales.Quote.UI.FmTransportPlaceConfig', N'运费各地基础数据管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'48', N'GaoShan.Sales.Quote.dll', N'GaoShan.Sales.Quote.UI.FmTransportVarConfig', N'运输用车算法变量')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'49', N'GaoShan.Sales.Quote.dll', N'GaoShan.Sales.Quote.UI.FmTransportMaxConfig', N'运输用车最长间算法')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'50', N'GaoShan.Sales.Quote.dll', N'GaoShan.Sales.Quote.UI.FmTransUseTruckManager', N'运费预估管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'51', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreManager', N'物料库存管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'52', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Order.FmOrderQuery', N'业务员自己审核过合同查询')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'53', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreOutOrder', N'订单出库管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'54', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreBackOrder', N'库房租赁回库管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'55', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreInDir', N'直接入库管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'56', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreCheckManager', N'盘库管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'57', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreCheckPermitManager', N'盘库审核管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'58', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Fin.FmOrderIncomeQuery', N'合同回款查询')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'59', N'GaoShan.Sales.Salary.dll', N'GaoShan.Sales.Salary.UI.Tmp.FmSalaryTmpManager', N'提成算法模板管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'60', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Fin.FmProjectOutcomeManager', N'财务合同退款管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'61', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Fin.FmOutcomeCheckManager', N'财务合同退款审核')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'62', N'GaoShan.Sales.Salary.dll', N'GaoShan.Sales.Salary.UI.Cal.FmSalaryCalManager', N'财务提成计算管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'63', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Gen.FmOrderGenCheck', N'财务合同摘要审核')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'64', N'GaoShan.Sales.Salary.dll', N'GaoShan.Sales.Salary.UI.Cal.FmSalaryGrantManager', N'财务提成发放管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'65', N'GaoShan.ReturnVisit.dll', N'GaoShan.ReturnVisit.UI.FmReturnVisitManager', N'费用回访管理')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'66', N'GaoShan.ReturnVisit.dll', N'GaoShan.ReturnVisit.UI.FmSmsConfigManager', N'发送短信参数设置')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'67', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.ProjectCost.FmProjectCostQuery', N'工程费用查询')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'68', N'GaoShan.Sales.dll', N'GaoShan.Sales.UI.Carriage.FmCarriageQuery', N'运输单查询')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'69', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreInQuery', N'入库记录查询')
GO
GO
INSERT INTO [dbo].[sm_ui_form] ([F_ID], [Dll_Name], [Class_Name], [F_Name]) VALUES (N'70', N'GaoShan.Sales.Store.dll', N'GaoShan.Sales.Store.UI.FmStoreOutQuery', N'出库记录查询')
GO
GO

-- ----------------------------
-- Table structure for sm_ui_mainform
-- ----------------------------
DROP TABLE [dbo].[sm_ui_mainform]
GO
CREATE TABLE [dbo].[sm_ui_mainform] (
[SoftName] varchar(200) NULL ,
[CompanyName] varchar(200) NULL ,
[MenuVisible] int NULL ,
[ToolButtonVisible] int NULL ,
[FontSize] decimal(18) NULL 
)


GO

-- ----------------------------
-- Records of sm_ui_mainform
-- ----------------------------
INSERT INTO [dbo].[sm_ui_mainform] ([SoftName], [CompanyName], [MenuVisible], [ToolButtonVisible], [FontSize]) VALUES (N'高山外销管理系统', N'墨诚科技(开发产品)', N'1', N'0', N'12')
GO
GO

-- ----------------------------
-- Table structure for sm_user_fm
-- ----------------------------
DROP TABLE [dbo].[sm_user_fm]
GO
CREATE TABLE [dbo].[sm_user_fm] (
[User_Name] varchar(30) NOT NULL DEFAULT ('0') ,
[FM_ID] int NOT NULL DEFAULT ((0)) 
)


GO

-- ----------------------------
-- Records of sm_user_fm
-- ----------------------------
INSERT INTO [dbo].[sm_user_fm] ([User_Name], [FM_ID]) VALUES (N'admin', N'2')
GO
GO
INSERT INTO [dbo].[sm_user_fm] ([User_Name], [FM_ID]) VALUES (N'kk', N'0')
GO
GO
INSERT INTO [dbo].[sm_user_fm] ([User_Name], [FM_ID]) VALUES (N'yzj', N'2')
GO
GO
INSERT INTO [dbo].[sm_user_fm] ([User_Name], [FM_ID]) VALUES (N'zm', N'2')
GO
GO
INSERT INTO [dbo].[sm_user_fm] ([User_Name], [FM_ID]) VALUES (N'zm', N'3')
GO
GO

-- ----------------------------
-- Table structure for tb_carriage_bill
-- ----------------------------
DROP TABLE [dbo].[tb_carriage_bill]
GO
CREATE TABLE [dbo].[tb_carriage_bill] (
[odr_No] varchar(50) NULL ,
[carriage_State] int NULL ,
[carriage_Type] varchar(30) NOT NULL ,
[product_Name] varchar(300) NULL ,
[max_Length] decimal(18,2) NULL ,
[product_Weight] decimal(18,2) NULL ,
[product_Volume] decimal(18,2) NULL ,
[product_Count] decimal(18,2) NULL ,
[load_Date] datetime NULL ,
[arrive_Date] datetime NULL ,
[load_Place_Text] varchar(300) NULL ,
[unload_Place_Text] varchar(300) NULL ,
[transport_Type] varchar(30) NULL ,
[receive_Man] varchar(30) NULL ,
[transport_Nature] varchar(30) NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[carriage_Id] bigint NOT NULL ,
[receive_Phone] varchar(30) NULL ,
[pay_Part] varchar(50) NULL ,
[pay_Way] varchar(50) NULL ,
[carriage_Cost] decimal(18,2) NULL ,
[carrier_Name] varchar(50) NULL ,
[carrier_Phone] varchar(30) NULL ,
[trunk_Spec] varchar(50) NULL ,
[plate_Number] varchar(30) NULL ,
[driving_Num] varchar(50) NULL ,
[linkBill_Name] varchar(200) NULL ,
[carriage_Name] varchar(100) NULL ,
[linkBill_Id] bigint NULL ,
[load_Place_Id] bigint NULL ,
[unload_Place_Id] bigint NULL ,
[is_return_visit] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'carriage_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输单状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输单状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'carriage_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'product_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'max_Length')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'最长件'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'max_Length'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'最长件'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'max_Length'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'product_Weight')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'车载'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Weight'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'车载'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Weight'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'product_Volume')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'体积'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Volume'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'体积'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Volume'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'product_Count')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'件数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Count'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'件数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'product_Count'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'load_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'装车时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'load_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'装车时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'load_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'arrive_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'到达时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'arrive_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'到达时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'arrive_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'load_Place_Text')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'装车地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'load_Place_Text'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'装车地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'load_Place_Text'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'unload_Place_Text')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'卸车地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'unload_Place_Text'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'卸车地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'unload_Place_Text'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'transport_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'transport_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'transport_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'receive_Man')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'收货人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'receive_Man'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'收货人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'receive_Man'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'transport_Nature')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输性质'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'transport_Nature'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输性质'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'transport_Nature'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'oper_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'oper_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'carriage_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输单Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输单Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'receive_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'收货电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'receive_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'收货电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'receive_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'pay_Part')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'支付方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'pay_Part'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'支付方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'pay_Part'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'pay_Way')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'支付方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'pay_Way'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'支付方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'pay_Way'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'carriage_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运费'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运费'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carriage_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'carrier_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'承运人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carrier_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'承运人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carrier_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'carrier_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'承运人电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carrier_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'承运人电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'carrier_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'trunk_Spec')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'车辆规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'trunk_Spec'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'车辆规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'trunk_Spec'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'plate_Number')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'车牌号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'plate_Number'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'车牌号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'plate_Number'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'driving_Num')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'驾驶证号码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'driving_Num'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'驾驶证号码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'driving_Num'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'linkBill_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_carriage_bill', 
'COLUMN', N'is_return_visit')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否回访'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'is_return_visit'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否回访'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_carriage_bill'
, @level2type = 'COLUMN', @level2name = N'is_return_visit'
GO

-- ----------------------------
-- Records of tb_carriage_bill
-- ----------------------------
INSERT INTO [dbo].[tb_carriage_bill] ([odr_No], [carriage_State], [carriage_Type], [product_Name], [max_Length], [product_Weight], [product_Volume], [product_Count], [load_Date], [arrive_Date], [load_Place_Text], [unload_Place_Text], [transport_Type], [receive_Man], [transport_Nature], [oper_Date], [oper_Code], [carriage_Id], [receive_Phone], [pay_Part], [pay_Way], [carriage_Cost], [carrier_Name], [carrier_Phone], [trunk_Spec], [plate_Number], [driving_Num], [linkBill_Name], [carriage_Name], [linkBill_Id], [load_Place_Id], [unload_Place_Id], [is_return_visit]) VALUES (N'185/20181108-01-R', N'1', N'租赁项目', N'篷房', N'7.20', N'30.00', N'2.50', N'1.00', N'1753-01-01 00:00:00.000', N'1753-01-01 00:00:00.000', N'大兰坨村', N'家乐福', N'陆运', N'田总', N'经营运输', N'2018-11-08 16:14:51.000', N'admin', N'4710543188969313352', N'18309881020', N'乙方', N'现金', N'1500.00', N'李运鹏', N'18309881020', N'9.6米车', N'辽A83X63', N'210122634198762102', N'展销会', N'展销会', N'5005630670041188925', N'210122', N'210106', N'0')
GO
GO
INSERT INTO [dbo].[tb_carriage_bill] ([odr_No], [carriage_State], [carriage_Type], [product_Name], [max_Length], [product_Weight], [product_Volume], [product_Count], [load_Date], [arrive_Date], [load_Place_Text], [unload_Place_Text], [transport_Type], [receive_Man], [transport_Nature], [oper_Date], [oper_Code], [carriage_Id], [receive_Phone], [pay_Part], [pay_Way], [carriage_Cost], [carrier_Name], [carrier_Phone], [trunk_Spec], [plate_Number], [driving_Num], [linkBill_Name], [carriage_Name], [linkBill_Id], [load_Place_Id], [unload_Place_Id], [is_return_visit]) VALUES (N'069/20181109-01-R', N'1', N'租赁项目', N'篷房', N'12.00', N'23.00', N'3.00', N'1.00', N'2018-11-09 12:00:00.000', N'2018-11-09 23:00:00.000', N'华润24城', N'大兰坨村', N'陆运', N'胡悦', N'经营运输', N'2018-11-09 15:39:24.000', N'416', N'4950747972047293277', N'87941048', N'乙方', N'现金', N'2400.00', N'刘光涛', N'15712307900', N'17.5米车', N'辽K9929C', N'13940463201', N'大连华润24城', N'大连华润24城', N'5695809777847501518', N'210211', N'210122', N'0')
GO
GO
INSERT INTO [dbo].[tb_carriage_bill] ([odr_No], [carriage_State], [carriage_Type], [product_Name], [max_Length], [product_Weight], [product_Volume], [product_Count], [load_Date], [arrive_Date], [load_Place_Text], [unload_Place_Text], [transport_Type], [receive_Man], [transport_Nature], [oper_Date], [oper_Code], [carriage_Id], [receive_Phone], [pay_Part], [pay_Way], [carriage_Cost], [carrier_Name], [carrier_Phone], [trunk_Spec], [plate_Number], [driving_Num], [linkBill_Name], [carriage_Name], [linkBill_Id], [load_Place_Id], [unload_Place_Id], [is_return_visit]) VALUES (N'069/20181109-01-R', N'1', N'租赁项目', N'篷房', N'12.00', N'23.00', N'34.00', N'12.00', N'2018-11-09 00:00:00.000', N'2018-11-09 12:00:00.000', N'大兰坨村', N'华润24城', N'陆运', N'金勇日', N'经营运输', N'2018-11-09 15:34:20.000', N'416', N'5075750199864955386', N'13940463201', N'乙方', N'现金', N'2600.00', N'许正洪', N'15712307900', N'13米车', N'辽K0818A', N'13940463201', N'大连华润24城', N'大连华润24城', N'5695809777847501518', N'210122', N'210211', N'0')
GO
GO
INSERT INTO [dbo].[tb_carriage_bill] ([odr_No], [carriage_State], [carriage_Type], [product_Name], [max_Length], [product_Weight], [product_Volume], [product_Count], [load_Date], [arrive_Date], [load_Place_Text], [unload_Place_Text], [transport_Type], [receive_Man], [transport_Nature], [oper_Date], [oper_Code], [carriage_Id], [receive_Phone], [pay_Part], [pay_Way], [carriage_Cost], [carrier_Name], [carrier_Phone], [trunk_Spec], [plate_Number], [driving_Num], [linkBill_Name], [carriage_Name], [linkBill_Id], [load_Place_Id], [unload_Place_Id], [is_return_visit]) VALUES (N'069/20181109-01-R', N'1', N'租赁项目', N'篷房', N'9.20', N'30.00', N'45.00', N'1.00', N'2018-11-09 00:00:00.000', N'2018-11-09 12:00:00.000', N'大兰坨村', N'华润24城', N'陆运', N'金勇日', N'经营运输', N'2018-11-09 15:34:52.000', N'416', N'5192735369672135622', N'15904018550', N'乙方', N'现金', N'2600.00', N'钮金海', N'15712307900', N'13米车', N'冀AKE152', N'13940463201', N'大连华润24城', N'大连华润24城', N'5695809777847501518', N'210122', N'210211', N'0')
GO
GO
INSERT INTO [dbo].[tb_carriage_bill] ([odr_No], [carriage_State], [carriage_Type], [product_Name], [max_Length], [product_Weight], [product_Volume], [product_Count], [load_Date], [arrive_Date], [load_Place_Text], [unload_Place_Text], [transport_Type], [receive_Man], [transport_Nature], [oper_Date], [oper_Code], [carriage_Id], [receive_Phone], [pay_Part], [pay_Way], [carriage_Cost], [carrier_Name], [carrier_Phone], [trunk_Spec], [plate_Number], [driving_Num], [linkBill_Name], [carriage_Name], [linkBill_Id], [load_Place_Id], [unload_Place_Id], [is_return_visit]) VALUES (N'069/20181109-01-R', N'1', N'租赁项目', N'篷房', N'12.00', N'23.00', N'23.00', N'1.00', N'2018-11-09 12:00:00.000', N'2018-11-09 23:00:00.000', N'华润24城', N'大兰坨村', N'陆运', N'胡悦', N'经营运输', N'2018-11-09 15:37:41.000', N'416', N'5408636686370598752', N'87941048', N'乙方', N'现金', N'2400.00', N'肖景俊', N'15712307900', N'13米车', N'辽H83423', N'13940463201', N'大连华润24城', N'大连华润24城', N'5695809777847501518', N'210211', N'210122', N'0')
GO
GO
INSERT INTO [dbo].[tb_carriage_bill] ([odr_No], [carriage_State], [carriage_Type], [product_Name], [max_Length], [product_Weight], [product_Volume], [product_Count], [load_Date], [arrive_Date], [load_Place_Text], [unload_Place_Text], [transport_Type], [receive_Man], [transport_Nature], [oper_Date], [oper_Code], [carriage_Id], [receive_Phone], [pay_Part], [pay_Way], [carriage_Cost], [carrier_Name], [carrier_Phone], [trunk_Spec], [plate_Number], [driving_Num], [linkBill_Name], [carriage_Name], [linkBill_Id], [load_Place_Id], [unload_Place_Id], [is_return_visit]) VALUES (N'185/20181108-01-R', N'0', N'租赁项目', N'展销会二次发货', N'7.20', N'7.20', N'.10', N'1.00', N'1753-01-01 00:00:00.000', N'1753-01-01 00:00:00.000', N'大兰坨村', N'家乐福', N'陆运', N'田总', N'经营运输', N'2018-11-08 16:59:06.000', N'admin', N'5694624092911142567', N'15712307900', N'乙方', N'现金', N'35.00', N'马列军', N'13843884388', N'6.8米车', N'辽A32453', N'210122662403939488', N'展销会', N'展销会', N'5005630670041188925', N'210122', N'210106', N'0')
GO
GO

-- ----------------------------
-- Table structure for tb_company_act
-- ----------------------------
DROP TABLE [dbo].[tb_company_act]
GO
CREATE TABLE [dbo].[tb_company_act] (
[act_Id] bigint NOT NULL ,
[act_Name] nvarchar(50) NULL ,
[act_FaRen] varchar(30) NULL ,
[act_Adress] varchar(300) NULL ,
[act_Phone] varchar(30) NULL ,
[pay_Act_Name] varchar(300) NULL ,
[pay_Bank_Name] varchar(100) NULL ,
[pay_Act_No] varchar(30) NULL ,
[pay_Tax_Code] varchar(30) NULL ,
[define_Code] varchar(30) NULL ,
[valid_Flag] int NULL ,
[remark] nvarchar(100) NULL 
)


GO

-- ----------------------------
-- Records of tb_company_act
-- ----------------------------
INSERT INTO [dbo].[tb_company_act] ([act_Id], [act_Name], [act_FaRen], [act_Adress], [act_Phone], [pay_Act_Name], [pay_Bank_Name], [pay_Act_No], [pay_Tax_Code], [define_Code], [valid_Flag], [remark]) VALUES (N'5406388792882078531', N'高山篷房制造（沈阳）有限公司', N'高山', N'辽宁省沈阳市辽中区肖寨门镇大兰坨村', N'024-87942549', N'高山篷房制造（沈阳）有限公司', N'中国农业银行辽中县支行', N'06105001040016018', N'91210122662506879U', N'001', N'1', N'')
GO
GO
INSERT INTO [dbo].[tb_company_act] ([act_Id], [act_Name], [act_FaRen], [act_Adress], [act_Phone], [pay_Act_Name], [pay_Bank_Name], [pay_Act_No], [pay_Tax_Code], [define_Code], [valid_Flag], [remark]) VALUES (N'5344572581832150423', N'高山气膜技术（沈阳）有限公司', N'高庄', N'沈阳市辽中区浦东街道房身地村', N'024-87943513', N'高山气膜技术（沈阳）有限公司', N'中国农业银行辽中县支行', N'06105001040031413', N'91210122MA0P53BG6J', N'002', N'1', N'')
GO
GO
INSERT INTO [dbo].[tb_company_act] ([act_Id], [act_Name], [act_FaRen], [act_Adress], [act_Phone], [pay_Act_Name], [pay_Bank_Name], [pay_Act_No], [pay_Tax_Code], [define_Code], [valid_Flag], [remark]) VALUES (N'5612246490215369950', N'沈阳泰德姆膜结构建筑安装有限公司', N'法人', N'辽宁省沈阳新民市湖滨西路5号6-7轴13555791770', N'024-87942549', N'沈阳泰德姆膜结构建筑安装有限公司', N'中国工商银行新民市支行', N'3301000209248223567', N'91210181MA0UNFB00J', N'003', N'1', N'')
GO
GO
INSERT INTO [dbo].[tb_company_act] ([act_Id], [act_Name], [act_FaRen], [act_Adress], [act_Phone], [pay_Act_Name], [pay_Bank_Name], [pay_Act_No], [pay_Tax_Code], [define_Code], [valid_Flag], [remark]) VALUES (N'5625086375365777037', N'新民市场丹辉会议会展服务中心', N'张玉贤', N'新民市新柳街道68号', N'0000000', N'000', N'000', N'000', N'000', N'000', N'1', N'000')
GO
GO

-- ----------------------------
-- Table structure for tb_contract_template
-- ----------------------------
DROP TABLE [dbo].[tb_contract_template]
GO
CREATE TABLE [dbo].[tb_contract_template] (
[template_Id] int NOT NULL ,
[template_Text] image NULL 
)


GO

-- ----------------------------
-- Records of tb_contract_template
-- ----------------------------

-- ----------------------------
-- Table structure for tb_customer
-- ----------------------------
DROP TABLE [dbo].[tb_customer]
GO
CREATE TABLE [dbo].[tb_customer] (
[csr_Id] bigint NOT NULL ,
[csr_Name] varchar(300) NULL ,
[csr_FaRen] varchar(30) NULL ,
[csr_DaiLi] varchar(30) NULL ,
[csr_Adress] varchar(300) NULL ,
[csr_Phone] varchar(30) NULL ,
[csr_Fax] varchar(30) NULL ,
[define_Code] varchar(30) NULL ,
[col_Extend] text NULL ,
[remark] nvarchar(100) NULL 
)


GO

-- ----------------------------
-- Records of tb_customer
-- ----------------------------

-- ----------------------------
-- Table structure for tb_default_adress
-- ----------------------------
DROP TABLE [dbo].[tb_default_adress]
GO
CREATE TABLE [dbo].[tb_default_adress] (
[place_Id] bigint NULL ,
[detail_Adress] varchar(300) NULL 
)


GO

-- ----------------------------
-- Records of tb_default_adress
-- ----------------------------
INSERT INTO [dbo].[tb_default_adress] ([place_Id], [detail_Adress]) VALUES (N'210122', N'大兰坨村')
GO
GO

-- ----------------------------
-- Table structure for tb_enum
-- ----------------------------
DROP TABLE [dbo].[tb_enum]
GO
CREATE TABLE [dbo].[tb_enum] (
[item_Id] bigint NOT NULL ,
[enum_Kind] varchar(50) NULL ,
[enum_Value] decimal(18) NULL ,
[enum_Text] varchar(50) NULL ,
[item_Flag] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_enum', 
'COLUMN', N'item_Flag')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'1为大类，0为子项'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_enum'
, @level2type = 'COLUMN', @level2name = N'item_Flag'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'1为大类，0为子项'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_enum'
, @level2type = 'COLUMN', @level2name = N'item_Flag'
GO

-- ----------------------------
-- Records of tb_enum
-- ----------------------------
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4612983046205228990', N'lld_net_frame', N'2', N'小网框', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4613410757962143439', N'TaxType', N'2', N'增值税发票', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4615432498795770417', N'Expend_Item', N'13', N'厂内工人工资', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4618947304625819448', N'lld_ground_State', N'1', N'大理石', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4643928584143485971', N'TransportParties', N'3', N'三方物流', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4649877760158268310', N'GroundState', N'5', N'沙滩', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4667120783852869510', N'lld_steel_part_pack', N'3', N'塑封', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4669497739029116354', N'Trans_Both_Direction', N'2', N'回车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4677775314262461615', N'Trunk_Spec', N'130', N'13米车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4689907954258760698', N'lld_net_frame', N'0', N'联络单-网框', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4698868690706913092', N'lld_has_Logo', N'0', N'联络单-篷房是否带LOGO', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4704184115270010837', N'BuildParties', N'2', N'甲方搭建', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4722350629508984583', N'lld_lamp_Info', N'2', N'150W', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4723073314891778434', N'Expend_Item', N'1', N'叉车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4733237224218832775', N'Transport_Nature', N'2', N'非经营运输', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4748331556529980946', N'Fin_ReceivePayWay', N'2', N'支票支付', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4755799489469622634', N'lld_Provide_Info', N'6', N'施工图', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4761854279481219441', N'lld_steel_drill', N'2', N'螺纹钢', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4777170344889550764', N'lld_Provide_Info', N'5', N'立面图', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4778769202631421712', N'Carriage_Type', N'4', N'货物调转', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4780213998928338330', N'TransItemType', N'0', N'运费基础类型', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4786233672675574407', N'lld_ground_State', N'3', N'草地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4812771185685765278', N'Expend_Item', N'14', N'外建员工工资', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4818341269450076194', N'lld_wall_Require', N'1', N'玻璃墙', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4827625087394182246', N'TransportParties', N'2', N'乙方', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4831635586466650575', N'lld_tent_Pack', N'2', N'编织袋', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4863369105544048740', N'OrderState', N'0', N'合同状态', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4874352841078498774', N'Trunk_Spec', N'0', N'车辆规格', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4878562959415936448', N'OrderState', N'0', N'拟定新建-未提交', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4890854846996821469', N'lld_tool_Bar', N'0', N'联络单-工具栏', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4903479956702532255', N'lld_en_roof_purlin', N'1', N'是', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4906369600716465320', N'Salary_Kind', N'2', N'部门奖提成', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4909256514164091454', N'Trunk_Spec', N'175', N'17.5米车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4909430236783945127', N'GroundState', N'6', N'沥青', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4912426079850222961', N'lld_wall_Require', N'3', N'ABS墙', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4913052406756956811', N'lld_lamp_Info', N'5', N'黄色', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4913415105462603569', N'OrderType', N'2', N'租赁合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4915874362501840925', N'FixedMode', N'2', N'配重', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4918027709698247671', N'Carriage_Type', N'7', N'海运', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4934361240402553394', N'OrderState', N'2', N'合同审核通过', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4942280754523833755', N'Trans_Both_Direction', N'1', N'发车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4947939316866547952', N'Transport_Type', N'3', N'铁路运输', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4962184084976724326', N'OrderTypeCode', N'3', N'F', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4978374690713349551', N'Transport_Type', N'0', N'运输方式', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4982212797465722457', N'lld_tent_Require', N'5', N'其他', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4984170467786684546', N'Carriage_Type', N'0', N'运输类型', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4984860797920637940', N'lld_lamp_Info', N'1', N'节能灯', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'4998756585538065144', N'lld_engine_truck_way', N'2', N'不可进场地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5010307574483870617', N'Expend_Item', N'16', N'其它', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5011420636417971822', N'lld_is_truck_enter', N'2', N'不可进场地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5011461942853875577', N'BuildParties', N'0', N'搭建方', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5035316437989296859', N'Salary_Type', N'1', N'销售合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5038155428658286910', N'lld_steel_part_pack', N'2', N'网框', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5040368022723394995', N'OrderType', N'4', N'追加合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5043170008300412219', N'Expend_Item', N'0', N'工程部费用-支出项目', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5048924800050873737', N'BuildParties', N'1', N'乙方搭建', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5054040740756561935', N'Pay_Way', N'0', N'付款方式', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5054732713840800270', N'lld_ground_State', N'0', N'联络单-地面情况', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5066380884342997102', N'Pay_Part', N'1', N'甲方', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5076429275110603520', N'OrderType', N'0', N'合同类型', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5086386351417560850', N'lld_tent_Require', N'3', N'B类', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5087536629916753386', N'lld_is_truck_enter', N'1', N'可进场地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5094196499937647515', N'Carriage_Type', N'2', N'销售项目', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5095833093804237861', N'lld_Provide_Info', N'1', N'三维效果图', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5097055039369989412', N'TransportParties', N'1', N'甲方', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5098041890388016706', N'lld_tool_Bar', N'4', N'扳手', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5104768769582812925', N'lld_engine_truck_way', N'0', N'联络单-工程车辆作业', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5110114997911326406', N'GroundState', N'2', N'大理石', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5111084926317022924', N'Transport_Type', N'2', N'海运', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5113947766394008829', N'lld_steel_part_pack', N'1', N'吨袋', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5113962658461996351', N'TaxType', N'1', N'小规模发票', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5137141945248707614', N'TaxType', N'3', N'不开发票', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5144503809112615875', N'OrderTypeCode', N'4', N'A', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5145282157724379542', N'lld_peri_cloth_bear', N'1', N'需要', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5157085192429220443', N'Carriage_Type', N'5', N'厂内用车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5158496616824995058', N'Pay_Part', N'2', N'乙方', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5159181680646580883', N'OrderTypeCode', N'2', N'R', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5160687219546520291', N'FixedMode', N'0', N'固定方式', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5164748375716261253', N'lld_peri_cloth_bear', N'2', N'不需要', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5166135063185202483', N'lld_tent_Require', N'2', N'A类', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5171457146353214631', N'Salary_Type', N'0', N'合同提成算法类型', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5174466562102613881', N'TwoParties', N'0', N'合同双方', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5177188356231178548', N'OrderType', N'1', N'销售合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5181316341613180390', N'lld_tool_Bar', N'5', N'小车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5183206822111008183', N'GroundState', N'4', N'草地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5184797805750764600', N'Expend_Item', N'12', N'厂内工人外出补助', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5186783093897646292', N'Fin_ReceivePayWay', N'0', N'财务-回款类型', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5188633792604068071', N'lld_tent_Require', N'1', N'全新', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5191800070593174172', N'lld_wall_Require', N'2', N'玻璃门', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5197320739567857508', N'lld_Provide_Info', N'4', N'电路图', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5197712021489509946', N'lld_net_frame', N'1', N'大网框', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5199171447581809755', N'TwoParties', N'2', N'乙方', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5207792205319452853', N'Fin_CompanyAccount', N'3', N'张玉贤/邮政/21012292445445445', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5224315173459988518', N'Carriage_Type', N'6', N'接送工人', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5240801057826816117', N'lld_tent_Pack', N'0', N'联络单-篷布包装', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5248198095676214947', N'lld_Provide_Info', N'2', N'平面图', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5251324713802506715', N'lld_lamp_Info', N'4', N'白色', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5259821426202400250', N'FixedMode', N'3', N'膨胀螺栓', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5270768594462177121', N'lld_has_Logo', N'2', N'否', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5273647447487322168', N'OrderState', N'3', N'合同作废', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5274788900446379390', N'lld_en_roof_purlin', N'2', N'否', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5278930096224476262', N'lld_ground_State', N'4', N'沥青', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5298155993029904966', N'GroundState', N'3', N'土地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5310885657792143796', N'OrderTypeCode', N'1', N'S', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5315434711734634317', N'FixedMode', N'6', N'无', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5316313089440063814', N'Fin_ReceivePayWay', N'1', N'现金转帐', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5316526297513771959', N'Expend_Item', N'11', N'市内交通费', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5322939631041029768', N'lld_tool_Bar', N'2', N'叉枪', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5324229023036424888', N'Salary_Type', N'3', N'固定合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5340533979223626533', N'lld_lamp_Info', N'3', N'250W', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5343361800054559982', N'Pay_Way', N'2', N'转账', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5345724987502256286', N'lld_tool_Bar', N'1', N'绳子', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5347698076862804979', N'lld_wall_Require', N'4', N'其他', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5348440002725565156', N'Expend_Item', N'3', N'铲车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5356472866541557053', N'Expend_Item', N'9', N'餐费', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5357115556516540655', N'Expend_Item', N'7', N'沙子', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5363193260348902058', N'OrderTypeCode', N'0', N'合同类型对应生成编码简写', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5364361273616219761', N'lld_tent_Require', N'0', N'联络单-篷布要求', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5368066656208929500', N'lld_ground_State', N'7', N'沙滩', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5368317805993668358', N'Transport_Nature', N'1', N'经营运输', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5369643904525767686', N'lld_has_Logo', N'1', N'是', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5373013225198480615', N'lld_ground_State', N'5', N'土地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5373230463735675386', N'Expend_Item', N'6', N'力工', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5378917187434091458', N'lld_is_truck_enter', N'0', N'联络单-货车进场', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5386934411466058438', N'Trans_Both_Direction', N'0', N'运输往返状态', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5398618035954944417', N'FixedMode', N'1', N'钢钎', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5408286629021062220', N'OrderType', N'3', N'服务合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5409195597692768029', N'GroundState', N'0', N'地面情况', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5410111924714594821', N'TransItemType', N'2', N'型材规格', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5414003795228325252', N'lld_Provide_Info', N'3', N'施工位置图', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5425336224492215519', N'Expend_Item', N'8', N'住宿费', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5429753315608258570', N'TaxType', N'0', N'税票类型', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5445500887404536315', N'Trunk_Spec', N'96', N'9.6米车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5452166082436117539', N'lld_Provide_Info', N'7', N'场地照片', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5460833949874516307', N'lld_ground_State', N'6', N'砖地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5460872863561778858', N'lld_en_roof_purlin', N'0', N'联络单-加密屋面檩条', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5472943335296651574', N'Expend_Item', N'5', N'升降车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5483621079212405882', N'lld_tent_Pack', N'1', N'帆布袋', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5484028852916273865', N'Expend_Item', N'2', N'吊车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5496102984442536512', N'Transport_Nature', N'0', N'运输性质', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5503611028785365190', N'lld_steel_drill', N'1', N'标准的', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5512004447506478512', N'lld_wall_Require', N'0', N'联络单-墙体要求', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5523780278467379229', N'lld_tent_Require', N'4', N'C类', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5524879095391487901', N'FixedMode', N'4', N'钢钎+配重', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5526220845870918097', N'Carriage_Type', N'1', N'租赁项目', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5542374317273288638', N'OrderState', N'1', N'拟定提交-待审核', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5543978038168286439', N'GroundState', N'7', N'砖地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5546563817270383014', N'Fin_CompanyAccount', N'2', N'高山-农业银行/6228117809871220321', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5546896152717337366', N'Salary_Kind', N'1', N'成交人提成', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5550902709004832732', N'TwoParties', N'1', N'甲方', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5551643491065952948', N'lld_Provide_Info', N'0', N'联络单-提供资料', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5553545471600202264', N'Expend_Item', N'15', N'外采物资', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5563035405821718674', N'GroundState', N'1', N'水泥地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5563637344360789054', N'TransportParties', N'0', N'运输方', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5564496512646839181', N'Carriage_Type', N'3', N'二次发货', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5578029020719321386', N'lld_tool_Bar', N'3', N'梯子', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5579871101833865344', N'FixedMode', N'5', N'膨胀螺栓+配重', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5588280607558239114', N'lld_power_Box', N'2', N'电线', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5629146291763753759', N'Trunk_Spec', N'68', N'6.8米车', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5630875019658715461', N'Fin_CompanyAccount', N'1', N'高山-建设银行/6228117809871220321', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5633371654982634114', N'Salary_Kind', N'0', N'提成类别', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5642464437527103131', N'lld_power_Box', N'0', N'联络单-配电箱', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5669028775862593966', N'Salary_Type', N'2', N'租赁合同', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5669451651948545668', N'Expend_Item', N'10', N'长途交通费', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5672100655063293351', N'Pay_Way', N'1', N'现金', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5684111365345859229', N'Fin_CompanyAccount', N'0', N'财务-入帐帐号', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5685499156980894517', N'lld_ground_State', N'2', N'水泥', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5688147899802562992', N'Transport_Type', N'1', N'陆运', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5701583117601929056', N'TransItemType', N'1', N'边高', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5701934993828508933', N'lld_steel_drill', N'0', N'联络单-钢钎', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5717161250726817946', N'lld_peri_cloth_bear', N'0', N'联络单-围布承重管', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5733316176395517019', N'lld_power_Box', N'1', N'配电箱', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5738096443150011533', N'lld_lamp_Info', N'0', N'联络单-灯具', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5744471122093646576', N'lld_engine_truck_way', N'1', N'可进场地', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5749125860177239515', N'Salary_Kind', N'3', N'组织奖提成', N'0')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5753697254652851881', N'Pay_Part', N'0', N'付款方', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5761003526686409682', N'lld_steel_part_pack', N'0', N'联络单-钢部件包装', N'1')
GO
GO
INSERT INTO [dbo].[tb_enum] ([item_Id], [enum_Kind], [enum_Value], [enum_Text], [item_Flag]) VALUES (N'5762921363794303817', N'Expend_Item', N'4', N'勾机', N'0')
GO
GO

-- ----------------------------
-- Table structure for tb_fin_order_gen
-- ----------------------------
DROP TABLE [dbo].[tb_fin_order_gen]
GO
CREATE TABLE [dbo].[tb_fin_order_gen] (
[odr_No] varchar(50) NOT NULL ,
[gen_Date] datetime NULL ,
[odr_Type] int NULL ,
[jia_Name] varchar(300) NULL ,
[jia_Adress] varchar(300) NULL ,
[jia_Phone] varchar(30) NULL ,
[jia_Fax] varchar(30) NULL ,
[odr_Prt_Name] varchar(300) NULL ,
[odr_Sum_Area] decimal(18) NULL ,
[odr_Prt_Purpose] varchar(300) NULL ,
[odr_Trans_Party] varchar(300) NULL ,
[odr_Place_Linkman] varchar(300) NULL ,
[odr_Bud_Palce] varchar(300) NULL ,
[odr_Place_Phone] varchar(300) NULL ,
[odr_Ground_State] varchar(300) NULL ,
[odr_Water_proof] varchar(300) NULL ,
[odr_Fixed_Mode] varchar(300) NULL ,
[odr_Tax_Type] varchar(300) NULL ,
[tot_Cost] decimal(10,2) NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[deliver_Date] datetime NULL ,
[supplier_Info] varchar(500) NULL ,
[remark] varchar(500) NULL ,
[odr_Cost] decimal(18) NULL ,
[part_Cost] decimal(18) NULL ,
[freight_Cost] decimal(18) NULL ,
[sales_Cost] decimal(18) NULL ,
[tax_Cost] decimal(18) NULL ,
[employ_Code] varchar(30) NULL ,
[gen_State] int NULL ,
[pay_Cost] decimal(10,2) NULL ,
[is_Salary] int NULL ,
[odr_No_Main] varchar(50) NULL ,
[rent_Cost] decimal(10,2) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'gen_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'制表时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'gen_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'制表时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'gen_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'jia_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'jia_Adress')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Adress'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Adress'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'jia_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'jia_Fax')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方传真'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Fax'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方传真'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'jia_Fax'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Prt_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Sum_Area')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同总面积'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Sum_Area'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同总面积'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Sum_Area'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Prt_Purpose')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'产品用途'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Purpose'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'产品用途'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Purpose'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Trans_Party')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Trans_Party'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Trans_Party'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Place_Linkman')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'场地联系人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Linkman'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'场地联系人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Linkman'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Bud_Palce')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'搭建地点'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Palce'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'搭建地点'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Palce'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Place_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'场地联系电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'场地联系电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Ground_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'地面状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Ground_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'地面状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Ground_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Water_proof')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'地面防水'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Water_proof'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'地面防水'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Water_proof'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Fixed_Mode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Fixed_Mode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Fixed_Mode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Tax_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同税票'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Tax_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同税票'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Tax_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'tot_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同成交金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'tot_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同成交金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'tot_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'oper_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'oper_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'deliver_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'提货时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'deliver_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'提货时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'deliver_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'supplier_Info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'供货方信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'supplier_Info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'供货方信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'supplier_Info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'remark')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'remark'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'remark'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'part_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'part_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'part_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'freight_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运费'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'freight_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运费'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'freight_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'sales_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售费用'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'sales_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售费用'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'sales_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'tax_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'税费'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'tax_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'税费'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'tax_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'employ_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'业务员'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'业务员'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'gen_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同摘要状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'gen_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同摘要状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'gen_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'pay_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'已经支付的金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'pay_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'已经支付的金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'pay_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'is_Salary')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否计算提成了'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'is_Salary'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否计算提成了'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'is_Salary'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'odr_No_Main')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'主合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_No_Main'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'主合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'odr_No_Main'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_gen', 
'COLUMN', N'rent_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'外租金'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'rent_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'外租金'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_gen'
, @level2type = 'COLUMN', @level2name = N'rent_Cost'
GO

-- ----------------------------
-- Records of tb_fin_order_gen
-- ----------------------------
INSERT INTO [dbo].[tb_fin_order_gen] ([odr_No], [gen_Date], [odr_Type], [jia_Name], [jia_Adress], [jia_Phone], [jia_Fax], [odr_Prt_Name], [odr_Sum_Area], [odr_Prt_Purpose], [odr_Trans_Party], [odr_Place_Linkman], [odr_Bud_Palce], [odr_Place_Phone], [odr_Ground_State], [odr_Water_proof], [odr_Fixed_Mode], [odr_Tax_Type], [tot_Cost], [oper_Date], [oper_Code], [deliver_Date], [supplier_Info], [remark], [odr_Cost], [part_Cost], [freight_Cost], [sales_Cost], [tax_Cost], [employ_Code], [gen_State], [pay_Cost], [is_Salary], [odr_No_Main], [rent_Cost]) VALUES (N'069/20181109-01-R', N'2018-11-09 16:00:02.023', N'2', N'沈阳凡禾文化传播有限公司', N'沈阳市和平区', N'00', N'00', N'人字顶篷房', N'1050', N'活动', N'乙方', N'赵经理', N'大连甘井子区华润24城', N'15524055501', N'大理石', N'无防水', N'配重', N'不开发票', N'50000.00', N'2018-11-09 15:59:53.000', N'404', N'2018-11-08 14:50:13.000', N'高山篷房制造（沈阳）有限公司', N'', N'52010', N'0', N'10000', N'0', N'0', N'069', N'1', N'50010.00', N'1', N'069/20181109-01-R', N'.00')
GO
GO
INSERT INTO [dbo].[tb_fin_order_gen] ([odr_No], [gen_Date], [odr_Type], [jia_Name], [jia_Adress], [jia_Phone], [jia_Fax], [odr_Prt_Name], [odr_Sum_Area], [odr_Prt_Purpose], [odr_Trans_Party], [odr_Place_Linkman], [odr_Bud_Palce], [odr_Place_Phone], [odr_Ground_State], [odr_Water_proof], [odr_Fixed_Mode], [odr_Tax_Type], [tot_Cost], [oper_Date], [oper_Code], [deliver_Date], [supplier_Info], [remark], [odr_Cost], [part_Cost], [freight_Cost], [sales_Cost], [tax_Cost], [employ_Code], [gen_State], [pay_Cost], [is_Salary], [odr_No_Main], [rent_Cost]) VALUES (N'185/20181108-01-R', N'2018-11-08 15:41:30.433', N'2', N'高山气膜技术（沈阳）有限公司', N'辽宁省沈阳市辽中区蒲东街道', N'024-87941313', N'024-87941733', N'篷房', N'500', N'展销会', N'乙方', N'田总', N'铁西区家乐福', N'18887879997', N'水泥地', N'无', N'沙袋固定', N'不开发票', N'100000.00', N'2018-11-08 15:41:26.000', N'185', N'2018-11-08 15:39:09.957', N'高山篷房制造（沈阳）有限公司', N'', N'100000', N'10000', N'20000', N'20000', N'0', N'185', N'1', N'100000.00', N'1', N'185/20181108-01-R', N'.00')
GO
GO

-- ----------------------------
-- Table structure for tb_fin_order_income
-- ----------------------------
DROP TABLE [dbo].[tb_fin_order_income]
GO
CREATE TABLE [dbo].[tb_fin_order_income] (
[fin_Id] bigint NOT NULL ,
[odr_No] varchar(50) NOT NULL ,
[fin_Date] datetime NULL ,
[odr_Type] int NULL ,
[jia_Name] varchar(300) NULL ,
[odr_Prt_Name] varchar(300) NULL ,
[pay_Cost] decimal(10,2) NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[pay_Way] varchar(255) NULL ,
[pay_Account] varchar(255) NULL ,
[pay_remark] varchar(500) NULL ,
[employ_Code] varchar(30) NULL ,
[audit_Code] varchar(30) NULL ,
[audit_Date] datetime NULL ,
[fin_State] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'fin_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'fin_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'fin_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'fin_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'回款日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'fin_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'回款日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'fin_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'odr_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'jia_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'odr_Prt_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'pay_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'支付金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'支付金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'oper_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'oper_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'pay_Way')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'回款类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_Way'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'回款类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_Way'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'pay_Account')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'入款账户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_Account'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'入款账户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_Account'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'pay_remark')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_remark'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'pay_remark'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'employ_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'业务员编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'业务员编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'audit_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'审核人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'audit_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'审核人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'audit_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'audit_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'审核日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'audit_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'审核日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'audit_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_income', 
'COLUMN', N'fin_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'回款状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'fin_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'回款状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_income'
, @level2type = 'COLUMN', @level2name = N'fin_State'
GO

-- ----------------------------
-- Records of tb_fin_order_income
-- ----------------------------
INSERT INTO [dbo].[tb_fin_order_income] ([fin_Id], [odr_No], [fin_Date], [odr_Type], [jia_Name], [odr_Prt_Name], [pay_Cost], [oper_Date], [oper_Code], [pay_Way], [pay_Account], [pay_remark], [employ_Code], [audit_Code], [audit_Date], [fin_State]) VALUES (N'4705547328225709720', N'185/20181108-01-R', N'2018-11-09 11:50:30.690', N'2', N'高山气膜技术（沈阳）有限公司', N'篷房', N'100000.00', N'2018-11-09 11:50:53.000', N'admin', N'现金转帐', N'高山-建设银行/6228117809871220321', N'', N'185', N'admin', N'2018-11-09 11:51:27.000', N'2')
GO
GO
INSERT INTO [dbo].[tb_fin_order_income] ([fin_Id], [odr_No], [fin_Date], [odr_Type], [jia_Name], [odr_Prt_Name], [pay_Cost], [oper_Date], [oper_Code], [pay_Way], [pay_Account], [pay_remark], [employ_Code], [audit_Code], [audit_Date], [fin_State]) VALUES (N'4922502101057160575', N'069/20181109-01-R', N'2018-11-09 16:10:42.123', N'2', N'沈阳凡禾文化传播有限公司', N'人字顶篷房', N'50000.00', N'2018-11-09 16:10:44.000', N'404', N'现金转帐', N'张玉贤/邮政/21012292445445445', N'', N'069', N'404', N'2018-11-09 16:10:54.000', N'2')
GO
GO
INSERT INTO [dbo].[tb_fin_order_income] ([fin_Id], [odr_No], [fin_Date], [odr_Type], [jia_Name], [odr_Prt_Name], [pay_Cost], [oper_Date], [oper_Code], [pay_Way], [pay_Account], [pay_remark], [employ_Code], [audit_Code], [audit_Date], [fin_State]) VALUES (N'4929811632965460364', N'069/20181109-01-R', N'2018-11-09 15:53:40.977', N'2', N'沈阳凡禾文化传播有限公司', N'人字顶篷房', N'2000.00', N'2018-11-09 15:56:36.000', N'404', N'现金转帐', N'张玉贤/邮政/21012292445445445', N'', N'069', N'404', N'2018-11-09 15:58:03.000', N'2')
GO
GO
INSERT INTO [dbo].[tb_fin_order_income] ([fin_Id], [odr_No], [fin_Date], [odr_Type], [jia_Name], [odr_Prt_Name], [pay_Cost], [oper_Date], [oper_Code], [pay_Way], [pay_Account], [pay_remark], [employ_Code], [audit_Code], [audit_Date], [fin_State]) VALUES (N'4981041732775603771', N'069/20181109-01-R', N'2018-11-09 16:09:08.960', N'2', N'沈阳凡禾文化传播有限公司', N'人字顶篷房', N'10.00', N'2018-11-09 16:09:11.000', N'404', N'现金转帐', N'张玉贤/邮政/21012292445445445', N'', N'069', N'404', N'2018-11-09 16:09:44.000', N'2')
GO
GO
INSERT INTO [dbo].[tb_fin_order_income] ([fin_Id], [odr_No], [fin_Date], [odr_Type], [jia_Name], [odr_Prt_Name], [pay_Cost], [oper_Date], [oper_Code], [pay_Way], [pay_Account], [pay_remark], [employ_Code], [audit_Code], [audit_Date], [fin_State]) VALUES (N'5340792715593159608', N'069/20181109-01-R', N'2018-11-09 15:57:36.103', N'2', N'沈阳凡禾文化传播有限公司', N'人字顶篷房', N'48000.00', N'2018-11-09 15:57:48.000', N'404', N'现金转帐', N'张玉贤/邮政/21012292445445445', N'', N'069', N'404', N'2018-11-09 15:58:06.000', N'2')
GO
GO

-- ----------------------------
-- Table structure for tb_fin_order_item
-- ----------------------------
DROP TABLE [dbo].[tb_fin_order_item]
GO
CREATE TABLE [dbo].[tb_fin_order_item] (
[item_Id] bigint NOT NULL ,
[odr_No] varchar(50) NULL ,
[item_Seq] int NULL ,
[item_Spec] ntext NULL ,
[item_Type] varchar(300) NULL ,
[item_Name] varchar(200) NULL ,
[item_Count] decimal(18) NULL ,
[item_Material] varchar(100) NULL ,
[item_Price] decimal(18) NULL ,
[remark] varchar(500) NULL 
)


GO

-- ----------------------------
-- Records of tb_fin_order_item
-- ----------------------------
INSERT INTO [dbo].[tb_fin_order_item] ([item_Id], [odr_No], [item_Seq], [item_Spec], [item_Type], [item_Name], [item_Count], [item_Material], [item_Price], [remark]) VALUES (N'5425116266364859102', N'185/20181108-01-R', N'2', N'{"Items":[{"Property_Value":"20","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"25","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5.4","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"7.2","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]}', N'15米人字篷房', N'篷房', N'500', N'112*203mm', N'200', N'')
GO
GO
INSERT INTO [dbo].[tb_fin_order_item] ([item_Id], [odr_No], [item_Seq], [item_Spec], [item_Type], [item_Name], [item_Count], [item_Material], [item_Price], [remark]) VALUES (N'5563837539127563577', N'069/20181109-01-R', N'2', N'{"Items":[{"Property_Value":"30","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"35","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"9.94","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]}', N'30米跨度', N'篷房', N'1050', N'', N'40', N'')
GO
GO

-- ----------------------------
-- Table structure for tb_fin_order_outcome
-- ----------------------------
DROP TABLE [dbo].[tb_fin_order_outcome]
GO
CREATE TABLE [dbo].[tb_fin_order_outcome] (
[fin_Id] bigint NOT NULL ,
[odr_No] varchar(50) NOT NULL ,
[fin_Date] datetime NULL ,
[odr_Type] int NULL ,
[jia_Name] varchar(300) NULL ,
[odr_Prt_Name] varchar(300) NULL ,
[pay_Cost] decimal(10,2) NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[pay_Way] varchar(255) NULL ,
[pay_Account] varchar(255) NULL ,
[pay_remark] varchar(500) NULL ,
[employ_Code] varchar(30) NULL ,
[audit_Code] varchar(30) NULL ,
[audit_Date] datetime NULL ,
[fin_State] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'fin_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'fin_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'fin_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'fin_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'回款日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'fin_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'回款日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'fin_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'odr_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'jia_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'odr_Prt_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'pay_Cost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'支付金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_Cost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'支付金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_Cost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'oper_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'oper_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'pay_Way')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'回款类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_Way'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'回款类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_Way'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'pay_Account')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'入款账户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_Account'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'入款账户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_Account'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'pay_remark')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_remark'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'pay_remark'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'employ_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'业务员编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'业务员编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'audit_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'审核人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'audit_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'审核人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'audit_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'audit_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'审核日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'audit_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'审核日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'audit_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_order_outcome', 
'COLUMN', N'fin_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'回款状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'fin_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'回款状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_order_outcome'
, @level2type = 'COLUMN', @level2name = N'fin_State'
GO

-- ----------------------------
-- Records of tb_fin_order_outcome
-- ----------------------------

-- ----------------------------
-- Table structure for tb_fin_transport_max
-- ----------------------------
DROP TABLE [dbo].[tb_fin_transport_max]
GO
CREATE TABLE [dbo].[tb_fin_transport_max] (
[max_Id] bigint NOT NULL ,
[tent_Width] decimal(18,2) NOT NULL ,
[row_Weight] decimal(18,2) NULL ,
[max_Length] decimal(18,2) NULL ,
[tent_Space] decimal(18,2) NOT NULL ,
[tent_edgeHeight] decimal(18,2) NOT NULL ,
[tent_MainSpec] varchar(50) NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'max_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'max_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'max_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'tent_Width')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房宽'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_Width'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房宽'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_Width'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'row_Weight')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'每排重'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'row_Weight'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'每排重'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'row_Weight'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'max_Length')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'最长件'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'max_Length'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'最长件'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'max_Length'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'tent_Space')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房间距'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_Space'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房间距'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_Space'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'tent_edgeHeight')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房边高'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_edgeHeight'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房边高'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_edgeHeight'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_max', 
'COLUMN', N'tent_MainSpec')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'主材规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_MainSpec'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'主材规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_max'
, @level2type = 'COLUMN', @level2name = N'tent_MainSpec'
GO

-- ----------------------------
-- Records of tb_fin_transport_max
-- ----------------------------
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'4', N'10.00', N'.50', N'5.50', N'5.00', N'4.00', N'130料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'5', N'10.00', N'.50', N'5.50', N'5.00', N'4.00', N'150料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'6', N'12.00', N'.60', N'5.50', N'5.00', N'4.00', N'150料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'7', N'15.00', N'.60', N'7.50', N'5.00', N'4.00', N'150料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'8', N'18.00', N'.75', N'9.60', N'5.00', N'4.00', N'150料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'9', N'15.00', N'.70', N'7.50', N'5.00', N'4.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'10', N'18.00', N'.75', N'9.60', N'5.00', N'4.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'11', N'20.00', N'.80', N'11.20', N'5.00', N'4.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'12', N'21.00', N'.80', N'11.20', N'5.00', N'4.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'13', N'25.00', N'.90', N'11.20', N'5.00', N'4.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'14', N'25.00', N'1.00', N'11.20', N'5.00', N'5.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'16', N'25.10', N'1.50', N'11.20', N'5.00', N'5.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'18', N'30.00', N'1.50', N'12.00', N'5.00', N'5.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'15', N'25.00', N'1.50', N'11.20', N'5.00', N'6.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'17', N'25.10', N'1.50', N'11.20', N'5.00', N'6.00', N'203料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'20', N'40.00', N'2.00', N'12.00', N'5.00', N'5.40', N'300料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'19', N'30.00', N'2.00', N'12.00', N'5.00', N'6.40', N'300料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'21', N'30.00', N'2.50', N'12.00', N'5.00', N'6.40', N'350料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'23', N'40.00', N'2.50', N'12.00', N'5.00', N'6.40', N'350料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'22', N'50.00', N'3.00', N'12.00', N'5.00', N'6.40', N'350料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'1', N'6.00', N'.20', N'3.50', N'3.00', N'2.80', N'84料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'2', N'8.00', N'.20', N'4.50', N'3.00', N'2.80', N'84料')
GO
GO
INSERT INTO [dbo].[tb_fin_transport_max] ([max_Id], [tent_Width], [row_Weight], [max_Length], [tent_Space], [tent_edgeHeight], [tent_MainSpec]) VALUES (N'3', N'10.00', N'.20', N'5.50', N'3.00', N'2.80', N'84料')
GO
GO

-- ----------------------------
-- Table structure for tb_fin_transport_tmp
-- ----------------------------
DROP TABLE [dbo].[tb_fin_transport_tmp]
GO
CREATE TABLE [dbo].[tb_fin_transport_tmp] (
[Var_Input] nvarchar(MAX) NULL ,
[Var_Cal] nvarchar(MAX) NULL ,
[main_Spec] nvarchar(MAX) NULL ,
[edge_Height] nvarchar(MAX) NULL ,
[trans_Fixed] nvarchar(MAX) NULL ,
[dml_Formula] nvarchar(MAX) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_tmp', 
'COLUMN', N'Var_Input')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表输入参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Input'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表输入参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Input'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_tmp', 
'COLUMN', N'Var_Cal')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表计算参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Cal'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表计算参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Cal'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_tmp', 
'COLUMN', N'main_Spec')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'型材规格集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'main_Spec'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'型材规格集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'main_Spec'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_tmp', 
'COLUMN', N'edge_Height')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'边高集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'edge_Height'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'边高集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'edge_Height'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_tmp', 
'COLUMN', N'trans_Fixed')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'trans_Fixed'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'trans_Fixed'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_fin_transport_tmp', 
'COLUMN', N'dml_Formula')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'端柱面公式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'dml_Formula'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'端柱面公式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_fin_transport_tmp'
, @level2type = 'COLUMN', @level2name = N'dml_Formula'
GO

-- ----------------------------
-- Records of tb_fin_transport_tmp
-- ----------------------------
INSERT INTO [dbo].[tb_fin_transport_tmp] ([Var_Input], [Var_Cal], [main_Spec], [edge_Height], [trans_Fixed], [dml_Formula]) VALUES (N'[{"Name":"tent_Width","Text":"篷房宽","Seq":1.0},{"Name":"tent_Length","Text":"篷房长","Seq":2.0},{"Name":"tent_Count","Text":"篷房数量","Seq":3.0},{"Name":"tent_Space","Text":"篷房间距","Seq":4.0},{"Name":"tent_edgeHeight","Text":"篷房边高","Seq":5.0},{"Name":"tent_MainSpec","Text":"主型材规格","Seq":6.0},{"Name":"add_Weight_Num","Text":"每点配重数量","Seq":7.0},{"Name":"trans_Fixed","Text":"固定方式","Seq":8.0}]', N'[{"Name":"sum_Space","Text":"篷房总间数","Formula":"(${tent_Length}/${tent_Space})*${tent_Count}","Level":0},{"Name":"sum_Row","Text":"篷房总排数","Formula":"(${tent_Length}/${tent_Space}+1)*${tent_Count}","Level":0},{"Name":"tip_Count","Text":"篷房山尖数","Formula":"2*${tent_Count}","Level":0},{"Name":"sum_Area","Text":"篷房总面积","Formula":"${tent_Width}*${tent_Length}*${tent_Count}","Level":0},{"Name":"unit_SpecNum","Text":"单座篷房间数","Formula":"${tent_Length}/${tent_Space} ","Level":0},{"Name":"tent_Dmlz_Count","Text":"篷房端面立柱数量","Formula":"dynamic","Level":1},{"Name":"add_Weight_Count","Text":"配重点数","Formula":"${sum_Row}*2+${tip_Count}*${tent_Dmlz_Count}","Level":2},{"Name":"add_Weight_Unit","Text":"配重单位重量","Formula":"dynamic","Level":2},{"Name":"add_Weight_Sum","Text":"配重重量","Formula":"${add_Weight_Num}*${add_Weight_Unit}*${add_Weight_Count}","Level":3}]', N'[{"Value":"84料"},{"Value":"130料"},{"Value":"150料"},{"Value":"203料"},{"Value":"300料"},{"Value":"350料"}]', N'[{"Value":2.8},{"Value":4.0},{"Value":5.0},{"Value":6.0},{"Value":5.4},{"Value":6.4}]', N'[{"Name":"中网框（空）","UnitWeight":0.04},{"Name":"大网框（空）","UnitWeight":0.45},{"Name":"中网框+小石块","UnitWeight":0.32},{"Name":"大网框+小石块","UnitWeight":1.15},{"Name":"大吨石0.9t","UnitWeight":0.93},{"Name":"小吨石0.4t","UnitWeight":0.43}]', N'[{"UL":3.0,"DL":3.0,"RT":0.0},{"UL":12.0,"DL":6.0,"RT":1.0},{"UL":15.0,"DL":15.0,"RT":2.0},{"UL":18.0,"DL":18.0,"RT":3.0},{"UL":20.0,"DL":20.0,"RT":3.0},{"UL":21.0,"DL":21.0,"RT":3.0},{"UL":25.0,"DL":25.0,"RT":4.0},{"UL":30.0,"DL":30.0,"RT":5.0},{"UL":40.0,"DL":40.0,"RT":7.0},{"UL":50.0,"DL":50.0,"RT":9.0}]')
GO
GO

-- ----------------------------
-- Table structure for tb_link_bill
-- ----------------------------
DROP TABLE [dbo].[tb_link_bill]
GO
CREATE TABLE [dbo].[tb_link_bill] (
[odr_No] varchar(50) NOT NULL ,
[odr_Date] datetime NULL ,
[bill_State] int NULL ,
[odr_Type] int NULL ,
[odr_Prt_Name] varchar(300) NULL ,
[odr_Trans_Party] varchar(300) NULL ,
[odr_Place_Linkman] varchar(300) NULL ,
[odr_Bud_Palce] varchar(300) NULL ,
[odr_Place_Phone] varchar(300) NULL ,
[odr_Ground_State] varchar(300) NULL ,
[odr_Water_proof] varchar(300) NULL ,
[odr_Fixed_Mode] varchar(300) NULL ,
[let_Entry_Date] datetime NULL ,
[let_Bud_SDate] datetime NULL ,
[let_Bud_EDate] datetime NULL ,
[let_Use_SDate] datetime NULL ,
[let_Use_EDate] datetime NULL ,
[let_Rm_SDate] datetime NULL ,
[let_Rm_EDate] datetime NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[odr_Bud_Party] varchar(255) NULL ,
[employ_Code] varchar(30) NULL ,
[project_Man] varchar(50) NULL ,
[duty_Info] varchar(255) NULL ,
[is_put_tool] varchar(255) NULL ,
[special_info] varchar(255) NULL ,
[supplier_Floor] varchar(255) NULL ,
[supplier_Carpet] varchar(255) NULL ,
[provide_Info] varchar(255) NULL ,
[linkBill_Id] bigint NOT NULL ,
[jia_Name] varchar(300) NULL ,
[linkBill_Name] varchar(255) NULL ,
[employ_Phone] varchar(30) NULL ,
[employ_Name] varchar(30) NULL ,
[is_MatchTb] int NULL ,
[is_Carriage] int NULL ,
[is_ProjectCost] int NULL ,
[linkBill_Type] int NULL ,
[is_OutStore] int NULL ,
[is_BackStore] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'bill_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'联络单状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'bill_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'联络单状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'bill_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Prt_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Trans_Party')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'运输方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Trans_Party'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'运输方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Trans_Party'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Place_Linkman')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'场地联系人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Linkman'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'场地联系人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Linkman'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Bud_Palce')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'搭建地点'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Palce'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'搭建地点'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Palce'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Place_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'场地联系电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'场地联系电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Place_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Ground_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'地面状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Ground_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'地面状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Ground_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Water_proof')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'地面防水'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Water_proof'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'地面防水'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Water_proof'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Fixed_Mode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Fixed_Mode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Fixed_Mode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Entry_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁物料入场时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Entry_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁物料入场时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Entry_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Bud_SDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁搭建起始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Bud_SDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁搭建起始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Bud_SDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Bud_EDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁搭建截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Bud_EDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁搭建截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Bud_EDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Use_SDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁使用开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Use_SDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁使用开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Use_SDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Use_EDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁使用截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Use_EDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁使用截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Use_EDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Rm_SDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁拆除开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Rm_SDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁拆除开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Rm_SDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'let_Rm_EDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁拆除截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Rm_EDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁拆除截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'let_Rm_EDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'oper_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'oper_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'odr_Bud_Party')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'搭建方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Party'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'搭建方'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Party'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'project_Man')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'工程负责人信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'project_Man'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'工程负责人信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'project_Man'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'duty_Info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'值班时间及人员信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'duty_Info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'值班时间及人员信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'duty_Info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'is_put_tool')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否放置工具信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_put_tool'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否放置工具信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_put_tool'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'special_info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'特殊场地信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'special_info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'特殊场地信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'special_info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'supplier_Floor')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'供应商地板信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'supplier_Floor'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'供应商地板信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'supplier_Floor'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'supplier_Carpet')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'供应商地毯信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'supplier_Carpet'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'供应商地毯信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'supplier_Carpet'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'provide_Info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'提供资料信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'provide_Info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'提供资料信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'provide_Info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'linkBill_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'联络单主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'联络单主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'linkBill_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'employ_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'业务员电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'employ_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'业务员电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'employ_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'employ_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'业务员名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'employ_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'业务员名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'employ_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'is_MatchTb')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否已经建立配套表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_MatchTb'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否已经建立配套表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_MatchTb'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'is_Carriage')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否建立运输单'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_Carriage'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否建立运输单'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_Carriage'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'is_ProjectCost')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否工程部费用录入'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_ProjectCost'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否工程部费用录入'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_ProjectCost'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'linkBill_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'联络单类型0是正常，1为取消单'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'联络单类型0是正常，1为取消单'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'linkBill_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'is_OutStore')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'完成出库'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_OutStore'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'完成出库'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_OutStore'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill', 
'COLUMN', N'is_BackStore')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否租赁回库'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_BackStore'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否租赁回库'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill'
, @level2type = 'COLUMN', @level2name = N'is_BackStore'
GO

-- ----------------------------
-- Records of tb_link_bill
-- ----------------------------
INSERT INTO [dbo].[tb_link_bill] ([odr_No], [odr_Date], [bill_State], [odr_Type], [odr_Prt_Name], [odr_Trans_Party], [odr_Place_Linkman], [odr_Bud_Palce], [odr_Place_Phone], [odr_Ground_State], [odr_Water_proof], [odr_Fixed_Mode], [let_Entry_Date], [let_Bud_SDate], [let_Bud_EDate], [let_Use_SDate], [let_Use_EDate], [let_Rm_SDate], [let_Rm_EDate], [oper_Date], [oper_Code], [odr_Bud_Party], [employ_Code], [project_Man], [duty_Info], [is_put_tool], [special_info], [supplier_Floor], [supplier_Carpet], [provide_Info], [linkBill_Id], [jia_Name], [linkBill_Name], [employ_Phone], [employ_Name], [is_MatchTb], [is_Carriage], [is_ProjectCost], [linkBill_Type], [is_OutStore], [is_BackStore]) VALUES (N'185/20181108-01-R', N'2018-11-08 14:48:01.783', N'1', N'2', N'篷房', N'乙方', N'田总', N'铁西区家乐福', N'18887879997', N'水泥地', N'无', N'沙袋固定', N'2018-11-08 00:00:50.000', N'2018-11-08 00:00:22.000', N'2018-11-11 12:59:28.000', N'2018-11-12 00:00:03.000', N'2018-11-16 00:00:10.000', N'2018-11-16 00:01:41.000', N'2018-11-17 00:00:51.000', N'2018-11-08 15:51:32.000', N'185', null, N'185', N'张工', N'需要', N'不以', N'客户地面为新做，注意保护', N'无', N'无', N'{"三维效果图":false,"平面图":false,"施工位置图":false,"电路图":false,"立面图":false,"施工图":false}', N'5005630670041188925', N'高山气膜技术（沈阳）有限公司', N'展销会', N'', N'杨航', N'0', N'0', N'1', N'0', N'0', N'0')
GO
GO
INSERT INTO [dbo].[tb_link_bill] ([odr_No], [odr_Date], [bill_State], [odr_Type], [odr_Prt_Name], [odr_Trans_Party], [odr_Place_Linkman], [odr_Bud_Palce], [odr_Place_Phone], [odr_Ground_State], [odr_Water_proof], [odr_Fixed_Mode], [let_Entry_Date], [let_Bud_SDate], [let_Bud_EDate], [let_Use_SDate], [let_Use_EDate], [let_Rm_SDate], [let_Rm_EDate], [oper_Date], [oper_Code], [odr_Bud_Party], [employ_Code], [project_Man], [duty_Info], [is_put_tool], [special_info], [supplier_Floor], [supplier_Carpet], [provide_Info], [linkBill_Id], [jia_Name], [linkBill_Name], [employ_Phone], [employ_Name], [is_MatchTb], [is_Carriage], [is_ProjectCost], [linkBill_Type], [is_OutStore], [is_BackStore]) VALUES (N'069/20181109-01-R', N'2018-11-09 14:11:24.773', N'1', N'2', N'人字顶篷房', N'乙方', N'赵经理', N'大连甘井子区华润24城', N'15524055501', N'大理石', N'无防水', N'配重', N'2018-06-21 00:00:48.000', N'2018-06-21 00:00:09.000', N'2018-06-22 23:59:23.000', N'2018-06-24 00:00:05.000', N'2018-06-30 23:59:56.000', N'2018-07-01 00:00:07.000', N'2018-07-01 23:59:20.000', N'2018-11-09 15:18:37.000', N'069', null, N'069', N'无', N'无', N'可以', N'场地不可破坏', N'无', N'无', N'{"三维效果图":false,"平面图":true,"施工位置图":false,"电路图":false,"立面图":false,"施工图":false}', N'5695809777847501518', N'沈阳凡禾文化传播有限公司', N'大连华润24城', N'', N'金勇日', N'0', N'0', N'1', N'0', N'0', N'0')
GO
GO

-- ----------------------------
-- Table structure for tb_link_bill_tent
-- ----------------------------
DROP TABLE [dbo].[tb_link_bill_tent]
GO
CREATE TABLE [dbo].[tb_link_bill_tent] (
[item_Id] bigint NOT NULL ,
[linkBill_Id] bigint NULL ,
[item_Seq] int NULL ,
[item_Spec] ntext NULL ,
[special_Info] varchar(500) NULL ,
[within_Bag] varchar(500) NULL ,
[item_Count] decimal(18) NULL ,
[fixed_Mode] varchar(50) NULL ,
[tent_Require] varchar(500) NULL ,
[wall_Require] varchar(500) NULL ,
[tool_Bar] varchar(500) NULL ,
[tent_Pack] varchar(500) NULL ,
[steel_part_pack] varchar(500) NULL ,
[ground_State] varchar(500) NULL ,
[lamp_Info] varchar(500) NULL ,
[net_frame] varchar(500) NULL ,
[steel_drill] varchar(500) NULL ,
[is_truck_enter] varchar(500) NULL ,
[engine_truck_way] varchar(500) NULL ,
[en_roof_purlin] varchar(500) NULL ,
[power_Box] varchar(500) NULL ,
[gutter_Info] varchar(500) NULL ,
[has_Logo] varchar(255) NULL ,
[remark] varchar(500) NULL ,
[peri_cloth_bear] varchar(500) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'linkBill_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'联络单id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'linkBill_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'联络单id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'linkBill_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'special_Info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'特殊要求信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'special_Info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'特殊要求信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'special_Info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'within_Bag')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'内包描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'within_Bag'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'内包描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'within_Bag'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'fixed_Mode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'fixed_Mode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'固定方式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'fixed_Mode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'tent_Require')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷布要求'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'tent_Require'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷布要求'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'tent_Require'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'wall_Require')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'墙体要求'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'wall_Require'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'墙体要求'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'wall_Require'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'tool_Bar')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'工具栏'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'tool_Bar'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'工具栏'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'tool_Bar'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'tent_Pack')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷布包装'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'tent_Pack'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷布包装'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'tent_Pack'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'steel_part_pack')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'钢部件包装'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'steel_part_pack'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'钢部件包装'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'steel_part_pack'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'ground_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'地面情况'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'ground_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'地面情况'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'ground_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'lamp_Info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'灯具'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'lamp_Info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'灯具'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'lamp_Info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'net_frame')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'网框'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'net_frame'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'网框'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'net_frame'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'steel_drill')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'钢钎'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'steel_drill'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'钢钎'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'steel_drill'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'is_truck_enter')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'货车是否可以进场'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'is_truck_enter'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'货车是否可以进场'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'is_truck_enter'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'engine_truck_way')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'工程车辆作业'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'engine_truck_way'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'工程车辆作业'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'engine_truck_way'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'en_roof_purlin')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'加密屋面檩条'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'en_roof_purlin'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'加密屋面檩条'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'en_roof_purlin'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'power_Box')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配电箱'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'power_Box'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配电箱'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'power_Box'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'gutter_Info')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'天沟'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'gutter_Info'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'天沟'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'gutter_Info'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'has_Logo')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售篷房山尖布是否带LOGO'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'has_Logo'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售篷房山尖布是否带LOGO'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'has_Logo'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'remark')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'remark'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'remark'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_link_bill_tent', 
'COLUMN', N'peri_cloth_bear')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'围布承重管'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'peri_cloth_bear'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'围布承重管'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_link_bill_tent'
, @level2type = 'COLUMN', @level2name = N'peri_cloth_bear'
GO

-- ----------------------------
-- Records of tb_link_bill_tent
-- ----------------------------
INSERT INTO [dbo].[tb_link_bill_tent] ([item_Id], [linkBill_Id], [item_Seq], [item_Spec], [special_Info], [within_Bag], [item_Count], [fixed_Mode], [tent_Require], [wall_Require], [tool_Bar], [tent_Pack], [steel_part_pack], [ground_State], [lamp_Info], [net_frame], [steel_drill], [is_truck_enter], [engine_truck_way], [en_roof_purlin], [power_Box], [gutter_Info], [has_Logo], [remark], [peri_cloth_bear]) VALUES (N'5260849232341889294', N'5695809777847501518', N'2', N'{"Items":[{"Property_Value":"30","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"35","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"9.94","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]}', N'无', N'无', N'1050', N'配重', N'{"A类":false,"B类":true,"C类":false,"其他":false}', N'{"玻璃墙":false,"玻璃门":false,"ABS墙":false,"其他":false}', N'{"绳子":false,"叉枪":false,"梯子":false,"扳手":false,"小车":false}', N'{"帆布袋":false,"编织袋":false}', N'{"吨袋":false,"网框":false,"塑封":false}', N'{"大理石":true,"水泥":false,"草地":false,"沥青":false,"土地":false,"砖地":false,"沙滩":false}', N'{"节能灯":false,"150W":false,"250W":false,"白色":false,"黄色":false}', N'{"大网框":true,"小网框":false}', N'{"Length":0.0,"LengthUnit":"米","StandardText":"标准的","StandardState":0,"ScrewText":"螺纹钢","ScrewState":0}', N'{"可进场地":false,"不可进场地":true}', N'{"可进场地":true,"不可进场地":false}', N'{"是":false,"否":true}', N'{"配电箱":false,"电线":false}', N'{"Width_Unit":"米","Length_Unit":"米","Width_Value":0.0,"Length_Value":0.0}', N'{"是":true,"否":false}', N'', N'{"需要":false,"不需要":true}')
GO
GO
INSERT INTO [dbo].[tb_link_bill_tent] ([item_Id], [linkBill_Id], [item_Seq], [item_Spec], [special_Info], [within_Bag], [item_Count], [fixed_Mode], [tent_Require], [wall_Require], [tool_Bar], [tent_Pack], [steel_part_pack], [ground_State], [lamp_Info], [net_frame], [steel_drill], [is_truck_enter], [engine_truck_way], [en_roof_purlin], [power_Box], [gutter_Info], [has_Logo], [remark], [peri_cloth_bear]) VALUES (N'5508745826956977734', N'5005630670041188925', N'2', N'{"Items":[{"Property_Value":"20","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"25","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5.4","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"7.2","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]}', N'', N'', N'1', N'支架固定', N'{"A类":false,"B类":false,"C类":false,"其他":true}', N'{"玻璃墙":true,"玻璃门":true,"ABS墙":true,"其他":false}', N'{"绳子":true,"叉枪":true,"梯子":true,"扳手":true,"小车":true}', N'{"帆布袋":true,"编织袋":false}', N'{"吨袋":false,"网框":true,"塑封":false}', N'{"大理石":false,"水泥":true,"草地":false,"沥青":false,"土地":false,"砖地":false,"沙滩":false}', N'{"节能灯":true,"150W":true,"250W":false,"白色":false,"黄色":false}', N'{"大网框":true,"小网框":false}', N'{"Length":0.0,"LengthUnit":"米","StandardText":"标准的","StandardState":1,"ScrewText":"螺纹钢","ScrewState":0}', N'{"可进场地":false,"不可进场地":true}', N'{"可进场地":true,"不可进场地":false}', N'{"是":false,"否":true}', N'{"配电箱":true,"电线":false}', N'{"Width_Unit":"米","Length_Unit":"米","Width_Value":0.0,"Length_Value":0.0}', N'{"是":true,"否":false}', N'', N'{"需要":false,"不需要":true}')
GO
GO

-- ----------------------------
-- Table structure for tb_matchTb
-- ----------------------------
DROP TABLE [dbo].[tb_matchTb]
GO
CREATE TABLE [dbo].[tb_matchTb] (
[odr_No] varchar(50) NOT NULL ,
[odr_Date] datetime NULL ,
[matchTb_State] int NULL ,
[odr_Type] int NULL ,
[odr_Prt_Name] varchar(300) NULL ,
[odr_Bud_Palce] varchar(300) NULL ,
[let_Bud_SDate] datetime NULL ,
[let_Bud_EDate] datetime NULL ,
[let_Use_SDate] datetime NULL ,
[let_Use_EDate] datetime NULL ,
[let_Rm_SDate] datetime NULL ,
[let_Rm_EDate] datetime NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[employ_Code] varchar(30) NULL DEFAULT '' ,
[matchTb_Id] bigint NOT NULL ,
[matchTb_Name] varchar(300) NULL ,
[linkBill_Name] varchar(255) NULL ,
[tent_Width] decimal(18) NULL ,
[tent_Length] decimal(18) NULL ,
[tent_Count] decimal(18) NULL ,
[tent_Space] decimal(18) NULL ,
[tent_edgeHeight] decimal(18) NULL ,
[tent_MainSpec] varchar(50) NULL ,
[linkBill_Id] bigint NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'odr_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'matchTb_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'联络单状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'matchTb_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'联络单状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'matchTb_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'odr_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'odr_Prt_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同产品名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Prt_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'odr_Bud_Palce')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'搭建地点'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Palce'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'搭建地点'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'odr_Bud_Palce'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'let_Bud_SDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁搭建起始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Bud_SDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁搭建起始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Bud_SDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'let_Bud_EDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁搭建截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Bud_EDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁搭建截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Bud_EDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'let_Use_SDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁使用开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Use_SDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁使用开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Use_SDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'let_Use_EDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁使用截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Use_EDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁使用截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Use_EDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'let_Rm_SDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁拆除开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Rm_SDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁拆除开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Rm_SDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'let_Rm_EDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'租赁拆除截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Rm_EDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'租赁拆除截止时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'let_Rm_EDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'oper_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'oper_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'oper_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'操作人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'oper_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'matchTb_Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'matchTb_Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表主键'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'matchTb_Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'matchTb_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'matchTb_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'matchTb_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'linkBill_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'linkBill_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'linkBill_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'tent_Width')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房宽'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Width'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房宽'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Width'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'tent_Length')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房长'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Length'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房长'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Length'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'tent_Count')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房数量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Count'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房数量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Count'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'tent_Space')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房间距'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Space'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房间距'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_Space'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'tent_edgeHeight')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'篷房边高'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_edgeHeight'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'篷房边高'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_edgeHeight'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb', 
'COLUMN', N'tent_MainSpec')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'主材规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_MainSpec'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'主材规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb'
, @level2type = 'COLUMN', @level2name = N'tent_MainSpec'
GO

-- ----------------------------
-- Records of tb_matchTb
-- ----------------------------
INSERT INTO [dbo].[tb_matchTb] ([odr_No], [odr_Date], [matchTb_State], [odr_Type], [odr_Prt_Name], [odr_Bud_Palce], [let_Bud_SDate], [let_Bud_EDate], [let_Use_SDate], [let_Use_EDate], [let_Rm_SDate], [let_Rm_EDate], [oper_Date], [oper_Code], [employ_Code], [matchTb_Id], [matchTb_Name], [linkBill_Name], [tent_Width], [tent_Length], [tent_Count], [tent_Space], [tent_edgeHeight], [tent_MainSpec], [linkBill_Id]) VALUES (N'185/20181108-01-R', N'2018-11-08 14:48:01.783', N'0', N'2', N'篷房', N'铁西区家乐福', N'2018-11-08 00:00:22.000', N'2018-11-11 12:59:28.000', N'2018-11-12 00:00:03.000', N'2018-11-16 00:00:10.000', N'2018-11-16 00:01:41.000', N'2018-11-17 00:00:51.000', N'2018-11-09 11:20:30.000', N'admin', N'185', N'5053794870005630729', N'展销会', N'展销会', N'3', N'18', N'1', N'3', N'3', N'48*48', N'5005630670041188925')
GO
GO

-- ----------------------------
-- Table structure for tb_matchTb_item
-- ----------------------------
DROP TABLE [dbo].[tb_matchTb_item]
GO
CREATE TABLE [dbo].[tb_matchTb_item] (
[mtl_Code] varchar(30) NOT NULL ,
[mtl_Name] varchar(100) NULL ,
[mtl_Spec] varchar(50) NULL ,
[mtl_Unit] varchar(30) NULL ,
[kind_Name] varchar(30) NULL ,
[mtl_Weight] decimal(18) NULL ,
[item_Id] bigint NOT NULL ,
[matchTb_Id] bigint NULL ,
[item_Count] decimal(18) NULL ,
[group_Name] varchar(50) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_item', 
'COLUMN', N'mtl_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_item', 
'COLUMN', N'mtl_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_item', 
'COLUMN', N'mtl_Spec')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Spec'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Spec'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_item', 
'COLUMN', N'mtl_Unit')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料单位'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Unit'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料单位'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Unit'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_item', 
'COLUMN', N'kind_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'分类名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'kind_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'分类名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'kind_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_item', 
'COLUMN', N'mtl_Weight')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'单重'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Weight'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'单重'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Weight'
GO

-- ----------------------------
-- Records of tb_matchTb_item
-- ----------------------------
INSERT INTO [dbo].[tb_matchTb_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [kind_Name], [mtl_Weight], [item_Id], [matchTb_Id], [item_Count], [group_Name]) VALUES (N'AB001', N'侧立柱（尖顶/55料）', N'55mm*55mm*1.7mm*2.5m', N'根', N'侧立柱', N'0', N'5024729842796896671', N'5053794870005630729', N'108', N'骨架类')
GO
GO
INSERT INTO [dbo].[tb_matchTb_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [kind_Name], [mtl_Weight], [item_Id], [matchTb_Id], [item_Count], [group_Name]) VALUES (N'AA001', N'长梁（3米尖顶）', N'55mm*55mm*1.7mm*3m', N'根', N'长梁', N'7', N'5104626507717260299', N'5053794870005630729', N'7', N'骨架类')
GO
GO
INSERT INTO [dbo].[tb_matchTb_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [kind_Name], [mtl_Weight], [item_Id], [matchTb_Id], [item_Count], [group_Name]) VALUES (N'AK002', N'十字撑（2.8米边高/48*84料)', N'30mm*50mm*2mm*3.4m', N'根', N'十字撑', N'0', N'5256248772698794967', N'5053794870005630729', N'2', N'骨架类')
GO
GO

-- ----------------------------
-- Table structure for tb_matchTb_tmp
-- ----------------------------
DROP TABLE [dbo].[tb_matchTb_tmp]
GO
CREATE TABLE [dbo].[tb_matchTb_tmp] (
[Var_Input] nvarchar(MAX) NULL ,
[Var_Cal] nvarchar(MAX) NULL ,
[szc_lt30] nvarchar(MAX) NULL ,
[szc_gt30] nvarchar(MAX) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_tmp', 
'COLUMN', N'Var_Input')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表输入参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Input'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表输入参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Input'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_tmp', 
'COLUMN', N'Var_Cal')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'配套表计算参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Cal'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'配套表计算参数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'Var_Cal'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_tmp', 
'COLUMN', N'szc_lt30')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'宽度小于30米的十字撑计算公式集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'szc_lt30'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'宽度小于30米的十字撑计算公式集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'szc_lt30'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_tmp', 
'COLUMN', N'szc_gt30')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'宽度大于30米的十字撑计算公式集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'szc_gt30'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'宽度大于30米的十字撑计算公式集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp'
, @level2type = 'COLUMN', @level2name = N'szc_gt30'
GO

-- ----------------------------
-- Records of tb_matchTb_tmp
-- ----------------------------
INSERT INTO [dbo].[tb_matchTb_tmp] ([Var_Input], [Var_Cal], [szc_lt30], [szc_gt30]) VALUES (N'[{"Name":"tent_Width","Text":"篷房宽","Seq":1.0},{"Name":"tent_Length","Text":"篷房长","Seq":2.0},{"Name":"tent_Count","Text":"篷房数量","Seq":3.0},{"Name":"tent_Space","Text":"篷房间距","Seq":4.0},{"Name":"tent_edgeHeight","Text":"篷房边高","Seq":5.0},{"Name":"tent_MainSpec","Text":"主型材规格","Seq":6.0}]', N'[{"Name":"sum_Space","Text":"篷房总间数","Formula":"(${tent_Length}/${tent_Space})*${tent_Count}","Level":0},{"Name":"sum_Row","Text":"篷房总排数","Formula":"(${tent_Length}/${tent_Space}+1)*${tent_Count}","Level":0},{"Name":"tip_Count","Text":"篷房山尖数","Formula":"2*${tent_Count}","Level":0},{"Name":"sum_Area","Text":"篷房总面积","Formula":"${tent_Width}*${tent_Length}*${tent_Count}","Level":0},{"Name":"unit_SpecNum","Text":"单座篷房间数","Formula":"${tent_Length}/${tent_Space} ","Level":0},{"Name":"tent_Spec","Text":"篷房规格","Formula":"string.篷房规格：${tent_Width}m × ${tent_Length}m × ${tent_Count}座","Level":0},{"Name":"tent_WeightText","Text":"篷房跨度说明","Formula":"string.${tent_Width}米人字","Level":0},{"Name":"tent_MainSpecText","Text":"主材规格说明","Formula":"string.${tent_MainSpec}料","Level":0},{"Name":"tent_edgeHeightText","Text":"边高说明","Formula":"string.${tent_edgeHeight}米边高","Level":0}]', N'[{"UL":1.0,"DL":1.0,"RT":1.0},{"UL":6.0,"DL":2.0,"RT":2.0},{"UL":11.0,"DL":7.0,"RT":3.0},{"UL":16.0,"DL":12.0,"RT":4.0},{"UL":21.0,"DL":17.0,"RT":5.0},{"UL":26.0,"DL":22.0,"RT":6.0},{"UL":31.0,"DL":27.0,"RT":7.0},{"UL":36.0,"DL":32.0,"RT":8.0},{"UL":41.0,"DL":37.0,"RT":9.0},{"UL":46.0,"DL":42.0,"RT":10.0},{"UL":51.0,"DL":47.0,"RT":11.0},{"UL":56.0,"DL":52.0,"RT":12.0},{"UL":61.0,"DL":57.0,"RT":13.0},{"UL":66.0,"DL":62.0,"RT":14.0},{"UL":71.0,"DL":67.0,"RT":15.0},{"UL":76.0,"DL":72.0,"RT":16.0},{"UL":81.0,"DL":77.0,"RT":17.0},{"UL":86.0,"DL":82.0,"RT":18.0}]', N'[{"UL":2.0,"DL":1.0,"RT":1.0},{"UL":3.0,"DL":3.0,"RT":2.0},{"UL":8.0,"DL":4.0,"RT":4.0},{"UL":14.0,"DL":9.0,"RT":6.0},{"UL":20.0,"DL":15.0,"RT":8.0},{"UL":26.0,"DL":21.0,"RT":10.0},{"UL":32.0,"DL":27.0,"RT":12.0},{"UL":38.0,"DL":33.0,"RT":14.0},{"UL":44.0,"DL":39.0,"RT":16.0},{"UL":50.0,"DL":45.0,"RT":18.0},{"UL":56.0,"DL":51.0,"RT":20.0},{"UL":62.0,"DL":57.0,"RT":22.0},{"UL":68.0,"DL":63.0,"RT":24.0},{"UL":74.0,"DL":69.0,"RT":26.0},{"UL":80.0,"DL":75.0,"RT":28.0},{"UL":86.0,"DL":81.0,"RT":30.0},{"UL":92.0,"DL":87.0,"RT":32.0},{"UL":98.0,"DL":93.0,"RT":34.0}]')
GO
GO

-- ----------------------------
-- Table structure for tb_matchTb_tmp_set
-- ----------------------------
DROP TABLE [dbo].[tb_matchTb_tmp_set]
GO
CREATE TABLE [dbo].[tb_matchTb_tmp_set] (
[set_Id] bigint NULL ,
[tent_Weight] decimal(18) NOT NULL ,
[tent_MainSpec] varchar(100) NOT NULL ,
[set_Items] nvarchar(MAX) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_matchTb_tmp_set', 
'COLUMN', N'set_Items')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N' 物流组成编码集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp_set'
, @level2type = 'COLUMN', @level2name = N'set_Items'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N' 物流组成编码集合'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_matchTb_tmp_set'
, @level2type = 'COLUMN', @level2name = N'set_Items'
GO

-- ----------------------------
-- Records of tb_matchTb_tmp_set
-- ----------------------------
INSERT INTO [dbo].[tb_matchTb_tmp_set] ([set_Id], [tent_Weight], [tent_MainSpec], [set_Items]) VALUES (N'5437569488434001933', N'3', N'48*48', N'{"AA001":"${sum_Row}*1","AB001":"${sum_Area}*2","AK002":"${szc_Value}"}')
GO
GO

-- ----------------------------
-- Table structure for tb_mtl_item
-- ----------------------------
DROP TABLE [dbo].[tb_mtl_item]
GO
CREATE TABLE [dbo].[tb_mtl_item] (
[mtl_Code] varchar(30) NOT NULL ,
[mtl_Name] varchar(100) NULL ,
[mtl_Spec] varchar(50) NULL ,
[mtl_Unit] varchar(30) NULL ,
[mtl_Extend] varchar(500) NULL ,
[kind_Code] varchar(30) NULL ,
[mtl_Weight] decimal(18) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'mtl_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'mtl_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'mtl_Spec')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Spec'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料规格'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Spec'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'mtl_Unit')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料单位'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Unit'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料单位'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Unit'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'mtl_Extend')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'扩展'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Extend'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'扩展'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Extend'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'kind_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'分类编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'kind_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'分类编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'kind_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_item', 
'COLUMN', N'mtl_Weight')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'单重'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Weight'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'单重'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_item'
, @level2type = 'COLUMN', @level2name = N'mtl_Weight'
GO

-- ----------------------------
-- Records of tb_mtl_item
-- ----------------------------
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA001', N'长梁（3米尖顶）', N'55mm*55mm*1.7mm*3m', N'根', null, N'AA', N'7')
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA002', N'长梁（4米尖顶）', N'55mm*55mm*1.7mm*4m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA003', N'长梁（3米尖顶）', N'48mm*84mm*2.7mm*3m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA004', N'长梁（4米尖顶）', N'48mm*84mm*2.7mm*4m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA005', N'长梁（5米尖顶）', N'48mm*84mm*2.7mm*5m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA006', N'长梁（6米尖顶）', N'48mm*84mm*2.7mm*6m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA007', N'长梁（5米尖顶）', N'48mm*100mm*2.7mm*5m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA008', N'长梁（6米尖顶）', N'48mm*100mm*2.7mm*6m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA009', N'长梁（3米弧形梁）', N'48mm*84mm*2.7mm*4.2m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA010', N'长梁（3米长梁）', N'48mm*84mm*2.7mm*1.75m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA011', N'长梁（6米长梁）', N'48mm*84mm*2.7mm*2.7m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA012', N'长梁（7米长梁）', N'48mm*84mm*2.7mm*3.75m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA013', N'长梁（8米长梁）', N'48mm*84mm*2.7mm*4.35m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA014', N'长梁（8米短梁）', N'48mm*84mm*2.7mm*1.65m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA015', N'长梁（9米长梁）', N'48mm*84mm*2.7mm*4.73m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA016', N'长梁（10米长梁）', N'48mm*84mm*2.7mm*5.34m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA017', N'长梁（10米长梁）', N'88mm*130mm*3mm*5.47m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA018', N'12米短梁（10变12米）', N'88mm*130mm*3mm*1.03m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA019', N'长梁（10米长梁）', N'120mm*150mm*3mm*5.47m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA020', N'长梁（15米长梁）', N'120mm*150mm*3mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA021', N'长梁（10变15米）', N'120mm*150mm*3mm*5.47m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA022', N'15米短梁（10变15米）', N'120mm*150mm*3mm*2.67m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA023', N'长梁（15变18米）', N'120mm*150mm*3mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA024', N'18米短梁（15变18米）', N'120mm*150mm*3mm*1.55m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA025', N'长梁（15米长梁）', N'112mm*203mm*4.5mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA026', N'长梁（15变18米）', N'112mm*203mm*4.5mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA027', N'18米短梁（15变18米）', N'112mm*203mm*4.5mm*1.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA028', N'长梁（18变21米）', N'112mm*203mm*4.5mm*9.68m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA029', N'21米短梁（18变21米）', N'112mm*203mm*4.5mm*1.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA030', N'长梁（20米长梁）', N'112mm*203mm*4.5mm*10.6m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA031', N'长梁（21米长梁）', N'112mm*203mm*4.5mm*11.2m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA032', N'长梁（25米长梁）', N'112mm*203mm*4.5mm*11.2m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA033', N'25米短梁（25米短梁）', N'112mm*203mm*4.5mm*3.76m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA034', N'一梁（112*203料）', N'112mm*203mm*4.5mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA035', N'三梁（112*203料）', N'112mm*203mm*4.5mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA036', N'一梁（120*250料）', N'120mm*250mm*5.2mm*10.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA037', N'三梁（120*250料）', N'120mm*250mm*5.2mm*5.4m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA038', N'一梁（120*300料）', N'120mm*300mm*5.2mm*10.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA039', N'二梁（120*300料）', N'120mm*300mm*5.2mm*10.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA040', N'三梁（120*300料）', N'120mm*300mm*5.2mm*5.4m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA041', N'一梁（120*350料）', N'120mm*350mm*5.2mm*10.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA042', N'二梁（120*350料）', N'120mm*350mm*5.2mm*10.62m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA043', N'三梁（120*350料）', N'120mm*350mm*5.2mm*5.4m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AA044', N'12米短梁（10变12米）', N'120mm*150mm*3mm*8.15m', N'根', null, N'AA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB001', N'侧立柱（尖顶/55料）', N'55mm*55mm*1.7mm*2.5m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB002', N'侧立柱（尖顶/84料）', N'48mm*84mm*2.7mm*2.5m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB003', N'侧立柱（尖顶/100料）', N'48mm*100mm*2.7mm*2.5m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB004', N'侧立柱（弧形/人字/84料/2.8米边高）', N'48mm*84mm*2.7mm*2.8m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB005', N'侧立柱（人字/88料/4米边高）', N'88mm*130mm*3mm*4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB006', N'侧立柱（人字/150料/4米边高）', N'120mm*150mm*3mm*4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB007', N'侧立柱（人字/150料/5米边高）', N'120mm*150mm*3mm*5m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB008', N'侧立柱（人字/203料/4米边高）', N'112mm*203mm*4.5mm*4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB009', N'侧立柱（人字/203料/5米边高）', N'112mm*203mm*4.5mm*5m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB010', N'侧立柱（人字/203料/6米边高）', N'112mm*203mm*4.5mm*6m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB011', N'侧立柱（人字/250料/5米边高）', N'120mm*250mm*5.2mm*5m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB012', N'侧立柱（人字/250料/6米边高）', N'120mm*250mm*5.2mm*6m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB013', N'侧立柱（人字/300料/5.4米边高）', N'120mm*300mm*5.2mm*5.4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB014', N'侧立柱（人字/300料/6.4米边高）', N'120mm*300mm*5.2mm*6.4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB015', N'侧立柱（人字/350料/5.4米边高）', N'120mm*350mm*5.2mm*5.4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AB016', N'侧立柱（人字/350料/6.4米边高）', N'120mm*350mm*5.2mm*5.4m', N'根', null, N'AB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC001', N'端立柱（6米专用/48*84料）', N'48mm*84mm*2.7mm*3.77m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC002', N'端立柱（7米专用/48*84料）', N'48mm*84mm*2.7mm*3.94m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC003', N'端立柱（8米专用/48*84料）', N'48mm*84mm*2.7mm*4.1m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC004', N'端立柱（9米专用/48*84料）', N'48mm*84mm*2.7mm*4.26m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC005', N'端立柱（10米专用/48*84料）', N'48mm*84mm*2.7mm*4.4m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC006', N'端立柱（10米专用/88*130料）', N'88mm*130mm*3mm*5m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC007', N'端立柱（5m/120*150料）', N'120mm*150mm*3mm*5m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC008', N'端立柱（6.2m/120*150料）', N'120mm*150mm*3mm*6.2m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC009', N'端立柱（6.33m/120*150料）', N'120mm*150mm*3mm*6.33m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC010', N'端立柱（7.2m/120*150料）', N'120mm*150mm*3mm*7.2m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC011', N'端立柱（7.9m/120*150料）', N'120mm*150mm*3mm*7.9m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC012', N'端立柱（8.9m/120*150料）', N'120mm*150mm*3mm*8.9m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC013', N'端立柱（9.45m/120*150料）', N'120mm*150mm*3mm*9.45m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC014', N'端立柱（10.45m/112*203料）', N'120mm*150mm*3mm*10.45m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC015', N'端立柱（10.95m/112*203料）', N'112mm*203mm*4.5mm*10.95m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC016', N'端立柱（11.95m/112*203料）', N'112mm*203mm*4.5mm*11.95m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC017', N'端立柱（12.58m/112*203料）', N'112mm*203mm*4.5mm*12.58m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AC018', N'端立柱（13.58m/112*203料）', N'112mm*203mm*4.5mm*13.58m', N'根', null, N'AC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD001', N'屋面檩条（3米尖顶/55料/钢圆管）', N'', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD002', N'屋面檩条（3米尖顶/铝方管）', N'40mm*40mm*2mm*m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD003', N'屋面檩条（4米尖顶/铝方管）', N'40mm*40mm*2mm*2.64m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD004', N'屋面檩条（5米尖顶/铝方管）', N'40mm*40mm*2mm*3.51m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD005', N'屋面檩条（6米尖顶/铝方管）', N'40mm*40mm*2mm*4.11m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD006', N'屋面檩条（40*40*2）', N'40mm*40mm*2mm*2.95m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD007', N'屋檐檩条（40*80*2）', N'40mm*48mm*2mm*2.95m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD008', N'屋面檩条（60*60*2.5）', N'60mm*60mm*2.5mm*4.882m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD009', N'通用檩条（80*100*2.7）', N'80mm*100mm*2.7mm*4.882m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD010', N'加固檩条（88*140*3.5）', N'88mm*140mm*3.5mm*4.882m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD011', N'屋檐檩条（90*140*4.0）', N'90mm*140mm*4mm*4.882m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD012', N'端中檩条（3.88m/80*100*2.7）', N'80mm*100mm*2.7mm*3.882m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AD013', N'端中檩条（5.38m/80*100*2.7）', N'80mm*100mm*2.7mm*5.38m', N'根', null, N'AD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE001', N'端横梁（3米弧形）', N'48mm*84mm*2.7mm*3m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE002', N'左右向檩条（6米人字）', N'48mm*84mm*2.7mm*3m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE003', N'左右向檩条（7米人字）', N'48mm*84mm*2.7mm*3.5m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE004', N'左右向檩条（8米人字）', N'48mm*84mm*2.7mm*3.94m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE005', N'左右向檩条（9米人字）', N'48mm*84mm*2.7mm*4.5m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE006', N'左右向檩条（10米人字）', N'48mm*84mm*2.7mm*4.95m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE007', N'左右向檩条（12米人字）', N'80mm*100mm*2.7mm*5.882m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AE008', N'左右向檩条（10米-50米人字）', N'80mm*100mm*2.7mm*4.882m', N'根', null, N'AE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF001', N'顶布穿管（84料/3m）', N'25.4mm*50.8mm*2.3mm*3m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF002', N'顶布穿管（铝）（10米-50米）', N'40mm*80mm*2mm*5m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF003', N'顶布穿管（铁）（10米-50米）', N'40mm*80mm*2mm*5m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF004', N'顶布穿管（铝）（3.88m）', N'40mm*80mm*2mm*3.88m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF005', N'顶布穿管（铝）（5.38m）', N'40mm*80mm*2mm*5.38m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF006', N'顶布穿管（铁）（3.88m）', N'40mm*80mm*2mm*3.88m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF007', N'顶布穿管（铁）（5.38m）', N'40mm*80mm*2mm*5.38m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF008', N'山尖布穿管（铝）（12米/88料/150料）', N'40mm*80mm*2mm*5.95m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF009', N'山尖布穿管（铁）（12米/88料/150料）', N'40mm*80mm*2mm*5.95m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF010', N'山尖布穿管（铝）（7米/84料）', N'25.4mm*50.8mm*2.3mm*3.5m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF011', N'山尖布穿管（铝）（8米/84料）', N'25.4mm*50.8mm*2.3mm*3.94m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF012', N'山尖布穿管（铝）（9米/84料）', N'25.4mm*50.8mm*2.3mm*4.5m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF013', N'山尖布穿管（铝）（10米/84料）', N'25.4mm*50.8mm*2.3mm*4.95m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF014', N'屋檐布穿条（3m）', N'mm*mm*mm*3m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF015', N'屋檐布穿条（4m）', N'mm*mm*mm*4m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF016', N'屋檐布穿条（5m）', N'mm*mm*mm*5m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AF017', N'屋檐布穿条（6m）', N'mm*mm*mm*6m', N'根', null, N'AF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG001', N'山尖固定扁铝（12米人字/2.5m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG002', N'山尖固定扁铝（15米人字/2.75m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG003', N'山尖固定扁铝（18米人字/3.4m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG004', N'山尖固定扁铝（20-21米人字/3.7m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG005', N'山尖固定扁铝（25米人字/4.3m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG006', N'山尖固定扁铝（30米人字/5.5m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG007', N'山尖固定扁铝（40米人字/6.5m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AG008', N'山尖固定扁铝（50米人字/8.5m）', N'两孔扁铝50mm', N'根', null, N'AG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AH001', N'斜撑（203料/21米-25米专用）', N'', N'根', null, N'AH', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AH002', N'斜撑（30米跨-50米跨专用）', N'', N'根', null, N'AH', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AH003', N'斜撑（203料/30米专用）', N'', N'根', null, N'AH', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AH004', N'特制斜撑（30米-50米特制）', N'', N'根', null, N'AH', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AI001', N'屋面拉杆（150料/15变18米专用）', N'', N'根', null, N'AI', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AI002', N'屋面拉杆（203料/25米专用）', N'', N'根', null, N'AI', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AI003', N'屋面拉杆（30米跨-50米跨专用）', N'', N'根', null, N'AI', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AJ001', N'侧横梁（48*84料专用）', N'', N'根', null, N'AJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AJ002', N'侧横梁（88料-350料）', N'', N'根', null, N'AJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK001', N'玻璃墙十字撑（2.8米边高/48*84料)', N'30mm*50mm*2mm*3.6m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK002', N'十字撑（2.8米边高/48*84料)', N'30mm*50mm*2mm*3.4m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK003', N'十字撑(4米边高/5.83m)', N'60mm*60mm*3.5mm*5.83m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK004', N'十字撑(5米边高/6.4m)', N'60mm*60mm*3.5mm*6.4m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK005', N'十字撑(6米边高/7.1m)', N'60mm*60mm*3.5mm*7.1m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK006', N'十字撑(5.4米边高/6.57m)', N'60mm*60mm*3.5mm*6.57m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AK007', N'十字撑(6.4米边高/7.32m)', N'60mm*60mm*3.5mm*7.32m', N'根', null, N'AK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL001', N'围布承重管3m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL002', N'围布承重管3.5m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL003', N'围布承重管3.88m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL004', N'围布承重管5.38', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL005', N'围布承重管4m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL006', N'围布承重管4.5m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL007', N'围布承重管5m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AL008', N'围布承重管6m', N'6分圆管', N'根', null, N'AL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AM001', N'顶幔穿管3m', N'4分圆管', N'根', null, N'AM', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'AM002', N'顶幔穿管5m', N'4分圆管', N'根', null, N'AM', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA001', N'过渡接头（48*84料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA002', N'过渡接头（48*100料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA003', N'过渡接头（48*105料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA004', N'过渡接头（88*130料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA005', N'过渡接头（120*150料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA006', N'过渡接头（112*203料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA007', N'过渡接头（120*250料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA008', N'过渡接头（120*300料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA009', N'过渡接头（120*350料）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BA010', N'过渡接头（48*84料/10米六角亭）', N'', N'个', null, N'BA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB001', N'地脚（尖顶/55料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB002', N'地脚（尖顶/84料/100料/105料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB003', N'玻璃墙侧地脚（人字/84料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB004', N'地脚（人字/84料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB005', N'侧地脚（人字/88料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB006', N'侧地脚（人字/150料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB007', N'侧地脚（人字/203料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB008', N'侧地脚（人字/250料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB009', N'侧地脚（人字/300料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BB010', N'侧地脚（人字/350料）', N'', N'个', null, N'BB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BC001', N'玻璃墙端地脚（人字/84料）', N'', N'个', null, N'BC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BC002', N'端地脚（人字/150料）', N'', N'个', null, N'BC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BC003', N'端地脚（人字/203料）', N'', N'个', null, N'BC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD001', N'钢丝绳（人字/84料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD002', N'钢丝绳（人字/88料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD003', N'钢丝绳（人字/150料/203料/250料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD004', N'钢丝绳（红）（人字/300料/350料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD005', N'钢丝绳（黄）（人字/300料/350料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD006', N'钢丝绳（蓝）（人字/300料/350料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BD007', N'钢丝绳（绿）（人字/300料/350料）', N'', N'根', null, N'BD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BE001', N'顶布连接器300mm', N'', N'根', null, N'BE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BE002', N'顶布连接器500mm', N'', N'根', null, N'BE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BE003', N'顶布连接器1m', N'', N'根', null, N'BE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BF001', N'顶布紧线器170mm', N'', N'根', null, N'BF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BF002', N'顶布紧线器340mm', N'', N'根', null, N'BF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BF003', N'顶布紧线器500mm', N'', N'根', null, N'BF', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BG001', N'侧立柱接头（短）', N'', N'个', null, N'BG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BG002', N'侧立柱接头（长）', N'', N'个', null, N'BG', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BH001', N'三角连接器', N'', N'个', null, N'BH', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BH002', N'带卡连接器', N'', N'个', null, N'BH', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BI001', N'钢缆基座（小）', N'', N'个', null, N'BI', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BI002', N'钢缆基座（直）', N'', N'个', null, N'BI', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BI003', N'钢缆基座（弯）', N'', N'个', null, N'BI', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ001', N'长梁连接器（三叉）（55料专用）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ002', N'长梁连接器（三叉）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ003', N'上托管加上托顶（3米/4米/5米）', N'', N'根', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ004', N'上托管加上托顶（6米）', N'', N'根', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ005', N'丝杆', N'', N'根', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ006', N'加强板（5米/6米专用）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ007', N'长梁短梁连接夹板（112*203料专用）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ008', N'长梁连接短梁芯子（112*203料专用）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ009', N'屋面拉杆接头（112*203料专用）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ010', N'新型捆紧器（嘎嘎叫）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ011', N'单钩捆紧器（嘎嘎叫）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BJ012', N'捆紧器（嘎嘎叫）', N'', N'个', null, N'BJ', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK001', N'固定销', N'', N'套', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK002', N'螺栓10*25', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK003', N'螺栓10*80', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK004', N'螺栓12*40', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK005', N'螺栓12*80', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK006', N'螺栓12*120', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK007', N'螺栓12*150', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK008', N'螺栓12*200', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK009', N'螺栓12*180', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK010', N'螺栓12*230', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK011', N'螺栓20*200', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK012', N'螺栓20*230', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK013', N'螺栓16*26', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK014', N'螺栓16*140', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK015', N'螺栓16*160', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK016', N'螺栓16*180', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK017', N'螺栓20*140', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK018', N'螺栓20*160', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK019', N'螺栓20*180', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK020', N'螺栓20*120', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK021', N'螺栓26*36', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BK022', N'螺栓M5*50(高强螺栓）', N'', N'个', null, N'BK', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BL001', N'钢钎0.9米', N'', N'根', null, N'BL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BL002', N'钢钎1.2米', N'', N'根', null, N'BL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BL003', N'钢钎1.5米', N'', N'根', null, N'BL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BL004', N'膨胀螺栓14*125', N'', N'根', null, N'BL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'BL005', N'膨胀螺栓20*200', N'', N'根', null, N'BL', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA001', N'顶布（3米尖顶）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA002', N'顶布（4米尖顶）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA003', N'顶布（5米尖顶）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA004', N'顶布（6米尖顶）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA005', N'顶布（3米弧形）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA006', N'顶布（3米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA007', N'顶布（4米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA008', N'顶布（5米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA009', N'顶布（6米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA010', N'顶布（7米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA011', N'顶布（8米人字）（8*3）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA012', N'顶布（8米人字）（8*5）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA013', N'顶布（9米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA014', N'顶布（10米人字）（10*3）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA015', N'顶布（10米人字）（10*5）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA016', N'顶布（12米人字）（12*3）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA017', N'顶布（12米人字）（12*5）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA018', N'顶布（15米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA019', N'顶布（18米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA020', N'顶布（20米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA021', N'顶布（21米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA022', N'顶布（25米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA023', N'顶布（30米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA024', N'顶布（40米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CA025', N'顶布（50米人字）', N'', N'块', null, N'CA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB001', N'围布（3米尖顶）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB002', N'围布（4米尖顶）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB003', N'围布（5米尖顶）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB004', N'围布（6米尖顶）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB005', N'围布（人字/2.8米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB006', N'围布（人字/4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB007', N'围布（人字/5米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB008', N'围布（人字/6米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB009', N'围布（人字/5.4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB010', N'围布（人字/6.4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB011', N'端围布（弧形/人字/2.8米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB012', N'端边围布（7米人字/2.8米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB013', N'端边围布（8米人字/2.8米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB014', N'端边围布（9米人字/2.8米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB015', N'端边围布（10米人字/2.8米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB016', N'端边围布（12米人字/4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB017', N'端边围布（10米人字/88料/4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB018', N'端边围布（15/18米人字/150料/4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB019', N'端边围布（15/18米人字/150料/5米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB020', N'端边围布（15/18米人字/150料/6米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB021', N'端中围布3.88m（人字/4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB022', N'端中围布3.88m（人字/5米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB023', N'端中围布3.88m（人字/6米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB024', N'端中围布5.38m（人字/4米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB025', N'端中围布5.38m（人字/5米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB026', N'端中围布5.38m（人字/6米边高）', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CB027', N'围布加宽条', N'', N'对', null, N'CB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC001', N'山尖布（3米弧形）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC002', N'山尖布（3米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC003', N'山尖布（4米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC004', N'山尖布（5米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC005', N'山尖布（6米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC006', N'山尖布（7米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC007', N'山尖布（8米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC008', N'山尖布（9米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC009', N'山尖布（10米人字）（10*3）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC010', N'山尖布（10米人字）（10*5）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC011', N'山尖布（12米人字）（10*3）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC012', N'山尖布（12米人字）（10*5）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC013', N'山尖布（15米人字）（150料）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC014', N'山尖布（15米人字）（203料）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC015', N'山尖布（18米人字）（150料）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC016', N'山尖布（18米人字）（203料）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC017', N'山尖布（20米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC018', N'山尖布（21米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC019', N'山尖布（25米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC020', N'山尖布（30米人字）（203料）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC021', N'山尖布（30米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC022', N'山尖布（40米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CC023', N'山尖布（50米人字）', N'', N'对', null, N'CC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD001', N'中网框罩', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD002', N'大网框罩', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD003', N'中网框罩pvc', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD004', N'大网框罩pvc', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD005', N'小吨石罩', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD006', N'大吨石罩', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD007', N'小吨石罩pvc', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD008', N'大吨石罩pvc', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD009', N'双网框罩', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD010', N'双网框罩pvc', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD011', N'沙袋', N'', N'条', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CD012', N'框胆', N'', N'个', null, N'CD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CE001', N'天沟', N'', N'条', null, N'CE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'CE002', N'顺水布', N'', N'条', null, N'CE', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA001', N'中网框', N'840mm*600mm*640mm*线径6mm', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA002', N'大网框', N'1000mm*800mm*840mm*线径6mm', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA003', N'大吨石', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA004', N'小吨石', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA005', N'铁皮石块', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA006', N'小石块', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA007', N'铁块', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA008', N'带卡承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA009', N'大带卡带斜撑承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA010', N'40米专用承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA011', N'田字格承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA012', N'小吨石承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA013', N'大吨石承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA014', N'84料专用带卡承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA015', N'铁皮石块承重盘', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA016', N'天沟连接器', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA017', N'托', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'DA018', N'网框夹板', N'', N'个', null, N'DA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA001', N'叉枪3.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA002', N'叉枪4.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA003', N'叉枪5.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA004', N'叉枪6.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA005', N'叉枪7.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA006', N'叉枪8.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA007', N'叉枪9.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA008', N'叉枪10.5m', N'', N'支', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA009', N'梯子2.5m', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA010', N'梯子3.5m', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA011', N'梯子4.5m', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA012', N'梯子5.5m', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA013', N'脚手架', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA014', N'天车4m', N'', N'台', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA015', N'电机', N'', N'台', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA016', N'天车5m', N'', N'台', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA017', N'加长电机', N'', N'台', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA018', N'绳子（2长2短）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA019', N'运料小车', N'', N'台', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA020', N'地牛', N'', N'台', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA021', N'大锤', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA022', N'撬棍', N'', N'根', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA023', N'铁锹', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA024', N'大扫把', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA025', N'反向上布器', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA026', N'铁丝', N'', N'kg', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA027', N'冲击钻（含25钻头2根）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA028', N'冲击钻（含25钻头30钻头各2根）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA029', N'电镐', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA030', N'角磨（含切片2个）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA031', N'手电钻', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA032', N'钻尾钉', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA033', N'割木锯', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA034', N'热合机', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA035', N'篷布条（用于篷布焊接）', N'', N'卷', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA036', N'发电机（含加油铁桶）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA037', N'发电机专用插头与输出电源插座', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA038', N'电源线', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA039', N'起钉器', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA040', N'天沟钩', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA041', N'抓', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA042', N'射灯（含电线）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA043', N'灯具250w', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA044', N'灯具[白][节能灯]', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA045', N'灯线50米专线（含绝缘管）', N'', N'条', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA046', N'灯线40米专线（含绝缘管）', N'', N'条', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA047', N'灯线5米头（含绝缘管）', N'', N'条', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA048', N'灯线3米头（含绝缘管）', N'', N'条', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA049', N'尼龙扎带', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA050', N'侧立柱绝缘夹板', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA051', N'铁丝（用于灯具）', N'', N'米', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA052', N'配线', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA053', N'配电箱', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA054', N'电工胶布', N'', N'卷', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA055', N'透明胶带', N'', N'卷', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA056', N'密封胶', N'', N'管', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA057', N'车贴', N'', N'米', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA058', N'塑料薄膜', N'', N'米', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA059', N'地毯块（用于顶幔）', N'', N'块', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA060', N'布幔钢丝绳', N'', N'米', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA061', N'布幔钩', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA062', N'别针', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA063', N'布基胶带（灰）', N'', N'卷', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA064', N'布基胶带（红）', N'', N'卷', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA065', N'线手套', N'', N'副', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA066', N'鞋套', N'', N'副', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA067', N'梯套', N'', N'副', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA068', N'木老爷胶', N'', N'桶', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA069', N'毛刷', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA070', N'吊带', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA071', N'吊扣', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA072', N'安全带', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA073', N'安全保障夹', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA074', N'带眼小钢钎（含专用绳子）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA075', N'圆管（用于搬运铁皮石块）', N'', N'根', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA076', N'扳手14-17', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA077', N'扳手19', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA078', N'扳手22-24', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA079', N'扳手27-30', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA080', N'扳手36-41', N'', N'把', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA081', N'安全帽（黄）', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA082', N'反光背心', N'', N'件', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA083', N'路锥', N'', N'个', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA084', N'警戒线', N'', N'卷', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'EA085', N'住人小房（含电源线、灯具）', N'', N'套', null, N'EA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA001', N'玻璃门（含白板）（2.5m*2.5m）', N'', N'套', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA002', N'玻璃墙（3.6m*1.2m）', N'', N'块', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA003', N'硬体墙（3.6m*1.2m）', N'', N'块', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA004', N'缓步台', N'', N'个', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA005', N'地钢梁', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA006', N'端左地钢梁', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA007', N'端右地钢梁', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA008', N'玻璃墙夹板', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA009', N'侧立柱夹板', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA010', N'端立柱夹板', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA011', N'端面侧立柱夹板', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA012', N'硬体墙锁', N'', N'根', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FA013', N'玻璃墙锁', N'', N'个', null, N'FA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB001', N'玻璃门（3m*2.8m）', N'', N'套', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB002', N'玻璃墙（2.61m*0.97m）', N'', N'块', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB003', N'缓步台', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB004', N'门上夹板', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB005', N'门边夹板', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB006', N'端面上坎', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB007', N'端面下坎', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB008', N'玻璃墙上坎', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB009', N'玻璃墙下坎', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB010', N'玻璃门上坎', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB011', N'玻璃门下坎', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB012', N'玻璃墙上托', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB013', N'玻璃墙小立柱', N'', N'个', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FB014', N'端面钢丝绳', N'', N'条', null, N'FB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FC001', N'地台板（无碗）（1.2m*3.6m）', N'', N'块', null, N'FC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FC002', N'地台板（有碗）（1.2m*3.6m）', N'', N'块', null, N'FC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FC003', N'车展专用承重地台（1m*1m*0.135厚）', N'1m*1m*0.135', N'块', null, N'FC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FC004', N'木方（40mm*70mm）', N'40mm*70mm', N'根', null, N'FC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FD001', N'地毯（灰）', N'', N'平', null, N'FD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'FD002', N'地毯（红）', N'', N'平', null, N'FD', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA001', N'顶幔（尖顶顶幔）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA002', N'顶幔（3米弧形）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA003', N'顶幔（3米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA004', N'顶幔（4米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA005', N'顶幔（5米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA006', N'顶幔（6米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA007', N'顶幔（7米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA008', N'顶幔（8米人字）（8*3）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA009', N'顶幔（8米人字）（8*5）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA010', N'顶幔（9米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA011', N'顶幔（10米人字）（10*3）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA012', N'顶幔（10米人字）（10*5）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA013', N'顶幔（12米人字）（12*3）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA014', N'顶幔（12米人字）（12*5）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA015', N'顶幔（15米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA016', N'顶幔（18米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA017', N'顶幔（20米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA018', N'顶幔（21米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA019', N'顶幔（25米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA020', N'顶幔（30米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA021', N'顶幔（40米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GA022', N'顶幔（50米人字）', N'', N'块', null, N'GA', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GB001', N'帷幔（2.8米边高）', N'', N'块', null, N'GB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GB002', N'帷幔（4米边高）', N'', N'块', null, N'GB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GB003', N'帷幔（5米边高）', N'', N'块', null, N'GB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GB004', N'帷幔（6.4米边高）', N'', N'块', null, N'GB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GB005', N'40米帷幔（新型）', N'', N'块', null, N'GB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GB006', N'2米加高帷幔', N'', N'块', null, N'GB', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC001', N'山尖幔（3米弧形）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC002', N'山尖幔（3米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC003', N'山尖幔（4米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC004', N'山尖幔（5米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC005', N'山尖幔（6米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC006', N'山尖幔（7米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC007', N'山尖幔（8米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC008', N'山尖幔（9米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC009', N'山尖幔（10米人字）（10*3）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC010', N'山尖幔（10米人字）（10*5）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC011', N'山尖幔（12米人字）（10*3）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC012', N'山尖幔（12米人字）（10*5）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC013', N'山尖幔（15米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC014', N'山尖幔（18米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC015', N'山尖幔（20米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC016', N'山尖幔（21米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC017', N'山尖幔（25米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC018', N'山尖幔（30米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC019', N'山尖幔（40米人字）', N'', N'对', null, N'GC', null)
GO
GO
INSERT INTO [dbo].[tb_mtl_item] ([mtl_Code], [mtl_Name], [mtl_Spec], [mtl_Unit], [mtl_Extend], [kind_Code], [mtl_Weight]) VALUES (N'GC020', N'山尖幔（50米人字）', N'', N'对', null, N'GC', null)
GO
GO

-- ----------------------------
-- Table structure for tb_mtl_kind
-- ----------------------------
DROP TABLE [dbo].[tb_mtl_kind]
GO
CREATE TABLE [dbo].[tb_mtl_kind] (
[kind_Name] varchar(255) NULL ,
[kind_Level] int NULL ,
[kind_Parent] varchar(30) NULL ,
[kind_Code] varchar(30) NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_kind', 
'COLUMN', N'kind_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'物料类型名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'物料类型名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_kind', 
'COLUMN', N'kind_Level')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'分类级别0,1'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Level'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'分类级别0,1'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Level'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_kind', 
'COLUMN', N'kind_Parent')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'父类'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Parent'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'父类'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Parent'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_mtl_kind', 
'COLUMN', N'kind_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_mtl_kind'
, @level2type = 'COLUMN', @level2name = N'kind_Code'
GO

-- ----------------------------
-- Records of tb_mtl_kind
-- ----------------------------
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'骨架类', N'0', null, N'A')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'长梁', N'1', N'A', N'AA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'侧立柱', N'1', N'A', N'AB')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'端立柱', N'1', N'A', N'AC')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'檩条', N'1', N'A', N'AD')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'左右向檩条', N'1', N'A', N'AE')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'顶布穿管/穿条', N'1', N'A', N'AF')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'山尖固定扁铝', N'1', N'A', N'AG')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'斜撑', N'1', N'A', N'AH')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'屋面拉杆', N'1', N'A', N'AI')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'侧横梁', N'1', N'A', N'AJ')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'十字撑', N'1', N'A', N'AK')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'围布承重管', N'1', N'A', N'AL')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'顶幔穿管', N'1', N'A', N'AM')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'钢部件类', N'0', null, N'B')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'过渡接头', N'1', N'B', N'BA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'侧地脚', N'1', N'B', N'BB')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'端地脚', N'1', N'B', N'BC')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'钢丝绳', N'1', N'B', N'BD')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'顶布连接器', N'1', N'B', N'BE')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'顶布紧线器', N'1', N'B', N'BF')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'侧立柱接头', N'1', N'B', N'BG')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'三角/带卡连接器', N'1', N'B', N'BH')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'钢缆基座', N'1', N'B', N'BI')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'其余小件', N'1', N'B', N'BJ')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'螺栓', N'1', N'B', N'BK')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'钢钎/膨胀', N'1', N'B', N'BL')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'篷布类', N'0', null, N'C')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'顶布', N'1', N'C', N'CA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'围布', N'1', N'C', N'CB')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'山尖布', N'1', N'C', N'CC')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'配重罩', N'1', N'C', N'CD')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'天沟类', N'1', N'C', N'CE')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'固定类', N'0', null, N'D')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'配重/承重盘', N'1', N'D', N'DA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'工具类', N'0', null, N'E')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'工具类', N'1', N'E', N'EA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'配套类', N'0', null, N'F')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'4米边高玻璃墙', N'1', N'F', N'FA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'2.8米边高玻璃墙', N'1', N'F', N'FB')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'地台', N'1', N'F', N'FC')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'地毯', N'1', N'F', N'FD')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'幔类', N'0', null, N'G')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'顶幔', N'1', N'G', N'GA')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'帷幔', N'1', N'G', N'GB')
GO
GO
INSERT INTO [dbo].[tb_mtl_kind] ([kind_Name], [kind_Level], [kind_Parent], [kind_Code]) VALUES (N'山尖幔', N'1', N'G', N'GC')
GO
GO

-- ----------------------------
-- Table structure for tb_mtl_store
-- ----------------------------
DROP TABLE [dbo].[tb_mtl_store]
GO
CREATE TABLE [dbo].[tb_mtl_store] (
[mtl_Code] varchar(30) NOT NULL ,
[descend_Qty] decimal(18,2) NULL ,
[upper_Qty] decimal(18,2) NULL 
)


GO

-- ----------------------------
-- Records of tb_mtl_store
-- ----------------------------

-- ----------------------------
-- Table structure for tb_order_code
-- ----------------------------
DROP TABLE [dbo].[tb_order_code]
GO
CREATE TABLE [dbo].[tb_order_code] (
[employ_Code] varchar(50) NOT NULL ,
[order_Date] varchar(20) NOT NULL ,
[seq_No] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_code', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'员工信息表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'员工信息表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_code', 
'COLUMN', N'employ_Code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_code'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_code'
, @level2type = 'COLUMN', @level2name = N'employ_Code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_code', 
'COLUMN', N'order_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'身份证号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_code'
, @level2type = 'COLUMN', @level2name = N'order_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'身份证号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_code'
, @level2type = 'COLUMN', @level2name = N'order_Date'
GO

-- ----------------------------
-- Records of tb_order_code
-- ----------------------------
INSERT INTO [dbo].[tb_order_code] ([employ_Code], [order_Date], [seq_No]) VALUES (N'153', N'20181109', N'0')
GO
GO
INSERT INTO [dbo].[tb_order_code] ([employ_Code], [order_Date], [seq_No]) VALUES (N'185', N'20181109', N'0')
GO
GO
INSERT INTO [dbo].[tb_order_code] ([employ_Code], [order_Date], [seq_No]) VALUES (N'admin', N'20181109', N'1')
GO
GO

-- ----------------------------
-- Table structure for tb_order_item
-- ----------------------------
DROP TABLE [dbo].[tb_order_item]
GO
CREATE TABLE [dbo].[tb_order_item] (
[item_Id] bigint NOT NULL ,
[odr_No] varchar(50) NULL ,
[item_Seq] int NULL ,
[item_Spec] ntext NULL ,
[item_Type] varchar(300) NULL ,
[product_Name] varchar(200) NULL ,
[product_Count] decimal(18) NULL ,
[product_Unit] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of tb_order_item
-- ----------------------------
INSERT INTO [dbo].[tb_order_item] ([item_Id], [odr_No], [item_Seq], [item_Spec], [item_Type], [product_Name], [product_Count], [product_Unit]) VALUES (N'4693462675935745687', N'185/20181108-01-R', N'2', N'{"Items":[{"Property_Value":"20","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"25","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5.4","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"7.2","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]}', N'18米人字篷房', N'篷房', N'500', N'平米')
GO
GO
INSERT INTO [dbo].[tb_order_item] ([item_Id], [odr_No], [item_Seq], [item_Spec], [item_Type], [product_Name], [product_Count], [product_Unit]) VALUES (N'5422436239997126664', N'069/20181109-01-R', N'1', N'{"Items":[{"Property_Value":"30","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"35","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"9.94","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]}', N'30米跨度', N'篷房', N'1050', N'平米')
GO
GO

-- ----------------------------
-- Table structure for tb_order_log
-- ----------------------------
DROP TABLE [dbo].[tb_order_log]
GO
CREATE TABLE [dbo].[tb_order_log] (
[odr_No] varchar(50) NULL ,
[msg] varchar(500) NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(30) NULL ,
[oper_log] varchar(500) NULL ,
[oper_Info] ntext NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_log', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'关联Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_log'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'关联Id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_log'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO

-- ----------------------------
-- Records of tb_order_log
-- ----------------------------
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (N'185/20181108-01-R', N'合同审核通过', N'2018-11-08 15:34:39.000', N'033', N'合同审核通过', N'{"Items":[{"ProductCountUnit":"500平米","ItemSpec":{"Items":[{"Property_Value":"20","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"25","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5.4","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"7.2","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]},"Item_Id":4693462675935745687,"Odr_No":"185/20181108-01-R","Item_Seq":2,"Item_Spec":"{\"Items\":[{\"Property_Value\":\"20\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"宽\",\"Property_Id\":1,\"Property_Seq\":1.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"25\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"长\",\"Property_Id\":2,\"Property_Seq\":2.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"5.4\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"边高\",\"Property_Id\":3,\"Property_Seq\":3.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"7.2\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"顶高\",\"Property_Id\":4,\"Property_Seq\":4.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"1\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"座\",\"Property_Id\":5,\"Property_Seq\":5.0,\"Property_Unit\":\"座\",\"Is_Spec\":0}]}","Item_Type":"18米人字篷房","Product_Name":"篷房","Product_Count":500.0,"Product_Unit":"平米"}],"OrderCode":null,"OrderTypeText":"租赁合同","FieldExtend":{"${501几日付定金}":"3","${502定金}":"40000","${503定金大写}":"肆万元整","${504部分金额}":"30000","${505部分金额大写}":"叁万元整"},"Odr_Clause":null,"Odr_BodyText":"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","Tag":null,"Odr_No":"185/20181108-01-R","Odr_Seq":0,"Odr_Date":"2018-11-08T14:48:01.783","Odr_State":2,"Odr_Type":2,"Jia_Name":"高山气膜技术（沈阳）有限公司","Jia_FaRen":"山常娥","Jia_DaiLi":"高山","Jia_Adress":"辽宁省沈阳市辽中区蒲东街道","Jia_Phone":"024-87941313","Jia_Fax":"024-87941733","Yi_Name":"高山篷房制造（沈阳）有限公司","Yi_FaRen":"高山","Yi_DaiLi":"杨航","Yi_Adress":"辽宁省沈阳市辽中区肖寨门镇大兰坨村","Yi_Phone":"024-87942549","Yi_Act_Name":"高山篷房制造（沈阳）有限公司","Yi_Bank_Name":"中国农业银行辽中县支行","Yi_Act_No":"06105001040016018","Yi_Tax_Code":"91210122662506879U","Odr_Prt_Name":"篷房","Odr_Sum_Area":500.0,"Odr_Prt_Purpose":"展销会","Odr_Trans_Party":"乙方","Odr_Place_Linkman":"田总","Odr_Bud_Palce":"铁西区家乐福","Odr_Place_Phone":"18887879997","Odr_Ground_State":"水泥地","Odr_Water_proof":"无","Odr_Fixed_Mode":"沙袋固定","Odr_Tax_Type":"不开发票","Let_Entry_Date":"2018-11-08T00:00:50","Let_Bud_SDate":"2018-11-08T00:00:22","Let_Bud_EDate":"2018-11-11T12:59:28","Let_Use_SDate":"2018-11-12T00:00:03","Let_Use_EDate":"2018-11-16T00:00:10","Let_Rm_SDate":"2018-11-16T00:01:41","Let_Rm_EDate":"2018-11-17T00:00:51","Tot_Cost":100000.00,"Oper_Date":"2018-11-08T15:09:14","Oper_Code":"185","Col_Extend":"{\"${501几日付定金}\":\"3\",\"${502定金}\":\"40000\",\"${503定金大写}\":\"肆万元整\",\"${504部分金额}\":\"30000\",\"${505部分金额大写}\":\"叁万元整\"}","Tmp_Id":4740465854849800789,"Tmp_Name":"租赁合同-3次支付","Tmp_Explain":"租赁合同-3次支付","Odr_Bud_Party":null,"Odr_No_Main":"185/20181108-01-R"}')
GO
GO
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (null, N'回款审核通过', N'2018-11-09 11:51:27.000', N'admin', N'回款审核通过', N'{"OrderTypeText":"租赁合同","Fin_Id":4705547328225709720,"Odr_No":"185/20181108-01-R","Fin_Date":"2018-11-09T11:50:30.69","Odr_Type":2,"Jia_Name":"高山气膜技术（沈阳）有限公司","Odr_Prt_Name":"篷房","Pay_Cost":100000.00,"Oper_Date":"2018-11-09T11:50:53","Oper_Code":"admin","Pay_Way":"现金转帐","Pay_Account":"高山-建设银行/6228117809871220321","Pay_remark":"","Employ_Code":"185","Audit_Code":null,"Audit_Date":"1753-01-01T00:00:00","Fin_State":2}')
GO
GO
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (N'069/20181109-01-R', N'合同审核通过', N'2018-11-09 14:49:24.000', N'033', N'合同审核通过', N'{"Items":[{"ProductCountUnit":"1050平米","ItemSpec":{"Items":[{"Property_Value":"30","Product_Id":5693845056367661209,"Property_Name":"宽","Property_Id":1,"Property_Seq":1.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"35","Product_Id":5693845056367661209,"Property_Name":"长","Property_Id":2,"Property_Seq":2.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"5","Product_Id":5693845056367661209,"Property_Name":"边高","Property_Id":3,"Property_Seq":3.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"9.94","Product_Id":5693845056367661209,"Property_Name":"顶高","Property_Id":4,"Property_Seq":4.0,"Property_Unit":"米","Is_Spec":1},{"Property_Value":"1","Product_Id":5693845056367661209,"Property_Name":"座","Property_Id":5,"Property_Seq":5.0,"Property_Unit":"座","Is_Spec":0}]},"Item_Id":5422436239997126664,"Odr_No":"069/20181109-01-R","Item_Seq":1,"Item_Spec":"{\"Items\":[{\"Property_Value\":\"30\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"宽\",\"Property_Id\":1,\"Property_Seq\":1.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"35\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"长\",\"Property_Id\":2,\"Property_Seq\":2.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"5\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"边高\",\"Property_Id\":3,\"Property_Seq\":3.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"9.94\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"顶高\",\"Property_Id\":4,\"Property_Seq\":4.0,\"Property_Unit\":\"米\",\"Is_Spec\":1},{\"Property_Value\":\"1\",\"Product_Id\":5693845056367661209,\"Property_Name\":\"座\",\"Property_Id\":5,\"Property_Seq\":5.0,\"Property_Unit\":\"座\",\"Is_Spec\":0}]}","Item_Type":"30米跨度","Product_Name":"篷房","Product_Count":1050.0,"Product_Unit":"平米"}],"OrderCode":null,"OrderTypeText":"租赁合同","FieldExtend":{"${501几日付定金}":"当","${502定金}":"10000","${503定金大写}":"壹万元整","${504部分金额}":"40000","${505部分金额大写}":"肆万元整"},"Odr_Clause":null,"Odr_BodyText":"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","Tag":null,"Odr_No":"069/20181109-01-R","Odr_Seq":0,"Odr_Date":"2018-11-09T14:11:24.773","Odr_State":2,"Odr_Type":2,"Jia_Name":"沈阳凡禾文化传播有限公司","Jia_FaRen":"张三","Jia_DaiLi":"李四","Jia_Adress":"沈阳市和平区","Jia_Phone":"00","Jia_Fax":"00","Yi_Name":"新民市场丹辉会议会展服务中心","Yi_FaRen":"张玉贤","Yi_DaiLi":"管理员","Yi_Adress":"新民市新柳街道68号","Yi_Phone":"0000000","Yi_Act_Name":"000","Yi_Bank_Name":"000","Yi_Act_No":"000","Yi_Tax_Code":"000","Odr_Prt_Name":"人字顶篷房","Odr_Sum_Area":1050.0,"Odr_Prt_Purpose":"活动","Odr_Trans_Party":"乙方","Odr_Place_Linkman":"赵经理","Odr_Bud_Palce":"大连甘井子区华润24城","Odr_Place_Phone":"15524055501","Odr_Ground_State":"大理石","Odr_Water_proof":"无防水","Odr_Fixed_Mode":"配重","Odr_Tax_Type":"不开发票","Let_Entry_Date":"2018-06-21T00:00:48","Let_Bud_SDate":"2018-06-21T00:00:09","Let_Bud_EDate":"2018-06-22T23:59:23","Let_Use_SDate":"2018-06-24T00:00:05","Let_Use_EDate":"2018-06-30T23:59:56","Let_Rm_SDate":"2018-07-01T00:00:07","Let_Rm_EDate":"2018-07-01T23:59:20","Tot_Cost":50000.00,"Oper_Date":"2018-11-09T14:34:26","Oper_Code":"069","Col_Extend":"{\"${501几日付定金}\":\"当\",\"${502定金}\":\"10000\",\"${503定金大写}\":\"壹万元整\",\"${504部分金额}\":\"40000\",\"${505部分金额大写}\":\"肆万元整\"}","Tmp_Id":4740465854849800789,"Tmp_Name":"租赁合同-3次支付","Tmp_Explain":"租赁合同-3次支付","Odr_Bud_Party":null,"Odr_No_Main":"069/20181109-01-R"}')
GO
GO
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (null, N'回款审核通过', N'2018-11-09 15:58:03.000', N'404', N'回款审核通过', N'{"OrderTypeText":"租赁合同","Fin_Id":4929811632965460364,"Odr_No":"069/20181109-01-R","Fin_Date":"2018-11-09T15:53:40.977","Odr_Type":2,"Jia_Name":"沈阳凡禾文化传播有限公司","Odr_Prt_Name":"人字顶篷房","Pay_Cost":2000.00,"Oper_Date":"2018-11-09T15:56:36","Oper_Code":"404","Pay_Way":"现金转帐","Pay_Account":"张玉贤/邮政/21012292445445445","Pay_remark":"","Employ_Code":"069","Audit_Code":null,"Audit_Date":"1753-01-01T00:00:00","Fin_State":2}')
GO
GO
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (null, N'回款审核通过', N'2018-11-09 16:09:44.000', N'404', N'回款审核通过', N'{"OrderTypeText":"租赁合同","Fin_Id":4981041732775603771,"Odr_No":"069/20181109-01-R","Fin_Date":"2018-11-09T16:09:08.96","Odr_Type":2,"Jia_Name":"沈阳凡禾文化传播有限公司","Odr_Prt_Name":"人字顶篷房","Pay_Cost":10.00,"Oper_Date":"2018-11-09T16:09:11","Oper_Code":"404","Pay_Way":"现金转帐","Pay_Account":"张玉贤/邮政/21012292445445445","Pay_remark":"","Employ_Code":"069","Audit_Code":null,"Audit_Date":"1753-01-01T00:00:00","Fin_State":2}')
GO
GO
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (null, N'回款审核通过', N'2018-11-09 16:10:54.000', N'404', N'回款审核通过', N'{"OrderTypeText":"租赁合同","Fin_Id":4922502101057160575,"Odr_No":"069/20181109-01-R","Fin_Date":"2018-11-09T16:10:42.123","Odr_Type":2,"Jia_Name":"沈阳凡禾文化传播有限公司","Odr_Prt_Name":"人字顶篷房","Pay_Cost":50000.00,"Oper_Date":"2018-11-09T16:10:44","Oper_Code":"404","Pay_Way":"现金转帐","Pay_Account":"张玉贤/邮政/21012292445445445","Pay_remark":"","Employ_Code":"069","Audit_Code":null,"Audit_Date":"1753-01-01T00:00:00","Fin_State":2}')
GO
GO
INSERT INTO [dbo].[tb_order_log] ([odr_No], [msg], [oper_Date], [oper_Code], [oper_log], [oper_Info]) VALUES (null, N'回款审核通过', N'2018-11-09 15:58:06.000', N'404', N'回款审核通过', N'{"OrderTypeText":"租赁合同","Fin_Id":5340792715593159608,"Odr_No":"069/20181109-01-R","Fin_Date":"2018-11-09T15:57:36.103","Odr_Type":2,"Jia_Name":"沈阳凡禾文化传播有限公司","Odr_Prt_Name":"人字顶篷房","Pay_Cost":48000.00,"Oper_Date":"2018-11-09T15:57:48","Oper_Code":"404","Pay_Way":"现金转帐","Pay_Account":"张玉贤/邮政/21012292445445445","Pay_remark":"","Employ_Code":"069","Audit_Code":null,"Audit_Date":"1753-01-01T00:00:00","Fin_State":2}')
GO
GO

-- ----------------------------
-- Table structure for tb_order_main
-- ----------------------------
DROP TABLE [dbo].[tb_order_main]
GO
CREATE TABLE [dbo].[tb_order_main] (
[odr_No] varchar(50) NOT NULL ,
[odr_Seq] int NULL ,
[odr_Date] datetime NULL ,
[odr_State] int NULL ,
[odr_Type] int NULL ,
[jia_Name] varchar(300) NULL ,
[jia_FaRen] varchar(30) NULL ,
[jia_DaiLi] varchar(30) NULL ,
[jia_Adress] varchar(300) NULL ,
[jia_Phone] varchar(30) NULL ,
[jia_Fax] varchar(30) NULL ,
[yi_Name] varchar(300) NULL ,
[yi_FaRen] varchar(30) NULL ,
[yi_DaiLi] varchar(30) NULL ,
[yi_Adress] varchar(300) NULL ,
[yi_Phone] varchar(30) NULL ,
[yi_Act_Name] varchar(300) NULL ,
[yi_Bank_Name] varchar(100) NULL ,
[yi_Act_No] varchar(30) NULL ,
[yi_Tax_Code] varchar(30) NULL ,
[odr_Prt_Name] varchar(300) NULL ,
[odr_Sum_Area] decimal(18) NULL ,
[odr_Prt_Purpose] varchar(300) NULL ,
[odr_Trans_Party] varchar(300) NULL ,
[odr_Place_Linkman] varchar(300) NULL ,
[odr_Bud_Palce] varchar(300) NULL ,
[odr_Place_Phone] varchar(300) NULL ,
[odr_Ground_State] varchar(300) NULL ,
[odr_Water_proof] varchar(300) NULL ,
[odr_Fixed_Mode] varchar(300) NULL ,
[odr_Tax_Type] varchar(300) NULL ,
[let_Entry_Date] datetime NULL ,
[let_Bud_SDate] datetime NULL ,
[let_Bud_EDate] datetime NULL ,
[let_Use_SDate] datetime NULL ,
[let_Use_EDate] datetime NULL ,
[let_Rm_SDate] datetime NULL ,
[let_Rm_EDate] datetime NULL ,
[tot_Cost] decimal(10,2) NULL ,
[oper_Date] datetime NULL ,
[oper_Code] varchar(50) NULL ,
[col_Extend] text NULL ,
[tmp_Id] bigint NULL ,
[tmp_Name] varchar(100) NULL ,
[tmp_Explain] varchar(500) NULL ,
[odr_Bud_Party] varchar(255) NULL ,
[odr_No_Main] varchar(50) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'odr_No')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_No'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_No'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'odr_Seq')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同追加的次数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_Seq'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同追加的次数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_Seq'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'odr_Date')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_Date'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_Date'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'odr_State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'odr_Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'合同类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'odr_Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'jia_Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方(需方)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'jia_FaRen')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方法人代表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_FaRen'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方法人代表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_FaRen'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'jia_DaiLi')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方委托代理人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_DaiLi'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方委托代理人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_DaiLi'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'jia_Adress')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_Adress'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_Adress'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'jia_Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'甲方电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'tb_order_main'
, @level2type = 'COLUMN', @level2name = N'jia_Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'tb_order_main', 
'COLUMN', N'jia_Fax')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'甲方传真'
ELSE
GO
ELSE
GO