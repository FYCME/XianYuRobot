using ZFine.Data;
using ZFine.Domain.Entity.XYRobot;
using ZFine.Domain.IRepository.XYRobot;
using ZFine.Repository.XYRobot;

namespace ZFine.Repository.XYRobot
{
    public class XYClientInfoRepository : RepositoryBase<XYClientInfoEntity>, IXYClientInfoRepository
    {


        /// <summary>
        /// 批量删除操作
        /// </summary>
        /// <param name="keyValue"></param>
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                //删除账号
                db.Delete<XYClientInfoEntity>(t => t.F_Id == keyValue);
                //删除......
                //db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == keyValue);
                db.Commit();
            }
        }


    }
}
