using System;



namespace ZFine.Domain.Entity.XYRobot
{

    public class XYClientInfoEntity : IEntity<XYClientInfoEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_ReleUser_Id { get; set; }
        public string F_XYUserName { get; set; }
        public int? F_HelpOthers { get; set; }
        public int? F_ByHelpOthers { get; set; }
        public int? F_HelpBabys { get; set; }
        public int? F_ByHelpBabys { get; set; }
        public int? F_IsOnline { get; set; }
        public int? F_IsDisabled { get; set; }
        public int? F_IsDelete { get; set; }
        //-----------------------------------------继承实现部分
        public string F_Id { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public bool? F_DeleteMark { get; set; }
        public string F_DeleteUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }

    }

}
