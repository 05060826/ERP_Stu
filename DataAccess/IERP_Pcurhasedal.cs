﻿using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.PuchasesInfoModel;

namespace DataAccess
{
  public  interface IERP_Pcurhasedal
    {
        /// <summary>
        /// 显示供应商
        /// </summary>
        /// <returns></returns>
        List<SupplierModel> showSupplier();

        /// <summary>
        /// 显示商品
        /// </summary>
        /// <param name="gid">供应商Id</param>
        /// <returns></returns>
        List<ComityModel> showCommodity(int gid);

        /// <summary>
        /// 添加采购表单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int add(PurchModel model);



        /// <summary>
        /// 仓库显示数据
        /// </summary>
        /// <returns></returns>

        List<WarehouseModel> CangKu();

        /// <summary>
        /// 显示采购列表
        /// </summary>
        /// <returns></returns>
        List<PurchModel> ShowPurchaseInfo();
        /// <summary>
        /// 显示结算账户信息
        /// </summary>
        /// <returns></returns>
        List<AccountModel> AccountModels();


        /// <summary>
        /// 根据商品id查询商品信息
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        ComityModel ShowCommdityInfo(int sid);


        /// <summary>
        /// 修改数据在页面是否显示页面删除
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        int UpdateIstate(int rid);

        /// <summary>
        /// 根据采购单据Id进行反填
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        PurchModel FanTian(int rid);


        /// <summary>
        /// 修改支付状态
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        int UpdatePaMent(int rid,string cgthCode);

        /// <summary>
        /// 修改支付状态未支付
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        int UpdatePaMents(int rid, string cgthCode);

        ///// <summary>
        ///// 根据单据编号反填
        ///// </summary>
        ///// <param name="nameCode"></param>
        ///// <returns></returns>
        //PurchModel DropFanTian(string nameCode);

        /// <summary>
        /// 显示退货商品
        /// </summary>
        /// <returns></returns>
        List<PurchModel> ShowPurchasTh();

        /// <summary>
        /// 显示采购报表列表
        /// </summary>
        /// <returns></returns>
        List<PurchModel> BaoPurchaseInfo();





    }
}
