using ZFine.Domain.Entity.XYRobot;
using System.Data.Entity.ModelConfiguration;


namespace ZFine.Mapping.XYRobot
{
    public class XYClientInfoMap : EntityTypeConfiguration<XYClientInfoEntity>
    {
        public XYClientInfoMap()
        {
            this.ToTable("Sys_XYClientInfo");
            this.HasKey(t => t.F_Id);
        }
    }
}
