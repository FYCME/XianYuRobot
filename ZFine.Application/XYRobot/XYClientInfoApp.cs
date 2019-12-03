using ZFine.Domain.Entity.XYRobot;
using ZFine.Domain.IRepository.XYRobot;
using ZFine.Repository.XYRobot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ZFine.Application.XYRobot
{
    /// <summary>
    /// 数据操作业务类
    /// XYClientInfoApp
    /// </summary>
    public class XYClientInfoApp
    {
        private IXYClientInfoRepository service = new XYClientInfoRepository();

        /// <summary>
        /// 根据创建时间正序查询所有数据
        /// </summary>
        /// <returns></returns>
        public List<XYClientInfoEntity> GetList()
        {
            return service.IQueryable().OrderBy(t => t.F_CreatorTime).ToList();
        }
        /// <summary>
        /// 根据Id查询实体
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public XYClientInfoEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

    

        /// <summary>
        /// 批量删除.....
        /// </summary>
        /// <param name="keyValue"></param>
        public void DeleteForm(string keyValue)
        {
            service.DeleteForm(keyValue);
        }

        /// <summary>
        /// 虚拟删除（软删除）
        /// </summary>
        /// <param name="keyValue"></param>
        public void FalseDeleteForm(XYClientInfoEntity organizeEntity,string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                organizeEntity.Modify(keyValue);
                organizeEntity.F_IsDelete = 2;
                service.Update(organizeEntity);
            }
        }


        /// <summary>
        /// 修改或添加
        /// </summary>
        /// <param name="XYClientInfoEntity"></param>
        /// <param name="keyValue"></param>
        public void SubmitForm(XYClientInfoEntity organizeEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                organizeEntity.Modify(keyValue);
                service.Update(organizeEntity);
            }
            else
            {
                organizeEntity.Create();
                service.Insert(organizeEntity);
            }
        }

    }
}
