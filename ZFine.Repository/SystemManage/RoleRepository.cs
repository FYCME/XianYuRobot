﻿/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台  FROM http://xmwxgn.com
 *
*********************************************************************************/
using ZFine.Data;
using ZFine.Domain.Entity.SystemManage;
using ZFine.Domain.IRepository.SystemManage;
using ZFine.Repository.SystemManage;
using System.Collections.Generic;

namespace ZFine.Repository.SystemManage
{
    public class RoleRepository : RepositoryBase<RoleEntity>, IRoleRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<RoleEntity>(t => t.F_Id == keyValue);
                db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(RoleEntity roleEntity, List<RoleAuthorizeEntity> roleAuthorizeEntitys, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(roleEntity);
                }
                else
                {
                    roleEntity.F_Category = 1;
                    db.Insert(roleEntity);
                }
                db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == roleEntity.F_Id);
                db.Insert(roleAuthorizeEntitys);
                db.Commit();
            }
        }
    }
}
