using Infrastructure;
using Infrastructure.Base;
using Model;

namespace Business
{
    public class HourlyPermission : PermissionBase
    {
        public override BaseOperationResult PermissionComplete(AddPermissionModel request)
        {
            var permissionResultBefore = PermissionCompleteBefore(request);

            if (!permissionResultBefore.IsSuccess)
                return permissionResultBefore;

            // TODO :  Saatlik izin için yapılacak olan operasyonlar

            var permissionResultAfter = PermissionCompleteAfter(request);

            return permissionResultBefore;
        }


        public override BaseOperationResult PermissionCompleteAfter(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();
            // TODO :  Saatlik izin verildikten sonra bilgilendirmeler , mailler vs.
            return result;
        }
        public override BaseOperationResult PermissionCompleteBefore(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();
            // TODO :  Saatlik izin için kullanıcı özelinde validasyonlar vs.
            return result;
        }
    }
}
