using ZFine.Data;
using ZFine.Domain.Entity.XYRobot;

namespace ZFine.Domain.IRepository.XYRobot
{
    public interface IXYClientInfoRepository : IRepositoryBase<XYClientInfoEntity>
    {
        void DeleteForm(string keyValue);
    }
}
