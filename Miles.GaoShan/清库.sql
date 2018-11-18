--清库脚本
TRUNCATE TABLE tb_carriage_bill;
TRUNCATE TABLE tb_fin_order_gen;
TRUNCATE TABLE tb_fin_order_income;
TRUNCATE TABLE tb_fin_order_item;
TRUNCATE TABLE tb_fin_order_gen;
TRUNCATE TABLE tb_fin_order_income;
TRUNCATE TABLE tb_fin_order_item;
TRUNCATE TABLE tb_link_bill;
TRUNCATE TABLE tb_link_bill_tent;
TRUNCATE TABLE tb_matchTb;
TRUNCATE TABLE tb_matchTb_item;
TRUNCATE TABLE tb_order_code;
TRUNCATE TABLE tb_order_item;
TRUNCATE TABLE tb_order_log;
TRUNCATE TABLE tb_order_main;
TRUNCATE TABLE tb_order_text;
TRUNCATE TABLE tb_place_fee;
TRUNCATE TABLE tb_project_Cost;
TRUNCATE TABLE tb_project_Cost_Item;
TRUNCATE TABLE tb_store_check;
TRUNCATE TABLE tb_store_check_log;
TRUNCATE TABLE tb_store_in;
TRUNCATE TABLE tb_store_in_item;
TRUNCATE TABLE tb_store_out;
TRUNCATE TABLE tb_store_out_item;
TRUNCATE TABLE tb_fin_order_outcome;
TRUNCATE TABLE tb_salary_main;
TRUNCATE TABLE tb_salary_main_item;
TRUNCATE TABLE tb_salary_grant_item;

UPDATE tb_store_main SET mtl_Qty=0;
UPDATE tb_store_state SET State=0;

--基础数据资料
--TRUNCATE TABLE tb_company_act;
--TRUNCATE TABLE tb_default_adress;
--TRUNCATE TABLE tb_enum;   --这个慎重
--TRUNCATE TABLE tb_expend_item;
--TRUNCATE TABLE tb_fin_act;
--TRUNCATE TABLE tb_mtl_item;
--TRUNCATE TABLE tb_mtl_kind;
--TRUNCATE TABLE tb_store_main;



--未使用表

--tb_contract_template
--tb_customer
--tb_fin_order_outcome
--tb_pay_out_item




